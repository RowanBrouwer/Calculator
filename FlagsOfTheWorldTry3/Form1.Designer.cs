﻿namespace FlagsOfTheWorldTry3
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.next = new System.Windows.Forms.Button();
            this.country = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.beantwoord = new System.Windows.Forms.Button();
            this.CorAwnser = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(14, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(328, 206);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // next
            // 
            this.next.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.next.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.next.ForeColor = System.Drawing.Color.Yellow;
            this.next.Location = new System.Drawing.Point(85, 224);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(190, 100);
            this.next.TabIndex = 1;
            this.next.Text = "Next";
            this.next.UseVisualStyleBackColor = false;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // country
            // 
            this.country.AutoSize = true;
            this.country.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.country.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.country.Location = new System.Drawing.Point(79, 343);
            this.country.Name = "country";
            this.country.Size = new System.Drawing.Size(0, 32);
            this.country.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(85, 595);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(190, 29);
            this.textBox1.TabIndex = 3;
            // 
            // beantwoord
            // 
            this.beantwoord.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.beantwoord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beantwoord.ForeColor = System.Drawing.Color.Yellow;
            this.beantwoord.Location = new System.Drawing.Point(85, 468);
            this.beantwoord.Name = "beantwoord";
            this.beantwoord.Size = new System.Drawing.Size(190, 100);
            this.beantwoord.TabIndex = 4;
            this.beantwoord.Text = "Awnser";
            this.beantwoord.UseVisualStyleBackColor = false;
            this.beantwoord.Click += new System.EventHandler(this.beantwoord_Click);
            // 
            // CorAwnser
            // 
            this.CorAwnser.AutoSize = true;
            this.CorAwnser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CorAwnser.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CorAwnser.Location = new System.Drawing.Point(79, 395);
            this.CorAwnser.Name = "CorAwnser";
            this.CorAwnser.Size = new System.Drawing.Size(0, 32);
            this.CorAwnser.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(356, 656);
            this.Controls.Add(this.CorAwnser);
            this.Controls.Add(this.beantwoord);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.country);
            this.Controls.Add(this.next);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.Label country;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button beantwoord;
        private System.Windows.Forms.Label CorAwnser;
    }
}

