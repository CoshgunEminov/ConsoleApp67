using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp67
{
    internal class Square:Shape
    {
        private double Side {  get; set; }

        public Square(double side) 
        {
            Side = side;
        }
         public override double CalculateArea() 
        {
            return Side * Side;
        }
    }
}
