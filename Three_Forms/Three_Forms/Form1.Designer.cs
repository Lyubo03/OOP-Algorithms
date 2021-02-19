namespace Three_Forms
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
            this.btnModal = new System.Windows.Forms.Button();
            this.btnNonModal = new System.Windows.Forms.Button();
            this.lblFirstForm = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnModal
            // 
            this.btnModal.Location = new System.Drawing.Point(12, 97);
            this.btnModal.Name = "btnModal";
            this.btnModal.Size = new System.Drawing.Size(78, 62);
            this.btnModal.TabIndex = 0;
            this.btnModal.Text = "Modal Form";
            this.btnModal.UseVisualStyleBackColor = true;
            this.btnModal.Click += new System.EventHandler(this.btnModal_Click);
            // 
            // btnNonModal
            // 
            this.btnNonModal.Location = new System.Drawing.Point(204, 97);
            this.btnNonModal.Name = "btnNonModal";
            this.btnNonModal.Size = new System.Drawing.Size(95, 62);
            this.btnNonModal.TabIndex = 1;
            this.btnNonModal.Text = "Non-Modal Form";
            this.btnNonModal.UseVisualStyleBackColor = true;
            this.btnNonModal.Click += new System.EventHandler(this.btnNonModal_Click);
            // 
            // lblFirstForm
            // 
            this.lblFirstForm.AutoSize = true;
            this.lblFirstForm.Location = new System.Drawing.Point(123, 9);
            this.lblFirstForm.Name = "lblFirstForm";
            this.lblFirstForm.Size = new System.Drawing.Size(71, 17);
            this.lblFirstForm.TabIndex = 2;
            this.lblFirstForm.Text = "First Form";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 171);
            this.Controls.Add(this.lblFirstForm);
            this.Controls.Add(this.btnNonModal);
            this.Controls.Add(this.btnModal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnModal;
        private System.Windows.Forms.Button btnNonModal;
        private System.Windows.Forms.Label lblFirstForm;
    }
}

