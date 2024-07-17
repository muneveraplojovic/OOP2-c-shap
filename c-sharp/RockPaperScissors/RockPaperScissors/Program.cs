using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int igraceviPoeni = 0;
            int protivnickiPoeni = 0;

            Console.WriteLine("Dobro dosli u igru papir, kamen, makaze!");

            Random random = new Random();

            
            while (igraceviPoeni != 3 && protivnickiPoeni != 3) 
            {
                Console.WriteLine("Protivnicki poeni: " + protivnickiPoeni);
                Console.WriteLine("Igracevi poeni: " + igraceviPoeni);
                Console.WriteLine();

                Console.WriteLine("Izaberite p za papir, k za kamen, m za makaze.");
                string igracevOdabir = Console.ReadLine();
                Console.WriteLine();

                int protivnickiOdabir = random.Next(0,3);

                if(protivnickiOdabir == 0)
                {
                    Console.WriteLine("Protivnik je izabrao papir.");
                    Console.WriteLine();

                    switch (igracevOdabir)
                    {
                        case "p":
                            Console.WriteLine("Nereseno");
                            Console.WriteLine();
                            break;
                        case "k":
                            Console.WriteLine("Protivnik je pobedio.");
                            Console.WriteLine();
                            protivnickiPoeni++;
                            break;
                        default:
                            Console.WriteLine("Igrac je pobedio.");
                            Console.WriteLine();
                            igraceviPoeni++;
                            break;
                    }
                }
                else if(protivnickiOdabir == 1)
                {
                    Console.WriteLine("Protivnik je izabrao kamen.");
                    Console.WriteLine();

                    switch (igracevOdabir)
                    {
                        case "p":
                            Console.WriteLine("Igrac je pobedio.");
                            Console.WriteLine();
                            igraceviPoeni++;
                            break;
                        case "k":
                            Console.WriteLine("Nereseno");
                            Console.WriteLine();
                            break;
                        default:
                            Console.WriteLine("Protivnik je pobedio.");
                            Console.WriteLine();
                            protivnickiPoeni++;
                            break;
                    }

                }
                else
                {
                    Console.WriteLine("Protivnik je izabrao makaze.");
                    Console.WriteLine();

                    switch (igracevOdabir)
                    {
                        case "p":
                            Console.WriteLine("Protivnik je pobedio.");
                            Console.WriteLine();
                            protivnickiPoeni++;
                            break;
                        case "k":
                            Console.WriteLine("Igrac je pobedio.");
                            Console.WriteLine();
                            igraceviPoeni++;
                            break;
                        default:
                            Console.WriteLine("Nereseno");
                            Console.WriteLine();
                            break;
                    }
                }

            }

            if(igraceviPoeni == 3)
            {
                Console.WriteLine("Vi ste pobedili u ovoj igri!");
            }
            else
            {
                Console.WriteLine("Protivnik je pobedio u ovoj rundi, Vi ste izgubili!");
            }

            Console.ReadKey();

        }
    }
}
