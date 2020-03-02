using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FovarosokForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<string> orszagok = new List<string>();
        List<string> fovarosok = new List<string>();
        Random rnd = new Random();
        int veletlen = 0;
        int veletlen2 = 0;
        bool betolt = true;
        Form Form2 = new Form();

        private void Form1_Load(object sender, EventArgs e)
        {
            fovarosok.Add("Budapest");
            orszagok.Add("Magyarország");
            fovarosok.Add("Bécs");
            orszagok.Add("Ausztria");
            fovarosok.Add("Zágráb");
            orszagok.Add("Horvátország");
            fovarosok.Add("Prága");
            orszagok.Add("Csehország");
            fovarosok.Add("Pozsony");
            orszagok.Add("Szlovákia");
            fovarosok.Add("Bukarest");
            orszagok.Add("Románia");

            veletlen = rnd.Next(fovarosok.Count);
            label3.Text = orszagok[veletlen];
        }

        private void Tippelobtn_Click(object sender, EventArgs e)
        {
            string tipFovaros = textBox1.Text;
            if (tipFovaros == fovarosok[veletlen] && betolt)
            {
                MessageBox.Show("Ügyes vagy!","Eredmény", MessageBoxButtons.OK);
                Ujorszagbtn.Visible = true;
                Kilepesbtn.Visible = true;
                Tippelobtn.Enabled = false;
            }
            else if (tipFovaros == fovarosok[veletlen2] && betolt)
            {
                MessageBox.Show("Ügyes vagy!", "Eredmény", MessageBoxButtons.OK);
                Ujorszagbtn.Visible = true;
                Kilepesbtn.Visible = true;
                Tippelobtn.Enabled = false;
            }
            else
            {
                MessageBox.Show("Nem talált!", "Eredmény", MessageBoxButtons.OK);
                textBox1.Text = "";
            }
        }

        private void Kilepesbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /*private void Ujorszagbtn_Click(object sender, EventArgs e)
        {
            veletlen2 = veletlen;
            while (veletlen == veletlen2)
            {
                veletlen2 = rnd.Next(fovarosok.Count);
            }
            label3.Text = orszagok[veletlen2];
            Ujorszagbtn.Visible = false;
            Kilepesbtn.Visible = false;
            Tippelobtn.Enabled = true;
            betolt = false;
            textBox1.Text = "";
        }*/

        
        Form2.Show();
    }
}
