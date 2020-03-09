namespace TransportWeightAndVolumeCalculations
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
            this.Bereken = new System.Windows.Forms.Button();
            this.cubiekemeters = new System.Windows.Forms.TextBox();
            this.kilogram = new System.Windows.Forms.TextBox();
            this.bldp = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Buitenland = new System.Windows.Forms.Label();
            this.vervoerskosten = new System.Windows.Forms.Label();
            this.kilometers = new System.Windows.Forms.TextBox();
            this.kilomtrtag = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.vloeibaardp = new System.Windows.Forms.ComboBox();
            this.vloeibaartag = new System.Windows.Forms.Label();
            this.Bkm = new System.Windows.Forms.TextBox();
            this.buitenlandsekm = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Bereken
            // 
            this.Bereken.Location = new System.Drawing.Point(374, 12);
            this.Bereken.Name = "Bereken";
            this.Bereken.Size = new System.Drawing.Size(147, 69);
            this.Bereken.TabIndex = 0;
            this.Bereken.Text = "Bereken";
            this.Bereken.UseVisualStyleBackColor = true;
            this.Bereken.Click += new System.EventHandler(this.Bereken_Click);
            // 
            // cubiekemeters
            // 
            this.cubiekemeters.Location = new System.Drawing.Point(12, 12);
            this.cubiekemeters.Name = "cubiekemeters";
            this.cubiekemeters.Size = new System.Drawing.Size(149, 29);
            this.cubiekemeters.TabIndex = 1;
            // 
            // kilogram
            // 
            this.kilogram.Location = new System.Drawing.Point(12, 47);
            this.kilogram.Name = "kilogram";
            this.kilogram.Size = new System.Drawing.Size(149, 29);
            this.kilogram.TabIndex = 2;
            // 
            // bldp
            // 
            this.bldp.FormattingEnabled = true;
            this.bldp.Items.AddRange(new object[] {
            "Ja"});
            this.bldp.Location = new System.Drawing.Point(12, 210);
            this.bldp.Name = "bldp";
            this.bldp.Size = new System.Drawing.Size(148, 32);
            this.bldp.TabIndex = 3;
            this.bldp.Text = "Nee";
            this.bldp.SelectedIndexChanged += new System.EventHandler(this.bldp_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(167, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = " : Kubieke meters";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(167, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = ": Kilogram";
            // 
            // Buitenland
            // 
            this.Buitenland.AutoSize = true;
            this.Buitenland.Location = new System.Drawing.Point(7, 182);
            this.Buitenland.Name = "Buitenland";
            this.Buitenland.Size = new System.Drawing.Size(104, 25);
            this.Buitenland.TabIndex = 6;
            this.Buitenland.Text = "Buitenland";
            // 
            // vervoerskosten
            // 
            this.vervoerskosten.AutoSize = true;
            this.vervoerskosten.Location = new System.Drawing.Point(527, 84);
            this.vervoerskosten.Name = "vervoerskosten";
            this.vervoerskosten.Size = new System.Drawing.Size(0, 25);
            this.vervoerskosten.TabIndex = 7;
            // 
            // kilometers
            // 
            this.kilometers.Location = new System.Drawing.Point(12, 134);
            this.kilometers.Name = "kilometers";
            this.kilometers.Size = new System.Drawing.Size(149, 29);
            this.kilometers.TabIndex = 8;
            // 
            // kilomtrtag
            // 
            this.kilomtrtag.AutoSize = true;
            this.kilomtrtag.Location = new System.Drawing.Point(7, 106);
            this.kilomtrtag.Name = "kilomtrtag";
            this.kilomtrtag.Size = new System.Drawing.Size(104, 25);
            this.kilomtrtag.TabIndex = 9;
            this.kilomtrtag.Text = "Kilometers";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(347, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Transport Kosten :";
            // 
            // vloeibaardp
            // 
            this.vloeibaardp.FormattingEnabled = true;
            this.vloeibaardp.Items.AddRange(new object[] {
            "Ja"});
            this.vloeibaardp.Location = new System.Drawing.Point(12, 300);
            this.vloeibaardp.Name = "vloeibaardp";
            this.vloeibaardp.Size = new System.Drawing.Size(148, 32);
            this.vloeibaardp.TabIndex = 11;
            this.vloeibaardp.Text = "Nee";
            this.vloeibaardp.SelectedIndexChanged += new System.EventHandler(this.vloeibaardp_SelectedIndexChanged);
            // 
            // vloeibaartag
            // 
            this.vloeibaartag.AutoSize = true;
            this.vloeibaartag.Location = new System.Drawing.Point(13, 269);
            this.vloeibaartag.Name = "vloeibaartag";
            this.vloeibaartag.Size = new System.Drawing.Size(159, 25);
            this.vloeibaartag.TabIndex = 12;
            this.vloeibaartag.Text = "Vloeibare Lading";
            // 
            // Bkm
            // 
            this.Bkm.Location = new System.Drawing.Point(172, 212);
            this.Bkm.Name = "Bkm";
            this.Bkm.Size = new System.Drawing.Size(100, 29);
            this.Bkm.TabIndex = 13;
            // 
            // buitenlandsekm
            // 
            this.buitenlandsekm.AutoSize = true;
            this.buitenlandsekm.Location = new System.Drawing.Point(279, 210);
            this.buitenlandsekm.Name = "buitenlandsekm";
            this.buitenlandsekm.Size = new System.Drawing.Size(172, 25);
            this.buitenlandsekm.TabIndex = 14;
            this.buitenlandsekm.Text = ": Buitenlandse KM";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 345);
            this.Controls.Add(this.buitenlandsekm);
            this.Controls.Add(this.Bkm);
            this.Controls.Add(this.vloeibaartag);
            this.Controls.Add(this.vloeibaardp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.kilomtrtag);
            this.Controls.Add(this.kilometers);
            this.Controls.Add(this.vervoerskosten);
            this.Controls.Add(this.Buitenland);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bldp);
            this.Controls.Add(this.kilogram);
            this.Controls.Add(this.cubiekemeters);
            this.Controls.Add(this.Bereken);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Bereken;
        private System.Windows.Forms.TextBox cubiekemeters;
        private System.Windows.Forms.TextBox kilogram;
        private System.Windows.Forms.ComboBox bldp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Buitenland;
        private System.Windows.Forms.Label vervoerskosten;
        private System.Windows.Forms.TextBox kilometers;
        private System.Windows.Forms.Label kilomtrtag;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox vloeibaardp;
        private System.Windows.Forms.Label vloeibaartag;
        private System.Windows.Forms.TextBox Bkm;
        private System.Windows.Forms.Label buitenlandsekm;
    }
}

