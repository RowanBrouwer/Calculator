namespace Waterverbruik
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
            this.kubiek = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Bereken = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tarief1 = new System.Windows.Forms.Label();
            this.tarief2 = new System.Windows.Forms.Label();
            this.uitkomst = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // kubiek
            // 
            this.kubiek.Location = new System.Drawing.Point(271, 9);
            this.kubiek.Name = "kubiek";
            this.kubiek.Size = new System.Drawing.Size(147, 29);
            this.kubiek.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Verbruik in kubieke meters :";
            // 
            // Bereken
            // 
            this.Bereken.Location = new System.Drawing.Point(228, 44);
            this.Bereken.Name = "Bereken";
            this.Bereken.Size = new System.Drawing.Size(190, 66);
            this.Bereken.TabIndex = 3;
            this.Bereken.Text = "Bereken";
            this.Bereken.UseVisualStyleBackColor = true;
            this.Bereken.Click += new System.EventHandler(this.Bereken_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kosten Tarief 1 :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Kosten Tarief 2 :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Goedkoopste optie :";
            // 
            // tarief1
            // 
            this.tarief1.AutoSize = true;
            this.tarief1.Location = new System.Drawing.Point(174, 146);
            this.tarief1.Name = "tarief1";
            this.tarief1.Size = new System.Drawing.Size(0, 25);
            this.tarief1.TabIndex = 7;
            // 
            // tarief2
            // 
            this.tarief2.AutoSize = true;
            this.tarief2.Location = new System.Drawing.Point(174, 198);
            this.tarief2.Name = "tarief2";
            this.tarief2.Size = new System.Drawing.Size(0, 25);
            this.tarief2.TabIndex = 8;
            // 
            // uitkomst
            // 
            this.uitkomst.AutoSize = true;
            this.uitkomst.Location = new System.Drawing.Point(205, 251);
            this.uitkomst.Name = "uitkomst";
            this.uitkomst.Size = new System.Drawing.Size(0, 25);
            this.uitkomst.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.uitkomst);
            this.Controls.Add(this.tarief2);
            this.Controls.Add(this.tarief1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Bereken);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kubiek);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox kubiek;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Bereken;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label tarief1;
        private System.Windows.Forms.Label tarief2;
        private System.Windows.Forms.Label uitkomst;
    }
}

