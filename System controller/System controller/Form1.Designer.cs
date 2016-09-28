namespace System_controller
{
    partial class SystemController
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SystemController));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.CPU = new System.Windows.Forms.RichTextBox();
            this.GPU1 = new System.Windows.Forms.RichTextBox();
            this.GPU2 = new System.Windows.Forms.RichTextBox();
            this.Average = new System.Windows.Forms.RichTextBox();
            this.WeightedSelect = new System.Windows.Forms.CheckBox();
            this.Weighted = new System.Windows.Forms.RichTextBox();
            this.CPUTemp = new System.Windows.Forms.RichTextBox();
            this.GPU1Temp = new System.Windows.Forms.RichTextBox();
            this.GPU2Temp = new System.Windows.Forms.RichTextBox();
            this.AvgTemp = new System.Windows.Forms.RichTextBox();
            this.Temps = new System.Windows.Forms.RichTextBox();
            this.Cores = new System.Windows.Forms.RichTextBox();
            this.CoreTemps = new System.Windows.Forms.RichTextBox();
            this.Fans = new System.Windows.Forms.RichTextBox();
            this.RPMVal = new System.Windows.Forms.RichTextBox();
            this.RPM = new System.Windows.Forms.RichTextBox();
            this.Speed = new System.Windows.Forms.RichTextBox();
            this.SpeedVal = new System.Windows.Forms.RichTextBox();
            this.Graph = new System.Windows.Forms.PictureBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.LockFan = new System.Windows.Forms.RichTextBox();
            this.LockFanSelect = new System.Windows.Forms.CheckBox();
            this.Apply = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.Leds = new System.Windows.Forms.RichTextBox();
            this.na = new System.Windows.Forms.RadioButton();
            this.fl = new System.Windows.Forms.RadioButton();
            this.rf = new System.Windows.Forms.RadioButton();
            this.fd = new System.Windows.Forms.RadioButton();
            this.tmp = new System.Windows.Forms.RadioButton();
            this.LEDMode = new System.Windows.Forms.GroupBox();
            this.Timing = new System.Windows.Forms.RichTextBox();
            this.Interval = new System.Windows.Forms.RichTextBox();
            this.RGB = new System.Windows.Forms.RichTextBox();
            this.R = new System.Windows.Forms.RichTextBox();
            this.G = new System.Windows.Forms.RichTextBox();
            this.B = new System.Windows.Forms.RichTextBox();
            this.PreviewRGB = new System.Windows.Forms.RichTextBox();
            this.PreviewInterval = new System.Windows.Forms.RichTextBox();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.LEDPreviewSelect = new System.Windows.Forms.CheckBox();
            this.Preview = new System.Windows.Forms.RichTextBox();
            this.LockLed = new System.Windows.Forms.RichTextBox();
            this.LockLEDSelect = new System.Windows.Forms.CheckBox();
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.ColorMode = new System.Windows.Forms.GroupBox();
            this.Override = new System.Windows.Forms.CheckBox();
            this.RGBTemp = new System.Windows.Forms.RadioButton();
            this.RGBRandom = new System.Windows.Forms.RadioButton();
            this.timer5 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Graph)).BeginInit();
            this.LEDMode.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.ColorMode.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // CPU
            // 
            this.CPU.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CPU.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CPU.Cursor = System.Windows.Forms.Cursors.Default;
            this.CPU.Font = new System.Drawing.Font("Open 24 Display St", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPU.ForeColor = System.Drawing.Color.Red;
            this.CPU.Location = new System.Drawing.Point(50, 95);
            this.CPU.Name = "CPU";
            this.CPU.ReadOnly = true;
            this.CPU.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.CPU.Size = new System.Drawing.Size(100, 52);
            this.CPU.TabIndex = 47;
            this.CPU.TabStop = false;
            this.CPU.Text = "CPU";
            this.CPU.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CPU_MouseDown);
            // 
            // GPU1
            // 
            this.GPU1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GPU1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GPU1.Cursor = System.Windows.Forms.Cursors.Default;
            this.GPU1.Font = new System.Drawing.Font("Open 24 Display St", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GPU1.ForeColor = System.Drawing.Color.Red;
            this.GPU1.Location = new System.Drawing.Point(213, 95);
            this.GPU1.Name = "GPU1";
            this.GPU1.ReadOnly = true;
            this.GPU1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.GPU1.Size = new System.Drawing.Size(100, 52);
            this.GPU1.TabIndex = 1;
            this.GPU1.TabStop = false;
            this.GPU1.Text = "GPU 1";
            this.GPU1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GPU1_MouseDown);
            // 
            // GPU2
            // 
            this.GPU2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GPU2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GPU2.Cursor = System.Windows.Forms.Cursors.Default;
            this.GPU2.Font = new System.Drawing.Font("Open 24 Display St", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GPU2.ForeColor = System.Drawing.Color.Red;
            this.GPU2.Location = new System.Drawing.Point(379, 95);
            this.GPU2.Name = "GPU2";
            this.GPU2.ReadOnly = true;
            this.GPU2.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.GPU2.Size = new System.Drawing.Size(100, 52);
            this.GPU2.TabIndex = 2;
            this.GPU2.TabStop = false;
            this.GPU2.Text = "GPU 2";
            this.GPU2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GPU2_MouseDown);
            // 
            // Average
            // 
            this.Average.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Average.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Average.Cursor = System.Windows.Forms.Cursors.Default;
            this.Average.Font = new System.Drawing.Font("Open 24 Display St", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Average.ForeColor = System.Drawing.Color.Red;
            this.Average.Location = new System.Drawing.Point(535, 95);
            this.Average.Name = "Average";
            this.Average.ReadOnly = true;
            this.Average.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.Average.Size = new System.Drawing.Size(100, 52);
            this.Average.TabIndex = 3;
            this.Average.TabStop = false;
            this.Average.Text = "Avg.";
            this.Average.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Average_MouseDown);
            // 
            // WeightedSelect
            // 
            this.WeightedSelect.AutoSize = true;
            this.WeightedSelect.Location = new System.Drawing.Point(550, 201);
            this.WeightedSelect.Name = "WeightedSelect";
            this.WeightedSelect.Size = new System.Drawing.Size(80, 17);
            this.WeightedSelect.TabIndex = 4;
            this.WeightedSelect.Text = "checkBox1";
            this.WeightedSelect.UseVisualStyleBackColor = true;
            this.WeightedSelect.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Weighted
            // 
            this.Weighted.BackColor = System.Drawing.SystemColors.Desktop;
            this.Weighted.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Weighted.Cursor = System.Windows.Forms.Cursors.Default;
            this.Weighted.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Weighted.Location = new System.Drawing.Point(569, 202);
            this.Weighted.Name = "Weighted";
            this.Weighted.ReadOnly = true;
            this.Weighted.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.Weighted.Size = new System.Drawing.Size(81, 17);
            this.Weighted.TabIndex = 5;
            this.Weighted.TabStop = false;
            this.Weighted.Text = "Weighted";
            this.Weighted.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Weighted_MouseDown);
            // 
            // CPUTemp
            // 
            this.CPUTemp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CPUTemp.Cursor = System.Windows.Forms.Cursors.Default;
            this.CPUTemp.Font = new System.Drawing.Font("Open 24 Display St", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPUTemp.ForeColor = System.Drawing.Color.Red;
            this.CPUTemp.Location = new System.Drawing.Point(50, 146);
            this.CPUTemp.Name = "CPUTemp";
            this.CPUTemp.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.CPUTemp.Size = new System.Drawing.Size(100, 49);
            this.CPUTemp.TabIndex = 6;
            this.CPUTemp.TabStop = false;
            this.CPUTemp.Text = "";
            // 
            // GPU1Temp
            // 
            this.GPU1Temp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GPU1Temp.Cursor = System.Windows.Forms.Cursors.Default;
            this.GPU1Temp.Font = new System.Drawing.Font("Open 24 Display St", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GPU1Temp.ForeColor = System.Drawing.Color.Red;
            this.GPU1Temp.Location = new System.Drawing.Point(213, 146);
            this.GPU1Temp.Name = "GPU1Temp";
            this.GPU1Temp.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.GPU1Temp.Size = new System.Drawing.Size(100, 49);
            this.GPU1Temp.TabIndex = 7;
            this.GPU1Temp.TabStop = false;
            this.GPU1Temp.Text = "";
            // 
            // GPU2Temp
            // 
            this.GPU2Temp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GPU2Temp.Cursor = System.Windows.Forms.Cursors.Default;
            this.GPU2Temp.Font = new System.Drawing.Font("Open 24 Display St", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GPU2Temp.ForeColor = System.Drawing.Color.Red;
            this.GPU2Temp.Location = new System.Drawing.Point(379, 146);
            this.GPU2Temp.Name = "GPU2Temp";
            this.GPU2Temp.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.GPU2Temp.Size = new System.Drawing.Size(100, 49);
            this.GPU2Temp.TabIndex = 8;
            this.GPU2Temp.TabStop = false;
            this.GPU2Temp.Text = "";
            // 
            // AvgTemp
            // 
            this.AvgTemp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AvgTemp.Cursor = System.Windows.Forms.Cursors.Default;
            this.AvgTemp.Font = new System.Drawing.Font("Open 24 Display St", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AvgTemp.ForeColor = System.Drawing.Color.Red;
            this.AvgTemp.Location = new System.Drawing.Point(535, 146);
            this.AvgTemp.Name = "AvgTemp";
            this.AvgTemp.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.AvgTemp.Size = new System.Drawing.Size(100, 49);
            this.AvgTemp.TabIndex = 9;
            this.AvgTemp.TabStop = false;
            this.AvgTemp.Text = "";
            // 
            // Temps
            // 
            this.Temps.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Temps.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Temps.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Temps.Font = new System.Drawing.Font("Open 24 Display St", 48F);
            this.Temps.ForeColor = System.Drawing.Color.Red;
            this.Temps.Location = new System.Drawing.Point(50, 12);
            this.Temps.Name = "Temps";
            this.Temps.ReadOnly = true;
            this.Temps.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.Temps.Size = new System.Drawing.Size(585, 77);
            this.Temps.TabIndex = 10;
            this.Temps.TabStop = false;
            this.Temps.Text = "Temperatures";
            this.Temps.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Temps_MouseDown);
            // 
            // Cores
            // 
            this.Cores.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Cores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Cores.Cursor = System.Windows.Forms.Cursors.Default;
            this.Cores.Font = new System.Drawing.Font("Open 24 Display St", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cores.ForeColor = System.Drawing.Color.Red;
            this.Cores.Location = new System.Drawing.Point(50, 224);
            this.Cores.Name = "Cores";
            this.Cores.ReadOnly = true;
            this.Cores.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.Cores.Size = new System.Drawing.Size(128, 42);
            this.Cores.TabIndex = 11;
            this.Cores.TabStop = false;
            this.Cores.Text = "CPU Cores";
            this.Cores.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Cores_MouseDown);
            // 
            // CoreTemps
            // 
            this.CoreTemps.BackColor = System.Drawing.SystemColors.InfoText;
            this.CoreTemps.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CoreTemps.Cursor = System.Windows.Forms.Cursors.Default;
            this.CoreTemps.Font = new System.Drawing.Font("Open 24 Display St", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CoreTemps.ForeColor = System.Drawing.Color.Red;
            this.CoreTemps.Location = new System.Drawing.Point(213, 224);
            this.CoreTemps.Name = "CoreTemps";
            this.CoreTemps.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.CoreTemps.Size = new System.Drawing.Size(422, 42);
            this.CoreTemps.TabIndex = 12;
            this.CoreTemps.TabStop = false;
            this.CoreTemps.Text = "";
            // 
            // Fans
            // 
            this.Fans.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Fans.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Fans.Cursor = System.Windows.Forms.Cursors.Default;
            this.Fans.Font = new System.Drawing.Font("Open 24 Display St", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fans.ForeColor = System.Drawing.Color.Lime;
            this.Fans.Location = new System.Drawing.Point(50, 321);
            this.Fans.Name = "Fans";
            this.Fans.ReadOnly = true;
            this.Fans.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.Fans.Size = new System.Drawing.Size(585, 81);
            this.Fans.TabIndex = 13;
            this.Fans.TabStop = false;
            this.Fans.Text = "Fan Speeds";
            this.Fans.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Fans_MouseDown);
            // 
            // RPMVal
            // 
            this.RPMVal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RPMVal.Cursor = System.Windows.Forms.Cursors.Default;
            this.RPMVal.Font = new System.Drawing.Font("Open 24 Display St", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RPMVal.ForeColor = System.Drawing.Color.Lime;
            this.RPMVal.Location = new System.Drawing.Point(535, 625);
            this.RPMVal.Name = "RPMVal";
            this.RPMVal.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.RPMVal.Size = new System.Drawing.Size(100, 42);
            this.RPMVal.TabIndex = 17;
            this.RPMVal.TabStop = false;
            this.RPMVal.Text = "";
            // 
            // RPM
            // 
            this.RPM.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.RPM.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RPM.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.RPM.Font = new System.Drawing.Font("Open 24 Display St", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RPM.ForeColor = System.Drawing.Color.Lime;
            this.RPM.Location = new System.Drawing.Point(535, 569);
            this.RPM.Name = "RPM";
            this.RPM.ReadOnly = true;
            this.RPM.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.RPM.Size = new System.Drawing.Size(100, 50);
            this.RPM.TabIndex = 16;
            this.RPM.TabStop = false;
            this.RPM.Text = "RPM";
            this.RPM.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RPM_MouseDown);
            // 
            // Speed
            // 
            this.Speed.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Speed.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Speed.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Speed.Font = new System.Drawing.Font("Open 24 Display St", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Speed.ForeColor = System.Drawing.Color.Lime;
            this.Speed.Location = new System.Drawing.Point(535, 420);
            this.Speed.Name = "Speed";
            this.Speed.ReadOnly = true;
            this.Speed.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.Speed.Size = new System.Drawing.Size(100, 50);
            this.Speed.TabIndex = 16;
            this.Speed.TabStop = false;
            this.Speed.Text = "Speed";
            this.Speed.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Speed_MouseDown);
            // 
            // SpeedVal
            // 
            this.SpeedVal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SpeedVal.Cursor = System.Windows.Forms.Cursors.Default;
            this.SpeedVal.Font = new System.Drawing.Font("Open 24 Display St", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpeedVal.ForeColor = System.Drawing.Color.Lime;
            this.SpeedVal.Location = new System.Drawing.Point(535, 476);
            this.SpeedVal.Name = "SpeedVal";
            this.SpeedVal.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.SpeedVal.Size = new System.Drawing.Size(100, 42);
            this.SpeedVal.TabIndex = 17;
            this.SpeedVal.TabStop = false;
            this.SpeedVal.Text = "";
            // 
            // Graph
            // 
            this.Graph.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Graph.BackgroundImage")));
            this.Graph.Location = new System.Drawing.Point(50, 420);
            this.Graph.Name = "Graph";
            this.Graph.Size = new System.Drawing.Size(442, 259);
            this.Graph.TabIndex = 20;
            this.Graph.TabStop = false;
            this.Graph.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SystemController_MouseClick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // LockFan
            // 
            this.LockFan.BackColor = System.Drawing.SystemColors.Desktop;
            this.LockFan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LockFan.Cursor = System.Windows.Forms.Cursors.Default;
            this.LockFan.ForeColor = System.Drawing.SystemColors.Window;
            this.LockFan.Location = new System.Drawing.Point(123, 695);
            this.LockFan.Name = "LockFan";
            this.LockFan.ReadOnly = true;
            this.LockFan.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.LockFan.Size = new System.Drawing.Size(81, 21);
            this.LockFan.TabIndex = 23;
            this.LockFan.TabStop = false;
            this.LockFan.Text = "Lock";
            this.LockFan.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LockFan_MouseDown);
            // 
            // LockFanSelect
            // 
            this.LockFanSelect.AutoSize = true;
            this.LockFanSelect.Checked = true;
            this.LockFanSelect.CheckState = System.Windows.Forms.CheckState.Checked;
            this.LockFanSelect.Location = new System.Drawing.Point(103, 694);
            this.LockFanSelect.Name = "LockFanSelect";
            this.LockFanSelect.Size = new System.Drawing.Size(80, 17);
            this.LockFanSelect.TabIndex = 22;
            this.LockFanSelect.Text = "checkBox1";
            this.LockFanSelect.UseVisualStyleBackColor = true;
            this.LockFanSelect.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_1);
            // 
            // Apply
            // 
            this.Apply.Location = new System.Drawing.Point(194, 692);
            this.Apply.Name = "Apply";
            this.Apply.Size = new System.Drawing.Size(75, 21);
            this.Apply.TabIndex = 25;
            this.Apply.TabStop = false;
            this.Apply.Text = "Apply";
            this.Apply.UseVisualStyleBackColor = true;
            this.Apply.Click += new System.EventHandler(this.Apply_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(307, 693);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 21);
            this.Cancel.TabIndex = 26;
            this.Cancel.TabStop = false;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(417, 693);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(75, 21);
            this.Reset.TabIndex = 27;
            this.Reset.TabStop = false;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // Leds
            // 
            this.Leds.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Leds.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Leds.Cursor = System.Windows.Forms.Cursors.Default;
            this.Leds.Font = new System.Drawing.Font("Open 24 Display St", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Leds.ForeColor = System.Drawing.Color.Blue;
            this.Leds.Location = new System.Drawing.Point(50, 766);
            this.Leds.Name = "Leds";
            this.Leds.ReadOnly = true;
            this.Leds.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.Leds.Size = new System.Drawing.Size(585, 83);
            this.Leds.TabIndex = 28;
            this.Leds.TabStop = false;
            this.Leds.Text = "LED Control";
            this.Leds.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Leds_MouseDown);
            // 
            // na
            // 
            this.na.AutoSize = true;
            this.na.ForeColor = System.Drawing.Color.Blue;
            this.na.Location = new System.Drawing.Point(10, 25);
            this.na.Name = "na";
            this.na.Size = new System.Drawing.Size(76, 28);
            this.na.TabIndex = 29;
            this.na.Text = "Static";
            this.na.UseVisualStyleBackColor = true;
            this.na.CheckedChanged += new System.EventHandler(this.na_CheckedChanged);
            // 
            // fl
            // 
            this.fl.AutoSize = true;
            this.fl.ForeColor = System.Drawing.Color.Blue;
            this.fl.Location = new System.Drawing.Point(10, 48);
            this.fl.Name = "fl";
            this.fl.Size = new System.Drawing.Size(73, 28);
            this.fl.TabIndex = 30;
            this.fl.Text = "Flash";
            this.fl.UseVisualStyleBackColor = true;
            this.fl.CheckedChanged += new System.EventHandler(this.fl_CheckedChanged);
            // 
            // rf
            // 
            this.rf.AutoSize = true;
            this.rf.ForeColor = System.Drawing.Color.Blue;
            this.rf.Location = new System.Drawing.Point(10, 71);
            this.rf.Name = "rf";
            this.rf.Size = new System.Drawing.Size(143, 28);
            this.rf.TabIndex = 31;
            this.rf.Text = "Random flash";
            this.rf.UseVisualStyleBackColor = true;
            this.rf.CheckedChanged += new System.EventHandler(this.rf_CheckedChanged);
            // 
            // fd
            // 
            this.fd.AutoSize = true;
            this.fd.ForeColor = System.Drawing.Color.Blue;
            this.fd.Location = new System.Drawing.Point(10, 94);
            this.fd.Name = "fd";
            this.fd.Size = new System.Drawing.Size(64, 28);
            this.fd.TabIndex = 32;
            this.fd.Text = "Fade";
            this.fd.UseVisualStyleBackColor = true;
            this.fd.CheckedChanged += new System.EventHandler(this.fd_CheckedChanged);
            // 
            // tmp
            // 
            this.tmp.AutoSize = true;
            this.tmp.ForeColor = System.Drawing.Color.Blue;
            this.tmp.Location = new System.Drawing.Point(10, 117);
            this.tmp.Name = "tmp";
            this.tmp.Size = new System.Drawing.Size(134, 28);
            this.tmp.TabIndex = 33;
            this.tmp.Text = "Temperature";
            this.tmp.UseVisualStyleBackColor = true;
            this.tmp.CheckedChanged += new System.EventHandler(this.tmp_CheckedChanged);
            // 
            // LEDMode
            // 
            this.LEDMode.BackColor = System.Drawing.SystemColors.InfoText;
            this.LEDMode.Controls.Add(this.na);
            this.LEDMode.Controls.Add(this.tmp);
            this.LEDMode.Controls.Add(this.fl);
            this.LEDMode.Controls.Add(this.fd);
            this.LEDMode.Controls.Add(this.rf);
            this.LEDMode.Font = new System.Drawing.Font("Open 24 Display St", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LEDMode.ForeColor = System.Drawing.Color.Blue;
            this.LEDMode.Location = new System.Drawing.Point(51, 865);
            this.LEDMode.Name = "LEDMode";
            this.LEDMode.Size = new System.Drawing.Size(155, 143);
            this.LEDMode.TabIndex = 34;
            this.LEDMode.TabStop = false;
            this.LEDMode.Text = "Mode selection";
            // 
            // Timing
            // 
            this.Timing.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Timing.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Timing.Cursor = System.Windows.Forms.Cursors.Default;
            this.Timing.Font = new System.Drawing.Font("Open 24 Display St", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Timing.ForeColor = System.Drawing.Color.Blue;
            this.Timing.Location = new System.Drawing.Point(227, 865);
            this.Timing.Name = "Timing";
            this.Timing.ReadOnly = true;
            this.Timing.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.Timing.Size = new System.Drawing.Size(100, 42);
            this.Timing.TabIndex = 35;
            this.Timing.TabStop = false;
            this.Timing.Text = "Interval";
            this.Timing.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Timing_MouseDown);
            // 
            // Interval
            // 
            this.Interval.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Interval.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Interval.Font = new System.Drawing.Font("Open 24 Display St", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Interval.ForeColor = System.Drawing.Color.Blue;
            this.Interval.Location = new System.Drawing.Point(227, 892);
            this.Interval.Name = "Interval";
            this.Interval.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.Interval.Size = new System.Drawing.Size(100, 34);
            this.Interval.TabIndex = 36;
            this.Interval.TabStop = false;
            this.Interval.Text = "";
            this.Interval.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Interval_KeyDown);
            this.Interval.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Interval_MouseDown);
            // 
            // RGB
            // 
            this.RGB.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.RGB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RGB.Font = new System.Drawing.Font("Open 24 Display St", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RGB.ForeColor = System.Drawing.Color.Blue;
            this.RGB.Location = new System.Drawing.Point(349, 865);
            this.RGB.Name = "RGB";
            this.RGB.ReadOnly = true;
            this.RGB.Size = new System.Drawing.Size(100, 42);
            this.RGB.TabIndex = 37;
            this.RGB.TabStop = false;
            this.RGB.Text = "RGB Color";
            this.RGB.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RGB_MouseDown);
            // 
            // R
            // 
            this.R.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.R.Font = new System.Drawing.Font("Open 24 Display St", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.R.ForeColor = System.Drawing.Color.Blue;
            this.R.Location = new System.Drawing.Point(349, 892);
            this.R.Multiline = false;
            this.R.Name = "R";
            this.R.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.R.Size = new System.Drawing.Size(100, 34);
            this.R.TabIndex = 38;
            this.R.TabStop = false;
            this.R.Text = "";
            this.R.KeyDown += new System.Windows.Forms.KeyEventHandler(this.R_KeyDown);
            this.R.MouseDown += new System.Windows.Forms.MouseEventHandler(this.R_MouseDown);
            // 
            // G
            // 
            this.G.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.G.Font = new System.Drawing.Font("Open 24 Display St", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.G.ForeColor = System.Drawing.Color.Blue;
            this.G.Location = new System.Drawing.Point(349, 930);
            this.G.Multiline = false;
            this.G.Name = "G";
            this.G.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.G.Size = new System.Drawing.Size(100, 34);
            this.G.TabIndex = 39;
            this.G.TabStop = false;
            this.G.Text = "";
            this.G.KeyDown += new System.Windows.Forms.KeyEventHandler(this.G_KeyDown);
            this.G.MouseDown += new System.Windows.Forms.MouseEventHandler(this.G_MouseDown);
            // 
            // B
            // 
            this.B.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.B.Font = new System.Drawing.Font("Open 24 Display St", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B.ForeColor = System.Drawing.Color.Blue;
            this.B.Location = new System.Drawing.Point(349, 968);
            this.B.Multiline = false;
            this.B.Name = "B";
            this.B.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.B.Size = new System.Drawing.Size(100, 34);
            this.B.TabIndex = 40;
            this.B.TabStop = false;
            this.B.Text = "";
            this.B.KeyDown += new System.Windows.Forms.KeyEventHandler(this.B_KeyDown);
            this.B.MouseDown += new System.Windows.Forms.MouseEventHandler(this.B_MouseDown);
            // 
            // PreviewRGB
            // 
            this.PreviewRGB.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PreviewRGB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PreviewRGB.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.PreviewRGB.Location = new System.Drawing.Point(476, 959);
            this.PreviewRGB.MaxLength = 0;
            this.PreviewRGB.Name = "PreviewRGB";
            this.PreviewRGB.ReadOnly = true;
            this.PreviewRGB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PreviewRGB.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.PreviewRGB.Size = new System.Drawing.Size(159, 66);
            this.PreviewRGB.TabIndex = 41;
            this.PreviewRGB.TabStop = false;
            this.PreviewRGB.Text = "";
            this.PreviewRGB.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PreviewRGB_MouseDown);
            // 
            // PreviewInterval
            // 
            this.PreviewInterval.BackColor = System.Drawing.Color.Black;
            this.PreviewInterval.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PreviewInterval.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.PreviewInterval.Location = new System.Drawing.Point(227, 941);
            this.PreviewInterval.MaxLength = 0;
            this.PreviewInterval.Name = "PreviewInterval";
            this.PreviewInterval.ReadOnly = true;
            this.PreviewInterval.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PreviewInterval.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.PreviewInterval.Size = new System.Drawing.Size(100, 55);
            this.PreviewInterval.TabIndex = 42;
            this.PreviewInterval.TabStop = false;
            this.PreviewInterval.Text = "";
            this.PreviewInterval.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PreviewInterval_MouseDown);
            // 
            // timer3
            // 
            this.timer3.Enabled = true;
            this.timer3.Interval = 1000;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // LEDPreviewSelect
            // 
            this.LEDPreviewSelect.AutoSize = true;
            this.LEDPreviewSelect.Location = new System.Drawing.Point(63, 1014);
            this.LEDPreviewSelect.Name = "LEDPreviewSelect";
            this.LEDPreviewSelect.Size = new System.Drawing.Size(80, 17);
            this.LEDPreviewSelect.TabIndex = 43;
            this.LEDPreviewSelect.Text = "checkBox1";
            this.LEDPreviewSelect.UseVisualStyleBackColor = true;
            this.LEDPreviewSelect.CheckedChanged += new System.EventHandler(this.LEDPreviewSelect_CheckedChanged);
            // 
            // Preview
            // 
            this.Preview.BackColor = System.Drawing.SystemColors.ControlText;
            this.Preview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Preview.Cursor = System.Windows.Forms.Cursors.Default;
            this.Preview.ForeColor = System.Drawing.SystemColors.Window;
            this.Preview.Location = new System.Drawing.Point(83, 1015);
            this.Preview.Name = "Preview";
            this.Preview.ReadOnly = true;
            this.Preview.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.Preview.Size = new System.Drawing.Size(51, 18);
            this.Preview.TabIndex = 44;
            this.Preview.TabStop = false;
            this.Preview.Text = "Preview";
            this.Preview.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Preview_MouseDown);
            // 
            // LockLed
            // 
            this.LockLed.BackColor = System.Drawing.SystemColors.ControlText;
            this.LockLed.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LockLed.Cursor = System.Windows.Forms.Cursors.Default;
            this.LockLed.ForeColor = System.Drawing.SystemColors.Window;
            this.LockLed.Location = new System.Drawing.Point(166, 1015);
            this.LockLed.Name = "LockLed";
            this.LockLed.ReadOnly = true;
            this.LockLed.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.LockLed.Size = new System.Drawing.Size(51, 18);
            this.LockLed.TabIndex = 46;
            this.LockLed.TabStop = false;
            this.LockLed.Text = "Lock";
            this.LockLed.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LockLed_MouseDown);
            // 
            // LockLEDSelect
            // 
            this.LockLEDSelect.AutoSize = true;
            this.LockLEDSelect.Location = new System.Drawing.Point(148, 1014);
            this.LockLEDSelect.Name = "LockLEDSelect";
            this.LockLEDSelect.Size = new System.Drawing.Size(80, 17);
            this.LockLEDSelect.TabIndex = 45;
            this.LockLEDSelect.Text = "checkBox2";
            this.LockLEDSelect.UseVisualStyleBackColor = true;
            this.LockLEDSelect.CheckedChanged += new System.EventHandler(this.LockLEDSelect_CheckedChanged);
            // 
            // timer4
            // 
            this.timer4.Enabled = true;
            this.timer4.Interval = 500;
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "System controller";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(104, 48);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(103, 22);
            this.toolStripMenuItem1.Text = "Show";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(103, 22);
            this.toolStripMenuItem2.Text = "Exit";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // ColorMode
            // 
            this.ColorMode.BackColor = System.Drawing.SystemColors.InfoText;
            this.ColorMode.Controls.Add(this.Override);
            this.ColorMode.Controls.Add(this.RGBTemp);
            this.ColorMode.Controls.Add(this.RGBRandom);
            this.ColorMode.Font = new System.Drawing.Font("Open 24 Display St", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColorMode.ForeColor = System.Drawing.Color.Blue;
            this.ColorMode.Location = new System.Drawing.Point(476, 855);
            this.ColorMode.Name = "ColorMode";
            this.ColorMode.Size = new System.Drawing.Size(159, 98);
            this.ColorMode.TabIndex = 35;
            this.ColorMode.TabStop = false;
            // 
            // Override
            // 
            this.Override.AutoSize = true;
            this.Override.Location = new System.Drawing.Point(10, 14);
            this.Override.Name = "Override";
            this.Override.Size = new System.Drawing.Size(131, 28);
            this.Override.TabIndex = 31;
            this.Override.Text = "RGB override";
            this.Override.UseVisualStyleBackColor = true;
            this.Override.CheckedChanged += new System.EventHandler(this.Override_CheckedChanged);
            // 
            // RGBTemp
            // 
            this.RGBTemp.AutoSize = true;
            this.RGBTemp.Enabled = false;
            this.RGBTemp.ForeColor = System.Drawing.Color.Blue;
            this.RGBTemp.Location = new System.Drawing.Point(10, 40);
            this.RGBTemp.Name = "RGBTemp";
            this.RGBTemp.Size = new System.Drawing.Size(134, 28);
            this.RGBTemp.TabIndex = 29;
            this.RGBTemp.Text = "Temperature";
            this.RGBTemp.UseVisualStyleBackColor = true;
            this.RGBTemp.CheckedChanged += new System.EventHandler(this.RGBTemp_CheckedChanged);
            // 
            // RGBRandom
            // 
            this.RGBRandom.AutoSize = true;
            this.RGBRandom.Enabled = false;
            this.RGBRandom.ForeColor = System.Drawing.Color.Blue;
            this.RGBRandom.Location = new System.Drawing.Point(10, 65);
            this.RGBRandom.Name = "RGBRandom";
            this.RGBRandom.Size = new System.Drawing.Size(89, 28);
            this.RGBRandom.TabIndex = 30;
            this.RGBRandom.Text = "Random";
            this.RGBRandom.UseVisualStyleBackColor = true;
            this.RGBRandom.CheckedChanged += new System.EventHandler(this.RGBRandom_CheckedChanged);
            // 
            // timer5
            // 
            this.timer5.Enabled = true;
            this.timer5.Interval = 1000;
            this.timer5.Tick += new System.EventHandler(this.timer5_Tick);
            // 
            // SystemController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(704, 1041);
            this.Controls.Add(this.ColorMode);
            this.Controls.Add(this.LockLed);
            this.Controls.Add(this.LockLEDSelect);
            this.Controls.Add(this.Preview);
            this.Controls.Add(this.LEDPreviewSelect);
            this.Controls.Add(this.PreviewInterval);
            this.Controls.Add(this.PreviewRGB);
            this.Controls.Add(this.B);
            this.Controls.Add(this.G);
            this.Controls.Add(this.R);
            this.Controls.Add(this.RGB);
            this.Controls.Add(this.Interval);
            this.Controls.Add(this.Timing);
            this.Controls.Add(this.LEDMode);
            this.Controls.Add(this.Leds);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Apply);
            this.Controls.Add(this.LockFan);
            this.Controls.Add(this.LockFanSelect);
            this.Controls.Add(this.Graph);
            this.Controls.Add(this.SpeedVal);
            this.Controls.Add(this.RPMVal);
            this.Controls.Add(this.Speed);
            this.Controls.Add(this.RPM);
            this.Controls.Add(this.Fans);
            this.Controls.Add(this.CoreTemps);
            this.Controls.Add(this.Cores);
            this.Controls.Add(this.Temps);
            this.Controls.Add(this.AvgTemp);
            this.Controls.Add(this.GPU2Temp);
            this.Controls.Add(this.GPU1Temp);
            this.Controls.Add(this.CPUTemp);
            this.Controls.Add(this.Weighted);
            this.Controls.Add(this.WeightedSelect);
            this.Controls.Add(this.Average);
            this.Controls.Add(this.GPU2);
            this.Controls.Add(this.GPU1);
            this.Controls.Add(this.CPU);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(720, 1080);
            this.MinimumSize = new System.Drawing.Size(720, 1038);
            this.Name = "SystemController";
            this.Text = "System controller";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SystemController_MouseClick);
            this.Resize += new System.EventHandler(this.SystemController_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.Graph)).EndInit();
            this.LEDMode.ResumeLayout(false);
            this.LEDMode.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ColorMode.ResumeLayout(false);
            this.ColorMode.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.RichTextBox CPU;
        private System.Windows.Forms.RichTextBox GPU1;
        private System.Windows.Forms.RichTextBox GPU2;
        private System.Windows.Forms.RichTextBox Average;
        private System.Windows.Forms.CheckBox WeightedSelect;
        private System.Windows.Forms.RichTextBox Weighted;
        private System.Windows.Forms.RichTextBox CPUTemp;
        private System.Windows.Forms.RichTextBox GPU1Temp;
        private System.Windows.Forms.RichTextBox GPU2Temp;
        private System.Windows.Forms.RichTextBox AvgTemp;
        private System.Windows.Forms.RichTextBox Temps;
        private System.Windows.Forms.RichTextBox Cores;
        private System.Windows.Forms.RichTextBox CoreTemps;
        private System.Windows.Forms.RichTextBox Fans;
        private System.Windows.Forms.RichTextBox RPMVal;
        private System.Windows.Forms.RichTextBox RPM;
        private System.Windows.Forms.RichTextBox Speed;
        private System.Windows.Forms.RichTextBox SpeedVal;
        private System.Windows.Forms.PictureBox Graph;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.RichTextBox LockFan;
        private System.Windows.Forms.CheckBox LockFanSelect;
        private System.Windows.Forms.Button Apply;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.RichTextBox Leds;
        private System.Windows.Forms.RadioButton na;
        private System.Windows.Forms.RadioButton fl;
        private System.Windows.Forms.RadioButton rf;
        private System.Windows.Forms.RadioButton fd;
        private System.Windows.Forms.RadioButton tmp;
        private System.Windows.Forms.GroupBox LEDMode;
        private System.Windows.Forms.RichTextBox Timing;
        private System.Windows.Forms.RichTextBox Interval;
        private System.Windows.Forms.RichTextBox RGB;
        private System.Windows.Forms.RichTextBox R;
        private System.Windows.Forms.RichTextBox G;
        private System.Windows.Forms.RichTextBox B;
        private System.Windows.Forms.RichTextBox PreviewRGB;
        private System.Windows.Forms.RichTextBox PreviewInterval;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.CheckBox LEDPreviewSelect;
        private System.Windows.Forms.RichTextBox Preview;
        private System.Windows.Forms.RichTextBox LockLed;
        private System.Windows.Forms.CheckBox LockLEDSelect;

        public void ModifyComponent(System.Windows.Forms.RichTextBox textbox, System.Drawing.Color color, System.Windows.Forms.HorizontalAlignment alignment, System.Drawing.Color backcolor)
        {
            textbox.BackColor = backcolor;
            textbox.Select(0, 100);
            textbox.SelectionColor = color;
            textbox.SelectionAlignment = alignment;
        }

        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.GroupBox ColorMode;
        private System.Windows.Forms.CheckBox Override;
        private System.Windows.Forms.RadioButton RGBTemp;
        private System.Windows.Forms.RadioButton RGBRandom;
        private System.Windows.Forms.Timer timer5;
    }
}

