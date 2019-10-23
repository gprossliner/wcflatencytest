namespace WcfLatencyTestClient
{
    partial class FrmMain
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
            this.cmdStart = new System.Windows.Forms.Button();
            this.lblDelay = new System.Windows.Forms.Label();
            this.nudBurstCount = new System.Windows.Forms.NumericUpDown();
            this.nudBurstDelay = new System.Windows.Forms.NumericUpDown();
            this.cmdBurst = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblBurstOutstanding = new System.Windows.Forms.Label();
            this.timRefreshLabel = new System.Windows.Forms.Timer(this.components);
            this.lblTotalRequests = new System.Windows.Forms.Label();
            this.lblParallel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudBurstCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBurstDelay)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdStart
            // 
            this.cmdStart.Location = new System.Drawing.Point(198, 31);
            this.cmdStart.Name = "cmdStart";
            this.cmdStart.Size = new System.Drawing.Size(75, 53);
            this.cmdStart.TabIndex = 0;
            this.cmdStart.Text = "START";
            this.cmdStart.UseVisualStyleBackColor = true;
            this.cmdStart.Click += new System.EventHandler(this.cmdStart_Click);
            // 
            // lblDelay
            // 
            this.lblDelay.AutoSize = true;
            this.lblDelay.Location = new System.Drawing.Point(13, 51);
            this.lblDelay.Name = "lblDelay";
            this.lblDelay.Size = new System.Drawing.Size(74, 13);
            this.lblDelay.TabIndex = 1;
            this.lblDelay.Text = "Current Delay:";
            // 
            // nudBurstCount
            // 
            this.nudBurstCount.Location = new System.Drawing.Point(16, 30);
            this.nudBurstCount.Name = "nudBurstCount";
            this.nudBurstCount.Size = new System.Drawing.Size(82, 20);
            this.nudBurstCount.TabIndex = 2;
            this.nudBurstCount.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // nudBurstDelay
            // 
            this.nudBurstDelay.Location = new System.Drawing.Point(16, 56);
            this.nudBurstDelay.Name = "nudBurstDelay";
            this.nudBurstDelay.Size = new System.Drawing.Size(82, 20);
            this.nudBurstDelay.TabIndex = 2;
            this.nudBurstDelay.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // cmdBurst
            // 
            this.cmdBurst.Location = new System.Drawing.Point(199, 30);
            this.cmdBurst.Name = "cmdBurst";
            this.cmdBurst.Size = new System.Drawing.Size(75, 50);
            this.cmdBurst.TabIndex = 3;
            this.cmdBurst.Text = "BURST";
            this.cmdBurst.UseVisualStyleBackColor = true;
            this.cmdBurst.Click += new System.EventHandler(this.cmdBurst_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Requests";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Seconds each";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmdStart);
            this.groupBox1.Controls.Add(this.lblDelay);
            this.groupBox1.Location = new System.Drawing.Point(15, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(294, 100);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Permanent Load";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblBurstOutstanding);
            this.groupBox2.Controls.Add(this.nudBurstCount);
            this.groupBox2.Controls.Add(this.nudBurstDelay);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cmdBurst);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(15, 131);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(294, 109);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "BURST Load";
            // 
            // lblBurstOutstanding
            // 
            this.lblBurstOutstanding.AutoSize = true;
            this.lblBurstOutstanding.Location = new System.Drawing.Point(17, 85);
            this.lblBurstOutstanding.Name = "lblBurstOutstanding";
            this.lblBurstOutstanding.Size = new System.Drawing.Size(64, 13);
            this.lblBurstOutstanding.TabIndex = 5;
            this.lblBurstOutstanding.Text = "Outstanding";
            // 
            // timRefreshLabel
            // 
            this.timRefreshLabel.Interval = 250;
            this.timRefreshLabel.Tick += new System.EventHandler(this.timRefreshLabel_Tick);
            // 
            // lblTotalRequests
            // 
            this.lblTotalRequests.AutoSize = true;
            this.lblTotalRequests.Location = new System.Drawing.Point(15, 247);
            this.lblTotalRequests.Name = "lblTotalRequests";
            this.lblTotalRequests.Size = new System.Drawing.Size(85, 13);
            this.lblTotalRequests.TabIndex = 7;
            this.lblTotalRequests.Text = "Total Requests: ";
            // 
            // lblParallel
            // 
            this.lblParallel.AutoSize = true;
            this.lblParallel.Location = new System.Drawing.Point(15, 261);
            this.lblParallel.Name = "lblParallel";
            this.lblParallel.Size = new System.Drawing.Size(89, 13);
            this.lblParallel.TabIndex = 7;
            this.lblParallel.Text = "Parallel Requests";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 283);
            this.Controls.Add(this.lblParallel);
            this.Controls.Add(this.lblTotalRequests);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudBurstCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBurstDelay)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdStart;
        private System.Windows.Forms.Label lblDelay;
        private System.Windows.Forms.NumericUpDown nudBurstCount;
        private System.Windows.Forms.NumericUpDown nudBurstDelay;
        private System.Windows.Forms.Button cmdBurst;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Timer timRefreshLabel;
        private System.Windows.Forms.Label lblBurstOutstanding;
        private System.Windows.Forms.Label lblTotalRequests;
        private System.Windows.Forms.Label lblParallel;
    }
}