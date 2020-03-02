namespace AutoForm
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
            this.Felveszbtn = new System.Windows.Forms.Button();
            this.Listazbtn = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.rendszambtn = new System.Windows.Forms.Label();
            this.MarkaCB = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.Markabtn = new System.Windows.Forms.Label();
            this.Tipusbtn = new System.Windows.Forms.Label();
            this.Evjaratbtn = new System.Windows.Forms.Label();
            this.Uzemanyagbtn = new System.Windows.Forms.Label();
            this.TipusB = new System.Windows.Forms.TextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.EvjaratNUM = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.EvjaratNUM)).BeginInit();
            this.SuspendLayout();
            // 
            // Felveszbtn
            // 
            this.Felveszbtn.Location = new System.Drawing.Point(316, 15);
            this.Felveszbtn.Name = "Felveszbtn";
            this.Felveszbtn.Size = new System.Drawing.Size(75, 23);
            this.Felveszbtn.TabIndex = 0;
            this.Felveszbtn.Text = "Felvesz";
            this.Felveszbtn.UseVisualStyleBackColor = true;
            this.Felveszbtn.Click += new System.EventHandler(this.Felveszbtn_Click);
            // 
            // Listazbtn
            // 
            this.Listazbtn.Location = new System.Drawing.Point(316, 41);
            this.Listazbtn.Name = "Listazbtn";
            this.Listazbtn.Size = new System.Drawing.Size(75, 23);
            this.Listazbtn.TabIndex = 1;
            this.Listazbtn.Text = "Listáz";
            this.Listazbtn.UseVisualStyleBackColor = true;
            this.Listazbtn.Click += new System.EventHandler(this.Listazbtn_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(437, 15);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(214, 212);
            this.listBox1.TabIndex = 2;
            // 
            // rendszambtn
            // 
            this.rendszambtn.AutoSize = true;
            this.rendszambtn.Location = new System.Drawing.Point(12, 15);
            this.rendszambtn.Name = "rendszambtn";
            this.rendszambtn.Size = new System.Drawing.Size(57, 13);
            this.rendszambtn.TabIndex = 3;
            this.rendszambtn.Text = "Rendszám";
            this.rendszambtn.Click += new System.EventHandler(this.label1_Click);
            // 
            // MarkaCB
            // 
            this.MarkaCB.FormattingEnabled = true;
            this.MarkaCB.Items.AddRange(new object[] {
            "Opel",
            "Fiat",
            "Ford",
            "VolksWagen",
            "Renault",
            "Toyota",
            "Ferrari"});
            this.MarkaCB.Location = new System.Drawing.Point(83, 41);
            this.MarkaCB.Name = "MarkaCB";
            this.MarkaCB.Size = new System.Drawing.Size(120, 21);
            this.MarkaCB.TabIndex = 4;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Benzin",
            "Gázolaj",
            "Diesel"});
            this.comboBox3.Location = new System.Drawing.Point(83, 125);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(120, 21);
            this.comboBox3.TabIndex = 6;
            // 
            // Markabtn
            // 
            this.Markabtn.AutoSize = true;
            this.Markabtn.Location = new System.Drawing.Point(12, 41);
            this.Markabtn.Name = "Markabtn";
            this.Markabtn.Size = new System.Drawing.Size(37, 13);
            this.Markabtn.TabIndex = 7;
            this.Markabtn.Text = "Márka";
            // 
            // Tipusbtn
            // 
            this.Tipusbtn.AutoSize = true;
            this.Tipusbtn.Location = new System.Drawing.Point(12, 70);
            this.Tipusbtn.Name = "Tipusbtn";
            this.Tipusbtn.Size = new System.Drawing.Size(35, 13);
            this.Tipusbtn.TabIndex = 8;
            this.Tipusbtn.Text = "Típus";
            // 
            // Evjaratbtn
            // 
            this.Evjaratbtn.AutoSize = true;
            this.Evjaratbtn.Location = new System.Drawing.Point(14, 101);
            this.Evjaratbtn.Name = "Evjaratbtn";
            this.Evjaratbtn.Size = new System.Drawing.Size(40, 13);
            this.Evjaratbtn.TabIndex = 9;
            this.Evjaratbtn.Text = "Évjárat";
            // 
            // Uzemanyagbtn
            // 
            this.Uzemanyagbtn.AutoSize = true;
            this.Uzemanyagbtn.Location = new System.Drawing.Point(14, 131);
            this.Uzemanyagbtn.Name = "Uzemanyagbtn";
            this.Uzemanyagbtn.Size = new System.Drawing.Size(63, 13);
            this.Uzemanyagbtn.TabIndex = 10;
            this.Uzemanyagbtn.Text = "Üzemanyag";
            // 
            // TipusB
            // 
            this.TipusB.Location = new System.Drawing.Point(83, 67);
            this.TipusB.Name = "TipusB";
            this.TipusB.Size = new System.Drawing.Size(120, 20);
            this.TipusB.TabIndex = 11;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(83, 15);
            this.maskedTextBox1.Mask = "AAA-000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(120, 20);
            this.maskedTextBox1.TabIndex = 13;
            // 
            // EvjaratNUM
            // 
            this.EvjaratNUM.Location = new System.Drawing.Point(84, 94);
            this.EvjaratNUM.Maximum = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            this.EvjaratNUM.Minimum = new decimal(new int[] {
            2010,
            0,
            0,
            0});
            this.EvjaratNUM.Name = "EvjaratNUM";
            this.EvjaratNUM.Size = new System.Drawing.Size(120, 20);
            this.EvjaratNUM.TabIndex = 14;
            this.EvjaratNUM.Value = new decimal(new int[] {
            2010,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 261);
            this.Controls.Add(this.EvjaratNUM);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.TipusB);
            this.Controls.Add(this.Uzemanyagbtn);
            this.Controls.Add(this.Evjaratbtn);
            this.Controls.Add(this.Tipusbtn);
            this.Controls.Add(this.Markabtn);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.MarkaCB);
            this.Controls.Add(this.rendszambtn);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Listazbtn);
            this.Controls.Add(this.Felveszbtn);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.EvjaratNUM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Felveszbtn;
        private System.Windows.Forms.Button Listazbtn;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label rendszambtn;
        private System.Windows.Forms.ComboBox MarkaCB;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label Markabtn;
        private System.Windows.Forms.Label Tipusbtn;
        private System.Windows.Forms.Label Evjaratbtn;
        private System.Windows.Forms.Label Uzemanyagbtn;
        private System.Windows.Forms.TextBox TipusB;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.NumericUpDown EvjaratNUM;
    }
}

