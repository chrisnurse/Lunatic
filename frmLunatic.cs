using System.IO.Ports;

namespace Lunatic
{
    public partial class frmLunatic : Form
    {
        private SerialPort? _serialPort;
        private System.Timers.Timer? _timer;
        private int _pollPositionInterval = 1000;
        private bool _running = false;

        private int x = 0, y = 0;

        private int max_x = 10;
        private int max_y = 10;

        private void Next()
        {
            x++;
            if (x == max_x)
            {
                y++;

                if (y == max_y)
                {
                    Stop();
                }
            }
        }

        private void UpdateUIState()
        {
            lblRA.Invoke(() =>
            {
                btnRun.Visible = !_running;
                btnCancel.Visible = _running;

                if (_running)
                {
                    lblX.Text = string.Format("{0}/{1}", x, max_x);
                    lblY.Text = string.Format("{0}/{1}", y, max_y);
                }
                else
                {
                    lblX.Text = "standby";
                    lblY.Text = "standby";
                }

                ReadPosition();

            });
        }

        private void Start()
        {
            _running = true;
            UpdateUIState();

            x = 0;
            y = 0;
        }

        private void Stop()
        {
            _running = false;
            UpdateUIState();

            x = 0;
            y = 0;
        }

        public frmLunatic()
        {
            InitializeComponent();

            foreach (string s in SerialPort.GetPortNames())
            {
                cboPort.Items.Add(s);
            }

            if (cboPort.Items.Count == 0)
                cboPort.Enabled = false;

            _timer = new System.Timers.Timer();
            _timer.Interval = _pollPositionInterval;
            _timer.Enabled = true;
            _timer.Elapsed += UpdatePosition;
        }

        private void UpdatePosition(object? sender, System.Timers.ElapsedEventArgs e)
        {
            if (_timer != null)
                _timer.Interval = _pollPositionInterval;

            UpdateUIState();
        }

        private void ReadPosition()
        {
            var rnd = new Random();
            var ra = rnd.Next(0, 60 * 60);
            var dec = rnd.Next(0, 60 * 60);

            var ra1 = (ra / 60);
            var ra2 = (ra % 60);
            var dec1 = (dec / 60);
            var dec2 = (dec % 60);

            var result = $"R{ra1:X2}{ra2:X2},{dec1:X2}{dec2:X2}";

            if (_serialPort != null)
            {
                _serialPort.Write("?");
                Thread.Sleep(250);
                _serialPort.Write("E");
                Thread.Sleep(1500);

                result = _serialPort.ReadExisting();
            }

            var pos = ParsePosition(result);

            lblRA.Text = string.Format("{0}:{1}", pos.RaHours, pos.RaMinutes);
            lblDec.Text = string.Format("{0}:{1}", pos.DecDegrees, pos.DecMinutes);
        }

        private AstronomicalPosition ParsePosition(string pos)
        {
            var ra = int.Parse(pos.Substring(1, 2), System.Globalization.NumberStyles.HexNumber) * 256;
            ra += int.Parse(pos.Substring(3, 2), System.Globalization.NumberStyles.HexNumber);
            ra = ra * 24 * 60 * 60 / 65536;

            var dec = int.Parse(pos.Substring(6, 2), System.Globalization.NumberStyles.HexNumber) * 256;
            dec += int.Parse(pos.Substring(8, 2), System.Globalization.NumberStyles.HexNumber);
            dec = dec * 360 * 60 / 65536;

            var ap = new AstronomicalPosition();

            ap.RaHours = ra / 360;
            ap.RaMinutes = ra % 360;

            ap.DecDegrees = dec / 360;
            ap.DecMinutes = dec % 360;

            return ap;
        }

        private string GetMountMoveCommand(AstronomicalPosition position)
        {
            var ra = (uint)(((position.RaHours * 60.0 + position.RaMinutes) * 15.0) * 3.0 * 1.011358);

            uint dec;

            if (position.Sign == DecSign.Plus)
            {
                dec = (uint)((position.DecDegrees * 60 + position.DecMinutes) * 3 * 1.011358);
            }
            else
            {
                dec = (uint)(((360 * 60) - (position.DecDegrees * 60 + position.DecMinutes)) * 3 * 1.011358);
            }

            var ra_hi = ra / 256;
            var ra_lo = ra % 256;

            var dec_hi = dec / 256;
            var dec_lo = dec % 256;

            return string.Format("R{0:X2}{1:X2},{2:X2}{3:X2}", ra_hi, ra_lo, dec_hi, dec_lo);
        }

        protected override void OnClosed(EventArgs e)
        {
            ClosePort();
            base.OnClosed(e);
        }

        private void ClosePort()
        {
            if (_serialPort != null)
            {
                _serialPort.Close();
                _serialPort.Dispose();
            }
        }

        private void OpenPort(string portName)
        {
            ClosePort();

            _serialPort = new SerialPort();
            _serialPort.PortName = portName;
            _serialPort.BaudRate = 9600;
            _serialPort.Parity = Parity.None;
            _serialPort.DataBits = 8;
            _serialPort.StopBits = StopBits.One;
            _serialPort.Handshake = Handshake.None;
            _serialPort.Open();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            Start();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Stop();
        }

        private void cboPort_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboPort.SelectedItem != null)
                OpenPort(cboPort.Text);
        }
    }
}