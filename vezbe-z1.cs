using System;

namespace z2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informacije o record");

            Student Amel = new Student("Amel", "Sijaric", 9);
            Student Amin = new Student("Amin", "Melic", 10);
            Student Melic = new Student("Amin", "Melic", 10);

            var (i, p, pr) = Amel;
            Console.WriteLine(pr);

            if (Amel == Amin)
                Console.WriteLine("Prvi i drugi studenti su isti");
            if (Amel == Melic)
                Console.WriteLine("Prvi i treci studenti su isti");
            if (Amin == Melic)
                Console.WriteLine("Drugi i treci studenti su isti");

            Console.WriteLine($"Informacije o studentu su {Amel}");
            Console.WriteLine($"Informacije o studentu su {Amin}");
            Console.WriteLine($"Informacije o studentu su {Melic}");

            Console.WriteLine($"GetHackCode o studentu1 su {Amel.GetHashCode()}");
            Console.WriteLine($"GetHackCode o studentu2 su {Amin.GetHashCode()}");
            Console.WriteLine($"GetHackCode o studentu3 su {Melic.GetHashCode()}");

            Console.WriteLine("Informacije o klasi");

            Student1 cAmel = new Student1("Amel", "Sijaric", 9);
            Student1 cAmin = new Student1("Amin", "Melic", 10);
            Student1 cMelic = new Student1("Amin", "Melic", 10);

            if (cAmel == cAmin)
                Console.WriteLine("Prvi i drugi studenti su isti");
            if (cAmel == cMelic)
                Console.WriteLine("Prvi i treci studenti su isti");
            if (cAmin == cMelic)
                Console.WriteLine("Drugi i treci studenti su isti");

            Console.WriteLine($"Informacije o studentu su {cAmel}");
            Console.WriteLine($"Informacije o studentu su {cAmin}");
            Console.WriteLine($"Informacije o studentu su {cMelic}");

            Console.WriteLine($"GetHackCode o studentu1 su {cAmel.GetHashCode()}");
            Console.WriteLine($"GetHackCode o studentu2 su {cAmin.GetHashCode()}");
            Console.WriteLine($"GetHackCode o studentu3 su {cMelic.GetHashCode()}");
        }
    }
    // RECORD TREBA KORISTITI SAMO KADA SU VASI OBJEKTI READ-ONLY
    public record Student(string Ime,string Prezime,float Prosek);

    public record Profesor(string Ime,string Prezime,float Prosek,int plata) : Student(Ime,Prezime,Prosek);

    public class Student1
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public float Prosek { get; set; }

        public Student1(string i,string p,float pr)
        {
            Ime = i;
            Prezime = p;
            Prosek = pr;
        }
        public override string ToString()
        {
            return $"Ime = {Ime}, Prezime = {Prezime},Prosek = {Prosek}";
        }
    }
}
