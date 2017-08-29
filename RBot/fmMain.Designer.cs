namespace RBot
{
    partial class fmMain
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
            this.btnStart = new System.Windows.Forms.Button();
            this.imgBox = new Emgu.CV.UI.ImageBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.tbEdge_1 = new System.Windows.Forms.TrackBar();
            this.tbEdge_2 = new System.Windows.Forms.TrackBar();
            this.tbMaxLineGap = new System.Windows.Forms.TrackBar();
            this.tbMinLineLen = new System.Windows.Forms.TrackBar();
            this.tbLinePixel = new System.Windows.Forms.TrackBar();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbEdge_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbEdge_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMaxLineGap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMinLineLen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbLinePixel)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.Location = new System.Drawing.Point(500, 638);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // imgBox
            // 
            this.imgBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imgBox.Location = new System.Drawing.Point(-1, 3);
            this.imgBox.Name = "imgBox";
            this.imgBox.Size = new System.Drawing.Size(656, 388);
            this.imgBox.TabIndex = 2;
            this.imgBox.TabStop = false;
            // 
            // btnStop
            // 
            this.btnStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStop.Location = new System.Drawing.Point(578, 638);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 3;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(12, 616);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(35, 13);
            this.lblInfo.TabIndex = 4;
            this.lblInfo.Text = "label1";
            // 
            // tbEdge_1
            // 
            this.tbEdge_1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbEdge_1.Location = new System.Drawing.Point(-1, 397);
            this.tbEdge_1.Maximum = 500;
            this.tbEdge_1.Name = "tbEdge_1";
            this.tbEdge_1.Size = new System.Drawing.Size(656, 45);
            this.tbEdge_1.TabIndex = 5;
            this.tbEdge_1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbEdge_1.Value = 125;
            // 
            // tbEdge_2
            // 
            this.tbEdge_2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbEdge_2.Location = new System.Drawing.Point(-1, 426);
            this.tbEdge_2.Maximum = 500;
            this.tbEdge_2.Name = "tbEdge_2";
            this.tbEdge_2.Size = new System.Drawing.Size(656, 45);
            this.tbEdge_2.TabIndex = 6;
            this.tbEdge_2.Value = 240;
            // 
            // tbMaxLineGap
            // 
            this.tbMaxLineGap.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMaxLineGap.Location = new System.Drawing.Point(-3, 533);
            this.tbMaxLineGap.Maximum = 20;
            this.tbMaxLineGap.Name = "tbMaxLineGap";
            this.tbMaxLineGap.Size = new System.Drawing.Size(656, 45);
            this.tbMaxLineGap.TabIndex = 8;
            this.tbMaxLineGap.Value = 5;
            // 
            // tbMinLineLen
            // 
            this.tbMinLineLen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMinLineLen.Location = new System.Drawing.Point(-3, 504);
            this.tbMinLineLen.Maximum = 100;
            this.tbMinLineLen.Name = "tbMinLineLen";
            this.tbMinLineLen.Size = new System.Drawing.Size(656, 45);
            this.tbMinLineLen.TabIndex = 7;
            this.tbMinLineLen.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbMinLineLen.Value = 20;
            // 
            // tbLinePixel
            // 
            this.tbLinePixel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbLinePixel.Location = new System.Drawing.Point(-3, 477);
            this.tbLinePixel.Maximum = 100;
            this.tbLinePixel.Name = "tbLinePixel";
            this.tbLinePixel.Size = new System.Drawing.Size(656, 45);
            this.tbLinePixel.TabIndex = 9;
            this.tbLinePixel.Value = 10;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(567, 606);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 663);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbMaxLineGap);
            this.Controls.Add(this.tbEdge_2);
            this.Controls.Add(this.tbEdge_1);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.imgBox);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.tbMinLineLen);
            this.Controls.Add(this.tbLinePixel);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.imgBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbEdge_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbEdge_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMaxLineGap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMinLineLen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbLinePixel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private Emgu.CV.UI.ImageBox imgBox;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.TrackBar tbEdge_1;
        private System.Windows.Forms.TrackBar tbEdge_2;
        private System.Windows.Forms.TrackBar tbMaxLineGap;
        private System.Windows.Forms.TrackBar tbMinLineLen;
        private System.Windows.Forms.TrackBar tbLinePixel;
        private System.Windows.Forms.Button button1;
    }
}

