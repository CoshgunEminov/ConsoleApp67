using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp67
{
    internal class Triangle:Shape
    {
        private double Base {  get; set; }
         private double Heigth { get; set; }  

        public Triangle(double @base, double heigth)
        {
            Base = @base;
            Heigth = heigth;
        }
         public override double CalculateArea()
        {
            return  Base * Heigth;
        }
    }
}
