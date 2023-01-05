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
            this.lblPositionCaption = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblSegmentCountdown = new System.Windows.Forms.Label();
            this.lblSegmentCaption = new System.Windows.Forms.Label();
            this.btnSetTL = new System.Windows.Forms.Button();
            this.btnSetTR = new System.Windows.Forms.Button();
            this.btnSetBR = new System.Windows.Forms.Button();
            this.btnSetBL = new System.Windows.Forms.Button();
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
            this.cboPort.Size = new System.Drawing.Size(581, 23);
            this.cboPort.TabIndex = 0;
            this.cboPort.SelectedIndexChanged += new System.EventHandler(this.cboPort_SelectedIndexChanged);
            // 
            // lblPositionCaption
            // 
            this.lblPositionCaption.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPositionCaption.AutoSize = true;
            this.lblPositionCaption.Location = new System.Drawing.Point(12, 592);
            this.lblPositionCaption.Name = "lblPositionCaption";
            this.lblPositionCaption.Size = new System.Drawing.Size(96, 15);
            this.lblPositionCaption.TabIndex = 1;
            this.lblPositionCaption.Text = "Current Position:";
            this.lblPositionCaption.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPosition
            // 
            this.lblPosition.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPosition.AutoSize = true;
            this.lblPosition.Location = new System.Drawing.Point(114, 592);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(12, 15);
            this.lblPosition.TabIndex = 2;
            this.lblPosition.Text = "?";
            this.lblPosition.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSegmentCountdown
            // 
            this.lblSegmentCountdown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSegmentCountdown.AutoSize = true;
            this.lblSegmentCountdown.Location = new System.Drawing.Point(559, 592);
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
            this.lblSegmentCaption.Location = new System.Drawing.Point(457, 592);
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
            this.btnSetTL.Location = new System.Drawing.Point(191, 348);
            this.btnSetTL.Name = "btnSetTL";
            this.btnSetTL.Size = new System.Drawing.Size(123, 32);
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
            this.btnSetTR.Location = new System.Drawing.Point(340, 348);
            this.btnSetTR.Name = "btnSetTR";
            this.btnSetTR.Size = new System.Drawing.Size(123, 32);
            this.btnSetTR.TabIndex = 6;
            this.btnSetTR.Text = "Set Top Right";
            this.btnSetTR.UseVisualStyleBackColor = false;
            // 
            // btnSetBR
            // 
            this.btnSetBR.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSetBR.BackColor = System.Drawing.Color.Navy;
            this.btnSetBR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetBR.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSetBR.ForeColor = System.Drawing.Color.White;
            this.btnSetBR.Location = new System.Drawing.Point(340, 389);
            this.btnSetBR.Name = "btnSetBR";
            this.btnSetBR.Size = new System.Drawing.Size(123, 32);
            this.btnSetBR.TabIndex = 8;
            this.btnSetBR.Text = "Set Bottom Right";
            this.btnSetBR.UseVisualStyleBackColor = false;
            // 
            // btnSetBL
            // 
            this.btnSetBL.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSetBL.BackColor = System.Drawing.Color.Navy;
            this.btnSetBL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetBL.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSetBL.ForeColor = System.Drawing.Color.White;
            this.btnSetBL.Location = new System.Drawing.Point(191, 389);
            this.btnSetBL.Name = "btnSetBL";
            this.btnSetBL.Size = new System.Drawing.Size(123, 32);
            this.btnSetBL.TabIndex = 7;
            this.btnSetBL.Text = "Set Bottom Left";
            this.btnSetBL.UseVisualStyleBackColor = false;
            // 
            // btnUp
            // 
            this.btnUp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUp.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUp.ForeColor = System.Drawing.Color.White;
            this.btnUp.Location = new System.Drawing.Point(274, 288);
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
            this.btnDown.Location = new System.Drawing.Point(271, 447);
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
            this.btnLeft.Location = new System.Drawing.Point(56, 389);
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
            this.btnRight.Location = new System.Drawing.Point(483, 389);
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
            this.udXStep.Location = new System.Drawing.Point(12, 88);
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
            this.lblXStepCaption.Location = new System.Drawing.Point(12, 70);
            this.lblXStepCaption.Name = "lblXStepCaption";
            this.lblXStepCaption.Size = new System.Drawing.Size(117, 15);
            this.lblXStepCaption.TabIndex = 15;
            this.lblXStepCaption.Text = "X Step Size (seconds)";
            // 
            // chkInvertUD
            // 
            this.chkInvertUD.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chkInvertUD.AutoSize = true;
            this.chkInvertUD.Location = new System.Drawing.Point(274, 263);
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
            this.chkInvertLR.Location = new System.Drawing.Point(56, 361);
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
            this.lblY.Location = new System.Drawing.Point(393, 592);
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
            this.lblYCaption.Location = new System.Drawing.Point(324, 592);
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
            this.lblX.Location = new System.Drawing.Point(231, 592);
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
            this.lblXCaption.Location = new System.Drawing.Point(162, 592);
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
            this.btnRun.Location = new System.Drawing.Point(367, 543);
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
            this.lblYStepCaption.Location = new System.Drawing.Point(255, 72);
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
            this.udYStep.Location = new System.Drawing.Point(255, 92);
            this.udYStep.Name = "udYStep";
            this.udYStep.Size = new System.Drawing.Size(72, 23);
            this.udYStep.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(484, 72);
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
            this.udDwell.Location = new System.Drawing.Point(484, 94);
            this.udDwell.Name = "udDwell";
            this.udDwell.Size = new System.Drawing.Size(72, 23);
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
            this.btnGoTL.Location = new System.Drawing.Point(191, 319);
            this.btnGoTL.Name = "btnGoTL";
            this.btnGoTL.Size = new System.Drawing.Size(48, 23);
            this.btnGoTL.TabIndex = 27;
            this.btnGoTL.Text = "GO";
            this.btnGoTL.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(415, 424);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 23);
            this.button1.TabIndex = 28;
            this.button1.Text = "GO";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnSetXStep
            // 
            this.btnSetXStep.Location = new System.Drawing.Point(90, 88);
            this.btnSetXStep.Name = "btnSetXStep";
            this.btnSetXStep.Size = new System.Drawing.Size(48, 23);
            this.btnSetXStep.TabIndex = 29;
            this.btnSetXStep.Text = "Set &X";
            this.btnSetXStep.UseVisualStyleBackColor = true;
            // 
            // btnSetYStep
            // 
            this.btnSetYStep.Location = new System.Drawing.Point(333, 92);
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
            this.label2.Location = new System.Drawing.Point(274, 204);
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
            this.numericUpDown1.Location = new System.Drawing.Point(274, 222);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(107, 23);
            this.numericUpDown1.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(15, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 15);
            this.label3.TabIndex = 33;
            this.label3.Text = "Scene Width";
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(15, 157);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(117, 15);
            this.lblWidth.TabIndex = 34;
            this.lblWidth.Text = "X Step Size (seconds)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(274, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 15);
            this.label5.TabIndex = 35;
            this.label5.Text = "Scene Height";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(274, 159);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(117, 15);
            this.lblHeight.TabIndex = 36;
            this.lblHeight.Text = "X Step Size (seconds)";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(483, 159);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(49, 15);
            this.lblTime.TabIndex = 38;
            this.lblTime.Text = "00:00:00";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(483, 141);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 15);
            this.label8.TabIndex = 37;
            this.label8.Text = "Scene Time";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.BackColor = System.Drawing.Color.Maroon;
            this.btnCancel.Enabled = false;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(483, 543);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 32);
            this.btnCancel.TabIndex = 39;
            this.btnCancel.Text = "&CANCEL";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // frmLunatic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 616);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
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
            this.Controls.Add(this.btnRun);
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
            this.Controls.Add(this.btnSetBL);
            this.Controls.Add(this.btnSetTR);
            this.Controls.Add(this.btnSetTL);
            this.Controls.Add(this.lblSegmentCountdown);
            this.Controls.Add(this.lblSegmentCaption);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.lblPositionCaption);
            this.Controls.Add(this.cboPort);
            this.MaximizeBox = false;
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
        private Label lblPositionCaption;
        private Label lblPosition;
        private Label lblSegmentCountdown;
        private Label lblSegmentCaption;
        private Button btnSetTL;
        private Button btnSetTR;
        private Button btnSetBR;
        private Button btnSetBL;
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
    }
}