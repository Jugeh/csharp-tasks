using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sanalomake
{
    public partial class Form1 : Form
    {
        Sanataulukko sanat;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sanat = new Sanataulukko();
            ohje1.Text = "Kirjoita lisättävä sana ruutuun ja paina Lisää sana -nappulaa.";
            ohje2.Text = "Napeista voi valita tulostuuko lista syöttöjärjestyksessä vai käänteisessä";
        }

        private void lisaysnappula_Click(object sender, EventArgs e)
        {
            sanat.LisaaSana(lisaysruutu.Text);
            lisaysruutu.Text = String.Empty;
        }

        private void naytaOikein_Click(object sender, EventArgs e)
        {
            nayttoruutu.Text = String.Empty;
            foreach (string sana in sanat.HaeSanat())
            {
                nayttoruutu.Text += sana;
                nayttoruutu.Text += Environment.NewLine;
            }
        }

        private void kaantaennappula_Click(object sender, EventArgs e)
        {
            nayttoruutu.Text = String.Empty;
            foreach (string sana in sanat.HaeKaanteinen())
            {
                nayttoruutu.Text += sana;
                nayttoruutu.Text += Environment.NewLine;
            }
        }

        private void lisaysruutu_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
