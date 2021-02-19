namespace BS_Game
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lblStartGame = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblClose = new System.Windows.Forms.Label();
            this.btnEnglish = new System.Windows.Forms.Button();
            this.btnBulgarian = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblStartGame
            // 
            this.lblStartGame.AutoSize = true;
            this.lblStartGame.BackColor = System.Drawing.Color.Transparent;
            this.lblStartGame.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblStartGame.Location = new System.Drawing.Point(24, 31);
            this.lblStartGame.Name = "lblStartGame";
            this.lblStartGame.Size = new System.Drawing.Size(80, 17);
            this.lblStartGame.TabIndex = 0;
            this.lblStartGame.Text = "Start Game";
            this.lblStartGame.MouseLeave += new System.EventHandler(this.lblStartGame_MouseLeave);
            this.lblStartGame.MouseHover += new System.EventHandler(this.lblStartGame_MouseHover);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblInfo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblInfo.Location = new System.Drawing.Point(24, 93);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(81, 17);
            this.lblInfo.TabIndex = 1;
            this.lblInfo.Text = "How to play";
            this.lblInfo.MouseLeave += new System.EventHandler(this.lblInfo_MouseLeave);
            this.lblInfo.MouseHover += new System.EventHandler(this.lblInfo_MouseHover);
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.BackColor = System.Drawing.Color.Transparent;
            this.lblClose.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblClose.Location = new System.Drawing.Point(24, 155);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(43, 17);
            this.lblClose.TabIndex = 2;
            this.lblClose.Text = "Close";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            this.lblClose.MouseLeave += new System.EventHandler(this.lblClose_MouseLeave);
            this.lblClose.MouseHover += new System.EventHandler(this.lblClose_MouseHover);
            // 
            // btnEnglish
            // 
            this.btnEnglish.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEnglish.BackgroundImage")));
            this.btnEnglish.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEnglish.Location = new System.Drawing.Point(689, 12);
            this.btnEnglish.Name = "btnEnglish";
            this.btnEnglish.Size = new System.Drawing.Size(75, 55);
            this.btnEnglish.TabIndex = 3;
            this.btnEnglish.UseVisualStyleBackColor = true;
            this.btnEnglish.Click += new System.EventHandler(this.btnEnglish_Click);
            // 
            // btnBulgarian
            // 
            this.btnBulgarian.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBulgarian.BackgroundImage")));
            this.btnBulgarian.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBulgarian.Location = new System.Drawing.Point(608, 12);
            this.btnBulgarian.Name = "btnBulgarian";
            this.btnBulgarian.Size = new System.Drawing.Size(75, 55);
            this.btnBulgarian.TabIndex = 4;
            this.btnBulgarian.UseVisualStyleBackColor = true;
            this.btnBulgarian.Click += new System.EventHandler(this.btnBulgarian_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBulgarian);
            this.Controls.Add(this.btnEnglish);
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblStartGame);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStartGame;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Button btnEnglish;
        private System.Windows.Forms.Button btnBulgarian;
    }
}

