using System;
using AkademiaCSharp4.Figures;
using AkademiaCSharp4.Humans;
using AkademiaCSharp4.Mammals;

namespace AkademiaCSharp4
{
    class Program
    {

        static void PresentRectangle()
        {
            //tworzenie klasy rectangle
            var rectangle = new Rectangle("red", 4, 5);
            rectangle.DisplayFillColor();
        }

        static void PresentCat()
        {
            //tworzenie klasy Cat
            var cat = new Cat("Andrzej", 4, "male");
            cat.DisplayInfo();
        }

        static void PresentTeacher()
        {
            //tworzenie klasy Teacher
            var teacher = new Teacher("Andrzej", "Ziomeczek");
            teacher.IntroduceYourself();
        }

        static void Main(string[] args)
        {
            PresentRectangle();
            PresentCat();
            PresentTeacher();

            Console.ReadKey();
        }
    }
}
