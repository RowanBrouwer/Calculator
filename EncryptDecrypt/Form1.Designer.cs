namespace EncryptDecrypt
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
            this.encrypter = new System.Windows.Forms.Button();
            this.Decrypter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // encrypter
            // 
            this.encrypter.BackColor = System.Drawing.Color.DimGray;
            this.encrypter.ForeColor = System.Drawing.Color.GreenYellow;
            this.encrypter.Location = new System.Drawing.Point(12, 12);
            this.encrypter.Name = "encrypter";
            this.encrypter.Size = new System.Drawing.Size(153, 83);
            this.encrypter.TabIndex = 0;
            this.encrypter.Text = "Encrypt";
            this.encrypter.UseVisualStyleBackColor = false;
            this.encrypter.Click += new System.EventHandler(this.oncrypter_Click);
            // 
            // Decrypter
            // 
            this.Decrypter.BackColor = System.Drawing.Color.DimGray;
            this.Decrypter.ForeColor = System.Drawing.Color.GreenYellow;
            this.Decrypter.Location = new System.Drawing.Point(171, 12);
            this.Decrypter.Name = "Decrypter";
            this.Decrypter.Size = new System.Drawing.Size(153, 83);
            this.Decrypter.TabIndex = 1;
            this.Decrypter.Text = "Decrypt";
            this.Decrypter.UseVisualStyleBackColor = false;
            this.Decrypter.Click += new System.EventHandler(this.Decrypter_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(336, 105);
            this.Controls.Add(this.Decrypter);
            this.Controls.Add(this.encrypter);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button encrypter;
        private System.Windows.Forms.Button Decrypter;
    }
}

