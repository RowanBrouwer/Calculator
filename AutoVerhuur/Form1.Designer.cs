namespace AutoVerhuur
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.akm = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Bereken = new System.Windows.Forms.Button();
            this.uitkomst = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.psa = new System.Windows.Forms.CheckBox();
            this.psb = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dagen = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(126, 57);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(293, 29);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(126, 181);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(293, 29);
            this.dateTimePicker2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Begin huur :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Eind huur :";
            // 
            // akm
            // 
            this.akm.Location = new System.Drawing.Point(126, 216);
            this.akm.Name = "akm";
            this.akm.Size = new System.Drawing.Size(136, 29);
            this.akm.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Aantal km :";
            // 
            // Bereken
            // 
            this.Bereken.Location = new System.Drawing.Point(301, 314);
            this.Bereken.Name = "Bereken";
            this.Bereken.Size = new System.Drawing.Size(118, 69);
            this.Bereken.TabIndex = 6;
            this.Bereken.Text = "Bereken";
            this.Bereken.UseVisualStyleBackColor = true;
            this.Bereken.Click += new System.EventHandler(this.Bereken_Click);
            // 
            // uitkomst
            // 
            this.uitkomst.AutoSize = true;
            this.uitkomst.Location = new System.Drawing.Point(296, 406);
            this.uitkomst.Name = "uitkomst";
            this.uitkomst.Size = new System.Drawing.Size(0, 25);
            this.uitkomst.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(205, 406);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Kosten :";
            // 
            // psa
            // 
            this.psa.AutoSize = true;
            this.psa.Location = new System.Drawing.Point(12, 283);
            this.psa.Name = "psa";
            this.psa.Size = new System.Drawing.Size(160, 29);
            this.psa.TabIndex = 9;
            this.psa.Text = "Personenauto";
            this.psa.UseVisualStyleBackColor = true;
            // 
            // psb
            // 
            this.psb.AutoSize = true;
            this.psb.Location = new System.Drawing.Point(12, 314);
            this.psb.Name = "psb";
            this.psb.Size = new System.Drawing.Size(169, 29);
            this.psb.TabIndex = 10;
            this.psb.Text = "Personenbusje";
            this.psb.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(134, 453);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Dagen Gehuurd :";
            // 
            // dagen
            // 
            this.dagen.AutoSize = true;
            this.dagen.Location = new System.Drawing.Point(302, 453);
            this.dagen.Name = "dagen";
            this.dagen.Size = new System.Drawing.Size(0, 25);
            this.dagen.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 571);
            this.Controls.Add(this.dagen);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.psb);
            this.Controls.Add(this.psa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.uitkomst);
            this.Controls.Add(this.Bereken);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.akm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox akm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Bereken;
        private System.Windows.Forms.Label uitkomst;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox psa;
        private System.Windows.Forms.CheckBox psb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label dagen;
    }
}

