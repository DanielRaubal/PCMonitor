namespace WindowsFormsApp1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.PictureBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.MonitorSwap = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.RamUsageCircularProgressBar = new CircularProgressBar.CircularProgressBar();
            this.DiskUtilCircularProgressBar = new CircularProgressBar.CircularProgressBar();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.GpuUtilCircularProgressBar = new CircularProgressBar.CircularProgressBar();
            this.GpuTempCircularProgressBar = new CircularProgressBar.CircularProgressBar();
            this.GpuFanCircularProgressBar = new CircularProgressBar.CircularProgressBar();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.CpuUtilCircularProgressBar = new CircularProgressBar.CircularProgressBar();
            this.CpuTempCircularProgressBar = new CircularProgressBar.CircularProgressBar();
            this.GpuSpeedCircularProgressBar = new CircularProgressBar.CircularProgressBar();
            this.UtilTimeTextBox = new System.Windows.Forms.TextBox();
            this.CpuTitle = new System.Windows.Forms.TextBox();
            this.GpuTitle = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.RamTotalTextBox = new System.Windows.Forms.TextBox();
            this.CDriveSpaceTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MonitorSwap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(353, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(155)))), ((int)(((byte)(180)))));
            this.Exit.Image = global::PCMonitor.Properties.Resources.Exit;
            this.Exit.Location = new System.Drawing.Point(340, 8);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(16, 16);
            this.Exit.TabIndex = 4;
            this.Exit.TabStop = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(203)))), ((int)(((byte)(220)))));
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Edit Undo BRK", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(105)))), ((int)(((byte)(136)))));
            this.textBox2.Location = new System.Drawing.Point(16, 227);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(340, 17);
            this.textBox2.TabIndex = 6;
            this.textBox2.Text = "v 0.01";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MonitorSwap
            // 
            this.MonitorSwap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(155)))), ((int)(((byte)(180)))));
            this.MonitorSwap.Image = global::PCMonitor.Properties.Resources.Monitor;
            this.MonitorSwap.Location = new System.Drawing.Point(17, 8);
            this.MonitorSwap.Name = "MonitorSwap";
            this.MonitorSwap.Size = new System.Drawing.Size(16, 16);
            this.MonitorSwap.TabIndex = 7;
            this.MonitorSwap.TabStop = false;
            this.MonitorSwap.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 250;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(23, 145);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 74);
            this.pictureBox1.TabIndex = 48;
            this.pictureBox1.TabStop = false;
            // 
            // RamUsageCircularProgressBar
            // 
            this.RamUsageCircularProgressBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.RamUsageCircularProgressBar.AnimationSpeed = 500;
            this.RamUsageCircularProgressBar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.RamUsageCircularProgressBar.Font = new System.Drawing.Font("Edit Undo BRK", 11F);
            this.RamUsageCircularProgressBar.ForeColor = System.Drawing.Color.Navy;
            this.RamUsageCircularProgressBar.InnerColor = System.Drawing.Color.RoyalBlue;
            this.RamUsageCircularProgressBar.InnerMargin = 2;
            this.RamUsageCircularProgressBar.InnerWidth = -1;
            this.RamUsageCircularProgressBar.Location = new System.Drawing.Point(27, 166);
            this.RamUsageCircularProgressBar.MarqueeAnimationSpeed = 2000;
            this.RamUsageCircularProgressBar.Name = "RamUsageCircularProgressBar";
            this.RamUsageCircularProgressBar.OuterColor = System.Drawing.Color.LightSkyBlue;
            this.RamUsageCircularProgressBar.OuterMargin = -25;
            this.RamUsageCircularProgressBar.OuterWidth = 26;
            this.RamUsageCircularProgressBar.ProgressColor = System.Drawing.Color.DodgerBlue;
            this.RamUsageCircularProgressBar.ProgressWidth = 25;
            this.RamUsageCircularProgressBar.SecondaryFont = new System.Drawing.Font("Edit Undo BRK", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RamUsageCircularProgressBar.Size = new System.Drawing.Size(49, 49);
            this.RamUsageCircularProgressBar.StartAngle = 270;
            this.RamUsageCircularProgressBar.SubscriptColor = System.Drawing.Color.White;
            this.RamUsageCircularProgressBar.SubscriptMargin = new System.Windows.Forms.Padding(10, -15, 0, 0);
            this.RamUsageCircularProgressBar.SubscriptText = "";
            this.RamUsageCircularProgressBar.SuperscriptColor = System.Drawing.Color.White;
            this.RamUsageCircularProgressBar.SuperscriptMargin = new System.Windows.Forms.Padding(-18, 30, 0, 0);
            this.RamUsageCircularProgressBar.SuperscriptText = "%";
            this.RamUsageCircularProgressBar.TabIndex = 49;
            this.RamUsageCircularProgressBar.Text = "100^";
            this.RamUsageCircularProgressBar.TextMargin = new System.Windows.Forms.Padding(5, -2, 0, 0);
            this.RamUsageCircularProgressBar.Value = 68;
            // 
            // DiskUtilCircularProgressBar
            // 
            this.DiskUtilCircularProgressBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.DiskUtilCircularProgressBar.AnimationSpeed = 500;
            this.DiskUtilCircularProgressBar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.DiskUtilCircularProgressBar.Font = new System.Drawing.Font("Edit Undo BRK", 11F);
            this.DiskUtilCircularProgressBar.ForeColor = System.Drawing.Color.Navy;
            this.DiskUtilCircularProgressBar.InnerColor = System.Drawing.Color.RoyalBlue;
            this.DiskUtilCircularProgressBar.InnerMargin = 2;
            this.DiskUtilCircularProgressBar.InnerWidth = -1;
            this.DiskUtilCircularProgressBar.Location = new System.Drawing.Point(130, 166);
            this.DiskUtilCircularProgressBar.MarqueeAnimationSpeed = 2000;
            this.DiskUtilCircularProgressBar.Name = "DiskUtilCircularProgressBar";
            this.DiskUtilCircularProgressBar.OuterColor = System.Drawing.Color.LightSkyBlue;
            this.DiskUtilCircularProgressBar.OuterMargin = -25;
            this.DiskUtilCircularProgressBar.OuterWidth = 26;
            this.DiskUtilCircularProgressBar.ProgressColor = System.Drawing.Color.DodgerBlue;
            this.DiskUtilCircularProgressBar.ProgressWidth = 25;
            this.DiskUtilCircularProgressBar.SecondaryFont = new System.Drawing.Font("Edit Undo BRK", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiskUtilCircularProgressBar.Size = new System.Drawing.Size(49, 49);
            this.DiskUtilCircularProgressBar.StartAngle = 270;
            this.DiskUtilCircularProgressBar.SubscriptColor = System.Drawing.Color.White;
            this.DiskUtilCircularProgressBar.SubscriptMargin = new System.Windows.Forms.Padding(10, -15, 0, 0);
            this.DiskUtilCircularProgressBar.SubscriptText = "";
            this.DiskUtilCircularProgressBar.SuperscriptColor = System.Drawing.Color.White;
            this.DiskUtilCircularProgressBar.SuperscriptMargin = new System.Windows.Forms.Padding(-18, 30, 0, 0);
            this.DiskUtilCircularProgressBar.SuperscriptText = "%";
            this.DiskUtilCircularProgressBar.TabIndex = 55;
            this.DiskUtilCircularProgressBar.Text = "100^";
            this.DiskUtilCircularProgressBar.TextMargin = new System.Windows.Forms.Padding(5, -2, 0, 0);
            this.DiskUtilCircularProgressBar.Value = 68;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox2.Location = new System.Drawing.Point(187, 37);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(162, 182);
            this.pictureBox2.TabIndex = 57;
            this.pictureBox2.TabStop = false;
            // 
            // GpuUtilCircularProgressBar
            // 
            this.GpuUtilCircularProgressBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.GpuUtilCircularProgressBar.AnimationSpeed = 100;
            this.GpuUtilCircularProgressBar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.GpuUtilCircularProgressBar.Font = new System.Drawing.Font("Edit Undo BRK", 15F, System.Drawing.FontStyle.Bold);
            this.GpuUtilCircularProgressBar.ForeColor = System.Drawing.Color.Navy;
            this.GpuUtilCircularProgressBar.InnerColor = System.Drawing.Color.RoyalBlue;
            this.GpuUtilCircularProgressBar.InnerMargin = 2;
            this.GpuUtilCircularProgressBar.InnerWidth = -1;
            this.GpuUtilCircularProgressBar.Location = new System.Drawing.Point(193, 69);
            this.GpuUtilCircularProgressBar.MarqueeAnimationSpeed = 2000;
            this.GpuUtilCircularProgressBar.Name = "GpuUtilCircularProgressBar";
            this.GpuUtilCircularProgressBar.OuterColor = System.Drawing.Color.LightSkyBlue;
            this.GpuUtilCircularProgressBar.OuterMargin = -25;
            this.GpuUtilCircularProgressBar.OuterWidth = 26;
            this.GpuUtilCircularProgressBar.ProgressColor = System.Drawing.Color.RoyalBlue;
            this.GpuUtilCircularProgressBar.ProgressWidth = 25;
            this.GpuUtilCircularProgressBar.SecondaryFont = new System.Drawing.Font("Edit Undo BRK", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GpuUtilCircularProgressBar.Size = new System.Drawing.Size(74, 74);
            this.GpuUtilCircularProgressBar.StartAngle = 270;
            this.GpuUtilCircularProgressBar.SubscriptColor = System.Drawing.Color.White;
            this.GpuUtilCircularProgressBar.SubscriptMargin = new System.Windows.Forms.Padding(10, -15, 0, 0);
            this.GpuUtilCircularProgressBar.SubscriptText = "";
            this.GpuUtilCircularProgressBar.SuperscriptColor = System.Drawing.Color.White;
            this.GpuUtilCircularProgressBar.SuperscriptMargin = new System.Windows.Forms.Padding(-18, 30, 0, 0);
            this.GpuUtilCircularProgressBar.SuperscriptText = "%";
            this.GpuUtilCircularProgressBar.TabIndex = 59;
            this.GpuUtilCircularProgressBar.Text = "100";
            this.GpuUtilCircularProgressBar.TextMargin = new System.Windows.Forms.Padding(5, -2, 0, 0);
            this.GpuUtilCircularProgressBar.Value = 68;
            // 
            // GpuTempCircularProgressBar
            // 
            this.GpuTempCircularProgressBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.GpuTempCircularProgressBar.AnimationSpeed = 100;
            this.GpuTempCircularProgressBar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.GpuTempCircularProgressBar.Font = new System.Drawing.Font("Edit Undo BRK", 15F, System.Drawing.FontStyle.Bold);
            this.GpuTempCircularProgressBar.ForeColor = System.Drawing.Color.Navy;
            this.GpuTempCircularProgressBar.InnerColor = System.Drawing.Color.RoyalBlue;
            this.GpuTempCircularProgressBar.InnerMargin = 2;
            this.GpuTempCircularProgressBar.InnerWidth = -1;
            this.GpuTempCircularProgressBar.Location = new System.Drawing.Point(269, 69);
            this.GpuTempCircularProgressBar.MarqueeAnimationSpeed = 2000;
            this.GpuTempCircularProgressBar.Maximum = 150;
            this.GpuTempCircularProgressBar.Name = "GpuTempCircularProgressBar";
            this.GpuTempCircularProgressBar.OuterColor = System.Drawing.Color.LightSkyBlue;
            this.GpuTempCircularProgressBar.OuterMargin = -25;
            this.GpuTempCircularProgressBar.OuterWidth = 26;
            this.GpuTempCircularProgressBar.ProgressColor = System.Drawing.Color.CornflowerBlue;
            this.GpuTempCircularProgressBar.ProgressWidth = 25;
            this.GpuTempCircularProgressBar.SecondaryFont = new System.Drawing.Font("Edit Undo BRK", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GpuTempCircularProgressBar.Size = new System.Drawing.Size(74, 74);
            this.GpuTempCircularProgressBar.StartAngle = -91;
            this.GpuTempCircularProgressBar.SubscriptColor = System.Drawing.Color.White;
            this.GpuTempCircularProgressBar.SubscriptMargin = new System.Windows.Forms.Padding(10, -15, 0, 0);
            this.GpuTempCircularProgressBar.SubscriptText = "";
            this.GpuTempCircularProgressBar.SuperscriptColor = System.Drawing.Color.White;
            this.GpuTempCircularProgressBar.SuperscriptMargin = new System.Windows.Forms.Padding(-20, 30, 0, 0);
            this.GpuTempCircularProgressBar.SuperscriptText = "°C";
            this.GpuTempCircularProgressBar.TabIndex = 58;
            this.GpuTempCircularProgressBar.Text = "10 ^";
            this.GpuTempCircularProgressBar.TextMargin = new System.Windows.Forms.Padding(5, -2, 0, 0);
            this.GpuTempCircularProgressBar.Value = 68;
            // 
            // GpuFanCircularProgressBar
            // 
            this.GpuFanCircularProgressBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.GpuFanCircularProgressBar.AnimationSpeed = 100;
            this.GpuFanCircularProgressBar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.GpuFanCircularProgressBar.Font = new System.Drawing.Font("Edit Undo BRK", 15F, System.Drawing.FontStyle.Bold);
            this.GpuFanCircularProgressBar.ForeColor = System.Drawing.Color.Navy;
            this.GpuFanCircularProgressBar.InnerColor = System.Drawing.Color.RoyalBlue;
            this.GpuFanCircularProgressBar.InnerMargin = 2;
            this.GpuFanCircularProgressBar.InnerWidth = -1;
            this.GpuFanCircularProgressBar.Location = new System.Drawing.Point(269, 143);
            this.GpuFanCircularProgressBar.MarqueeAnimationSpeed = 2000;
            this.GpuFanCircularProgressBar.Maximum = 10000;
            this.GpuFanCircularProgressBar.Name = "GpuFanCircularProgressBar";
            this.GpuFanCircularProgressBar.OuterColor = System.Drawing.Color.LightSkyBlue;
            this.GpuFanCircularProgressBar.OuterMargin = -25;
            this.GpuFanCircularProgressBar.OuterWidth = 26;
            this.GpuFanCircularProgressBar.ProgressColor = System.Drawing.Color.DodgerBlue;
            this.GpuFanCircularProgressBar.ProgressWidth = 25;
            this.GpuFanCircularProgressBar.SecondaryFont = new System.Drawing.Font("Edit Undo BRK", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GpuFanCircularProgressBar.Size = new System.Drawing.Size(74, 74);
            this.GpuFanCircularProgressBar.StartAngle = 270;
            this.GpuFanCircularProgressBar.SubscriptColor = System.Drawing.Color.White;
            this.GpuFanCircularProgressBar.SubscriptMargin = new System.Windows.Forms.Padding(10, -15, 0, 0);
            this.GpuFanCircularProgressBar.SubscriptText = "";
            this.GpuFanCircularProgressBar.SuperscriptColor = System.Drawing.Color.White;
            this.GpuFanCircularProgressBar.SuperscriptMargin = new System.Windows.Forms.Padding(-18, 30, 0, 0);
            this.GpuFanCircularProgressBar.SuperscriptText = "RPM";
            this.GpuFanCircularProgressBar.TabIndex = 61;
            this.GpuFanCircularProgressBar.Text = "10000";
            this.GpuFanCircularProgressBar.TextMargin = new System.Windows.Forms.Padding(5, -2, 0, 0);
            this.GpuFanCircularProgressBar.Value = 68;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox3.Location = new System.Drawing.Point(23, 37);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(160, 107);
            this.pictureBox3.TabIndex = 62;
            this.pictureBox3.TabStop = false;
            // 
            // CpuUtilCircularProgressBar
            // 
            this.CpuUtilCircularProgressBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.CpuUtilCircularProgressBar.AnimationSpeed = 100;
            this.CpuUtilCircularProgressBar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CpuUtilCircularProgressBar.Font = new System.Drawing.Font("Edit Undo BRK", 15F, System.Drawing.FontStyle.Bold);
            this.CpuUtilCircularProgressBar.ForeColor = System.Drawing.Color.Navy;
            this.CpuUtilCircularProgressBar.InnerColor = System.Drawing.Color.RoyalBlue;
            this.CpuUtilCircularProgressBar.InnerMargin = 2;
            this.CpuUtilCircularProgressBar.InnerWidth = -1;
            this.CpuUtilCircularProgressBar.Location = new System.Drawing.Point(30, 70);
            this.CpuUtilCircularProgressBar.MarqueeAnimationSpeed = 2000;
            this.CpuUtilCircularProgressBar.Name = "CpuUtilCircularProgressBar";
            this.CpuUtilCircularProgressBar.OuterColor = System.Drawing.Color.LightSkyBlue;
            this.CpuUtilCircularProgressBar.OuterMargin = -25;
            this.CpuUtilCircularProgressBar.OuterWidth = 26;
            this.CpuUtilCircularProgressBar.ProgressColor = System.Drawing.Color.RoyalBlue;
            this.CpuUtilCircularProgressBar.ProgressWidth = 25;
            this.CpuUtilCircularProgressBar.SecondaryFont = new System.Drawing.Font("Edit Undo BRK", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CpuUtilCircularProgressBar.Size = new System.Drawing.Size(70, 70);
            this.CpuUtilCircularProgressBar.StartAngle = 270;
            this.CpuUtilCircularProgressBar.SubscriptColor = System.Drawing.Color.White;
            this.CpuUtilCircularProgressBar.SubscriptMargin = new System.Windows.Forms.Padding(10, -15, 0, 0);
            this.CpuUtilCircularProgressBar.SubscriptText = "";
            this.CpuUtilCircularProgressBar.SuperscriptColor = System.Drawing.Color.White;
            this.CpuUtilCircularProgressBar.SuperscriptMargin = new System.Windows.Forms.Padding(-18, 30, 0, 0);
            this.CpuUtilCircularProgressBar.SuperscriptText = "%";
            this.CpuUtilCircularProgressBar.TabIndex = 65;
            this.CpuUtilCircularProgressBar.Text = "100^";
            this.CpuUtilCircularProgressBar.TextMargin = new System.Windows.Forms.Padding(5, -2, 0, 0);
            this.CpuUtilCircularProgressBar.Value = 68;
            // 
            // CpuTempCircularProgressBar
            // 
            this.CpuTempCircularProgressBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.CpuTempCircularProgressBar.AnimationSpeed = 100;
            this.CpuTempCircularProgressBar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CpuTempCircularProgressBar.Font = new System.Drawing.Font("Edit Undo BRK", 15F, System.Drawing.FontStyle.Bold);
            this.CpuTempCircularProgressBar.ForeColor = System.Drawing.Color.Navy;
            this.CpuTempCircularProgressBar.InnerColor = System.Drawing.Color.RoyalBlue;
            this.CpuTempCircularProgressBar.InnerMargin = 2;
            this.CpuTempCircularProgressBar.InnerWidth = -1;
            this.CpuTempCircularProgressBar.Location = new System.Drawing.Point(102, 69);
            this.CpuTempCircularProgressBar.MarqueeAnimationSpeed = 2000;
            this.CpuTempCircularProgressBar.Name = "CpuTempCircularProgressBar";
            this.CpuTempCircularProgressBar.OuterColor = System.Drawing.Color.LightSkyBlue;
            this.CpuTempCircularProgressBar.OuterMargin = -25;
            this.CpuTempCircularProgressBar.OuterWidth = 26;
            this.CpuTempCircularProgressBar.ProgressColor = System.Drawing.Color.CornflowerBlue;
            this.CpuTempCircularProgressBar.ProgressWidth = 25;
            this.CpuTempCircularProgressBar.SecondaryFont = new System.Drawing.Font("Edit Undo BRK", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CpuTempCircularProgressBar.Size = new System.Drawing.Size(70, 70);
            this.CpuTempCircularProgressBar.StartAngle = 270;
            this.CpuTempCircularProgressBar.SubscriptColor = System.Drawing.Color.White;
            this.CpuTempCircularProgressBar.SubscriptMargin = new System.Windows.Forms.Padding(10, -15, 0, 0);
            this.CpuTempCircularProgressBar.SubscriptText = "";
            this.CpuTempCircularProgressBar.SuperscriptColor = System.Drawing.Color.White;
            this.CpuTempCircularProgressBar.SuperscriptMargin = new System.Windows.Forms.Padding(-20, 30, 0, 0);
            this.CpuTempCircularProgressBar.SuperscriptText = "°C";
            this.CpuTempCircularProgressBar.TabIndex = 64;
            this.CpuTempCircularProgressBar.Text = "10 ^";
            this.CpuTempCircularProgressBar.TextMargin = new System.Windows.Forms.Padding(5, -2, 0, 0);
            this.CpuTempCircularProgressBar.Value = 68;
            // 
            // GpuSpeedCircularProgressBar
            // 
            this.GpuSpeedCircularProgressBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.GpuSpeedCircularProgressBar.AnimationSpeed = 100;
            this.GpuSpeedCircularProgressBar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.GpuSpeedCircularProgressBar.Font = new System.Drawing.Font("Edit Undo BRK", 15F, System.Drawing.FontStyle.Bold);
            this.GpuSpeedCircularProgressBar.ForeColor = System.Drawing.Color.Navy;
            this.GpuSpeedCircularProgressBar.InnerColor = System.Drawing.Color.RoyalBlue;
            this.GpuSpeedCircularProgressBar.InnerMargin = 2;
            this.GpuSpeedCircularProgressBar.InnerWidth = -1;
            this.GpuSpeedCircularProgressBar.Location = new System.Drawing.Point(193, 143);
            this.GpuSpeedCircularProgressBar.MarqueeAnimationSpeed = 2000;
            this.GpuSpeedCircularProgressBar.Maximum = 10000;
            this.GpuSpeedCircularProgressBar.Name = "GpuSpeedCircularProgressBar";
            this.GpuSpeedCircularProgressBar.OuterColor = System.Drawing.Color.LightSkyBlue;
            this.GpuSpeedCircularProgressBar.OuterMargin = -25;
            this.GpuSpeedCircularProgressBar.OuterWidth = 26;
            this.GpuSpeedCircularProgressBar.ProgressColor = System.Drawing.Color.DodgerBlue;
            this.GpuSpeedCircularProgressBar.ProgressWidth = 25;
            this.GpuSpeedCircularProgressBar.SecondaryFont = new System.Drawing.Font("Edit Undo BRK", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GpuSpeedCircularProgressBar.Size = new System.Drawing.Size(74, 74);
            this.GpuSpeedCircularProgressBar.StartAngle = 270;
            this.GpuSpeedCircularProgressBar.SubscriptColor = System.Drawing.Color.White;
            this.GpuSpeedCircularProgressBar.SubscriptMargin = new System.Windows.Forms.Padding(10, -15, 0, 0);
            this.GpuSpeedCircularProgressBar.SubscriptText = "";
            this.GpuSpeedCircularProgressBar.SuperscriptColor = System.Drawing.Color.White;
            this.GpuSpeedCircularProgressBar.SuperscriptMargin = new System.Windows.Forms.Padding(-18, 30, 0, 0);
            this.GpuSpeedCircularProgressBar.SuperscriptText = "Mhz";
            this.GpuSpeedCircularProgressBar.TabIndex = 69;
            this.GpuSpeedCircularProgressBar.Text = "10000";
            this.GpuSpeedCircularProgressBar.TextMargin = new System.Windows.Forms.Padding(5, -2, 0, 0);
            this.GpuSpeedCircularProgressBar.Value = 68;
            // 
            // UtilTimeTextBox
            // 
            this.UtilTimeTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(203)))), ((int)(((byte)(220)))));
            this.UtilTimeTextBox.Enabled = false;
            this.UtilTimeTextBox.Font = new System.Drawing.Font("Edit Undo BRK", 8.25F);
            this.UtilTimeTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(105)))), ((int)(((byte)(136)))));
            this.UtilTimeTextBox.Location = new System.Drawing.Point(37, 8);
            this.UtilTimeTextBox.Name = "UtilTimeTextBox";
            this.UtilTimeTextBox.Size = new System.Drawing.Size(300, 17);
            this.UtilTimeTextBox.TabIndex = 71;
            this.UtilTimeTextBox.Text = "v 0.01";
            this.UtilTimeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CpuTitle
            // 
            this.CpuTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(203)))), ((int)(((byte)(220)))));
            this.CpuTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CpuTitle.Enabled = false;
            this.CpuTitle.Font = new System.Drawing.Font("Edit Undo BRK", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CpuTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(105)))), ((int)(((byte)(136)))));
            this.CpuTitle.Location = new System.Drawing.Point(27, 40);
            this.CpuTitle.Multiline = true;
            this.CpuTitle.Name = "CpuTitle";
            this.CpuTitle.Size = new System.Drawing.Size(152, 29);
            this.CpuTitle.TabIndex = 72;
            this.CpuTitle.Text = "CPU";
            this.CpuTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // GpuTitle
            // 
            this.GpuTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(203)))), ((int)(((byte)(220)))));
            this.GpuTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GpuTitle.Enabled = false;
            this.GpuTitle.Font = new System.Drawing.Font("Edit Undo BRK", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GpuTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(105)))), ((int)(((byte)(136)))));
            this.GpuTitle.Location = new System.Drawing.Point(191, 40);
            this.GpuTitle.Multiline = true;
            this.GpuTitle.Name = "GpuTitle";
            this.GpuTitle.Size = new System.Drawing.Size(154, 29);
            this.GpuTitle.TabIndex = 73;
            this.GpuTitle.Text = "GPU";
            this.GpuTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(203)))), ((int)(((byte)(220)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Edit Undo BRK", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(105)))), ((int)(((byte)(136)))));
            this.textBox1.Location = new System.Drawing.Point(27, 150);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(49, 17);
            this.textBox1.TabIndex = 74;
            this.textBox1.Text = "RAM";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(203)))), ((int)(((byte)(220)))));
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Enabled = false;
            this.textBox3.Font = new System.Drawing.Font("Edit Undo BRK", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(105)))), ((int)(((byte)(136)))));
            this.textBox3.Location = new System.Drawing.Point(130, 150);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(49, 17);
            this.textBox3.TabIndex = 75;
            this.textBox3.Text = "(C:) free";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RamTotalTextBox
            // 
            this.RamTotalTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(203)))), ((int)(((byte)(220)))));
            this.RamTotalTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RamTotalTextBox.Enabled = false;
            this.RamTotalTextBox.Font = new System.Drawing.Font("Edit Undo BRK", 6.249999F);
            this.RamTotalTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(105)))), ((int)(((byte)(136)))));
            this.RamTotalTextBox.Location = new System.Drawing.Point(77, 150);
            this.RamTotalTextBox.Multiline = true;
            this.RamTotalTextBox.Name = "RamTotalTextBox";
            this.RamTotalTextBox.Size = new System.Drawing.Size(52, 32);
            this.RamTotalTextBox.TabIndex = 76;
            this.RamTotalTextBox.Text = "ram total/used";
            this.RamTotalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CDriveSpaceTextBox
            // 
            this.CDriveSpaceTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(203)))), ((int)(((byte)(220)))));
            this.CDriveSpaceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CDriveSpaceTextBox.Enabled = false;
            this.CDriveSpaceTextBox.Font = new System.Drawing.Font("Edit Undo BRK", 6.249999F);
            this.CDriveSpaceTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(105)))), ((int)(((byte)(136)))));
            this.CDriveSpaceTextBox.Location = new System.Drawing.Point(77, 183);
            this.CDriveSpaceTextBox.Multiline = true;
            this.CDriveSpaceTextBox.Name = "CDriveSpaceTextBox";
            this.CDriveSpaceTextBox.Size = new System.Drawing.Size(52, 32);
            this.CDriveSpaceTextBox.TabIndex = 77;
            this.CDriveSpaceTextBox.Text = "(C:) Total/used";
            this.CDriveSpaceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::PCMonitor.Properties.Resources.Back;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(371, 240);
            this.Controls.Add(this.CDriveSpaceTextBox);
            this.Controls.Add(this.RamTotalTextBox);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.GpuTitle);
            this.Controls.Add(this.CpuTitle);
            this.Controls.Add(this.UtilTimeTextBox);
            this.Controls.Add(this.GpuSpeedCircularProgressBar);
            this.Controls.Add(this.CpuUtilCircularProgressBar);
            this.Controls.Add(this.CpuTempCircularProgressBar);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.GpuFanCircularProgressBar);
            this.Controls.Add(this.GpuUtilCircularProgressBar);
            this.Controls.Add(this.GpuTempCircularProgressBar);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.DiskUtilCircularProgressBar);
            this.Controls.Add(this.RamUsageCircularProgressBar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.MonitorSwap);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "PCMonitor";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MonitorSwap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox Exit;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.PictureBox MonitorSwap;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private CircularProgressBar.CircularProgressBar RamUsageCircularProgressBar;
        private CircularProgressBar.CircularProgressBar DiskUtilCircularProgressBar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private CircularProgressBar.CircularProgressBar GpuUtilCircularProgressBar;
        private CircularProgressBar.CircularProgressBar GpuTempCircularProgressBar;
        private CircularProgressBar.CircularProgressBar GpuFanCircularProgressBar;
        private System.Windows.Forms.PictureBox pictureBox3;
        private CircularProgressBar.CircularProgressBar CpuUtilCircularProgressBar;
        private CircularProgressBar.CircularProgressBar CpuTempCircularProgressBar;
        private CircularProgressBar.CircularProgressBar GpuSpeedCircularProgressBar;
        private System.Windows.Forms.TextBox UtilTimeTextBox;
        private System.Windows.Forms.TextBox CpuTitle;
        private System.Windows.Forms.TextBox GpuTitle;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox RamTotalTextBox;
        private System.Windows.Forms.TextBox CDriveSpaceTextBox;
    }
}

