namespace Limppariautomaatti
{
    public partial class automaatti : Form
    {
        public automaatti()
        {
            InitializeComponent();
        }

        private void siirtonappi_Click(object sender, EventArgs e)
        {
            string luku = rahansyotto.Text;
            rahaasyotetty.Text += luku + " euroa.";
            rahansyotto.Text = string.Empty;
        }
        private void rahansyotto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                siirtonappi_Click(sender, e);
            }
        }

        private void ostapullo_Click(object sender, EventArgs e)
        {
            int hinta, varat, tulos;
            hinta = 2;
            string[] taulukko = rahaasyotetty.Text.Split(); 
            varat = int.Parse(taulukko[0]);
            tulos = varat - hinta;
            string viesti = "Pullo ostettu!";
            string otsikko = "Ostotapahtuma";
            MessageBoxButtons nappula = MessageBoxButtons.OK;
            MessageBox.Show(viesti, otsikko, nappula);
            palautetutrahat.Text += tulos + " euroa";
        }
    }
}