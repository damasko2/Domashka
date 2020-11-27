using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domashka
{
    public class Product
    {
        //private string Name;
        //private string ManufacturerCountry;
        //private double TheCost;
        public string Name { get; private set; }
        public string ManufacturerCountry { get; private set; }
        public double TheCost { get; private set; }

        public Product(string Name, string ManufacturerCountry, double TheCost)
        {
            this.Name = Name;
            this.ManufacturerCountry = ManufacturerCountry;
            this.TheCost = Math.Round(TheCost, 2);
        }

        public override string ToString()
        {
            return $"{Name} || {ManufacturerCountry} || {TheCost}";
        }
    }
}
