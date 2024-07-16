using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int broj1;
            int broj2;

            int rezultat;
            string operacija;

            Console.WriteLine("Zdravo, ja sam Maja!");
            Console.WriteLine("Dobro dosli na moj program kalkulatora!");
            
            Console.WriteLine("Unesite vas prvi broj: ");
            broj1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Unesite vas drugi broj: ");
            broj2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Izaberite koju operaciju zelite da radite?");
            Console.WriteLine("Molim vas unesite s za sabiranje, o za oduzimanje, m za mnozenje, d za deljenje");

            operacija = Console.ReadLine();

            if(operacija == "s")
            {
                rezultat = broj1 + broj2; 
            }
            else if(operacija == "o")
            {
                rezultat = broj1 - broj2;  
            }
            else if (operacija == "m")
            {
                rezultat = broj1 * broj2;
            }
            else {
                rezultat = broj1 / broj2;

            }

            Console.WriteLine("Rezultat vase operacije je: " + rezultat);
            Console.WriteLine("Hvala vam sto ste koristili moj program!");
            Console.ReadKey();
        }
    }
}
