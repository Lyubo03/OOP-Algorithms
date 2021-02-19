namespace Traffic
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
            this.picBoxTraffic = new System.Windows.Forms.PictureBox();
            this.picBoxMan = new System.Windows.Forms.PictureBox();
            this.lblText = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxTraffic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMan)).BeginInit();
            this.SuspendLayout();
            // 
            // picBoxTraffic
            // 
            this.picBoxTraffic.Image = global::Traffic.Properties.Resources.trafficGreen;
            this.picBoxTraffic.Location = new System.Drawing.Point(46, 74);
            this.picBoxTraffic.Name = "picBoxTraffic";
            this.picBoxTraffic.Size = new System.Drawing.Size(108, 314);
            this.picBoxTraffic.TabIndex = 0;
            this.picBoxTraffic.TabStop = false;
            // 
            // picBoxMan
            // 
            this.picBoxMan.Image = global::Traffic.Properties.Resources.ManRed;
            this.picBoxMan.Location = new System.Drawing.Point(306, 74);
            this.picBoxMan.Name = "picBoxMan";
            this.picBoxMan.Size = new System.Drawing.Size(100, 314);
            this.picBoxMan.TabIndex = 1;
            this.picBoxMan.TabStop = false;
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(315, 416);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(74, 13);
            this.lblText.TabIndex = 2;
            this.lblText.Text = "Не пресичай!";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(89, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(331, 12);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 4;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 487);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.picBoxMan);
            this.Controls.Add(this.picBoxTraffic);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxTraffic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxTraffic;
        private System.Windows.Forms.PictureBox picBoxMan;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnStop;
    }
}

