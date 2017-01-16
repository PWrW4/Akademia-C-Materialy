using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkademiaCSharp3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tablice i listy
            //IntroduceCollection();
            

            // Klasy i obiekty

            // Scenariusz z konstruktorem domyślnym
            //var citizen = new Citizen();
            //Console.WriteLine(citizen.ToString());
            //Console.WriteLine(citizen.CalculateTax());
            //citizen.Income = 1800;
            //citizen.Name = "Kamil";


            // Scenariusz ze zdefiniowanym konstruktorem przyjmującym argumenty
            var citizen = new Citizen("Kasia", 2000, 0.2);
            Console.WriteLine(citizen.ToString());
            Console.WriteLine(citizen.CalculateTax());



            // Poniższy kod został zakomentowany, 
            // ponieważ metoda "Format" jest teraz statyczna
            //var formatter = new CitizenFormatter();
            Console.WriteLine(CitizenFormatter.Format(citizen));



            // Lista obywateli
            var citizens = new List<Citizen>()
            {
                new Citizen("Jan", 1800, 0.2),
                new Citizen("Anna", 1800, 0.3),
                new Citizen("Tomasz", 2000, 0.2)
            };

            foreach (var citizen1 in citizens)
            {
                Console.WriteLine(CitizenFormatter.Format(citizen1));
            }

            Console.ReadKey();
        }


        public static void IntroduceCollection()
        {
            // Tablica
            int [] numbers = new int[5];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = i+1;
                Console.WriteLine(numbers[i]);
            }
            numbers[2] = 8;

            // Błąd!
            //Console.WriteLine(numbers[7]);

            
            // Lista
            var names = new List<string> {"Jan", "Anna", "Tomek", "Dawid"};
            names.Sort();
            names.Reverse();
            var isJan = names.Contains("Jan");

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }          

            Console.ReadKey();
        }
    }
}
