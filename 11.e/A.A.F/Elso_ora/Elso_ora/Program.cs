using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elso_ora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //alapok();
            vezerlesszerkezetek();

            Console.WriteLine("Nyomd le az Enter-t!");
            Console.ReadLine();
        }

        static void alapok()
        {
            //ez egysoros Komment
            /*
             Ez
             több
             soros
             komment
             */
            // Minden utasítást ;-vel zárunk
            Console.Write("Hello World!"); // Cursor a sor végén marad
            Console.WriteLine("Hello World! 2.0"); // Cursor a következő sorra ugrik
            Console.WriteLine("Nyomd le az Enter-t!");
            Console.ReadLine(); // Beolvasás, Enter lenyomására vár.
            Console.WriteLine("Üss le egy billenytyűt!");
            Console.ReadKey();
            // Változók
            // Típus név = érték;
            /*
             Típus név;
             név = Érték;
            */
            /*
            Típusok:

            Szöveg: string
            pl string szo= "alma";
            Karakter: char
            pl char betu= 'a';

            számok:

            egész számok:
            byte 0-255 byte b=255;
            sbyte -12# - 12# 0 az intervallum közepén
            short - ushort (2 byteon ábrázol)
            int (ez az alap) - uint ()
            long - ulong ()

            valós számok:
            double - ezt használjuk
            double d = 3.14
            decimal
            float

            Logikai:
            bool
            bool l=true/false;

            Dátum és idő:
            DateTime
            TimeSpan
             */
            // szöveg bekérése:
            Console.Write("Adjon meg egy szót:");
            string szoveg = Console.ReadLine();
            // mindig szöveg tipusú adatot olvasunk be.
            // ha más típust szeretnénk, akkor arról nekünk kell gondoskodni
            // pl karakter beolvasása:
            Console.Write("Kérek egy karaktert! ");
            char c = Convert.ToChar(Console.ReadLine());
            Console.WriteLine($"A beolvasott Karakter: {c}");
            Console.Write("Kérek egy karaktert! ");
            char c1 = char.Parse(Console.ReadLine());
            Console.WriteLine($"A beolvasott Karakter: {c1}");
            // egész szám beolvasása
            Console.Write("Kérek egy egész számot");
            int sz = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"A beolvasott szám: {sz}");
            Console.Write("Kérek egy egész számot");
            int sz1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"A beolvasott szám: {sz1}");
        }
        static void vezerlesszerkezetek()
        {
            // Szekvencia - utasítások egymás útáni végrehajtása

            // Szeleció - elágazások
            /* Egyirányú
             * if (feltétel)
             * {
             * utasítások, ha a feltétel igaz
             * }
             * 
             * Kétirányú
             * if (feltétel)
             * {
             * utasítások, ha a feltétel igaz
             * }
             * else
             * {
             * utasítások, ha a feltétel hamis
             * }
             * 
             * Többirányú
             * if (feltétel1)
             * {
             * utasítások, ha a feltétel1 igaz
             * }
             * else if (feltétel2)
             * {
             * utasítások, ha a feltétel2 igaz
             * }
             * ...
             * else
             * {
             * utasítások, ha a feltételx hamisak
             * }
             * 
             * switch... case szerkezet egy változú értékétől függően sok irányba lehet elágazni
             * 
             * switch (változó)     -értékek típusa megegyezik a változó típusával
             * {
             *      case érték1:
             *          utasítások, ha a változó értéke érték1
             *          break;
             *      case érték2:
             *          utasítások, ha a változó értéke érték2
             *          break;
             *  .
             *  .
             *  .
             *      default:
             *          utasítások, ha egyik érték sem szerepel a felsoroltak között, de ez az ág nem kötelező, ha van, akkor ezt is le kell zárni break-kel    
             *  
             * }
             * 
             * 
             */

            // Iterációk - ciklusok
        }

    }
}
