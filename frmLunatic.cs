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

        private void Start()
        {
            btnRun.Enabled = false;
            btnCancel.Enabled = true;

            _running = true;
            x = 0;
            y = 0;
        }

        private void Stop()
        {
            btnRun.Enabled = true;
            btnCancel.Enabled = false;

            _running = false;
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

            lblPosition.Invoke(() =>
            {
                if (_serialPort == null)
                {
                    lblPosition.Text = "Not Connected";
                }
                else
                {
                    lblPosition.Text = GetPosition();
                }

                if (_running)
                {
                    lblX.Text = string.Format("{0}/{1}", x, max_x);
                    lblY.Text = string.Format("{0}/{1}", y, max_y);
                }
            });

        }

        private string GetPosition()
        {
            if (_serialPort != null)
            {
                _serialPort.Write("?");
                Thread.Sleep(250);
                _serialPort.Write("E");
                Thread.Sleep(1500);

                var result = _serialPort.ReadExisting();

                var ra = int.Parse(result.Substring(1, 2), System.Globalization.NumberStyles.HexNumber) * 256;
                ra += int.Parse(result.Substring(3, 2), System.Globalization.NumberStyles.HexNumber);
                ra = ra * 24 * 60 / 65536;

                var dec = int.Parse(result.Substring(6, 2), System.Globalization.NumberStyles.HexNumber) * 256;
                dec += int.Parse(result.Substring(8, 2), System.Globalization.NumberStyles.HexNumber);
                dec = dec * 360 * 60 / 65536;

                return string.Format("RA={0}:{1}:00  DEC={2}:{3}:00", ra / 60, ra % 60, dec / 60, dec % 60);
            }

            return "N/C";
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
            btnRun.Enabled = false;
            _running = true;
        }

        private void cboPort_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboPort.SelectedItem != null)
                OpenPort(cboPort.Text);
        }
    }
}