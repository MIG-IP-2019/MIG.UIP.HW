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
                Console.WriteLine("The number " + a + "  is even");
            else
                Console.WriteLine("The humber " + a + "  is odd");


            // task #3 (check which of the numbers is greater)            
            bool isBiggerABC = (a < b && b < c);
                Console.WriteLine(a + "<" + b + "<" + c + "   =   " + isBiggerABC);


            // task #4 (check  ones of numbers is bigger 0)
            bool isOnesOfNumbersPositive = (a > 0 || b > 0 || c > 0);
                Console.WriteLine("are there positive numbers  " + a + ",  " + b + ",  " + c + ",  " + isOnesOfNumbersPositive);


                    // task #5 (check  only one of numbers is bigger 0)  Variant 1                        
                    int ax = (a > 0 && a != 0) ? 1 : 0;
                    int bx = (b > 0 && b != 0) ? 1 : 0;
                    int cx = (c > 0 && c != 0) ? 1 : 0;
                    bool isOnlyOneOfNumbersPositive = ((ax + bx + cx) == 1);
                    int howManyPossitiveNumbers = ax + bx + cx;

                    // task #5 (check  only one of numbers is bigger 0)  Variant 2
                    bool isOnePositiveNumber = ((a > 0 ^ b > 0) ^ (c > 0 && (a < 0 || b < 0)));  // this method do not working , if ons of the random numbers is "0".

                    Console.WriteLine("TEST method  is there only one positive numbers    " + a + "  ," + b + "  ," + c + "  ," + isOnePositiveNumber);
                    Console.WriteLine("is there only one positive numbers                 " + a + ",  " + b + ",  " + c + ",  " + isOnlyOneOfNumbersPositive);
                    Console.WriteLine("How many possitive Numbers  in array               " + a + ",  " + b + ",  " + c + ",  " + howManyPossitiveNumbers);
                    


            // task #6 (check.  is number  odd and  three digits?)
            int d = randomizer.Next(1, 2000);
            bool isNumberOdd = (((d % 2) == 0) && ((d >= 100) && (d <= 999)));
                Console.WriteLine("Is number    " + d + "     odd & three digits? " + isNumberOdd);

            // task 7 (point in rectangle)
            int x = randomizer.Next(-120, 120);
            int y = randomizer.Next(-120, 120);            
            int x1 = randomizer.Next(-100, -1);
            int y1 = randomizer.Next(1, 100);
            int x2 = randomizer.Next(1, 100);
            int y2 = randomizer.Next(-100, -1);                     
              bool isPointInRectangle = ((x > x1) && (x < x2)&&(y<y1)&&(y>y2));
            
            Console.WriteLine("Is point  " + x + "  ,  " + y+"   in rectangle   " + x1+" , " + y1 + "  x  " + x2 + " , " + y2 + "   " + isPointInRectangle);

            Console.ReadLine();
        }
    }
}
