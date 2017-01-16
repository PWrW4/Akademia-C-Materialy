using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkademiaCSharp3
{
    public class Citizen
    {
        public string Name { get; set; }        
        public double Income { get; set; }
        private double _taxRate;


        // Konstruktor I
        public Citizen(string name, double income, double taxRate)
        {
            Name = name;
            Income = income;
            _taxRate = taxRate;
        }

        // Konstruktor II - przyjmuje inne argumenty
        public Citizen(string name, double income)
        {
            Name = name;
            Income = income;
            // Nie ma takiego argumentu, więc możemy podać wartość domyślną
            _taxRate = 0.1;
        }


        public double CalculateTax()
        {
            return _taxRate*Income + 10;
        }
    }
}
