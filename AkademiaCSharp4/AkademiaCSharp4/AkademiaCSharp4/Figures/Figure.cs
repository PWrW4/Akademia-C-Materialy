using System;

namespace AkademiaCSharp4.Figures
{
    //klasa implementuje interfejs IFigure - musi zaimplementować wszystkie metody/właściwości/zdarzenia zadeklarowane w tym interfejsie
    public class Figure : IFigure
    {
        public string FillColor { get; set; }

        public Figure(string fillColor)
        {
            FillColor = fillColor;
        }

        //metoda wirtualna klasy - może być nadpisana w klasie potomnej - ale nie musi
        public virtual void DisplayFillColor()
        {
            Console.WriteLine("Fill color of the figure is: " + FillColor);
        }

        //właściowści i metody zdefiniowane w interfejsie - bez których program nie skompiluje nam się
        //należy wypełnić je odpowiednimi akcjami, zależnie od klasy w której interfejs jest implementowany
        public string Name { get; set; }

        public int CalculateArea(int firstSide, int secondSide)
        {
            //jakieś działania matematyczne obliczajace pole
            //np.
            int sum = firstSide * secondSide;
            return sum; ;
        }

        public void DisplayAreaInConsole()
        {
            int area = CalculateArea(4, 3);
            Console.WriteLine();
        }
    }
}
