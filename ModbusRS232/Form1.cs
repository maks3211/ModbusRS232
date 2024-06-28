using ModbusRS232.RS232;
using System.ComponentModel;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static ModbusRS232.RS232.Enums;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

//IWSK - GLIWICE sem.VI Komunikacja na porcie znakowym RS232
//Sk³ad sekcji 4A (ismip) (wtorek 8:00 t.N):
//Jakub	Gazda
//Kamil	Brewczyk
//Maksymilian Kloc
//Jakub	Bia³kowski
//Mykyta Shemechko
//Pawe³	Pluta
//Jakub Smajdor
//Micha³ Brodziak
//Aleksander Sykulski
//Jakub	Zaj¹c
//Jakub	Kromo³owski
//Konrad Kobielus
//Micha³ Kulesa
//Jakub	Skraba

namespace ModbusRS232
{
    public partial class Form1 : Form
    {
        private readonly IRS232Service service;
        public Form1()
        {
         
            service = new RS232Service();
            InitializeComponent();
            this.Text = "IWSK s. 4A";
            rsResponseBox.ScrollBars = ScrollBars.Vertical;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rsSpeedBox.DataSource = new List<int> { 150, 300, 600, 1200, 2400, 4800, 9600, 14400, 19200, 38400, 56000, 57600, 115200 }.Select(it => new KeyValuePair<int, int>(it, it)).ToList();
            rsstopBitBox.DataSource = new List<int> { 1, 2 }.Select(it => new KeyValuePair<int, int>(it, it)).ToList();
            rsdataBitsBox.DataSource = new List<int> { 7, 8 }.Select(it => new KeyValuePair<int, int>(it, it)).ToList();
            rsterminatorBox.DataSource = Enum.GetNames(typeof(Terminator)).Select(it => new KeyValuePair<Terminator, string>((Terminator)Enum.Parse(typeof(Terminator), it), it)).ToList();
            rsportBox.DataSource = service.GetPortNames().Select(it => new KeyValuePair<string, string>(it, it)).ToList();
            rscontrolBox.DataSource = Enum.GetNames(typeof(FlowControl)).Select(it => new KeyValuePair<FlowControl, string>((FlowControl)Enum.Parse(typeof(FlowControl), it), it.Replace('_', '/'))).ToList();
            rstimeoutBox.DataSource = Enumerable.Range(1, 1000).Select(it => ((double)it) / 100).Select(it => new KeyValuePair<double, double>(it, it)).ToList();
            rsparityBox.DataSource = Enum.GetNames(typeof(Parity)).Select(it => new KeyValuePair<Parity, string>((Parity)Enum.Parse(typeof(Parity), it), it)).ToList();
            rstypeBox.DataSource = Enum.GetNames(typeof(DataType)).Select(it => new KeyValuePair<DataType, string>((DataType)Enum.Parse(typeof(DataType), it), it)).ToList();

            SetAllEnabled(true);
            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;
                while (true)
                {
                    var message = service.ReceiveMessage();

                    if (!string.IsNullOrEmpty(message))
                    {
                        try
                        {
                            this.rsResponseBox.AppendText(Environment.NewLine);
                            this.rsResponseBox.AppendText(message);
                        }
                        catch
                        {

                        }
                    }
                }
            }).Start();
        }
  

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rsSaveBtn_Click(object sender, EventArgs e)
        {
            var portParameters = new PortParameters
            {
                Speed = Int32.Parse(this.rsSpeedBox.Text),
                StopBits = (StopBits)Int32.Parse(this.rsstopBitBox.Text),
                DataBits = Int32.Parse(this.rsdataBitsBox.Text),
                Terminator = (Terminator)Enum.Parse(typeof(Terminator), this.rsterminatorBox.Text),
                MyTerminator = (Terminator)Enum.Parse(typeof(Terminator), this.rsterminatorBox.Text)
                   == Terminator.WLASNY ? this.rsCustomTerBox.Text : string.Empty,
                PortName = this.rsportBox.Text,
                FlowControl = (FlowControl)Enum.Parse(typeof(FlowControl), this.rscontrolBox.Text.Replace('/', '_')),
                Parity = (Parity)Enum.Parse(typeof(Parity), this.rsparityBox.Text),
                Timeout = Double.Parse(this.rstimeoutBox.Text),
                DataType = (DataType)Enum.Parse(typeof(DataType), this.rsdataBitsBox.Text)
            };

            this.rsResponseBox.Text = "Konfiguracja portu...";

            var isOpen = service.OpenPort(portParameters);
            SetAllEnabled(!isOpen);

            if (isOpen)
            {
                this.rsResponseBox.AppendText(Environment.NewLine);
                this.rsResponseBox.Text += "Konfiguracja przebieg³a pomyœlnie.";
            }
            else
            {
                this.rsResponseBox.AppendText(Environment.NewLine);
                this.rsResponseBox.Text += "Konfiguracja NIE przebieg³a pomyœlnie.";
            }
        }
        private void SetAllEnabled(bool enabled)
        {

            if (enabled)
            {
                var value = rsportBox.SelectedValue;
                rsportBox.DataSource = service.GetPortNames().Select(it => new KeyValuePair<string, string>(it, it)).ToList();
                try
                {
                    rsportBox.SelectedValue = value;
                }
                catch (Exception) { }
            }

            rsSaveBtn.Enabled = enabled;
            rsChangeBtn.Enabled = !enabled;
            rsPingBtn.Enabled = !enabled;
            rsTextBox.Enabled = !enabled;
            rsSendBtn.Enabled = !enabled;
        }
        private void SetOwnTerminatorVisible(bool visible)
        {

            rsCustomTerBox.Visible = visible;
            label10.Visible = visible;

        }

        private void rsterminatorBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Terminator terminator = (Terminator)rsterminatorBox.SelectedValue;
            SetOwnTerminatorVisible(terminator == Terminator.WLASNY);
        }

        private void rsClearBtn_Click(object sender, EventArgs e)
        {
            rsResponseBox.Text = "";
        }

        private void rsChangeBtn_Click(object sender, EventArgs e)
        {
            SetAllEnabled(true);
            service.ClosePort();
        }

        private void rsSendBtn_Click(object sender, EventArgs e)
        {
            var message = this.rsTextBox.Text;
            var encodedMessage = message;
            DataType transferType = (DataType)rstypeBox.SelectedValue;
            if (transferType == DataType.HEX)
            {
                if (!Regex.IsMatch(rsdataBitsBox.Text, "^([0-9a-fA-F]{2}( )?)*$"))
                {
                    MessageBox.Show("Nieprawid³owy ci¹g bajtów.", "B³¹d walidacji", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                encodedMessage = service.HexToString(encodedMessage.Replace(" ", ""));
            }
            service.SendMessage(encodedMessage);
            this.rsResponseBox.AppendText(Environment.NewLine);
            this.rsResponseBox.AppendText($"[out] {message}");
            this.rsTextBox.Text = string.Empty;
            this.rsTextBox.Focus();
        }
        private void hexByte_Validating(object sender, CancelEventArgs e)
        {
            if (!Regex.IsMatch(((System.Windows.Forms.TextBox)sender).Text, "^([0-9a-fA-F]{2}( )?)*$"))
            {
                e.Cancel = true;
                MessageBox.Show("Nieprawid³owy ci¹g bajtów.", "B³¹d walidacji", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rsPingBtn_Click(object sender, EventArgs e)
        {
            service.SendPing();
        }

        private void controlTab_Selecting_1(object sender, TabControlCancelEventArgs e)
        {
            //Wy³aczenie zak³adki dla modbusa
            if (e.TabPage == controlTab.TabPages["modBusTab"])
            {
                
                e.Cancel = true;
                MessageBox.Show("Opcja modbus nie zosta³a ukoñczona");
            }
        }
    }
}
