using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIG.UIP.HW2.ConditionsArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomizer = new Random();
            int randomIntValue1 = randomizer.Next(-50, 50);
            int randomIntValue2 = randomizer.Next(-50, 50);
            int randomIntValue3 = randomizer.Next(-50, 50);

            Console.WriteLine("First random    " + randomIntValue1);
            Console.WriteLine("Second random   " + randomIntValue2);
            Console.WriteLine("Third random    " + randomIntValue3);
            

            int a = randomIntValue1;
            int b = randomIntValue2;
            int c = randomIntValue3;

                    // task #1 (check number "-" or "+")
            if (a > 0)
                Console.WriteLine("Number(a) is positive");
            else
                Console.WriteLine("Number(a) is negative");


                    // task #2 (check number even or odd)
            if ((a % 2) == 0)
                Console.WriteLine("The number "+ a +"  is even");
            else
                Console.WriteLine("The humber " + a + "  is odd");


                    // task #3 (check which of the numbers is greater)            
            bool isBiggerABC = (a < b && b < c);
                Console.WriteLine(a + "<" + b + "<" + c + "   =   " + isBiggerABC  );


                    // task #4 (check  ones of numbers is bigger 0)
            bool isOnesOfNumbersPositive = (a > 0 || b > 0 || c > 0);
            Console.WriteLine("are there positive numbers  "+  a+",  "  +  b+",  "  +  c+",  "  + isOnesOfNumbersPositive);


                    // task #5 (check  only one of numbers is bigger 0)
            bool isOnlyOneOfNumbersPositive = (a > 0 || b > 0 || c > 0);
            Console.WriteLine("are there positive numbers  " + a + ",  " + b + ",  " + c + ",  " + isOnesOfNumbersPositive);

            Console.ReadLine();




        }
    }
}
