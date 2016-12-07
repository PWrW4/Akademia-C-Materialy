namespace AkademiaCSharp4.Figures
{
    //publiczny interfejs będący spisem właściwości/metod/zdarzeń które klasa implementująca dany interfejs będzie musiała zaimplementować
    //jeśli nie będą zaimplementowane wszystkie właściwości/metody/zdarzenia w klasie implementującej interfejs, program nie skompiluje się!
    //nazwy interfejsów warto zaczynać duzą lietą "I" - praktyka programistyczna
    public interface IFigure
    {
        string Name { get; set; }
        int CalculateArea(int firstSide, int secondSide);
        void DisplayAreaInConsole();
    }
}
