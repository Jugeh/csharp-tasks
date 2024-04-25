namespace Nappuloita
{
    public partial class Laskin : Form
    {
        public Laskin()
        {
            InitializeComponent();
        }

        private void nollaNappi_Click(object sender, EventArgs e)
        {
            laskimenNaytto.Text = String.Empty;
            laskimenNaytto.Text = "0";
        }
        private void ykkosNappi_Click(object sender, EventArgs e)
        {
            laskimenNaytto.Text = String.Empty;
            laskimenNaytto.Text = "1";           
        }
        private void kakkosNappi_Click(object sender, EventArgs e)
        {
            laskimenNaytto.Text = String.Empty;
            laskimenNaytto.Text = "2";
        }
        private void kolmosNappi_Click(object sender, EventArgs e)
        {
            laskimenNaytto.Text = String.Empty;
            laskimenNaytto.Text = "3";
        }
        private void nelosNappi_Click(object sender, EventArgs e)
        {
            laskimenNaytto.Text = String.Empty;
            laskimenNaytto.Text = "4";
        }
        private void vitosNappi_Click(object sender, EventArgs e)
        {
            laskimenNaytto.Text = String.Empty;
            laskimenNaytto.Text = "5";
        }
        private void kutosNappi_Click(object sender, EventArgs e)
        {
            laskimenNaytto.Text = String.Empty;
            laskimenNaytto.Text = "6";
        }
        private void seiskaNappi_Click(object sender, EventArgs e)
        {
            laskimenNaytto.Text = String.Empty;
            laskimenNaytto.Text = "7";
        }
        private void kasiNappi_Click(object sender, EventArgs e)
        {
            laskimenNaytto.Text = String.Empty;
            laskimenNaytto.Text = "8";
        }
        private void ysiNappi_Click(object sender, EventArgs e)
        {
            laskimenNaytto.Text = String.Empty;
            laskimenNaytto.Text = "9";
        }
    }
}