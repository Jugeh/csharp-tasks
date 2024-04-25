using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autovuokraamo
{
    public class Vuokraamo
    {
        private List<HenkiloAuto> hloautot;
        private List<PakettiAuto> pakut;

        /// <summary>
        /// Vuokraamo luokasta löytyy listat hlöautoista ja pakettiautoista
        /// </summary>
        /// <param name="hloautot">Lista henkilöautoista</param>
        /// <param name="pakut">Lista pakettiautoista</param>
        public Vuokraamo(List<HenkiloAuto> hloautot, List<PakettiAuto> pakut)
        {
            this.hloautot = new List<HenkiloAuto>();
            this.pakut = new List<PakettiAuto>();
        }
        /// <summary>
        /// Lisää uuden henkilöauton vuokraamoon
        /// </summary>
        /// <param name="uusiHloauto">Uusi henkilöauto</param>
        public void LisaaHloauto(HenkiloAuto uusiHloauto)
        {
            hloautot.Add(uusiHloauto);
        }

        /// <summary>
        /// Lisää uuden pakettiauton vuokraamoon
        /// </summary>
        /// <param name="uusiPaku">Uusi pakettiauto</param>
        public void LisaaPaku(PakettiAuto uusiPaku)
        {
            pakut.Add(uusiPaku);
        }

        /// <summary>
        /// Vuokraa henkilöauton ja vähentää vuokratun ajoneuvon kys. ajoneuvojen määrästä
        /// </summary>
        /// <param name="vuokrattavaAuto">Vuokrattava auto</param>
        public void VuokraaHloauto(HenkiloAuto vuokrattavaAuto)
        {
            vuokrattavaAuto.Jaljella -= 1;
        }

        /// <summary>
        /// Vuokraa pakettiauton ja vähentää vuokratun ajoneuvon kys. ajoneuvojen määrästä
        /// </summary>
        /// <param name="vuokrattavaAuto">Vuokrattava auto</param>
        public void VuokrattavaPaku(PakettiAuto vuokrattavaAuto)
        {
            vuokrattavaAuto.Jaljella -= 1;
        }

        /// <summary>
        /// Hakee kaikki jäsenet
        /// </summary>
        public List<HenkiloAuto> Hloautot
        {
            get { return hloautot; }
        }

        /// <summary>
        /// Hakee kaikki maksut
        /// </summary>
        public List<PakettiAuto> Pakut
        {
            get { return pakut; }
        }
    }
}
