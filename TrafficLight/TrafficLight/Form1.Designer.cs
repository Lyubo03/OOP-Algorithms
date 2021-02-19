namespace TrafficLight
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.picBoxMen = new System.Windows.Forms.PictureBox();
            this.picBoxTraffic = new System.Windows.Forms.PictureBox();
            this.lblText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxTraffic)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // picBoxMen
            // 
            this.picBoxMen.Image = global::TrafficLight.Properties.Resources.ManRed;
            this.picBoxMen.Location = new System.Drawing.Point(305, 12);
            this.picBoxMen.Name = "picBoxMen";
            this.picBoxMen.Size = new System.Drawing.Size(100, 283);
            this.picBoxMen.TabIndex = 1;
            this.picBoxMen.TabStop = false;
            // 
            // picBoxTraffic
            // 
            this.picBoxTraffic.Image = global::TrafficLight.Properties.Resources.trafficGreen;
            this.picBoxTraffic.Location = new System.Drawing.Point(78, 12);
            this.picBoxTraffic.Name = "picBoxTraffic";
            this.picBoxTraffic.Size = new System.Drawing.Size(102, 313);
            this.picBoxTraffic.TabIndex = 0;
            this.picBoxTraffic.TabStop = false;
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(336, 312);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(0, 10);
            this.lblText.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 352);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.picBoxMen);
            this.Controls.Add(this.picBoxTraffic);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxTraffic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox picBoxTraffic;
        private System.Windows.Forms.PictureBox picBoxMen;
        private System.Windows.Forms.Label lblText;
    }
}

