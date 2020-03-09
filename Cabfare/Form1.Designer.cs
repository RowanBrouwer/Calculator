namespace CabFare
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
            this.button1 = new System.Windows.Forms.Button();
            this.DateVertrek = new System.Windows.Forms.DateTimePicker();
            this.DateAankomst = new System.Windows.Forms.DateTimePicker();
            this.Vertrek = new System.Windows.Forms.Label();
            this.Aankomst = new System.Windows.Forms.Label();
            this.TimeVertrek = new System.Windows.Forms.DateTimePicker();
            this.TimeAankomst = new System.Windows.Forms.DateTimePicker();
            this.Awnser = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 373);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 65);
            this.button1.TabIndex = 0;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DateVertrek
            // 
            this.DateVertrek.Location = new System.Drawing.Point(12, 30);
            this.DateVertrek.Name = "DateVertrek";
            this.DateVertrek.Size = new System.Drawing.Size(200, 20);
            this.DateVertrek.TabIndex = 2;
            this.DateVertrek.ValueChanged += new System.EventHandler(this.DateVertrek_ValueChanged);
            // 
            // DateAankomst
            // 
            this.DateAankomst.Location = new System.Drawing.Point(12, 109);
            this.DateAankomst.Name = "DateAankomst";
            this.DateAankomst.Size = new System.Drawing.Size(200, 20);
            this.DateAankomst.TabIndex = 3;
            this.DateAankomst.ValueChanged += new System.EventHandler(this.DateAankomst_ValueChanged);
            // 
            // Vertrek
            // 
            this.Vertrek.AutoSize = true;
            this.Vertrek.Location = new System.Drawing.Point(9, 14);
            this.Vertrek.Name = "Vertrek";
            this.Vertrek.Size = new System.Drawing.Size(41, 13);
            this.Vertrek.TabIndex = 4;
            this.Vertrek.Text = "Vertrek";
            // 
            // Aankomst
            // 
            this.Aankomst.AutoSize = true;
            this.Aankomst.Location = new System.Drawing.Point(12, 90);
            this.Aankomst.Name = "Aankomst";
            this.Aankomst.Size = new System.Drawing.Size(54, 13);
            this.Aankomst.TabIndex = 5;
            this.Aankomst.Text = "Aankomst";
            // 
            // TimeVertrek
            // 
            this.TimeVertrek.CustomFormat = "HH:mm";
            this.TimeVertrek.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TimeVertrek.Location = new System.Drawing.Point(12, 56);
            this.TimeVertrek.Name = "TimeVertrek";
            this.TimeVertrek.Size = new System.Drawing.Size(54, 20);
            this.TimeVertrek.TabIndex = 6;
            this.TimeVertrek.Value = new System.DateTime(2020, 2, 18, 13, 58, 41, 0);
            this.TimeVertrek.ValueChanged += new System.EventHandler(this.TimeVertrek_ValueChanged);
            // 
            // TimeAankomst
            // 
            this.TimeAankomst.CustomFormat = "HH:mm";
            this.TimeAankomst.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TimeAankomst.Location = new System.Drawing.Point(12, 135);
            this.TimeAankomst.Name = "TimeAankomst";
            this.TimeAankomst.Size = new System.Drawing.Size(54, 20);
            this.TimeAankomst.TabIndex = 7;
            this.TimeAankomst.ValueChanged += new System.EventHandler(this.TimeAankomst_ValueChanged);
            // 
            // Awnser
            // 
            this.Awnser.AutoSize = true;
            this.Awnser.Location = new System.Drawing.Point(146, 373);
            this.Awnser.Name = "Awnser";
            this.Awnser.Size = new System.Drawing.Size(0, 13);
            this.Awnser.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 450);
            this.Controls.Add(this.Awnser);
            this.Controls.Add(this.TimeAankomst);
            this.Controls.Add(this.TimeVertrek);
            this.Controls.Add(this.Aankomst);
            this.Controls.Add(this.Vertrek);
            this.Controls.Add(this.DateAankomst);
            this.Controls.Add(this.DateVertrek);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker DateVertrek;
        private System.Windows.Forms.DateTimePicker DateAankomst;
        private System.Windows.Forms.Label Vertrek;
        private System.Windows.Forms.Label Aankomst;
        private System.Windows.Forms.DateTimePicker TimeVertrek;
        private System.Windows.Forms.DateTimePicker TimeAankomst;
        private System.Windows.Forms.Label Awnser;
    }
}

