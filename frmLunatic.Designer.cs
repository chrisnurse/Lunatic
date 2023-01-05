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
            this.button1 = new System.Windows.Forms.Button();
            this.btnSetXStep = new System.Windows.Forms.Button();
            this.btnSetYStep = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.lblWidth = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblDec = new System.Windows.Forms.Label();
            this.lblDecCaption = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.udXStep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udYStep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udDwell)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // cboPort
            // 
            this.cboPort.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboPort.FormattingEnabled = true;
            this.cboPort.Location = new System.Drawing.Point(12, 27);
            this.cboPort.Name = "cboPort";
            this.cboPort.Size = new System.Drawing.Size(616, 23);
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
            this.lblSegmentCountdown.Size = new System.Drawing.Size(34, 15);
            this.lblSegmentCountdown.TabIndex = 4;
            this.lblSegmentCountdown.Text = "00:00";
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
            this.btnSetTL.Location = new System.Drawing.Point(518, 355);
            this.btnSetTL.Name = "btnSetTL";
            this.btnSetTL.Size = new System.Drawing.Size(110, 32);
            this.btnSetTL.TabIndex = 5;
            this.btnSetTL.Text = "Set Top Left";
            this.btnSetTL.UseVisualStyleBackColor = false;
            // 
            // btnSetTR
            // 
            this.btnSetTR.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSetTR.BackColor = System.Drawing.Color.Navy;
            this.btnSetTR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetTR.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSetTR.ForeColor = System.Drawing.Color.White;
            this.btnSetTR.Location = new System.Drawing.Point(518, 393);
            this.btnSetTR.Name = "btnSetTR";
            this.btnSetTR.Size = new System.Drawing.Size(110, 32);
            this.btnSetTR.TabIndex = 6;
            this.btnSetTR.Text = "Set Max X";
            this.btnSetTR.UseVisualStyleBackColor = false;
            // 
            // btnSetBR
            // 
            this.btnSetBR.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSetBR.BackColor = System.Drawing.Color.Navy;
            this.btnSetBR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetBR.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSetBR.ForeColor = System.Drawing.Color.White;
            this.btnSetBR.Location = new System.Drawing.Point(518, 431);
            this.btnSetBR.Name = "btnSetBR";
            this.btnSetBR.Size = new System.Drawing.Size(110, 32);
            this.btnSetBR.TabIndex = 8;
            this.btnSetBR.Text = "Set Max Y";
            this.btnSetBR.UseVisualStyleBackColor = false;
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
            this.lblXStepCaption.Size = new System.Drawing.Size(117, 15);
            this.lblXStepCaption.TabIndex = 15;
            this.lblXStepCaption.Text = "X Step Size (seconds)";
            // 
            // chkInvertUD
            // 
            this.chkInvertUD.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chkInvertUD.AutoSize = true;
            this.chkInvertUD.Location = new System.Drawing.Point(262, 311);
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
            this.chkInvertLR.Location = new System.Drawing.Point(262, 286);
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
            this.lblY.Location = new System.Drawing.Point(552, 259);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(36, 15);
            this.lblY.TabIndex = 19;
            this.lblY.Text = "20/20";
            this.lblY.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblYCaption
            // 
            this.lblYCaption.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblYCaption.AutoSize = true;
            this.lblYCaption.Location = new System.Drawing.Point(483, 257);
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
            this.lblX.Location = new System.Drawing.Point(552, 240);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(30, 15);
            this.lblX.TabIndex = 21;
            this.lblX.Text = "1/20";
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
            this.lblYStepCaption.Size = new System.Drawing.Size(117, 15);
            this.lblYStepCaption.TabIndex = 24;
            this.lblYStepCaption.Text = "Y Step Size (seconds)";
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
            this.label1.Location = new System.Drawing.Point(484, 67);
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
            this.udDwell.Location = new System.Drawing.Point(484, 89);
            this.udDwell.Name = "udDwell";
            this.udDwell.Size = new System.Drawing.Size(72, 23);
            this.udDwell.TabIndex = 25;
            this.udDwell.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // btnGoTL
            // 
            this.btnGoTL.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnGoTL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoTL.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGoTL.Location = new System.Drawing.Point(456, 355);
            this.btnGoTL.Name = "btnGoTL";
            this.btnGoTL.Size = new System.Drawing.Size(48, 32);
            this.btnGoTL.TabIndex = 27;
            this.btnGoTL.Text = "GO";
            this.btnGoTL.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(456, 431);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 32);
            this.button1.TabIndex = 28;
            this.button1.Text = "GO";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnSetXStep
            // 
            this.btnSetXStep.Location = new System.Drawing.Point(90, 83);
            this.btnSetXStep.Name = "btnSetXStep";
            this.btnSetXStep.Size = new System.Drawing.Size(48, 23);
            this.btnSetXStep.TabIndex = 29;
            this.btnSetXStep.Text = "Set &X";
            this.btnSetXStep.UseVisualStyleBackColor = true;
            // 
            // btnSetYStep
            // 
            this.btnSetYStep.Location = new System.Drawing.Point(333, 87);
            this.btnSetYStep.Name = "btnSetYStep";
            this.btnSetYStep.Size = new System.Drawing.Size(48, 23);
            this.btnSetYStep.TabIndex = 30;
            this.btnSetYStep.Text = "Set &Y";
            this.btnSetYStep.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 15);
            this.label2.TabIndex = 32;
            this.label2.Text = "Slew Speed";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.numericUpDown1.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Location = new System.Drawing.Point(138, 284);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(66, 23);
            this.numericUpDown1.TabIndex = 31;
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
            this.lblWidth.Size = new System.Drawing.Size(117, 15);
            this.lblWidth.TabIndex = 34;
            this.lblWidth.Text = "X Step Size (seconds)";
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
            this.lblHeight.Size = new System.Drawing.Size(117, 15);
            this.lblHeight.TabIndex = 36;
            this.lblHeight.Text = "Y Step Size (seconds)";
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(255, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 15);
            this.label4.TabIndex = 43;
            this.label4.Text = "Y Step Size (seconds)";
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 15);
            this.label7.TabIndex = 41;
            this.label7.Text = "X Step Size (seconds)";
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
            // frmLunatic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 532);
            this.Controls.Add(this.lblDecCaption);
            this.Controls.Add(this.lblDec);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblWidth);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.btnSetYStep);
            this.Controls.Add(this.btnSetXStep);
            this.Controls.Add(this.button1);
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
            this.MinimumSize = new System.Drawing.Size(621, 502);
            this.Name = "frmLunatic";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Lunatic";
            ((System.ComponentModel.ISupportInitialize)(this.udXStep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udYStep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udDwell)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
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
        private Button button1;
        private Button btnSetXStep;
        private Button btnSetYStep;
        private Label label2;
        private NumericUpDown numericUpDown1;
        private Label label3;
        private Label lblWidth;
        private Label label5;
        private Label lblHeight;
        private Label lblTime;
        private Label label8;
        private Button btnCancel;
        private Label label4;
        private Label label6;
        private Label label7;
        private Label label9;
        private Label lblDec;
        private Label lblDecCaption;
    }
}