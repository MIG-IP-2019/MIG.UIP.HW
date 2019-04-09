using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение стороны А");
            double sideA = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение стороны В");
            double sideB = Convert.ToDouble(Console.ReadLine());

            Rectangle rectangle_01 = new Rectangle(sideA,sideB);
            Console.WriteLine("Perimetr = {0}, area = {1}", rectangle_01.Perimeter, rectangle_01.Squere);

            Console.ReadLine();

        }
    }
}
