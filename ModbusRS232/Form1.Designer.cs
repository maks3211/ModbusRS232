namespace ModbusRS232
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            controlTab = new TabControl();
            rs232Tab = new TabPage();
            rsClearBtn = new Button();
            label10 = new Label();
            rsCustomTerBox = new TextBox();
            rsSendBtn = new Button();
            rsTextBox = new TextBox();
            rsResponseBox = new TextBox();
            rsPingBtn = new Button();
            rsChangeBtn = new Button();
            rsSaveBtn = new Button();
            rstimeoutBox = new ComboBox();
            rsparityBox = new ComboBox();
            rstypeBox = new ComboBox();
            rscontrolBox = new ComboBox();
            rsportBox = new ComboBox();
            rsterminatorBox = new ComboBox();
            rsdataBitsBox = new ComboBox();
            rsstopBitBox = new ComboBox();
            rsSpeedBox = new ComboBox();
            label6 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            modBusTab = new TabPage();
            label17 = new Label();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            label11 = new Label();
            comboBox5 = new ComboBox();
            comboBox4 = new ComboBox();
            comboBox3 = new ComboBox();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            button1 = new Button();
            controlTab.SuspendLayout();
            rs232Tab.SuspendLayout();
            modBusTab.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(984, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // controlTab
            // 
            controlTab.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            controlTab.Controls.Add(rs232Tab);
            controlTab.Controls.Add(modBusTab);
            controlTab.Location = new Point(0, 0);
            controlTab.Name = "controlTab";
            controlTab.SelectedIndex = 0;
            controlTab.Size = new Size(984, 598);
            controlTab.SizeMode = TabSizeMode.FillToRight;
            controlTab.TabIndex = 1;
            controlTab.Selecting += controlTab_Selecting_1;
            // 
            // rs232Tab
            // 
            rs232Tab.AccessibleDescription = "";
            rs232Tab.AccessibleName = "";
            rs232Tab.Controls.Add(rsClearBtn);
            rs232Tab.Controls.Add(label10);
            rs232Tab.Controls.Add(rsCustomTerBox);
            rs232Tab.Controls.Add(rsSendBtn);
            rs232Tab.Controls.Add(rsTextBox);
            rs232Tab.Controls.Add(rsResponseBox);
            rs232Tab.Controls.Add(rsPingBtn);
            rs232Tab.Controls.Add(rsChangeBtn);
            rs232Tab.Controls.Add(rsSaveBtn);
            rs232Tab.Controls.Add(rstimeoutBox);
            rs232Tab.Controls.Add(rsparityBox);
            rs232Tab.Controls.Add(rstypeBox);
            rs232Tab.Controls.Add(rscontrolBox);
            rs232Tab.Controls.Add(rsportBox);
            rs232Tab.Controls.Add(rsterminatorBox);
            rs232Tab.Controls.Add(rsdataBitsBox);
            rs232Tab.Controls.Add(rsstopBitBox);
            rs232Tab.Controls.Add(rsSpeedBox);
            rs232Tab.Controls.Add(label6);
            rs232Tab.Controls.Add(label9);
            rs232Tab.Controls.Add(label8);
            rs232Tab.Controls.Add(label7);
            rs232Tab.Controls.Add(label5);
            rs232Tab.Controls.Add(label4);
            rs232Tab.Controls.Add(label3);
            rs232Tab.Controls.Add(label2);
            rs232Tab.Controls.Add(label1);
            rs232Tab.Location = new Point(4, 24);
            rs232Tab.Name = "rs232Tab";
            rs232Tab.Padding = new Padding(3);
            rs232Tab.Size = new Size(976, 570);
            rs232Tab.TabIndex = 0;
            rs232Tab.Text = "RS232";
            rs232Tab.UseVisualStyleBackColor = true;
            rs232Tab.Click += tabPage1_Click;
            // 
            // rsClearBtn
            // 
            rsClearBtn.Location = new Point(893, 6);
            rsClearBtn.Name = "rsClearBtn";
            rsClearBtn.Size = new Size(75, 23);
            rsClearBtn.TabIndex = 27;
            rsClearBtn.Text = "Wyczyść";
            rsClearBtn.UseVisualStyleBackColor = true;
            rsClearBtn.Click += rsClearBtn_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F);
            label10.Location = new Point(57, 403);
            label10.Name = "label10";
            label10.Size = new Size(180, 21);
            label10.TabIndex = 26;
            label10.Text = "Własny terminator (hex):";
            // 
            // rsCustomTerBox
            // 
            rsCustomTerBox.Location = new Point(78, 427);
            rsCustomTerBox.Name = "rsCustomTerBox";
            rsCustomTerBox.Size = new Size(121, 23);
            rsCustomTerBox.TabIndex = 25;
            // 
            // rsSendBtn
            // 
            rsSendBtn.Location = new Point(299, 514);
            rsSendBtn.Name = "rsSendBtn";
            rsSendBtn.Size = new Size(87, 23);
            rsSendBtn.TabIndex = 24;
            rsSendBtn.Text = "Wyślij";
            rsSendBtn.UseVisualStyleBackColor = true;
            rsSendBtn.Click += rsSendBtn_Click;
            // 
            // rsTextBox
            // 
            rsTextBox.Location = new Point(392, 514);
            rsTextBox.Name = "rsTextBox";
            rsTextBox.Size = new Size(578, 23);
            rsTextBox.TabIndex = 23;
            // 
            // rsResponseBox
            // 
            rsResponseBox.Location = new Point(297, 6);
            rsResponseBox.Multiline = true;
            rsResponseBox.Name = "rsResponseBox";
            rsResponseBox.Size = new Size(671, 502);
            rsResponseBox.TabIndex = 22;
            // 
            // rsPingBtn
            // 
            rsPingBtn.Enabled = false;
            rsPingBtn.Location = new Point(76, 528);
            rsPingBtn.Name = "rsPingBtn";
            rsPingBtn.Size = new Size(123, 23);
            rsPingBtn.TabIndex = 21;
            rsPingBtn.Text = "TEST - PING";
            rsPingBtn.UseVisualStyleBackColor = true;
            rsPingBtn.Click += rsPingBtn_Click;
            // 
            // rsChangeBtn
            // 
            rsChangeBtn.Enabled = false;
            rsChangeBtn.Location = new Point(76, 499);
            rsChangeBtn.Name = "rsChangeBtn";
            rsChangeBtn.Size = new Size(123, 23);
            rsChangeBtn.TabIndex = 20;
            rsChangeBtn.Text = "Zamknij port";
            rsChangeBtn.UseVisualStyleBackColor = true;
            rsChangeBtn.Click += rsChangeBtn_Click;
            // 
            // rsSaveBtn
            // 
            rsSaveBtn.Location = new Point(76, 470);
            rsSaveBtn.Name = "rsSaveBtn";
            rsSaveBtn.Size = new Size(123, 23);
            rsSaveBtn.TabIndex = 19;
            rsSaveBtn.Text = "ZAPISZ";
            rsSaveBtn.UseVisualStyleBackColor = true;
            rsSaveBtn.Click += rsSaveBtn_Click;
            // 
            // rstimeoutBox
            // 
            rstimeoutBox.DisplayMember = "Value";
            rstimeoutBox.DropDownStyle = ComboBoxStyle.DropDownList;
            rstimeoutBox.Font = new Font("Segoe UI", 12F);
            rstimeoutBox.FormattingEnabled = true;
            rstimeoutBox.Location = new Point(137, 270);
            rstimeoutBox.Name = "rstimeoutBox";
            rstimeoutBox.Size = new Size(121, 29);
            rstimeoutBox.TabIndex = 18;
            rstimeoutBox.ValueMember = "Key";
            // 
            // rsparityBox
            // 
            rsparityBox.DisplayMember = "Value";
            rsparityBox.DropDownStyle = ComboBoxStyle.DropDownList;
            rsparityBox.Font = new Font("Segoe UI", 12F);
            rsparityBox.FormattingEnabled = true;
            rsparityBox.Location = new Point(137, 310);
            rsparityBox.Name = "rsparityBox";
            rsparityBox.Size = new Size(121, 29);
            rsparityBox.TabIndex = 17;
            rsparityBox.ValueMember = "Key";
            // 
            // rstypeBox
            // 
            rstypeBox.DisplayMember = "Value";
            rstypeBox.DropDownStyle = ComboBoxStyle.DropDownList;
            rstypeBox.Font = new Font("Segoe UI", 12F);
            rstypeBox.FormattingEnabled = true;
            rstypeBox.Location = new Point(137, 350);
            rstypeBox.Name = "rstypeBox";
            rstypeBox.Size = new Size(121, 29);
            rstypeBox.TabIndex = 16;
            rstypeBox.ValueMember = "Key";
            // 
            // rscontrolBox
            // 
            rscontrolBox.DisplayMember = "Value";
            rscontrolBox.DropDownStyle = ComboBoxStyle.DropDownList;
            rscontrolBox.Font = new Font("Segoe UI", 12F);
            rscontrolBox.FormattingEnabled = true;
            rscontrolBox.Location = new Point(137, 230);
            rscontrolBox.Name = "rscontrolBox";
            rscontrolBox.Size = new Size(121, 29);
            rscontrolBox.TabIndex = 15;
            rscontrolBox.ValueMember = "Key";
            // 
            // rsportBox
            // 
            rsportBox.DisplayMember = "Value";
            rsportBox.DropDownStyle = ComboBoxStyle.DropDownList;
            rsportBox.Font = new Font("Segoe UI", 12F);
            rsportBox.FormattingEnabled = true;
            rsportBox.Location = new Point(137, 30);
            rsportBox.Name = "rsportBox";
            rsportBox.Size = new Size(121, 29);
            rsportBox.TabIndex = 14;
            rsportBox.ValueMember = "Key";
            // 
            // rsterminatorBox
            // 
            rsterminatorBox.DisplayMember = "Value";
            rsterminatorBox.DropDownStyle = ComboBoxStyle.DropDownList;
            rsterminatorBox.Font = new Font("Segoe UI", 12F);
            rsterminatorBox.FormattingEnabled = true;
            rsterminatorBox.Location = new Point(137, 150);
            rsterminatorBox.Name = "rsterminatorBox";
            rsterminatorBox.Size = new Size(121, 29);
            rsterminatorBox.TabIndex = 13;
            rsterminatorBox.ValueMember = "Key";
            rsterminatorBox.SelectedIndexChanged += rsterminatorBox_SelectedIndexChanged;
            // 
            // rsdataBitsBox
            // 
            rsdataBitsBox.DisplayMember = "Value";
            rsdataBitsBox.DropDownStyle = ComboBoxStyle.DropDownList;
            rsdataBitsBox.Font = new Font("Segoe UI", 12F);
            rsdataBitsBox.FormattingEnabled = true;
            rsdataBitsBox.Location = new Point(137, 110);
            rsdataBitsBox.Name = "rsdataBitsBox";
            rsdataBitsBox.Size = new Size(121, 29);
            rsdataBitsBox.TabIndex = 12;
            rsdataBitsBox.ValueMember = "Key";
            // 
            // rsstopBitBox
            // 
            rsstopBitBox.DisplayMember = "Value";
            rsstopBitBox.DropDownStyle = ComboBoxStyle.DropDownList;
            rsstopBitBox.Font = new Font("Segoe UI", 12F);
            rsstopBitBox.FormattingEnabled = true;
            rsstopBitBox.Location = new Point(137, 70);
            rsstopBitBox.Name = "rsstopBitBox";
            rsstopBitBox.Size = new Size(121, 29);
            rsstopBitBox.TabIndex = 11;
            rsstopBitBox.ValueMember = "Key";
            // 
            // rsSpeedBox
            // 
            rsSpeedBox.DisplayMember = "Value";
            rsSpeedBox.DropDownStyle = ComboBoxStyle.DropDownList;
            rsSpeedBox.Font = new Font("Segoe UI", 12F);
            rsSpeedBox.FormattingEnabled = true;
            rsSpeedBox.Location = new Point(137, 190);
            rsSpeedBox.Name = "rsSpeedBox";
            rsSpeedBox.Size = new Size(121, 29);
            rsSpeedBox.TabIndex = 10;
            rsSpeedBox.ValueMember = "Key";
            rsSpeedBox.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(22, 350);
            label6.Name = "label6";
            label6.Size = new Size(109, 21);
            label6.TabIndex = 9;
            label6.Text = "Typ transmisji:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.Location = new Point(22, 270);
            label9.Name = "label9";
            label9.Size = new Size(70, 21);
            label9.TabIndex = 8;
            label9.Text = "Timeout:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(22, 310);
            label8.Name = "label8";
            label8.Size = new Size(85, 21);
            label8.TabIndex = 7;
            label8.Text = "Parzystość:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F);
            label7.Location = new Point(6, 236);
            label7.Name = "label7";
            label7.Size = new Size(131, 19);
            label7.TabIndex = 6;
            label7.Text = "Kontrola przepływu:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(22, 30);
            label5.Name = "label5";
            label5.Size = new Size(41, 21);
            label5.TabIndex = 4;
            label5.Text = "Port:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(22, 110);
            label4.Name = "label4";
            label4.Size = new Size(93, 21);
            label4.TabIndex = 3;
            label4.Text = "Bity danych:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(22, 70);
            label3.Name = "label3";
            label3.Size = new Size(82, 21);
            label3.TabIndex = 2;
            label3.Text = "Bity stopu:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(22, 190);
            label2.Name = "label2";
            label2.Size = new Size(77, 21);
            label2.TabIndex = 1;
            label2.Text = "Szybkość:";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(22, 150);
            label1.Name = "label1";
            label1.Size = new Size(88, 21);
            label1.TabIndex = 0;
            label1.Text = "Terminator:";
            label1.Click += label1_Click;
            // 
            // modBusTab
            // 
            modBusTab.Controls.Add(label17);
            modBusTab.Controls.Add(label16);
            modBusTab.Controls.Add(label15);
            modBusTab.Controls.Add(label14);
            modBusTab.Controls.Add(label11);
            modBusTab.Controls.Add(comboBox5);
            modBusTab.Controls.Add(comboBox4);
            modBusTab.Controls.Add(comboBox3);
            modBusTab.Controls.Add(comboBox1);
            modBusTab.Controls.Add(comboBox2);
            modBusTab.Controls.Add(button1);
            modBusTab.Location = new Point(4, 24);
            modBusTab.Name = "modBusTab";
            modBusTab.Padding = new Padding(3);
            modBusTab.Size = new Size(976, 570);
            modBusTab.TabIndex = 1;
            modBusTab.Text = "Modbus";
            modBusTab.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Enabled = false;
            label17.Font = new Font("Segoe UI", 12F);
            label17.Location = new Point(27, 81);
            label17.Name = "label17";
            label17.Size = new Size(41, 21);
            label17.TabIndex = 22;
            label17.Text = "Port:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 12F);
            label16.Location = new Point(27, 122);
            label16.Name = "label16";
            label16.Size = new Size(73, 21);
            label16.TabIndex = 21;
            label16.Text = "Prędkość";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 12F);
            label15.Location = new Point(27, 174);
            label15.Name = "label15";
            label15.Size = new Size(109, 21);
            label15.TabIndex = 20;
            label15.Text = "Typ transmisji:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F);
            label14.Location = new Point(21, 224);
            label14.Name = "label14";
            label14.Size = new Size(115, 21);
            label14.TabIndex = 19;
            label14.Text = "Timeout znaku:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F);
            label11.Location = new Point(27, 35);
            label11.Name = "label11";
            label11.Size = new Size(76, 21);
            label11.TabIndex = 16;
            label11.Text = "Typ stacji:";
            // 
            // comboBox5
            // 
            comboBox5.DisplayMember = "Value";
            comboBox5.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox5.Font = new Font("Segoe UI", 12F);
            comboBox5.FormattingEnabled = true;
            comboBox5.Location = new Point(134, 171);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(121, 29);
            comboBox5.TabIndex = 15;
            comboBox5.ValueMember = "Key";
            // 
            // comboBox4
            // 
            comboBox4.DisplayMember = "Value";
            comboBox4.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox4.Font = new Font("Segoe UI", 12F);
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(142, 221);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(121, 29);
            comboBox4.TabIndex = 14;
            comboBox4.ValueMember = "Key";
            // 
            // comboBox3
            // 
            comboBox3.DisplayMember = "Value";
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox3.Font = new Font("Segoe UI", 12F);
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(134, 73);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(121, 29);
            comboBox3.TabIndex = 13;
            comboBox3.ValueMember = "Key";
            // 
            // comboBox1
            // 
            comboBox1.DisplayMember = "Value";
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Segoe UI", 12F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(134, 119);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 29);
            comboBox1.TabIndex = 12;
            comboBox1.ValueMember = "Key";
            // 
            // comboBox2
            // 
            comboBox2.DisplayMember = "Value";
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.Font = new Font("Segoe UI", 12F);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(134, 27);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 29);
            comboBox2.TabIndex = 11;
            comboBox2.ValueMember = "Key";
            // 
            // button1
            // 
            button1.Location = new Point(28, 311);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 597);
            Controls.Add(controlTab);
            Controls.Add(menuStrip1);
            MaximumSize = new Size(1000, 636);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            controlTab.ResumeLayout(false);
            rs232Tab.ResumeLayout(false);
            rs232Tab.PerformLayout();
            modBusTab.ResumeLayout(false);
            modBusTab.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private TabControl controlTab;
        private TabPage rs232Tab;
        private Label label1;
        private TabPage modBusTab;
        private Button button1;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private ComboBox rsSpeedBox;
        private Label label6;
        private ComboBox rstimeoutBox;
        private ComboBox rsparityBox;
        private ComboBox rstypeBox;
        private ComboBox rscontrolBox;
        private ComboBox rsportBox;
        private ComboBox rsterminatorBox;
        private ComboBox rsdataBitsBox;
        private ComboBox rsstopBitBox;
        private Button rsPingBtn;
        private Button rsChangeBtn;
        private Button rsSaveBtn;
        private Button rsSendBtn;
        private TextBox rsTextBox;
        private TextBox rsResponseBox;
        private Label label10;
        private TextBox rsCustomTerBox;
        private Button rsClearBtn;
        private Label label17;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label11;
        private ComboBox comboBox5;
        private ComboBox comboBox4;
        private ComboBox comboBox3;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
    }
}
