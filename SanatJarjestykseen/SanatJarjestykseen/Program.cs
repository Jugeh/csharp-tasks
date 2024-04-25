using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanatJarjestykseen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] sanalista = null;
            using (StreamReader readFile = new StreamReader("sanoja.txt"))
            {
                sanalista = readFile.ReadToEnd().Split(new char[] { ' ' });
                foreach (var sana in sanalista)
                {
                    sanalista.Append(sana);
                }
            }

            using (StreamWriter writeFile = File.AppendText("output.txt"))
            {
                Array.Sort(sanalista);
                writeFile.Write(string.Join(" ", sanalista));
            }

        }
    }
}
