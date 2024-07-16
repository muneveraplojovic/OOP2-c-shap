using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kockice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int randomBrojIgraca;
            int randomBrojProtivnika;

            int igraceviPoeni = 0;
            int proticnickiPoeni = 0;

            Random random = new Random();

            Console.WriteLine("Dobro dosli u moj program bacanja kockica. Srecno!");

            for (int i = 0; i < 10; i++)
            {

                Console.WriteLine("Pritisni bilo koji taster da bacis kockicu.");
                Console.ReadKey();

                randomBrojIgraca = random.Next(1, 7);
                Console.WriteLine("Dobio/la si broj: " + randomBrojIgraca);

                Console.WriteLine("...");
                System.Threading.Thread.Sleep(1000);

                randomBrojProtivnika = random.Next(1, 7);
                Console.WriteLine("Protivnik/ca je dobio/la broj: " + randomBrojProtivnika);
                Console.WriteLine();

                Console.WriteLine("Rezultat je: ");
                Console.WriteLine("Igrac: " + igraceviPoeni + " : " + "Protivnik: " + proticnickiPoeni + ".");
                Console.WriteLine();

                if (randomBrojIgraca > randomBrojProtivnika)
                {
                    igraceviPoeni++;
                    Console.WriteLine("Igrac je pobedio u ovom bacanju!");
                }
                else if(randomBrojProtivnika > randomBrojIgraca)
                {
                    proticnickiPoeni++;
                    Console.WriteLine("Protivnik je pobedio u ovom bacanju!");

                }
                else
                {
                    Console.WriteLine("Nereseno!");
                }
                Console.WriteLine();
            }
            Console.ReadKey();

        }
    }
}
