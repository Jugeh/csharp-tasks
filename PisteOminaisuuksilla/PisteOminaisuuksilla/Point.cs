using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PisteOminaisuuksilla
{
    /// <summary>
    /// Luokka jossa on 2 koordinaattia. X ja Y.
    /// </summary>
    public class Point
    {
        int x;
        int y;
        /// <summary>
        /// Alustus metodi koordinaateille.
        /// </summary>
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        /// <summary>
        /// Koordinaatti X ominaisuus.
        /// </summary>
        public int X
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }
        /// <summary>
        /// Koordinaatti Y ominaisuus.
        /// </summary>
        public int Y
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }
        /// <summary>
        /// Metodi joka palauttaa koordinaatit sulkujen sisällä.
        /// </summary>
        public override string ToString()
        {
            return string.Format("({0}, {1})", X, Y);
        }
    }
}
