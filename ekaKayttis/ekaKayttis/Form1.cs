namespace ekaKayttis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void siirtonappula_Click(object sender, EventArgs e)
        {
            string rivi = tekstirivi.Text;
            monirivinen.Text += rivi;
            monirivinen.Text += Environment.NewLine;
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