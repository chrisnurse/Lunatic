using System.IO.Ports;

namespace Lunatic
{
    public partial class frmLunatic : Form
    {
        private SerialPort? serialPort;
        private System.Timers.Timer? pollTimer;
        private int pollInterval = 1000;
        private int updatePositionInterval = 5;
        private bool running = false;

        private int x = 0, y = 0;

        private int max_x = 5;
        private int max_y = 5;
        private int current_frame_elapsed = 0;

        private AstronomicalPosition? top_left;
        private AstronomicalPosition? top_right;
        private AstronomicalPosition? bottom_right;

        #region Construct / Destruct

        public frmLunatic()
        {
            InitializeComponent();
            LoadPorts();

            pollTimer = new System.Timers.Timer();
            pollTimer.Interval = pollInterval;
            pollTimer.Enabled = true;
            pollTimer.Elapsed += OneSecondTick;
        }

        protected override void OnClosed(EventArgs e)
        {
            ClosePort();
            base.OnClosed(e);
        }

        #endregion

        #region Get / Set Position

        private void OneSecondTick(object? sender, System.Timers.ElapsedEventArgs e)
        {
            if (pollTimer != null)
                pollTimer.Interval = pollInterval;

            if (running)
            {
                current_frame_elapsed++;

                if (current_frame_elapsed > udDwell.Value)
                {
                    current_frame_elapsed = 0;
                    MoveToNextPosition();
                }
            }

            UpdateUIState();
        }

        private AstronomicalPosition? ReadPosition()
        {
            if (serialPort != null)
            {
                // Get RA/DEC in 32bit format
                serialPort.Write("e");
                Thread.Sleep(1000);
                var bytes = serialPort.ReadExisting();

                if (bytes.Trim().Length == 0 || bytes.Trim().Length < 17)
                    return null;


                // Remove any erroneous hash character
                if (bytes[0] == '#')
                    bytes = bytes.Substring(1);

                var pos = ParsePosition(bytes);
                Log("RA/DEC (Hex): " + bytes);

                return pos;
            }

            return null;
        }

        private AstronomicalPosition ParsePosition(string pos_32bit)
        {
            // position format is text, with ra,dec#
            // ra and dec are 4 bytes each in hex format
            // e.g. 34AB0500,12CE0500#
            // Ignore the last byte as it is always 00
            var bytes_per_coordinate = 4;
            var len = bytes_per_coordinate * 2;
            var ra_bytes = pos_32bit.Substring(0, len);
            var dec_bytes = pos_32bit.Substring(9, len);

            var ra = long.Parse(ra_bytes, System.Globalization.NumberStyles.HexNumber);
            var dec = long.Parse(dec_bytes, System.Globalization.NumberStyles.HexNumber);

            var ap = new AstronomicalPosition(ra, dec);

            return ap;
        }

        private string GetGotoCommand(AstronomicalPosition pos)
        {
            var cmd = string.Format("r{0:X2}{1:X2}{2:X2}00,{3:X2}{4:X2}{5:X2}00",
                (pos.RA >> 24) & 0xff,
                (pos.RA >> 16) & 0xff,
                (pos.RA >> 8) & 0xff,

                (pos.DEC >> 24) & 0xff,
                (pos.DEC >> 16) & 0xff,
                (pos.DEC >> 8) & 0xff
                );

            Log("Goto command: " + cmd);

            return cmd;
        }

        private void ExecuteGotoCommand(AstronomicalPosition pos)
        {
            if (serialPort != null)
            {
                var cmd = GetGotoCommand(pos);
                serialPort.Write(cmd);
            }
        }

        #endregion

        #region RUN

        private void Start()
        {
            running = true;
            current_frame_elapsed = (int)udDwell.Value;

            if (top_left != null)
                ExecuteGotoCommand(top_left);

            UpdateUIState();

            x = 0;
            y = 0;
        }

        private void Stop()
        {
            running = false;
            UpdateUIState();

            x = 0;
            y = 0;
        }

        private void MoveToNextPosition()
        {
            if (++x == max_x)
            {
                x = 0;

                if (y++ >= max_y)
                    Stop();
            }
        }

        #endregion

