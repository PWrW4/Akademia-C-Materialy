using System;

namespace AkademiaCSharp4.Figures
{
    //klasa rectangle dziedziczą po klase bazowej Figure
    //dziedziczy właściwości/metody/zdarzenia zdefiniowane w klasie Figure
    public class Rectangle : Figure
    {
        public int FirstSide { get; set; }
        public int SecondSide { get; set; }

        //konsturktor klasy rectangle, wywołujący konstruktor klasy bazowej(klasy Figure) + dodatkowo wypełniający nowo dodane właściowści
        public Rectangle(string fillColor, int firstSide, int secondSide) : base(fillColor)
        {
            FirstSide = firstSide;
            SecondSide = secondSide;
        }

        //przesłonięta metoda z klasy bazowej
        //przesłonięcie uzyskujemy za pomocą słowa kluczowego override
        //nalezy pamiętać żeby modyfikator dostępu, zwracany typ, nazwa, oraz argumenty były identyczne jak w nadpisywanej metodzie
        public override void DisplayFillColor()
        {
            //tutaj definiujemy nową definicje metody
            Console.WriteLine("Fill color of the rectangle is: " + FillColor);
            //jest to jednak tylko przesłonięcie, więc wciąż możemy wywołać metodę z klasy bazowej
            //w tym celu używamy słowa kluczowego base a po kropce, nazwe wywoływanej metody
            Console.WriteLine("DisplayFillColor z klasy bazowej:");
            base.DisplayFillColor();
        }
    }
}
