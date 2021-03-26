using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DolgozoProject
{
    class Program
    {

        static List<Dolgozo> dolgozok;
        static void Main(string[] args)
        {
            Beolvas();
            HamadikFeladat();
            NegyedikFeladat();
            OtodikFeladat();
            HatodikFeladat();
            HetedikFeladat();



            Console.ReadKey();
        }

        private static void Beolvas()
        {
            dolgozok = new List<Dolgozo>();
            using (StreamReader sr = new StreamReader("adatok.txt"))
            {
                sr.ReadLine();
                while (!sr.EndOfStream)
                {
                    string[] sor = sr.ReadLine().Split(' ');
                    string vezeteknev = sor[0];
                    string keresztnev = sor[1];
                    string nem = sor[2];
                    int eletkor = Convert.ToInt32(sor[3]);
                    int fizetes = Convert.ToInt32(sor[4]);
                    string ft = sor[5];

                    Dolgozo dolgozo = new Dolgozo(vezeteknev, keresztnev, nem, eletkor, fizetes, ft);
                    dolgozok.Add(dolgozo);

                  
                }
            }
           
        }

        private static void Kiir()
        {
        
        }
        
        private static void HamadikFeladat()
        {
            Console.WriteLine("3. feladat: Dolgozók száma: " + dolgozok.Count);
        }

        private static void NegyedikFeladat()
        {
            Console.WriteLine("4. feladat: ");
            int n = 0;
            for (int i = 0; i < dolgozok.Count; i++)
            {
                if (dolgozok[i].Eletkor < 25)
                {
                    n = n + dolgozok[i].Fizetes;
                }
            }
            Console.WriteLine("25 év alattiak összfizetése: " + n + "Ft");
        }

        private static void OtodikFeladat()
        {
            int max = 0;
            int hanyadik = 0;

            for (int i = 0; i < dolgozok.Count; i++)
            {
                if (dolgozok[i].Fizetes > max)
                {
                    max = dolgozok[i].Fizetes;
                    hanyadik = i;
                }
            }
            Console.WriteLine("5. feladat: A legngyobb fizetésű dolgozó adatai: " + "\n" +
                "A dolgozó neve: " + dolgozok[hanyadik].Vezeteknev + dolgozok[hanyadik].Keresztnev + "\n" +
                "Neme: " + dolgozok[hanyadik].Nem + "\n" +
                "Életkora: " + dolgozok[hanyadik].Eletkor + "\n" +
                "Fizetése: " + dolgozok[hanyadik].Fizetes);
        }

        private static void HatodikFeladat()
        {
            int osszeg = 0;
            Console.WriteLine("Kérem írjon be egy összeget.");
            osszeg = int.Parse(Console.ReadLine());

            for (int i = 0; i < dolgozok.Count; i++)
            {
                if (osszeg < dolgozok[i].Fizetes)
                {
                    
                }
            }
            Console.WriteLine("6. feladat: Van olyan dolgozó, akinek a fizetése " + osszeg + " Ft felett van.");
        }

        private static void HetedikFeladat()
        {
      

        }


    }
}
