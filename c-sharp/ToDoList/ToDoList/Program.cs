using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Dobro dosli u to do aplikaciju!");
            Console.WriteLine();
            List<string> listaObaveza = new List<string>();
            string opcija = "";



            while(opcija != "e")
            {
                Console.WriteLine();
                Console.WriteLine("Izaberite neku od opcija: ");
                Console.WriteLine();


                Console.WriteLine("Izaberite 1 ukoliko zelite da dodate nesto u listu...");
                Console.WriteLine("Izaberite 2 ukoliko zelite da izbrisete nesto iz liste...");
                Console.WriteLine("Izaberite 3 ukoliko zelite da prikazete listu...");
                Console.WriteLine("Izaberite e ukoliko zelite da izadjete iz programa...");

                opcija = Console.ReadLine();

                if(opcija == "1")
                {
                    Console.WriteLine("Dodajte u listu: ");
                    string obaveza = Console.ReadLine();
                    listaObaveza.Add(obaveza);
                    Console.WriteLine();
                    Console.WriteLine("Obaveza je dodana u listu!");
                    Console.WriteLine();

                }
                else if(opcija == "2")
                {
                    for (int i = 0; i < listaObaveza.Count; i++)
                    {
                        Console.WriteLine(i + ": " + listaObaveza[i] + " [ ]");
                    }
                    Console.WriteLine();
                    Console.WriteLine("Izaberite sta zelite da izbrisete: ");
                    Console.WriteLine();
                    int brojObaveze = Convert.ToInt32(Console.ReadLine());
                    listaObaveza.RemoveAt(brojObaveze);
                }
                else if (opcija == "3") 
                {
                    Console.WriteLine();
                    Console.WriteLine("Vasa lista obaveza: ");
                    Console.WriteLine();

                    for(int i = 0; i < listaObaveza.Count; i++)
                    {
                        Console.WriteLine(i + ": " + listaObaveza[i] + " [ ]");
                    }

                }
                else if(opcija == "e")
                {
                    Console.WriteLine();
                    Console.WriteLine("Izasli ste iz programa. ");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Greska u unosu, molimo vas proverite ponovo vas unos!");
                }
            }

            Console.WriteLine("Hvala vam sto ste koristili nas program!");
            Console.ReadKey();
        }
    }
}
