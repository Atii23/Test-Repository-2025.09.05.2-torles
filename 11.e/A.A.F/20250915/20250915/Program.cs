using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _20250915
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // f1();
            // f3();
            // f4();
            // f5();
            // f6();
            // f7();
            // f8();
            // f9();
            // f10();
            // f11();
            // f12();
            // f13();
            // f14();
            f15();
            
            Console.WriteLine("Nyomd le az Enter-t!");
            Console.ReadLine();
        }

        static void f1()
        {
            Console.Write("Kérek egy egész számot!");
            int szam=int.Parse(Console.ReadLine());
            if (szam < 0)
            {
                Console.WriteLine("A szám pozitív!");
            }
        }
        static void f3()
        {
            Console.Write("Kérek be egy számot!");
            int szam31 = int.Parse(Console.ReadLine());
            Console.Write("Kérek be mégegy számot!");
            int szam32 = int.Parse(Console.ReadLine());
            if (szam31 < szam32)
            {
                Console.WriteLine("Az első szám nagyobb");
            }
            else
            {
                Console.WriteLine("A második szám nagyobb");
            }
        }
        static void f4()
        {
            Console.Write("Kérek egy számot!");
            int szam41 = int.Parse(Console.ReadLine());
            Console.Write("Kérek mégegy számot!");
            int szam42 = int.Parse(Console.ReadLine());
            if (szam41 == 0)
            {
                Console.WriteLine("ERROR!");
                
            }
            else if (szam42 == 0)
            {
                Console.WriteLine("ERROR!");

            }
            else
            {
                Console.WriteLine($"A számok hányadosa: {szam41 / szam42}");
            }
        
        }
        static void f5()
        {
            Console.Write("Kérek egy számot:");
            int szam51 = int.Parse(Console.ReadLine());
            Console.Write("Kérek még egy számot: ");
            int szam52 = int.Parse(Console.ReadLine());
            Console.Write("Kérek egy harmadik számot:");
            int szam53 = int.Parse(Console.ReadLine());
            if (szam51 < szam52 + szam53 && szam52 < szam51 + szam53 && szam53 < szam51 + szam52)
            {
            Console.WriteLine("Lehetnek-e háromszög oldalai: Igen");      
            }
            else { Console.WriteLine("Lehetnek-e háromszög oldalai: Nem"); }
        }
        static void f6()
        {
            Console.Write("Kérem az X Koordinátát:");
            int szam6x = int.Parse(Console.ReadLine());
            Console.Write("Kérem az Y Koordinátát:");
            int szam6y = int.Parse(Console.ReadLine());
            if (szam6x >= 0)
            {
                if(szam6y >= 0)
                {
                    Console.WriteLine("A koordináta az első Síknegyedben van");
                }
                else
                {Console.WriteLine("A koordináta az negyedik Síknegyedben van"); }
            }
            else
            {
                if (szam6y >= 0)
                {
                Console.WriteLine("A koordináta az második Síknegyedben van");
                }
                else
                { Console.WriteLine("A koordináta az harmadik Síknegyedben van"); }
            }
        }
        static void f7()
        {
            Console.Write("Kérem egy tanuló pontszámát:");
            int szam71 = int.Parse(Console.ReadLine());
            
            if (szam71 < 37.5)
            {
                Console.WriteLine($"{Math.Round(szam71 / 1.5)}% Elégtelen (1)");
            }
            else if (szam71 < 60)
            {
                Console.WriteLine($"{Math.Round(szam71 / 1.5)}% Elégséges (2)");
            }
            else if (szam71 < 90)
            {
                Console.WriteLine($"{Math.Round(szam71 / 1.5)}% Közepes (3)");
            }
            else if (szam71 < 120)
            {
                Console.WriteLine($"{Math.Round(szam71 / 1.5)}% Jó (4)");
            }
            else if (szam71 < 151)
            {
                Console.WriteLine($"{Math.Round(szam71 / 1.5)}% Jeles (5)");
            }
        }
        static void f8()
        {
            Console.Write("Kérek egy számot:");
            int szam81 = int.Parse(Console.ReadLine());
            if (szam81 % 3 == 0)
            {
                Console.WriteLine("A szám osztható 3-mal");
            }
            else
            {
                Console.WriteLine("A szám nem osztható 3-mal");
            }
        }
        static void f9()
        {
            Console.Write("Adja meg a víz hőmérsékletét: ");
            int szam91 = int.Parse(Console.ReadLine());
            if (szam91 <= 0)
            {
                Console.WriteLine("A víz szilárd halmazállapotú");
            }
            else if (szam91 <= 99)
            {
                Console.WriteLine("A víz folyékony halmazállapotú");
            }
            else
            {
                Console.WriteLine("A víz gáz halmazállapotú");
            }
        }
        static void f10()
        {
            Console.Write("Kérek egy számot: ");
            double szam101 = double.Parse(Console.ReadLine());
            Console.Write("Kérek mégegy számot: ");
            double szam102 = double.Parse(Console.ReadLine());
            if (szam101 == 0 || szam102 == 0)
            {
                Console.WriteLine("0-val nem lehet osztani");
            }
            else if (szam101 <= szam102)
            {
                Console.WriteLine($"Nagyobb osztva a kisebbel: {Math.Round(szam102 / szam101)}");
            }
            else
            {
                Console.WriteLine($"Nagyobb osztva a kisebbel: {Math.Round(szam101 / szam102)}");
            }
        }
        static void f11()
        {
            Console.Write("Kérek egy számot: ");
            int szam111 = int.Parse(Console.ReadLine());
            if (szam111 % 2 == 0)
            {
                Console.WriteLine("A megadott szám Páros");
            }
            else
            {
                Console.WriteLine("A megadott szám Páros");
            }
        }
        static void f12()
        {
            Console.Write("Kérek egy számot: ");
            int szam121 = int.Parse(Console.ReadLine());
            if (szam121 <= 0)
            {
                Console.WriteLine("Fagy van odakint");
            }
            else
            {
                Console.WriteLine("Nincs fagy odakint");
            }
        }
        static void f13()
        {
            Console.Write("Kérek egy számot: ");
            int szam131 = int.Parse(Console.ReadLine());
            if (szam131 <= 40 || szam131 >= -30)
            {
                Console.WriteLine("A megadott szám a megadott zónában van");
            }
            else
            {
                Console.WriteLine("A megadott szám nincs a megadott zónában");
            }
        }
        static void f14()
        {
            Console.Write("Kérek egy számot: ");
            int szam141 = int.Parse(Console.ReadLine());
            Console.Write("Kérek mégegy számot: ");
            int szam142 = int.Parse(Console.ReadLine());
            if (szam142 < szam141)
            {
                Console.WriteLine($"A nagyobb szám: {szam141}");
            }
            else
            {
                Console.WriteLine($"A nagyobb szám: {szam142}");
            }

        }
        static void f15()
        {
            Console.Write("Kérek egy karaktert:");

        }
    }   
}
