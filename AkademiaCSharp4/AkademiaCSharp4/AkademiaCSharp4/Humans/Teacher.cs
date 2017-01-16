using System;

namespace AkademiaCSharp4.Humans
{
    public class Teacher : Human
    {
        //konstruktor klasy Teacher przyjmujący 2 argumenty, który wywołuje konstruktor z klasy bazowej (Human)
        public Teacher(string name, string surname) : base(name, surname)
        {
        }

        //metoda konieczna do nadpisania, bez tego program nam się nie skompiluje
        //słowo kluczowe abstract przy metodzie w klasie bazowej zapewnia nam że musimy w klasie potomnej ją nadpisać
        public override void IntroduceYourself()
        {
            Console.WriteLine("Hello, I am teacher!");
            Console.WriteLine(Name);
            Console.WriteLine(Surname);
            Console.WriteLine();
        }
    }
}
