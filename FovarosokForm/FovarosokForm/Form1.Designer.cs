namespace FovarosokForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Tippelobtn = new System.Windows.Forms.Button();
            this.Ujorszagbtn = new System.Windows.Forms.Button();
            this.Kilepesbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ország";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Főváros";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(142, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(111, 86);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // Tippelobtn
            // 
            this.Tippelobtn.Location = new System.Drawing.Point(281, 21);
            this.Tippelobtn.Name = "Tippelobtn";
            this.Tippelobtn.Size = new System.Drawing.Size(75, 23);
            this.Tippelobtn.TabIndex = 4;
            this.Tippelobtn.Text = "Tippelő";
            this.Tippelobtn.UseVisualStyleBackColor = true;
            this.Tippelobtn.Click += new System.EventHandler(this.Tippelobtn_Click);
            // 
            // Ujorszagbtn
            // 
            this.Ujorszagbtn.Location = new System.Drawing.Point(281, 50);
            this.Ujorszagbtn.Name = "Ujorszagbtn";
            this.Ujorszagbtn.Size = new System.Drawing.Size(75, 23);
            this.Ujorszagbtn.TabIndex = 5;
            this.Ujorszagbtn.Text = "Új ország";
            this.Ujorszagbtn.UseVisualStyleBackColor = true;
            this.Ujorszagbtn.Visible = false;
            this.Ujorszagbtn.Click += new System.EventHandler(this.Ujorszagbtn_Click);
            // 
            // Kilepesbtn
            // 
            this.Kilepesbtn.Location = new System.Drawing.Point(281, 79);
            this.Kilepesbtn.Name = "Kilepesbtn";
            this.Kilepesbtn.Size = new System.Drawing.Size(75, 23);
            this.Kilepesbtn.TabIndex = 6;
            this.Kilepesbtn.Text = "Kilépés";
            this.Kilepesbtn.UseVisualStyleBackColor = true;
            this.Kilepesbtn.Visible = false;
            this.Kilepesbtn.Click += new System.EventHandler(this.Kilepesbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 180);
            this.Controls.Add(this.Kilepesbtn);
            this.Controls.Add(this.Ujorszagbtn);
            this.Controls.Add(this.Tippelobtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Tippelobtn;
        private System.Windows.Forms.Button Ujorszagbtn;
        private System.Windows.Forms.Button Kilepesbtn;
    }
}

