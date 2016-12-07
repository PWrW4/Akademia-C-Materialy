using System;

namespace AkademiaCSharp4.Humans
{
    //klasa abstrakcyjna będąca klasą bazową dla klas po niej dziedziczącej
    //nie możemy utworzyć obiektu klasy abstrakcyjnej !
    //klasa abstrakcyjna musi posiadać przynajmniej 1 metodę abstrakcyjną
    public abstract class Human
    {
        //publiczne właściwości
        public string Name { get; set; }
        public string Surname { get; set; }
        
        //konstruktor klasy, nie można stworzyć obiektu klasy abstrakcyjnej więc posiada on modyfikator protected - tak by mógł być wywołany przez klasę potomną
        protected Human(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }
        
        //normalna metoda, będzie dziedziczona w normalny sposób, nie wymaga nadpisywania
        public void Sleep()
        {
            Console.WriteLine("I am sleeping!");
        }

        //metoda abstrakcyjna - Nie posiada definicji, jedynie DEKLARACJA!
        //musi być nadpisana (za pomocą override) w klasach potomnych
        public abstract void IntroduceYourself();
    }
}
