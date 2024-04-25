using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JalkapalloEiToimi
{
    /// <summary>
    /// Luokka Ottelu esittää ottelutuloksia jalakpallotilasto
    /// -ohjelmassa. Ottelussa on kaksi joukkuetta: kotijoukkue
    /// ja vierasjoukkue. Tehdyt maalit lisätään joko kotimaaleiksi
    /// tai vierasmaaleiksi. Joukkue luodaan, kun ottelu alkaa ja
    /// ottelun kuluessa maalit lisätään niiden tullessa.
    /// </summary>
    public class Ottelu
    {
        /// <summary>
        /// Kotijoukkueen olio.
        /// </summary>
        private Joukkue kotijoukkue;
        /// <summary>
        /// Kotijoukkueen tekemät maalit.
        /// </summary>
        private int kotimaalit;
        /// <summary>
        /// Vierasjoukkueen olio.
        /// </summary>
        private Joukkue vierasjoukkue;
        /// <summary>
        /// vierasjoukkueen tekemät maalit.
        /// </summary>
        private int vierasmaalit;
        /// <summary>
        /// pelikenttä jossa ottelu pelataan.
        /// </summary>
        private string kotikentta;
        /// <summary>
        /// ottelun maaliero.
        /// </summary>
        private int maaliero;
        /// <summary>
        /// Alustusmetodi ottelulle kaden annetun joukkueen välillä.
        /// Alussa ei ole yhtään maalia.
        /// </summary>
        /// <param name="kotijoukkue">Pelin kotijoukkueolio.</param>
        /// <param name="vierasjoukkue">Pelin vierasjoukkueolio.</param>
        public Ottelu(Joukkue kotijoukkue, Joukkue vierasjoukkue)
        {
            this.kotijoukkue = kotijoukkue;
            this.vierasjoukkue = vierasjoukkue;
            kotikentta = kotijoukkue.HaeKentta();
            kotimaalit = 0;
            vierasmaalit = 0;
            maaliero = 0;
        }

        /// <summary>
        /// Hakee kotijoukkueen olion.
        /// </summary>
        /// <returns>Kotijoukkueen olio.</returns>
        public Joukkue HaeKotijoukkue()
        {
            return kotijoukkue;
        }

        /// <summary>Hakee vierasjoukkueen olion.</summary>
        /// <returns>Vierasjoukkueen olio.</returns>
        public Joukkue HaeVierasjoukkue()
        {
            return vierasjoukkue;
        }
        /// <summary>Hakee pelikentän</summary>
        public string HaePelikentta()
        {
            return kotikentta;
        }
        public int HaeMaaliero()
        {
            return kotimaalit - vierasmaalit;
        }
        /// <summary>Lisää kotijoukkueen tekemän maalin.</summary>
        public void LisaaKotimaali()
        {
            kotimaalit = kotimaalit +1;
        }

        /// <summary>Lisää vierasjoukkueen tekemän maalin.</summary>
        public void LisaaVierasmaali()
        {
            vierasmaalit = vierasmaalit + 1;
        }

        /// <summary>
        /// Hakee kotijoukkueen tekemien maalien määrän.
        /// </summary>
        /// <returns>Maalimäärä (int).</returns>
        public int HaeKotimaalit()
        {
            return kotimaalit;
        }

        /// <summary>
        /// Hakee vierasjoukkueen tekemien maalien määrän.
        /// </summary>
        /// <returns>Maalimäärä (int).</returns>
        public int HaeVierasmaalit()
        {
            return vierasmaalit;
        }

        /// <summary>
        /// Hakee joukkeiden maalimäärän yhteenlaskettuna.
        /// </summary>
        /// <returns>Maalit yhteensä (int).</returns>
        public int HaeYhteismaalit()
        {
            return HaeKotimaalit() + HaeVierasmaalit();
        }

        /// <summary>
        /// Hakee tiedon, voittiko kotijoukkue pelin.
        /// </summary>
        /// <returns>true, jos kotijoukkue voitti. Muuten false.</returns>
        public bool OnkoKotivoitto()
        {
            return kotimaalit > vierasmaalit;
        }

        /// <summary>
        /// Hakee tiedon, voittiko vierasjoukkue pelin.
        /// </summary>
        /// <returns>true, jos vierasjoukkue voitti. Muuten false.</returns>
        public bool OnkoVierasvoitto()
        {
            return kotimaalit < vierasmaalit;
        }


        /// <summary>
        /// Hakee tiedon, päättyikö peli tasan.
        /// </summary>
        /// <returns>true, jos tasapeli. Muuten false.</returns>

        public bool OnkoTasapeli()
        {
            return kotimaalit == vierasmaalit;
        }

        /// <summary>
        /// Hakee tiedon tehtiinkö ottelussa enemmän maaleja kuin
        /// annetussa ottelussa. 
        /// </summary>
        /// <param name="toinenOttelu">Toinen ottelu, johon tätä ottelua verrataan.</param>
        /// <returns>true, jos tässä ottelussa tehtiin enemmän maaleja kuin toisessa. Muuten false.</returns>
        public bool OnkoRunsasmaalisempi(Ottelu toinenOttelu)
        {
            return HaeYhteismaalit() > toinenOttelu.HaeYhteismaalit();
        }
    }
}
