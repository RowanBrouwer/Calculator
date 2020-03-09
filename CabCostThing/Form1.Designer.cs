namespace CabCostThing
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
            this.vdatum = new System.Windows.Forms.DateTimePicker();
            this.adatum = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.vTime = new System.Windows.Forms.DateTimePicker();
            this.aTime = new System.Windows.Forms.DateTimePicker();
            this.bereken = new System.Windows.Forms.Button();
            this.kostendis = new System.Windows.Forms.Label();
            this.aakm = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // vdatum
            // 
            this.vdatum.Location = new System.Drawing.Point(181, 27);
            this.vdatum.Name = "vdatum";
            this.vdatum.Size = new System.Drawing.Size(333, 29);
            this.vdatum.TabIndex = 0;
            // 
            // adatum
            // 
            this.adatum.Location = new System.Drawing.Point(181, 268);
            this.adatum.Name = "adatum";
            this.adatum.Size = new System.Drawing.Size(333, 29);
            this.adatum.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Vertrek Datum : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-3, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Aankomst Datum : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Vertrek Tijd : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-3, 320);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Aankomst Tijd : ";
            // 
            // vTime
            // 
            this.vTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.vTime.Location = new System.Drawing.Point(181, 73);
            this.vTime.Name = "vTime";
            this.vTime.ShowUpDown = true;
            this.vTime.Size = new System.Drawing.Size(111, 29);
            this.vTime.TabIndex = 6;
            // 
            // aTime
            // 
            this.aTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.aTime.Location = new System.Drawing.Point(181, 316);
            this.aTime.Name = "aTime";
            this.aTime.ShowUpDown = true;
            this.aTime.Size = new System.Drawing.Size(111, 29);
            this.aTime.TabIndex = 7;
            // 
            // bereken
            // 
            this.bereken.Location = new System.Drawing.Point(391, 460);
            this.bereken.Name = "bereken";
            this.bereken.Size = new System.Drawing.Size(123, 57);
            this.bereken.TabIndex = 8;
            this.bereken.Text = "Bereken";
            this.bereken.UseVisualStyleBackColor = true;
            this.bereken.Click += new System.EventHandler(this.bereken_Click);
            // 
            // kostendis
            // 
            this.kostendis.AutoSize = true;
            this.kostendis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kostendis.Location = new System.Drawing.Point(385, 530);
            this.kostendis.Name = "kostendis";
            this.kostendis.Size = new System.Drawing.Size(0, 32);
            this.kostendis.TabIndex = 9;
            // 
            // aakm
            // 
            this.aakm.Location = new System.Drawing.Point(171, 413);
            this.aakm.Name = "aakm";
            this.aakm.Size = new System.Drawing.Size(121, 29);
            this.aakm.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 417);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Aantal km\'s : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(261, 530);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 32);
            this.label6.TabIndex = 12;
            this.label6.Text = "Ritprijs :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 622);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.aakm);
            this.Controls.Add(this.kostendis);
            this.Controls.Add(this.bereken);
            this.Controls.Add(this.aTime);
            this.Controls.Add(this.vTime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.adatum);
            this.Controls.Add(this.vdatum);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker vdatum;
        private System.Windows.Forms.DateTimePicker adatum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker vTime;
        private System.Windows.Forms.DateTimePicker aTime;
        private System.Windows.Forms.Button bereken;
        private System.Windows.Forms.Label kostendis;
        private System.Windows.Forms.TextBox aakm;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

