using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace _20250908
{
    internal class Program
    {
        static void Main(string[] args)

        {
            //1. Feladat
            Console.WriteLine("Nyomd le az Enter-t!");
            Console.ReadLine();
            Console.Write("Add meg a négyzet oldalát: a=");
            double oldal=double.Parse(Console.ReadLine());
            Console.WriteLine($"A négyzet ketülete: {4*oldal}, területe: {Math.Pow(oldal,2)}");

            //2. Feladat
            Console.Write("Add meg a trapéz felső alapját: f_a=");
            double felso_oldal = double.Parse(Console.ReadLine());
            Console.Write("Add meg a trapéz alsó alapját: a_a=");
            double also_oldal = double.Parse(Console.ReadLine());
            Console.Write("Add meg a trapéz magasságát: m=");
            double magassag = double.Parse(Console.ReadLine());
            Console.WriteLine($"A trapéz Területe={((felso_oldal + also_oldal) * magassag)/2}");

            //3. Feladat
            Console.Write("Add meg a téglalap egyik oldalát: a=");
            double a_oldal=double.Parse(Console.ReadLine());
            Console.Write("Add meg a téglalap másik oldalát: b=");
            double b_oldal= double.Parse(Console.ReadLine());   
            Console.WriteLine($"A téglalap ketülete= {(a_oldal+b_oldal)*2} Területe= {a_oldal*b_oldal}");

            //4. Feladat
            Console.Write("Add meg a háromszög alapját: alap=");
            double alap=double.Parse(Console.ReadLine());
            Console.Write("Add meg a háromszög magasságát: m=");
            double magassag2=double.Parse(Console.ReadLine());
            Console.WriteLine($"A háromszög területe: {(alap*magassag2)/2}");

            //5. Feladat
            Console.Write("Add meg a kör sugarát: r=");
            double sugar=double.Parse(Console.ReadLine());
            Console.WriteLine($"A kör kerülete: {2 * sugar * Math.PI}, Területe: {Math.Pow(sugar, 2) * Math.PI}");

            //6. Feladat
            Console.Write("Adj meg egy pozitív számot: ");
            double sz=double.Parse(Console.ReadLine());
            Console.WriteLine($"A megadott szám négyzetgyöke: {Math.Sqrt(sz)}");

            //7. Feladat
            Console.Write("Add meg a Háromszög első oldalát: ");
            double h_a=double.Parse(Console.ReadLine());
            Console.Write("Add meg a Háromszög második oldalát: ");
            double h_b=double.Parse(Console.ReadLine());
            Console.Write("Add meg a Háromszög harmadik oldalát: ");
            double h_c=double.Parse(Console.ReadLine());
            double S=h_a+h_b+h_c;
            Console.WriteLine($"A háromszög területe: {Math.Sqrt(S*(S*h_a) * (S*h_b) * (S*h_c))}");

            //8. Feladat
            Console.Write("Add meg a kocka élhosszát: a=");
            double el_a=double.Parse(Console.ReadLine());
            Console.WriteLine($"A kocka térfogata: {Math.Pow(el_a,3)}, Felszine: {6*Math.Pow(el_a,2)}");

            //9. Feladat
            Console.Write("Add meg a téglatest hosszúságát: a=");
            double t_a=double.Parse(Console.ReadLine());
            Console.Write("Add meg a téglatest szélességét: b=");
            double t_b=double.Parse(Console.ReadLine());
            Console.Write("Add meg a téglatest magasságát: m=");
            double t_m=double.Parse(Console.ReadLine());
            Console.WriteLine($"A téglatest térfogata: {t_a*t_b*t_m}");

            //10. Feladat
            Console.Write("Add meg a gömb sugarát: r=");
            double r2=double.Parse(Console.ReadLine());
            Console.WriteLine($"A gömb térfogata: {(4*Math.PI/3)*Math.Pow(r2,3)}, Felszine: {4*Math.PI*Math.Pow(r2,2)}");

            //11. Feladat
            Console.Write("Add meg a Henger sugarát: r=");
            double h_r=double.Parse(Console.ReadLine());
            Console.Write("Add meg a Henger Magasságát: m=");
            double h_m=double.Parse(Console.ReadLine());
            Console.WriteLine($"A henger térfogata: {Math.Pow(h_r, 2) * Math.PI * h_m}, Felszine: {2 * h_r * Math.PI * (h_r + h_m)}");

            //12. Feladat
            Console.Write("Add meg a kúp sugarát: r=");
            double k_r=double.Parse(Console.ReadLine());
            Console.Write("Add meg a kúp magasságát: m=");
            double k_m=double.Parse(Console.ReadLine());
            Console.WriteLine($"A kúp térfogata: {(Math.Pow(k_r,2)*Math.PI*k_m)/3}, felszine: {Math.PI*k_r*(k_r+Math.Sqrt(Math.Pow(k_r,2)+Math.Pow(k_m,2)))}");

            //13. Feladat
            Console.Write("Add meg a gúla alapjának a területét: a_t=");
            double g_a=double.Parse(Console.ReadLine());
            Console.Write("Add meg a gúla magasságát: m=");
            double g_m=double.Parse(Console.ReadLine());
            Console.WriteLine($"A gúla térfogata: {(g_a*g_m)/3}");

            //14. Feladat
            Console.Write("Add meg a Paralelogramma egyik oldalát: a=");
            double p_a=double.Parse(Console.ReadLine());
            Console.Write("Add meg a Paralelogramma mások oldalát: b=");
            double p_b=double.Parse(Console.ReadLine());
            Console.Write("Add meg az a és b oldal által bezárt szöget: y=");
            double p_y=double.Parse(Console.ReadLine());
            Console.WriteLine($"A paralelogramma területe: {p_a*p_b*Math.Sin(p_y)}");

            //15. Feladat
            Console.Write("Add meg a háromszög egyik oldalát: a=");
            double h_a2=double.Parse(Console.ReadLine());
            Console.Write("Add meg a háromszög másik oldalát: b=");
            double h_b2=double.Parse(Console.ReadLine());
            Console.Write("Add meg az a és b oldal által bezárt szöget: y=");
            double h_y=double.Parse(Console.ReadLine());
            Console.WriteLine($"A háromszög c oldala: {Math.Sqrt(Math.Pow(h_a2,2)+Math.Pow(h_b2,2)-2*h_a2*h_b2*Math.Cos(h_y))}, Területe: {(h_a2*h_b2*Math.Sin(h_y))/2}");

            //16. Feladat
            double g = 9.81;
            Console.Write("Add meg a vízszintes hajítás kezdő sebességét m/s-ben: v0=");
            double v0=double.Parse(Console.ReadLine());
            Console.Write("Add meg az időt másodperc-ben: t=");
            double t = double.Parse(Console.ReadLine());
            Console.WriteLine($"Az X-koordináta: {v0*t}, Az Y-koordináta: {g/2*Math.Pow(t,2)}");

            //17. Feladat
            Console.Write("Add meg a vízszintessel bezárt szöget: a=");
            double f_a=double.Parse(Console.ReadLine());
            Console.Write("Add meg a kezdősebességet m/s-ben: v0=");
            double f_v0 = double.Parse(Console.ReadLine());
            Console.Write("Add meg az eltelt időt másodpercben: t=");
            double f_t = double.Parse(Console.ReadLine());
            Console.WriteLine($"Pillanatnyi helyzetének koordinátái: X= {f_v0*f_t*Math.Cos(f_a)}, Y= {f_v0*f_t*Math.Sin(f_a)-g/2*Math.Pow(f_t,2)}");
            Console.WriteLine($"Pillanatnyi Sebesség koordinátái: Vx= {f_v0*Math.Cos(f_a)}, Vy= {f_v0*Math.Sin(f_a)-g*f_t}");
            Console.WriteLine($"Az emelkedés ideje: Tem= {(f_v0*Math.Sin(f_a))/g}");
            Console.WriteLine($"A hajítás távolsága: Xmax= {(Math.Pow(f_v0,2)*Math.Sin(2*f_a))/g}");
            Console.WriteLine($"az emelkedés maximális értéke: Ymax= {(Math.Pow(f_v0,2)*Math.Pow(Math.Sin(f_a),2)/2*g)}");


            Console.WriteLine("Nyomd le az Enter-t!");
            Console.ReadLine();


        }
    }
}
