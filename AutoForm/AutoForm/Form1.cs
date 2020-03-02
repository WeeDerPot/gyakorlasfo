using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Auto> lista = new List<Auto>();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Felveszbtn_Click(object sender, EventArgs e)
        {
            string rendszam = maskedTextBox1.Text;
            maskedTextBox1.Clear();
            string marka = MarkaCB.SelectedItem.ToString();
            string tipus = TipusB.Text;
            TipusB.Text = "";
            int evjarat = (int)EvjaratNUM.Value;
            string uzemanyag = comboBox3.SelectedItem.ToString();

            Auto auto = new Auto(rendszam, marka, tipus, evjarat, uzemanyag);
            lista.Add(auto);
        }

        private void Listazbtn_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (var item in lista)
            {
                listBox1.Items.Add(item.Kiir());
            }
        }
    }
}
