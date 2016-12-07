using System;

namespace AkademiaCSharp4.Mammals
{
    //klasa potomna, dziedzicząca po klasie Mammal
    public class Cat : Mammal
    {
        public string Name { get; set; }

        //konstukor wykorzystujący konstuktor klasy bazowej (inicjalizatora)
        public Cat(string name, int legAmount, string gender) : base(legAmount, gender)
        {
            Name = name;
        }

        public void DisplayInfo()
        {
            Console.WriteLine("Cat name is: " + Name);
            Console.WriteLine("Cat gender is: " + Gender);
            Console.WriteLine("Cat amount of legs is: " + LegAmount);
        }
    }
}
