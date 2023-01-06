namespace Lunatic
{
    partial class frmLunatic
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
            this.cboPort = new System.Windows.Forms.ComboBox();
            this.lblRACaption = new System.Windows.Forms.Label();
            this.lblRA = new System.Windows.Forms.Label();
            this.lblSegmentCountdown = new System.Windows.Forms.Label();
            this.lblSegmentCaption = new System.Windows.Forms.Label();
            this.btnSetTL = new System.Windows.Forms.Button();
            this.btnSetTR = new System.Windows.Forms.Button();
            this.btnSetBR = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.udXStep = new System.Windows.Forms.NumericUpDown();
            this.lblPortCaption = new System.Windows.Forms.Label();
            this.lblXStepCaption = new System.Windows.Forms.Label();
            this.chkInvertUD = new System.Windows.Forms.CheckBox();
            this.chkInvertLR = new System.Windows.Forms.CheckBox();
            this.lblY = new System.Windows.Forms.Label();
            this.lblYCaption = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.lblXCaption = new System.Windows.Forms.Label();
            this.btnRun = new System.Windows.Forms.Button();
            this.lblYStepCaption = new System.Windows.Forms.Label();
            this.udYStep = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.udDwell = new System.Windows.Forms.NumericUpDown();
            this.btnGoTL = new System.Windows.Forms.Button();
            this.btnGoBR = new System.Windows.Forms.Button();
            this.btnSetXStep = new System.Windows.Forms.Button();
            this.btnSetYStep = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.udSpeed = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.lblWidth = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblTopRight = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTopLeft = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblDec = new System.Windows.Forms.Label();
            this.lblDecCaption = new System.Windows.Forms.Label();
            this.btnRefreshPorts = new System.Windows.Forms.Button();
            this.lblFrameTime = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.chkLog = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.udXStep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udYStep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udDwell)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // cboPort
            // 
            this.cboPort.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPort.FormattingEnabled = true;
            this.cboPort.Location = new System.Drawing.Point(12, 27);
            this.cboPort.Name = "cboPort";
            this.cboPort.Size = new System.Drawing.Size(531, 23);
            this.cboPort.TabIndex = 0;
            this.cboPort.SelectedIndexChanged += new System.EventHandler(this.cboPort_SelectedIndexChanged);
            // 
            // lblRACaption
            // 
            this.lblRACaption.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRACaption.AutoSize = true;
            this.lblRACaption.Location = new System.Drawing.Point(16, 259);
            this.lblRACaption.Name = "lblRACaption";
            this.lblRACaption.Size = new System.Drawing.Size(25, 15);
            this.lblRACaption.TabIndex = 1;
            this.lblRACaption.Text = "RA:";
            this.lblRACaption.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblRA
            // 
            this.lblRA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRA.AutoSize = true;
            this.lblRA.Location = new System.Drawing.Point(47, 259);
            this.lblRA.Name = "lblRA";
            this.lblRA.Size = new System.Drawing.Size(12, 15);
            this.lblRA.TabIndex = 2;
            this.lblRA.Text = "?";
            this.lblRA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSegmentCountdown
            // 
            this.lblSegmentCountdown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSegmentCountdown.AutoSize = true;
            this.lblSegmentCountdown.Location = new System.Drawing.Point(552, 221);
            this.lblSegmentCountdown.Name = "lblSegmentCountdown";
            this.lblSegmentCountdown.Size = new System.Drawing.Size(25, 15);
            this.lblSegmentCountdown.TabIndex = 4;
            this.lblSegmentCountdown.Text = "n/a";
            this.lblSegmentCountdown.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSegmentCaption
            // 
            this.lblSegmentCaption.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSegmentCaption.AutoSize = true;
            this.lblSegmentCaption.Location = new System.Drawing.Point(450, 221);
            this.lblSegmentCaption.Name = "lblSegmentCaption";
            this.lblSegmentCaption.Size = new System.Drawing.Size(93, 15);
            this.lblSegmentCaption.TabIndex = 3;
            this.lblSegmentCaption.Text = "Time Remaining";
            this.lblSegmentCaption.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnSetTL
            // 
            this.btnSetTL.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSetTL.BackColor = System.Drawing.Color.Navy;
            this.btnSetTL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetTL.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSetTL.ForeColor = System.Drawing.Color.White;
            this.btnSetTL.Location = new System.Drawing.Point(503, 355);
            this.btnSetTL.Name = "btnSetTL";
            this.btnSetTL.Size = new System.Drawing.Size(125, 32);
            this.btnSetTL.TabIndex = 5;
            this.btnSetTL.Text = "Set Top Left";
            this.btnSetTL.UseVisualStyleBackColor = false;
            this.btnSetTL.Click += new System.EventHandler(this.btnSetTL_Click);
            // 
            // btnSetTR
            // 
            this.btnSetTR.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSetTR.BackColor = System.Drawing.Color.Navy;
            this.btnSetTR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetTR.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSetTR.ForeColor = System.Drawing.Color.White;
            this.btnSetTR.Location = new System.Drawing.Point(503, 393);
            this.btnSetTR.Name = "btnSetTR";
            this.btnSetTR.Size = new System.Drawing.Size(125, 32);
            this.btnSetTR.TabIndex = 6;
            this.btnSetTR.Text = "Set Top Right";
            this.btnSetTR.UseVisualStyleBackColor = false;
            this.btnSetTR.Click += new System.EventHandler(this.btnSetTR_Click);
            // 
            // btnSetBR
            // 
            this.btnSetBR.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSetBR.BackColor = System.Drawing.Color.Navy;
            this.btnSetBR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetBR.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSetBR.ForeColor = System.Drawing.Color.White;
            this.btnSetBR.Location = new System.Drawing.Point(503, 431);
            this.btnSetBR.Name = "btnSetBR";
            this.btnSetBR.Size = new System.Drawing.Size(125, 32);
            this.btnSetBR.TabIndex = 8;
            this.btnSetBR.Text = "Set Bottom Right";
            this.btnSetBR.UseVisualStyleBackColor = false;
            this.btnSetBR.Click += new System.EventHandler(this.btnSetBR_Click);
            // 
            // btnUp
            // 
            this.btnUp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUp.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUp.ForeColor = System.Drawing.Color.White;
            this.btnUp.Location = new System.Drawing.Point(138, 355);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(110, 32);
            this.btnUp.TabIndex = 9;
            this.btnUp.Text = "Up";
            this.btnUp.UseVisualStyleBackColor = false;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnDown
            // 
            this.btnDown.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDown.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDown.ForeColor = System.Drawing.Color.White;
            this.btnDown.Location = new System.Drawing.Point(138, 411);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(110, 32);
            this.btnDown.TabIndex = 10;
            this.btnDown.Text = "Down";
            this.btnDown.UseVisualStyleBackColor = false;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLeft.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLeft.ForeColor = System.Drawing.Color.White;
            this.btnLeft.Location = new System.Drawing.Point(22, 382);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(110, 32);
            this.btnLeft.TabIndex = 11;
            this.btnLeft.Text = "Left";
            this.btnLeft.UseVisualStyleBackColor = false;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnRight
            // 
            this.btnRight.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRight.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRight.ForeColor = System.Drawing.Color.White;
            this.btnRight.Location = new System.Drawing.Point(250, 382);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(110, 32);
            this.btnRight.TabIndex = 12;
            this.btnRight.Text = "Right";
            this.btnRight.UseVisualStyleBackColor = false;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // udXStep
            // 
            this.udXStep.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.udXStep.Location = new System.Drawing.Point(12, 83);
            this.udXStep.Name = "udXStep";
            this.udXStep.Size = new System.Drawing.Size(72, 23);
            this.udXStep.TabIndex = 13;
            // 
            // lblPortCaption
            // 
            this.lblPortCaption.AutoSize = true;
            this.lblPortCaption.Location = new System.Drawing.Point(12, 9);
            this.lblPortCaption.Name = "lblPortCaption";
            this.lblPortCaption.Size = new System.Drawing.Size(29, 15);
            this.lblPortCaption.TabIndex = 14;
            this.lblPortCaption.Text = "Port";
            // 
            // lblXStepCaption
            // 
            this.lblXStepCaption.AutoSize = true;
            this.lblXStepCaption.Location = new System.Drawing.Point(12, 65);
            this.lblXStepCaption.Name = "lblXStepCaption";
            this.lblXStepCaption.Size = new System.Drawing.Size(71, 15);
            this.lblXStepCaption.TabIndex = 15;
            this.lblXStepCaption.Text = "Panel Width";
            // 
            // chkInvertUD
            // 
            this.chkInvertUD.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chkInvertUD.AutoSize = true;
            this.chkInvertUD.Location = new System.Drawing.Point(250, 503);
            this.chkInvertUD.Name = "chkInvertUD";
            this.chkInvertUD.Size = new System.Drawing.Size(110, 19);
            this.chkInvertUD.TabIndex = 16;
            this.chkInvertUD.Text = "Invert Up/Down";
            this.chkInvertUD.UseVisualStyleBackColor = true;
            // 
            // chkInvertLR
            // 
            this.chkInvertLR.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chkInvertLR.AutoSize = true;
            this.chkInvertLR.Location = new System.Drawing.Point(250, 478);
            this.chkInvertLR.Name = "chkInvertLR";
            this.chkInvertLR.Size = new System.Drawing.Size(112, 19);
            this.chkInvertLR.TabIndex = 17;
            this.chkInvertLR.Text = "Invert Left/Right";
            this.chkInvertLR.UseVisualStyleBackColor = true;
            // 
            // lblY
            // 
            this.lblY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(553, 258);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(25, 15);
            this.lblY.TabIndex = 19;
            this.lblY.Text = "n/a";
            this.lblY.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblYCaption
            // 
            this.lblYCaption.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblYCaption.AutoSize = true;
            this.lblYCaption.Location = new System.Drawing.Point(483, 258);
            this.lblYCaption.Name = "lblYCaption";
            this.lblYCaption.Size = new System.Drawing.Size(60, 15);
            this.lblYCaption.TabIndex = 18;
            this.lblYCaption.Text = "Y Position";
            this.lblYCaption.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblX
            // 
            this.lblX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(553, 240);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(25, 15);
            this.lblX.TabIndex = 21;
            this.lblX.Text = "n/a";
            this.lblX.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblXCaption
            // 
            this.lblXCaption.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblXCaption.AutoSize = true;
            this.lblXCaption.Location = new System.Drawing.Point(483, 240);
            this.lblXCaption.Name = "lblXCaption";
            this.lblXCaption.Size = new System.Drawing.Size(60, 15);
            this.lblXCaption.TabIndex = 20;
            this.lblXCaption.Text = "X Position";
            this.lblXCaption.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnRun
            // 
            this.btnRun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRun.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRun.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRun.ForeColor = System.Drawing.Color.White;
            this.btnRun.Location = new System.Drawing.Point(518, 491);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(110, 32);
            this.btnRun.TabIndex = 22;
            this.btnRun.Text = "&RUN";
            this.btnRun.UseVisualStyleBackColor = false;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // lblYStepCaption
            // 
            this.lblYStepCaption.AutoSize = true;
            this.lblYStepCaption.Location = new System.Drawing.Point(255, 67);
            this.lblYStepCaption.Name = "lblYStepCaption";
            this.lblYStepCaption.Size = new System.Drawing.Size(75, 15);
            this.lblYStepCaption.TabIndex = 24;
            this.lblYStepCaption.Text = "Panel Height";
            // 
            // udYStep
            // 
            this.udYStep.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.udYStep.Location = new System.Drawing.Point(255, 87);
            this.udYStep.Name = "udYStep";
            this.udYStep.Size = new System.Drawing.Size(72, 23);
            this.udYStep.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(538, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 15);
            this.label1.TabIndex = 26;
            this.label1.Text = "Dwell Time (s)";
            // 
            // udDwell
            // 
            this.udDwell.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.udDwell.Location = new System.Drawing.Point(538, 85);
            this.udDwell.Name = "udDwell";
            this.udDwell.Size = new System.Drawing.Size(90, 23);
            this.udDwell.TabIndex = 25;
            this.udDwell.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // btnGoTL
            // 
            this.btnGoTL.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnGoTL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoTL.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGoTL.Location = new System.Drawing.Point(439, 355);
            this.btnGoTL.Name = "btnGoTL";
            this.btnGoTL.Size = new System.Drawing.Size(48, 32);
            this.btnGoTL.TabIndex = 27;
            this.btnGoTL.Text = "GO";
            this.btnGoTL.UseVisualStyleBackColor = true;
            this.btnGoTL.Click += new System.EventHandler(this.btnGoTL_Click);
            // 
            // btnGoBR
            // 
            this.btnGoBR.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnGoBR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoBR.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGoBR.Location = new System.Drawing.Point(439, 431);
            this.btnGoBR.Name = "btnGoBR";
            this.btnGoBR.Size = new System.Drawing.Size(48, 32);
            this.btnGoBR.TabIndex = 28;
            this.btnGoBR.Text = "GO";
            this.btnGoBR.UseVisualStyleBackColor = true;
            this.btnGoBR.Click += new System.EventHandler(this.btnGoBR_Click);
            // 
            // btnSetXStep
            // 
            this.btnSetXStep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetXStep.Location = new System.Drawing.Point(90, 83);
            this.btnSetXStep.Name = "btnSetXStep";
            this.btnSetXStep.Size = new System.Drawing.Size(80, 27);
            this.btnSetXStep.TabIndex = 29;
            this.btnSetXStep.Text = "Set &Width";
            this.btnSetXStep.UseVisualStyleBackColor = true;
            this.btnSetXStep.Click += new System.EventHandler(this.btnSetXStep_Click);
            // 
            // btnSetYStep
            // 
            this.btnSetYStep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetYStep.Location = new System.Drawing.Point(333, 83);
            this.btnSetYStep.Name = "btnSetYStep";
            this.btnSetYStep.Size = new System.Drawing.Size(80, 27);
            this.btnSetYStep.TabIndex = 30;
            this.btnSetYStep.Text = "Set &Height";
            this.btnSetYStep.UseVisualStyleBackColor = true;
            this.btnSetYStep.Click += new System.EventHandler(this.btnSetYStep_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 478);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 15);
            this.label2.TabIndex = 32;
            this.label2.Text = "Slew Speed";
            // 
            // udSpeed
            // 
            this.udSpeed.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.udSpeed.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.udSpeed.Location = new System.Drawing.Point(153, 505);
            this.udSpeed.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.udSpeed.Name = "udSpeed";
            this.udSpeed.Size = new System.Drawing.Size(66, 23);
            this.udSpeed.TabIndex = 31;
            this.udSpeed.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 15);
            this.label3.TabIndex = 33;
            this.label3.Text = "Scene Width";
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(12, 186);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(25, 15);
            this.lblWidth.TabIndex = 34;
            this.lblWidth.Text = "n/a";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(255, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 15);
            this.label5.TabIndex = 35;
            this.label5.Text = "Scene Height";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(255, 186);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(25, 15);
            this.lblHeight.TabIndex = 36;
            this.lblHeight.Text = "n/a";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(483, 188);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(49, 15);
            this.lblTime.TabIndex = 38;
            this.lblTime.Text = "00:00:00";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(483, 170);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 15);
            this.label8.TabIndex = 37;
            this.label8.Text = "Scene Time";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.BackColor = System.Drawing.Color.Maroon;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(518, 491);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 32);
            this.btnCancel.TabIndex = 39;
            this.btnCancel.Text = "&CANCEL";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblTopRight
            // 
            this.lblTopRight.AutoSize = true;
            this.lblTopRight.Location = new System.Drawing.Point(255, 143);
            this.lblTopRight.Name = "lblTopRight";
            this.lblTopRight.Size = new System.Drawing.Size(25, 15);
            this.lblTopRight.TabIndex = 43;
            this.lblTopRight.Text = "n/a";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(255, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 15);
            this.label6.TabIndex = 42;
            this.label6.Text = "Scene Top Right";
            // 
            // lblTopLeft
            // 
            this.lblTopLeft.AutoSize = true;
            this.lblTopLeft.Location = new System.Drawing.Point(12, 143);
            this.lblTopLeft.Name = "lblTopLeft";
            this.lblTopLeft.Size = new System.Drawing.Size(25, 15);
            this.lblTopLeft.TabIndex = 41;
            this.lblTopLeft.Text = "n/a";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(12, 125);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 15);
            this.label9.TabIndex = 40;
            this.label9.Text = "Scene Top Left";
            // 
            // lblDec
            // 
            this.lblDec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDec.AutoSize = true;
            this.lblDec.Location = new System.Drawing.Point(47, 292);
            this.lblDec.Name = "lblDec";
            this.lblDec.Size = new System.Drawing.Size(12, 15);
            this.lblDec.TabIndex = 44;
            this.lblDec.Text = "?";
            this.lblDec.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDecCaption
            // 
            this.lblDecCaption.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDecCaption.AutoSize = true;
            this.lblDecCaption.Location = new System.Drawing.Point(9, 292);
            this.lblDecCaption.Name = "lblDecCaption";
            this.lblDecCaption.Size = new System.Drawing.Size(32, 15);
            this.lblDecCaption.TabIndex = 45;
            this.lblDecCaption.Text = "DEC:";
            this.lblDecCaption.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnRefreshPorts
            // 
            this.btnRefreshPorts.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnRefreshPorts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshPorts.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRefreshPorts.Location = new System.Drawing.Point(552, 27);
            this.btnRefreshPorts.Name = "btnRefreshPorts";
            this.btnRefreshPorts.Size = new System.Drawing.Size(76, 23);
            this.btnRefreshPorts.TabIndex = 46;
            this.btnRefreshPorts.Text = "&Refresh";
            this.btnRefreshPorts.UseVisualStyleBackColor = true;
            this.btnRefreshPorts.Click += new System.EventHandler(this.btnRefreshPorts_Click);
            // 
            // lblFrameTime
            // 
            this.lblFrameTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFrameTime.AutoSize = true;
            this.lblFrameTime.Location = new System.Drawing.Point(553, 275);
            this.lblFrameTime.Name = "lblFrameTime";
            this.lblFrameTime.Size = new System.Drawing.Size(25, 15);
            this.lblFrameTime.TabIndex = 48;
            this.lblFrameTime.Text = "n/a";
            this.lblFrameTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(469, 275);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 15);
            this.label7.TabIndex = 47;
            this.label7.Text = "Frame Time";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(378, 220);
            this.txtLog.Margin = new System.Windows.Forms.Padding(2);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(252, 245);
            this.txtLog.TabIndex = 49;
            // 
            // chkLog
            // 
            this.chkLog.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chkLog.AutoSize = true;
            this.chkLog.Checked = true;
            this.chkLog.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkLog.Location = new System.Drawing.Point(378, 476);
            this.chkLog.Name = "chkLog";
            this.chkLog.Size = new System.Drawing.Size(46, 19);
            this.chkLog.TabIndex = 50;
            this.chkLog.Text = "Log";
            this.chkLog.UseVisualStyleBackColor = true;
            this.chkLog.CheckedChanged += new System.EventHandler(this.chkLog_CheckedChanged);
            // 
            // frmLunatic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 532);
            this.Controls.Add(this.chkLog);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.lblFrameTime);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnRefreshPorts);
            this.Controls.Add(this.lblDecCaption);
            this.Controls.Add(this.lblDec);
            this.Controls.Add(this.lblTopRight);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblTopLeft);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblWidth);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.udSpeed);
            this.Controls.Add(this.btnSetYStep);
            this.Controls.Add(this.btnSetXStep);
            this.Controls.Add(this.btnGoBR);
            this.Controls.Add(this.btnGoTL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.udDwell);
            this.Controls.Add(this.lblYStepCaption);
            this.Controls.Add(this.udYStep);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.lblXCaption);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.lblYCaption);
            this.Controls.Add(this.chkInvertLR);
            this.Controls.Add(this.chkInvertUD);
            this.Controls.Add(this.lblXStepCaption);
            this.Controls.Add(this.lblPortCaption);
            this.Controls.Add(this.udXStep);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.btnSetBR);
            this.Controls.Add(this.btnSetTR);
            this.Controls.Add(this.btnSetTL);
            this.Controls.Add(this.lblSegmentCountdown);
            this.Controls.Add(this.lblSegmentCaption);
            this.Controls.Add(this.lblRA);
            this.Controls.Add(this.lblRACaption);
            this.Controls.Add(this.cboPort);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRun);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(619, 495);
            this.Name = "frmLunatic";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Lunatic";
            ((System.ComponentModel.ISupportInitialize)(this.udXStep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udYStep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udDwell)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udSpeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cboPort;
        private Label lblRACaption;
        private Label lblRA;
        private Label lblSegmentCountdown;
        private Label lblSegmentCaption;
        private Button btnSetTL;
        private Button btnSetTR;
        private Button btnSetBR;
        private Button btnUp;
        private Button btnDown;
        private Button btnLeft;
        private Button btnRight;
        private NumericUpDown udXStep;
        private Label lblPortCaption;
        private Label lblXStepCaption;
        private CheckBox chkInvertUD;
        private CheckBox chkInvertLR;
        private Label lblY;
        private Label lblYCaption;
        private Label lblX;
        private Label lblXCaption;
        private Button btnRun;
        private Label lblYStepCaption;
        private NumericUpDown udYStep;
        private Label label1;
        private NumericUpDown udDwell;
        private Button btnGoTL;
        private Button btnGoBR;
        private Button btnSetXStep;
        private Button btnSetYStep;
        private Label label2;
        private NumericUpDown udSpeed;
        private Label label3;
        private Label lblWidth;
        private Label label5;
        private Label lblHeight;
        private Label lblTime;
        private Label label8;
        private Button btnCancel;
        private Label lblTopRight;
        private Label label6;
        private Label lblTopLeft;
        private Label label9;
        private Label lblDec;
        private Label lblDecCaption;
        private Button btnRefreshPorts;
        private Label lblFrameTime;
        private Label label7;
        private TextBox txtLog;
        private CheckBox chkLog;
    }
}