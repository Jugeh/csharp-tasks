using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokeri
{
    /// <summary>
    /// Pakan tiedot löytyvät tästä rakenteesta
    /// </summary>
    public struct PakanTiedot
    {
        public const int korttejaPakassa = 52;
        public const int korttejaMaassa = 13;
        public const int korttejaKadessa = 5;
        public static readonly IList<string> maat = new ReadOnlyCollection<string>(new List<string> {"Hertta", "Pata", "Ruutu", "Risti" });
        public static readonly IList<string> arvot = new ReadOnlyCollection<string>(new List<string> { "Ässä", "2", "3", "4", "5", "6", "7",
            "8", "9", "10", "Sotilas", "Kuningatar", "Kuningas"});
        public static readonly IList<string> kasienJarjestys = new ReadOnlyCollection<string>(new List<string> { "Värisuora", "Neloset",
            "Täyskäsi", "Väri", "Suora", "Kolmoset", "Parit", "Pari", "" });
    }
}
