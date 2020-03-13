namespace HoutHandel
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
            this.label1 = new System.Windows.Forms.Label();
            this.meerdan14 = new System.Windows.Forms.CheckBox();
            this.meerdan21 = new System.Windows.Forms.CheckBox();
            this.meerdan28 = new System.Windows.Forms.CheckBox();
            this.Bereken = new System.Windows.Forms.Button();
            this.klas1 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.klas2 = new System.Windows.Forms.CheckBox();
            this.klas3 = new System.Windows.Forms.CheckBox();
            this.aantalm3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.plaatdikte = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.uitkomst = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "levertijd";
            // 
            // meerdan14
            // 
            this.meerdan14.AutoSize = true;
            this.meerdan14.Location = new System.Drawing.Point(3, 44);
            this.meerdan14.Name = "meerdan14";
            this.meerdan14.Size = new System.Drawing.Size(173, 29);
            this.meerdan14.TabIndex = 1;
            this.meerdan14.Text = "14 tot 21 dagen";
            this.meerdan14.UseVisualStyleBackColor = true;
            this.meerdan14.CheckedChanged += new System.EventHandler(this.meerdan14_CheckedChanged);
            // 
            // meerdan21
            // 
            this.meerdan21.AutoSize = true;
            this.meerdan21.Location = new System.Drawing.Point(3, 79);
            this.meerdan21.Name = "meerdan21";
            this.meerdan21.Size = new System.Drawing.Size(173, 29);
            this.meerdan21.TabIndex = 2;
            this.meerdan21.Text = "21 tot 28 dagen";
            this.meerdan21.UseVisualStyleBackColor = true;
            this.meerdan21.CheckedChanged += new System.EventHandler(this.meerdan21_CheckedChanged);
            // 
            // meerdan28
            // 
            this.meerdan28.AutoSize = true;
            this.meerdan28.Location = new System.Drawing.Point(3, 114);
            this.meerdan28.Name = "meerdan28";
            this.meerdan28.Size = new System.Drawing.Size(207, 29);
            this.meerdan28.TabIndex = 3;
            this.meerdan28.Text = "meer dan 28 dagen";
            this.meerdan28.UseVisualStyleBackColor = true;
            this.meerdan28.CheckedChanged += new System.EventHandler(this.meerdan28_CheckedChanged);
            // 
            // Bereken
            // 
            this.Bereken.Location = new System.Drawing.Point(381, 306);
            this.Bereken.Name = "Bereken";
            this.Bereken.Size = new System.Drawing.Size(120, 91);
            this.Bereken.TabIndex = 4;
            this.Bereken.Text = "Bereken";
            this.Bereken.UseVisualStyleBackColor = true;
            this.Bereken.Click += new System.EventHandler(this.Bereken_Click);
            // 
            // klas1
            // 
            this.klas1.AutoSize = true;
            this.klas1.Location = new System.Drawing.Point(302, 44);
            this.klas1.Name = "klas1";
            this.klas1.Size = new System.Drawing.Size(110, 29);
            this.klas1.TabIndex = 5;
            this.klas1.Text = "klasse 1";
            this.klas1.UseVisualStyleBackColor = true;
            this.klas1.CheckedChanged += new System.EventHandler(this.klas1_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(296, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 32);
            this.label2.TabIndex = 6;
            this.label2.Text = "Hout klasse";
            // 
            // klas2
            // 
            this.klas2.AutoSize = true;
            this.klas2.Location = new System.Drawing.Point(302, 79);
            this.klas2.Name = "klas2";
            this.klas2.Size = new System.Drawing.Size(110, 29);
            this.klas2.TabIndex = 7;
            this.klas2.Text = "klasse 2";
            this.klas2.UseVisualStyleBackColor = true;
            this.klas2.CheckedChanged += new System.EventHandler(this.klas2_CheckedChanged);
            // 
            // klas3
            // 
            this.klas3.AutoSize = true;
            this.klas3.Location = new System.Drawing.Point(302, 114);
            this.klas3.Name = "klas3";
            this.klas3.Size = new System.Drawing.Size(110, 29);
            this.klas3.TabIndex = 8;
            this.klas3.Text = "klasse 3";
            this.klas3.UseVisualStyleBackColor = true;
            this.klas3.CheckedChanged += new System.EventHandler(this.klas3_CheckedChanged);
            // 
            // aantalm3
            // 
            this.aantalm3.Location = new System.Drawing.Point(335, 161);
            this.aantalm3.Name = "aantalm3";
            this.aantalm3.Size = new System.Drawing.Size(172, 29);
            this.aantalm3.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(311, 32);
            this.label3.TabIndex = 10;
            this.label3.Text = "Aantal kubieke meters :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(88, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(235, 32);
            this.label4.TabIndex = 11;
            this.label4.Text = "plaat dikte in cm :";
            // 
            // plaatdikte
            // 
            this.plaatdikte.Location = new System.Drawing.Point(335, 195);
            this.plaatdikte.Name = "plaatdikte";
            this.plaatdikte.Size = new System.Drawing.Size(172, 29);
            this.plaatdikte.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(441, 400);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "Prijs :";
            // 
            // uitkomst
            // 
            this.uitkomst.AutoSize = true;
            this.uitkomst.Location = new System.Drawing.Point(507, 400);
            this.uitkomst.Name = "uitkomst";
            this.uitkomst.Size = new System.Drawing.Size(0, 25);
            this.uitkomst.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.uitkomst);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.plaatdikte);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.aantalm3);
            this.Controls.Add(this.klas3);
            this.Controls.Add(this.klas2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.klas1);
            this.Controls.Add(this.Bereken);
            this.Controls.Add(this.meerdan28);
            this.Controls.Add(this.meerdan21);
            this.Controls.Add(this.meerdan14);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox meerdan14;
        private System.Windows.Forms.CheckBox meerdan21;
        private System.Windows.Forms.CheckBox meerdan28;
        private System.Windows.Forms.Button Bereken;
        private System.Windows.Forms.CheckBox klas1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox klas2;
        private System.Windows.Forms.CheckBox klas3;
        private System.Windows.Forms.TextBox aantalm3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox plaatdikte;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label uitkomst;
    }
}

