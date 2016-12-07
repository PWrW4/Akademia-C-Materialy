namespace AkademiaCSharp4.Mammals
{
    //klasa bazowa
    public class Mammal
    {
        public int LegAmount { get; set; }
        public string Gender { get; set; }

        //konstruktor
        public Mammal(int legAmount, string gender)
        {
            LegAmount = legAmount;
            Gender = gender;
        }
    }
}
