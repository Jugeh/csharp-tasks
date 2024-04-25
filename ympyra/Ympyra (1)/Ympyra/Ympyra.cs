using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ympyra
{
    public class Ympyra
    {
        double sade;
        Point keskipiste;

        /// <summary>
        /// Ympyrän pinta-ala ja keskipiste
        /// </summary>
        public Ympyra(double sade, Point keskipiste)
        {
            this.sade = sade;
            this.keskipiste = keskipiste;
        }

        /// <summary>
        /// Palauttaa ympyrän säteen
        /// </summary>
        public double Sade
        {
            get
            {
                return sade;
            }
            set
            {
                sade = value;
            }
        }

        /// <summary>
        /// Palauttaa ympyrän keskipisteen
        /// </summary>
        public Point Keskipiste
        {
            get
            {
                return keskipiste;
            }
            set
            {
                keskipiste = value;
            }
        }

        /// <summary>
        /// Laskukaava ympyrän pinta-alalle
        /// </summary>
        public double Pintaala
        {
            get
            { 
                return Math.PI * sade * sade;
            }
        }
              
    }
}
