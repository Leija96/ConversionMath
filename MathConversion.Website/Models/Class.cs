using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MathConversion.Website.Models
{
    public class Problem
    {
        public string Fraction {get; set;}
        public double Decimal  { get; set; }
        public int Percentage { get; set; }
        public override string ToString()
        {
            return String.Format("Fraction = {0}, Decimal = {1}, Percentage = {2}", Fraction, Decimal, Percentage);

        }
    }
}
