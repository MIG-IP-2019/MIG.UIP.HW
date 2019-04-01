using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{
    class Rectangle
    {
        private double sideA, sideB;
       

        public Rectangle (double sideA,double sideB)
        {
            this.sideA = sideA;
            this.sideB = sideB;
        }

        double PerimeterCalculator()
        {
            return (sideA + sideB) * 2;
        }
        public double Perimeter
        {
            get
            {
                return this.PerimeterCalculator();
            }
        }

        double SquereRectangle()
        {
            return (sideA * sideB);
        }

        public double Squere
        {
            get
            {
                return this.Squere;
            }
        }
    }
   
    
}
