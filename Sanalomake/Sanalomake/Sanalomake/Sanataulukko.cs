using System;
using System.Collections.Generic;
using System.Linq;

namespace Sanalomake
{
    class Sanataulukko
    {
        string[] sanat;
        int sanoja;

        public Sanataulukko()
        {
            sanat = new string[100];
            sanoja = 0;
        }

        public void LisaaSana(string sana)
        {
            sanat[sanoja] = sana;
            sanoja += 1;
        }

        public string[] HaeSanat()
        {
            return sanat;
        } 

        public string[] HaeKaanteinen()
        {
            string[] kaanteiset = new string[sanoja];
            for (int i = 0; i < sanoja; i++)
            {
                kaanteiset[i] = sanat[sanoja - i - 1];
            }
            return kaanteiset;
        }
    }
}
