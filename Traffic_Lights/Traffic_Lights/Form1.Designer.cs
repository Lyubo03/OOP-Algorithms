namespace Traffic_Lights
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
            ((System.ComponentModel.ISupportInitialize)(this.picBoxTraffic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMan)).BeginInit();
            this.SuspendLayout();
            // 
            // picBoxTraffic
            // 
            this.picBoxTraffic.Image = global::Traffic_Lights.Properties.Resources.trafficGreen;
            this.picBoxTraffic.Location = new System.Drawing.Point(122, 33);
            this.picBoxTraffic.Name = "picBoxTraffic";
            this.picBoxTraffic.Size = new System.Drawing.Size(108, 309);
            this.picBoxTraffic.TabIndex = 0;
            this.picBoxTraffic.TabStop = false;
            // 
            // picBoxMan
            // 
            this.picBoxMan.Image = global::Traffic_Lights.Properties.Resources.ManRed;
            this.picBoxMan.Location = new System.Drawing.Point(353, 33);
            this.picBoxMan.Name = "picBoxMan";
            this.picBoxMan.Size = new System.Drawing.Size(100, 309);
            this.picBoxMan.TabIndex = 1;
            this.picBoxMan.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 447);
            this.Controls.Add(this.picBoxMan);
            this.Controls.Add(this.picBoxTraffic);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxTraffic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxTraffic;
        private System.Windows.Forms.PictureBox picBoxMan;
    }
}

