

namespace Laskukone
{
    /// <summary>
    /// Luokka esittää nelilaskinta. Laskutoimitus on annettava
    /// muodossa luku1 operaattori luku2, missä operaattori on 
    /// joko +, -, * tai /.
    /// </summary>
    public class Laskin
    {
        double tulos;
        double luku1;
        double luku2;
        char operaattori;
        string syy;

        /// <summary>
        /// Luo uuden laskimen. Nollaa tuloksen.
        /// </summary>
        public Laskin()
        {
            tulos = 0;
        }

        /// <summary>
        /// Erottaa syöterivistä luvut ja laskutoimituksen.
        /// </summary>
        /// <param name="rivi">Tehtävä laskutoimitus tekstinä (string).</param>
        /// <returns>Onnistuiko purku. True, jos onnistui. false muuten.</returns>
        public bool PuraRivi(string rivi)
        {
            bool onnistuiko;
            // Jaetaan välilyönneistä.
            string[] osat = rivi.Split(new char[] { ' ' });
            // Voiko ensimmäisen osan muuttaa liukuluvuksi.
            onnistuiko = double.TryParse(osat[0], out luku1);
            // Syöte ei kelpaa liukuluvuksi.
            if(onnistuiko == false)
            {
                syy = "Ensimmäinen laskettava ei kelpaa luvuksi";
                return false;
            }
            // Voiko kolmannen osan muuttaa liukuluvuksi.
            onnistuiko = double.TryParse(osat[2], out luku2);
            // Syöte ei kelpaa liukuluvuksi.
            if (onnistuiko == false)
            {
                syy = "Toinen laskettava ei kelpaa luvuksi";
                return false;
            }
            // Voiko toisen osan muuttaa liukuluvuksi.
            onnistuiko = char.TryParse(osat[1], out operaattori);
            // Syöte ei kelpaa merkiksi.
            if (onnistuiko == false)
            {
                syy = "Operaattorina ei merkki";
                return false;
            }
            // Merkki ei ole +, -, /, eikä *
            if(operaattori != '+' && operaattori != '-' && operaattori != '*' && operaattori != '/')
            {
                syy = "Väärä operaattori";
                return false;
            }
            // Rivin purku onnistui.
            return true;
        }

        /// <summary>
        /// Tekee laskutoimituksen.
        /// </summary>
        public void Laske()
        {
            switch (operaattori)
            {
                case '+':
                    tulos = luku1 + luku2;
                    break;
                case '-':
                    tulos = luku1 - luku2;
                    break;
                case '/':
                    tulos = luku1 / luku2;
                    break;
                case '*':
                    tulos = luku1 * luku2;
                    break;
            }
        }

        /// <summary>
        /// Hakee laskutoimituksen tuloksen.
        /// </summary>
        /// <returns>Laskun tulos (double).</returns>
        public double HaeTulos()
        {
            return tulos;
        }

        /// <summary>
        /// Hakee rivin purun epäonnistumisen syyn
        /// </summary>
        /// <returns>Miksi riviä ei voitu purkaa (string).</returns>
        public string HaeSyy()
        {
            return syy;
        }
    }
}