        #region Status
        private void UpdateUIState()
        {
            lblRA.Invoke(() =>
            {
                btnRun.Visible = !running;
                btnCancel.Visible = running;

                if (running)
                {
                    lblFrameTime.Text = $"{current_frame_elapsed / 60}:{current_frame_elapsed % 60}";

                    lblX.Text = string.Format("{0}/{1}", x, max_x);
                    lblY.Text = string.Format("{0}/{1}", y, max_y);
                }
                else
                {
                    lblX.Text = "standby";
                    lblY.Text = "standby";
                }

                if (--updatePositionInterval == 0)
                {
                    updatePositionInterval = 10;

                    var pos = ReadPosition();

                    if (pos != null)
                    {
                        lblRA.Text = pos.RaText;
                        lblDec.Text = pos.DecText;
                    }
                    else
                    {
                        lblRA.Text = "n/a";
                        lblDec.Text = "n/a";
                    }
                }

                if (top_left != null)
                {
                    lblTopLeft.Text = top_left.RaText + "," + top_left.DecText;
                }
                else
                {
                    lblTopLeft.Text = "n/a";
                }

                if (top_right != null)
                {
                    lblTopRight.Text = top_right.RaText + "," + top_right.DecText;
                }
                else
                {
                    lblTopRight.Text = "n/a";
                }

                int width = 0, height = 0;

                if (top_left != null && top_right != null)
                {
                    width = (int)(top_right.TotalRaSeconds - top_left.TotalRaSeconds);
                    lblWidth.Text = width.ToString();

                }

                if (top_left != null && bottom_right != null)
                {
                    height = (int)(bottom_right.TotalDecSeconds - top_left.TotalDecSeconds);
                    lblWidth.Text = height.ToString();
                }

                if (width > 0 && height > 0)
                {
                    var panels_x = width / udXStep.Value;
                    var panels_y = height / udYStep.Value;

                    var time = x * y * udDwell.Value;
                    lblTime.Text = $"{time / 60:2}:{time % 60:2}";
                }
                else
                {
                    lblTime.Text = "00:00";
                }
            });
        }

        #endregion

        #region Serial Port Management

        private void LoadPorts()
        {
            cboPort.Items.Clear();

            foreach (string s in SerialPort.GetPortNames())
            {
                cboPort.Items.Add(s);
            }

            if (cboPort.Items.Count == 0)
                cboPort.Enabled = false;
            else if (cboPort.Items.Count == 1)
                cboPort.SelectedIndex = 0;
        }

        private void ClosePort()
        {
            if (serialPort != null)
            {
                serialPort.Close();
                serialPort.Dispose();
            }
        }

        private void OpenPort(string portName)
        {
            ClosePort();

            serialPort = new SerialPort();
            serialPort.PortName = portName;
            serialPort.BaudRate = 9600;
            serialPort.Parity = Parity.None;
            serialPort.DataBits = 8;
            serialPort.StopBits = StopBits.One;
            serialPort.Handshake = Handshake.None;
            serialPort.Open();
        }

        #endregion

        #region UI

        private void btnRun_Click(object sender, EventArgs e)
        {
            Start();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Stop();
        }

        private void btnRefreshPorts_Click(object sender, EventArgs e)
        {
            LoadPorts();
        }

        private void btnSetTL_Click(object sender, EventArgs e)
        {
            top_left = ReadPosition();
        }

        private void btnSetTR_Click(object sender, EventArgs e)
        {
            top_right = ReadPosition();
        }

        private void btnSetBR_Click(object sender, EventArgs e)
        {
            bottom_right = ReadPosition();
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            var target = ReadPosition();

            if (target != null)
                ExecuteGotoCommand(target.WithOffset((int)udSpeed.Value * (chkInvertUD.Checked ? -1 : 1), 0));
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            var target = ReadPosition();

            if (target != null)
                ExecuteGotoCommand(target.WithOffset((int)udSpeed.Value * (chkInvertUD.Checked ? 1 : -1), 0));
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            var target = ReadPosition();
            if (target != null)
                ExecuteGotoCommand(target.WithOffset(0, (int)udSpeed.Value * (chkInvertUD.Checked ? -1 : 1)));
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            var target = ReadPosition();
            if (target != null)
                ExecuteGotoCommand(target.WithOffset(0, (int)udSpeed.Value * (chkInvertUD.Checked ? 1 : -1)));
        }

        private void btnGoTL_Click(object sender, EventArgs e)
        {
            if (top_left != null)
                ExecuteGotoCommand(top_left);
        }

        private void btnGoBR_Click(object sender, EventArgs e)
        {
            if (bottom_right != null)
                ExecuteGotoCommand(bottom_right);
        }

        private void btnSetXStep_Click(object sender, EventArgs e)
        {
            if (top_left != null)
            {
                var pos = ReadPosition();

                if (pos != null)
                    udXStep.Value = pos.TotalRaSeconds - top_left.TotalRaSeconds;
            }
        }

        private void btnSetYStep_Click(object sender, EventArgs e)
        {
            if (top_left != null)
            {
                var pos = ReadPosition();

                if (pos != null)
                    udYStep.Value = pos.TotalDecSeconds - top_left.TotalDecSeconds;
            }
        }

        private void cboPort_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboPort.SelectedItem != null)
                OpenPort(cboPort.Text);
        }

        #endregion

        private void chkLog_CheckedChanged(object sender, EventArgs e)
        {
            txtLog.Visible = chkLog.Checked;
        }

        private void Log(string text)
        {
            txtLog.Text += text + "\r\n";
        }
    }
}