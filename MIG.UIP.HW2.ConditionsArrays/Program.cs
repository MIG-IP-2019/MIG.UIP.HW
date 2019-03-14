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
            Console.WriteLine(" \r\n \r\n    Response from task #1");

            if (a > 0)
                Console.WriteLine("Number(a) is positive");
            else
                Console.WriteLine("Number(a) is negative");



            // task #2 (check number even or odd)
            Console.WriteLine("\r\n \r\n   Response from task #2");

            if ((a % 2) == 0)
                Console.WriteLine("The number " + a + "  is even");
            else
                Console.WriteLine("The humber " + a + "  is odd");



            // task #3 (check which of the numbers is greater)  
            Console.WriteLine(" \r\n \r\n   Response from task #3");

            bool isBiggerABC = (a < b && b < c);
            Console.WriteLine(a + "<" + b + "<" + c + "   =   " + isBiggerABC);


            // task #4 (check  ones of numbers is bigger 0)
            Console.WriteLine(" \r\n \r\n   Response from task #4");

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
            Console.WriteLine("\r\n \r\n  Response from task #5 (variant1)");
            Console.WriteLine("TEST method  is there only one positive numbers    " + a + "  ," + b + "  ," + c + "  ," + isOnePositiveNumber);
            Console.WriteLine("\r\n \r\n  Response from task #5 (variant2)");
            Console.WriteLine("is there only one positive numbers                 " + a + ",  " + b + ",  " + c + ",  " + isOnlyOneOfNumbersPositive);
            Console.WriteLine("How many possitive Numbers  in array               " + a + ",  " + b + ",  " + c + ",  " + howManyPossitiveNumbers);



            // task #6 (check.  is number  odd and  three digits?)
            Console.WriteLine(" \r\n \r\n  Response from task #6  ");

            int d = randomizer.Next(1, 2000);
            bool isNumberOdd = (((d % 2) == 1) && ((d >= 100) && (d <= 999)));
            Console.WriteLine("Is number    " + d + "     odd & three digits? " + isNumberOdd);

            // task 7 (point in rectangle)
            Console.WriteLine("  \r\n \r\n  Response from task #7  ");

            int x = randomizer.Next(-120, 120);
            int y = randomizer.Next(-120, 120);
            int x1 = randomizer.Next(-100, -1);
            int y1 = randomizer.Next(1, 100);
            int x2 = randomizer.Next(1, 100);
            int y2 = randomizer.Next(-100, -1);
            bool isPointInRectangle = ((x > x1) && (x < x2) && (y < y1) && (y > y2));

            Console.WriteLine("Is point X=" + x + "  ,  Y=" + y + "   in rectangle   " + x1 + " , " + y1 + "  x  " + x2 + " , " + y2 + "   " + isPointInRectangle);


            // task # 8 (can triangle to be?)
            Console.WriteLine(" \r\n \r\n  Response from task #8  ");

            //a = 2;   (for test method)
            //b = 3;   (for test method)
            //c = 4;   (for test method)

            a = randomizer.Next(1, 50);
            b = randomizer.Next(1, 50);
            c = randomizer.Next(1, 50);
            bool isTriangleBe = ((a < b + c) && (b < c + a) && (c < a + b));
            Console.WriteLine("Triangle " + " a=" + a + " b=" + b + " c=" + c + "   can to be = " + isTriangleBe);


            // task 9 (is this place white?)
            Console.WriteLine(" \r\n \r\n Response from task #9  ");

            x = randomizer.Next(1, 9);
            y = randomizer.Next(1, 9);
            bool isPlaceWhite = ((((x % 2) == 1) && ((y % 2) == 0)) || (((x % 2) == 0) && ((y % 2) == 1)));
            Console.WriteLine("The place x=" + x + ", y=" + y + " is white?  " + isPlaceWhite);




            // task 10 (chess quin)
            Console.WriteLine(" \r\n \r\n  Response from task #10  ");

            x1 = randomizer.Next(1, 9);
            y1 = randomizer.Next(1, 9);
            x2 = randomizer.Next(1, 9);
            y2 = randomizer.Next(1, 9);
            Console.WriteLine("from point A(" + x1 + " : " + y1 + ") to point B (" + x2 + " : " + y2 + ")");
            if ((x1 == x2) || (y1 == y2))
            {
                Console.WriteLine("Quin can go");
            }

            else
            {
                if ((Math.Abs(x1 - x2)) == (Math.Abs(y1 - y2))) {
                    Console.WriteLine("Quin can go");
                }
                else
                    Console.WriteLine("Quin can't go");
            }


            // task 11 (chess quin)
            Console.WriteLine(" \r\n \r\n  Response from task #11  ");

            a = -310;
            b = 721;

            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("After change , A=" + a + ", B=" + b);



            // task 12 (Day of a week)
            Console.WriteLine(" \r\n \r\n Response from task #12  ");
            int day = randomizer.Next(1, 7);
            Console.WriteLine("Number case  " + day);

            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
            }




            // task 13 (Raiting)
            Console.WriteLine(" \r\n \r\n Response from task #13  ");
            int rating = randomizer.Next(1, 10);
            Console.WriteLine("Raiting  " + rating);

            switch (rating)
            {
                case 1:
                    Console.WriteLine("Bed");
                    break;

                case 2:
                    Console.WriteLine("Not Bed");
                    break;
                case 3:
                    Console.WriteLine("Good");
                    break;
                case 4:
                    Console.WriteLine("Very good");
                    break;
                case 5:
                    Console.WriteLine("Exelent");
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }


            // task 15 (Measure of length)
            Console.WriteLine(" \r\n \r\n Response from task #15  ");
            int measureName = randomizer.Next(1, 6);           
            double length = randomizer.NextDouble()* (100) ;

            length = Math.Round(length, 2);


            switch (measureName)
            {
                case 1:
                    Console.WriteLine(length+"Decimeter ="+ length/10+" meter");
                    break;
                case 2:
                    Console.WriteLine(length + "Kilometer =" +length * 1000 + " meter");
                    break;
                case 3:
                    Console.WriteLine(length + "Meter =" + length +  " meter");
                    break;
                case 4:
                    Console.WriteLine(length + "Millimeter =" + length / 1000 + " meter");
                    break;
                case 5:
                    Console.WriteLine(length + "Centimeter =" + length/ 100 + " meter");
                    break;
               
            }


            // task 16 (Numbers from 1 to 99)
            Console.WriteLine(" \r\n \r\n Response from task #15  ");


            int number = randomizer.Next(1, 100);
            if (number >= 1 && number <= 19)
            {
                switch (number)
                {
                    case 1:
                        Console.WriteLine("One");
                        break;
                    case 2:
                        Console.WriteLine("Two");
                        break;
                    case 3:
                        Console.WriteLine("Three");
                        break;
                    case 4:
                        Console.WriteLine("Four");
                        break;
                    case 5:
                        Console.WriteLine("Five");
                        break;
                    case 6:
                        Console.WriteLine("Six");
                        break;


                }

            }




            Console.ReadLine();
            
        }
    }
}
