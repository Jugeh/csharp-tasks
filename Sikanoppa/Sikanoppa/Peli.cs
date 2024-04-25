using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sikanoppa
{
    public class Peli
    {
        private string pelinnimi;
        Pelaaja pelaaja1;
        Pelaaja pelaaja2;

        public int Vuoro { get; private set; }
        /// <summary>
        /// Aloittaa uuden pelin, jossa parametreina pelille annettu nimi ja pelaajat
        /// </summary>
        /// <param name="pelinnimi">Pelattavan pelin nimi</param>
        /// <param name="pelaaja1">Pelaajan nimi</param>
        /// <param name="pelaaja2">Pelaajan nimi</param>
        public Peli(string pelinnimi, Pelaaja pelaaja1, Pelaaja pelaaja2)
        {
            this.pelinnimi = pelinnimi;
            this.pelaaja1 = pelaaja1;
            this.pelaaja2 = pelaaja2;
            Vuoro = 1;
        }
        /// <summary>
        /// Lisää heittovuoron pisteet pelaajan kokonaispisteisiin ja vaihtaa vuoron
        /// </summary>
        public void OtaPisteet()
        {
            if (Vuoro == 1)
            {
                pelaaja1.Kokonaispisteet += pelaaja1.Pisteet;
                if (pelaaja1.Kokonaispisteet >= 100)
                {
                    Console.WriteLine(pelaaja1.Nimi + " voitti pelin!");
                }
                Console.WriteLine("Kokonaispisteisiisi lisättiin " + pelaaja1.Pisteet + ". Sinulla on " + pelaaja1.Kokonaispisteet + " pistettä.");
                Vuoro = 2;
            }
            else
            {
                pelaaja2.Kokonaispisteet += pelaaja2.Pisteet;
                if (pelaaja2.Kokonaispisteet >= 100)
                {
                    Console.WriteLine(pelaaja2.Nimi + " voitti pelin!");
                }
                Console.WriteLine("Kokonaispisteisiisi lisättiin " + pelaaja2.Pisteet + ". Sinulla on " + pelaaja2.Kokonaispisteet + " pistettä.");
                Vuoro = 1;
            }
        }
        /// <summary>
        /// Konepelaajan päätös ottaako pisteet vai jatkaako vuoroa
        /// </summary>
        /// <returns>Palauttaa 0 tai 1</returns>
        public void KonepelaajanJatko()
        {
            Random random = new Random();
            int jatko;
            jatko = random.Next(0, 2);
            
            if (Vuoro == 1 && jatko == 0)
            {
                //cpu pelaaja1 ottaa pisteet
            }
            else if (Vuoro == 1 && jatko == 1)
            {
                //cpu pelaaja1 jatkaa
            }
            else if (Vuoro == 2 && jatko == 0)
            {
                //cpu pelaaja2 ottaa pisteet
            }
            else if (Vuoro == 2 && jatko == 1)
            {
                //cpu pelaaja2 jatkaa
            }
        }
        /// <summary>
        /// Nopan heitto. Jos tulos on 1, niin vuoro vaihtuu ja pisteet nollataan, muuten lisätään heitto pelaajan pisteisiin
        /// </summary>
        public void HeitaNoppa()
        {
            Random noppa = new Random();
            int heitto;
            heitto = noppa.Next(1, 7);
            if (heitto == 1 && Vuoro == 1)
            {
                Console.WriteLine("Heitit luvun 1. Sait 0 pistettä.");
                pelaaja1.Pisteet = 0;
                Vuoro = 2;
            }
            else if (heitto == 1 && Vuoro == 2)
            {
                Console.WriteLine("Heitit luvun 1. Sait 0 pistettä.");
                pelaaja2.Pisteet = 0;
                Vuoro = 1;
            }
            else if (heitto != 1 && Vuoro == 1)
            {
                Console.WriteLine("Luku " + heitto + " lisättiin pisteisiisi.");
                pelaaja1.Pisteet += heitto;
            }
            else if (heitto != 1 && Vuoro == 2)
            {
                Console.WriteLine("Luku " + heitto + " lisättiin pisteisiisi.");
                pelaaja2.Pisteet += heitto;
            }
        }
        /// <summary>
        /// Valitaan pelaajan tyyppi, eli onko kyseessä ihmis vai tietokonepelaaja
        /// </summary>
        public void ValitseTyyppi()
        {
            int valinta1;
            int valinta2;
            Console.Write("Valitse ensimmäisen pelaajan tyyppi. 1 = ihmispelaaja. 2 = konepelaaja: ");
            valinta1 = int.Parse(Console.ReadLine());
            if (valinta1 == 1)
            {
                pelaaja1.Tyyppi = "ihminen";
                Console.WriteLine("Ensimmäinen pelaaja on ihminen.");
            }
            else if (valinta1 == 2)
            {
                pelaaja1.Tyyppi = "tietokone";
                Console.WriteLine("Ensimmäinen pelaaja on tietokone.");
            }
            Console.Write("Valitse toisen pelaajan tyyppi. 1 = ihmispelaaja. 2 = konepelaaja: ");
            valinta2 = int.Parse(Console.ReadLine());
            if (valinta2 == 1)
            {
                pelaaja2.Tyyppi = "ihminen";
                Console.WriteLine("Toinen pelaaja on ihminen.");
            }
            else if (valinta2 == 2)
            {
                pelaaja2.Tyyppi = "tietokone";
                Console.WriteLine("Toinen pelaaja on ihminen.");
            }
        }

        /// <summary>
        /// Keskeyttää pelin
        /// </summary>
        public void Keskeyta()
        {
            Console.Write("Syötä keskeytettevän pelinnimi: ");
            pelinnimi = Console.ReadLine();
            string constr;
            
            // for the connection to
            // sql server database
            SqlConnection conn;

            // Data Source is the name of the
            // server on which the database is stored.
            // The Initial Catalog is used to specify
            // the name of the database
            constr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=\\JANUS\students\LN_TIVIJ21\salokoski_jukka\C#\Sikanoppa\Sikanoppa\SikanoppaDB.mdf;Integrated Security=True;Connect Timeout=30";

            conn = new SqlConnection(constr);

            // to open the connection
            conn.Open();

            // use to perform read and write
            // operations in the database
            SqlCommand cmd;
            SqlCommand cmd2;
            SqlCommand cmd3;

            // data adapter object is use to
            // insert, update or delete commands
            SqlDataAdapter adap = new SqlDataAdapter();

            string sql = "";
            string sql2 = "";
            string sql3 = "";

            // use the defined sql statement
            // against our database
            sql = "INSERT into Peli(pelinnimi) values('pelinnimi')";
            sql2 = "INSERT into Pelaaja(pelaajaID, tyyppi, nimi) values('pelaaja1.pelaajaID', 'pelaaja2.pelaajaID','pelaaja1.Tyyppi', 'pelaaja2.Tyyppi', 'pelaaja1.Nimi', 'pelaaja2.Nimi')";
            sql3 = "INSERT into Tulokset(tulosID, kokonaispisteet) values('tulosID', 'pelaaja1.Kokonaispisteet', 'pelaaja2.Kokonaispisteet')";

            // use to execute the sql command so we
            // are passing query and connection object
            cmd = new SqlCommand(sql, conn);
            cmd2 = new SqlCommand(sql2, conn);
            cmd3 = new SqlCommand(sql3, conn);

            // associate the insert SQL
            // command to adapter object
            adap.InsertCommand = new SqlCommand(sql, conn);
            adap.InsertCommand.ExecuteNonQuery();
            adap.InsertCommand = new SqlCommand(sql2, conn);
            adap.InsertCommand.ExecuteNonQuery();
            adap.InsertCommand = new SqlCommand(sql3, conn);
            adap.InsertCommand.ExecuteNonQuery();

            // use to execute the DML statement against
            // our database
            adap.InsertCommand.ExecuteNonQuery();

            // closing all the objects
            cmd.Dispose();
            cmd2.Dispose();
            cmd3.Dispose();
            conn.Close();
            Console.WriteLine("Peli keskeytetty.");
        }
        /// <summary>
        /// Jatka keskeytettyä peliä
        /// </summary>
        public void Jatka()
        {
            string constr;

            // for the connection to
            // sql server database
            SqlConnection conn;

            // Data Source is the name of the
            // server on which the database is stored.
            // The Initial Catalog is used to specify
            // the name of the database
            constr = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=Sikanoppadb";

            conn = new SqlConnection(constr);

            // to open the connection
            conn.Open();

            // use to perform read and write
            // operations in the database
            SqlCommand cmd;

            string sql = "";

            // use the defined sql statement
            // against our database
            sql = "SELECT pelinnimi from Peli";

            // use to execute the sql command so we
            // are passing query and connection object
            cmd = new SqlCommand(sql, conn);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                foreach (var i in reader)
                {
                    Console.WriteLine(i);
                }
            }
            Console.Write("Syötä jatkettavan pelinnimi: ");
            pelinnimi = Console.ReadLine();

            // closing all the objects
            cmd.Dispose();
            conn.Close();
        }

    }
}
