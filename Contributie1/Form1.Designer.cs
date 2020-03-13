namespace Contributie1
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
            this.wel = new System.Windows.Forms.CheckBox();
            this.niet = new System.Windows.Forms.CheckBox();
            this.Bereken = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Uitkomst = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(181, 9);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(302, 29);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.Value = new System.DateTime(2020, 3, 13, 0, 0, 0, 0);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(181, 57);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(302, 29);
            this.dateTimePicker2.TabIndex = 1;
            this.dateTimePicker2.Value = new System.DateTime(2020, 3, 13, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Geboorte datum :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Lid geworden :";
            // 
            // wel
            // 
            this.wel.AutoSize = true;
            this.wel.Location = new System.Drawing.Point(17, 103);
            this.wel.Name = "wel";
            this.wel.Size = new System.Drawing.Size(111, 29);
            this.wel.TabIndex = 5;
            this.wel.Text = "Spelend";
            this.wel.UseVisualStyleBackColor = true;
            this.wel.CheckedChanged += new System.EventHandler(this.wel_CheckedChanged);
            // 
            // niet
            // 
            this.niet.AutoSize = true;
            this.niet.Location = new System.Drawing.Point(17, 138);
            this.niet.Name = "niet";
            this.niet.Size = new System.Drawing.Size(146, 29);
            this.niet.TabIndex = 6;
            this.niet.Text = "Niet spelend";
            this.niet.UseVisualStyleBackColor = true;
            this.niet.CheckedChanged += new System.EventHandler(this.niet_CheckedChanged);
            // 
            // Bereken
            // 
            this.Bereken.Location = new System.Drawing.Point(181, 103);
            this.Bereken.Name = "Bereken";
            this.Bereken.Size = new System.Drawing.Size(125, 77);
            this.Bereken.TabIndex = 7;
            this.Bereken.Text = "Bereken Contributie";
            this.Bereken.UseVisualStyleBackColor = true;
            this.Bereken.Click += new System.EventHandler(this.Bereken_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(154, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "contributie prijs :";
            // 
            // Uitkomst
            // 
            this.Uitkomst.AutoSize = true;
            this.Uitkomst.Location = new System.Drawing.Point(312, 183);
            this.Uitkomst.Name = "Uitkomst";
            this.Uitkomst.Size = new System.Drawing.Size(0, 25);
            this.Uitkomst.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Uitkomst);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Bereken);
            this.Controls.Add(this.niet);
            this.Controls.Add(this.wel);
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
        private System.Windows.Forms.CheckBox wel;
        private System.Windows.Forms.CheckBox niet;
        private System.Windows.Forms.Button Bereken;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Uitkomst;
    }
}

