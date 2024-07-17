using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool pogodjenBroj = false;
            Random random = new Random();
            int randomBroj = random.Next(1, 11);

            Console.WriteLine("Dobro dosli u igru pogadjanja broja!");
            Console.WriteLine("Nasumican broj izmedju 1 i 10 ce biti generisan.");
            Console.WriteLine("Ukoliko pogodite broj vi pobedjujete. Srecno!");

            while (!pogodjenBroj)
            {

                Console.WriteLine("Pokusajte da pogodite broj: ");
                int nagodjeniBroj = Convert.ToInt32(Console.ReadLine());


                if(nagodjeniBroj > randomBroj)
                {
                    Console.WriteLine("Vas nagodjeni broj je mnogo visok.");
                }
                else if (nagodjeniBroj < randomBroj)
                {
                    Console.WriteLine("Vas nagodjeni broj je mnogo manji.");
                }
                else
                {
                    Console.WriteLine("Pogodili ste broj!");
                    pogodjenBroj = true;
                }
            }

            Console.WriteLine("Cestitamo, pobedili ste!");
            Console.ReadKey();
        }
    }
}
