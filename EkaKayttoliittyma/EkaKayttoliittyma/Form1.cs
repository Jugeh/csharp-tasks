using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EkaKayttoliittyma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tekstirivi_TextChanged(object sender, EventArgs e)
        {

        }

        private void siirtonappula_Click(object sender, EventArgs e)
        {
            string viesti = "Haluatko siirtää tyhjän rivin?";
            string otsikko = "Tyhjä syöte";
            MessageBoxButtons nappulat = MessageBoxButtons.OKCancel;
            string rivi = tekstirivi.Text;
            if (rivi == String.Empty)
            {
                DialogResult vastaus = MessageBox.Show(viesti, otsikko, nappulat);
                if (vastaus == DialogResult.Cancel)
                {
                    return;
                }
                else
                {
                    rivi = string.Empty;
                }
            }
            tekstilaatikko.Text += rivi;
            tekstilaatikko.Text += Environment.NewLine;
            tekstirivi.Text = String.Empty;
        }

        private void tekstirivi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                siirtonappula_Click(sender, e);
            }
        }

    }
}
