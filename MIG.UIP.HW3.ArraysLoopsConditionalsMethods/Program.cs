using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MIG.UIP.HW3.ArraysLoopsConditionalsMethods

{
    class Program
    {
        static void Main(string[] args)
        {
            // Task#1  (Даны два целых числа A и B (A < B). Вывести в порядке возрастания все целые числа, расположенные между A и B (включая сами числа A и B), а также количество N этих чисел.)
            Console.WriteLine("Response from task #1  ");
            int a = 10, b = 55;
            int countNumbersFirstTask = 0;
            int countNumbersSecondTask = 0;
            for (int i = a; i <= b; i++)
            {
                countNumbersFirstTask++;
                Console.WriteLine(i);
            }
            Console.WriteLine("count of numbers = " + countNumbersFirstTask);

            // Task#2  (Даны два целых числа A и B (A < B). Вывести в порядке убывания все целые числа, расположенные между A и B (не включая числа A и B), а также количество N этих чисел.)
            Console.WriteLine(" \r\n \r\n Response from task #2  ");
            for (int i = b - 1; i > a; i--)
            {
                countNumbersSecondTask++;
                Console.WriteLine(i);
            }
            Console.WriteLine("count of numbers = " + countNumbersSecondTask);


            // Task#3  (Начальный вклад в банке равен $1000. Через каждый месяц размер вклада увеличивается на P процентов от имеющейся суммы (P — вещественное число, 0 < P < 25).
            // По данному P определить, через сколько месяцев размер вклада превысит $1100, и вывести найденное количество месяцев K (целое число) и итоговый размер вклада S (вещественное число).)
            Console.WriteLine(" \r\n \r\n Response from task #3  ");

            float capital = 1000f;
            float percent = 3.2f;            
            int kMonths = 0;

            for (; capital < 1100;)
            {
                kMonths++;
                capital = capital / 100 * percent + capital;
                Console.WriteLine("test" + capital);
            }
            Console.WriteLine("month count = " + kMonths);
            Console.WriteLine("Final capital= " + capital);

            //do
            //{
            //    capital = capital / 100 * percent + capital;
            //    kMonths++;
            //    Console.WriteLine("тест месяца " + kMonths);
            //    Console.WriteLine("тест капитал " + capital);
            //}
            //while (capital < 1100);




            // Task#4  (Дано целое число N (> 0). Сформировать и вывести целочисленный массив размера N, содержащий N первых положительных нечетных чисел: 1, 3, 5, … .)
            Console.WriteLine(" \r\n \r\n Response from task #4  ");

            int n = 20;
            int[] array = new int[n];
            for (int i = 1; i < array.Length; i += 2)
            {
                array[i] = i;
                Console.WriteLine(array[i]);
            }


            // Task#5  (Дан массив размера N. Вывести его элементы в обратном порядке.)
            Console.WriteLine(" \r\n \r\n Response from task #5  ");

            n = 12;
            int[] arrayTaskFive = new int[n];
            Random randomForTask = new Random();
            for (int i = arrayTaskFive.Length - 1; i >= 0; i--)
            {

                arrayTaskFive[i] = randomForTask.Next(1, 50);
                Console.WriteLine("index=" + i + "  value=" + arrayTaskFive[i]);
            }


            // Task#6  (Дан целочисленный массив размера N. Вывести вначале все содержащиеся в данном массиве четные числа в порядке возрастания их индексов,
            //           а затем — все нечетные числа в порядке убывания их индексов. Также вывести количество четных и нечетных членов массива.)
            Console.WriteLine(" \r\n \r\n Response from task #6  ");

            n = 10;
            //Random randomArraysNumbers = new Random();            
            int[] arraysForTask = new int[n];
            for (int i = 0; i <= arraysForTask.Length - 1; i++)
            {
                arraysForTask[i] = randomForTask.Next(1, 50);
                if (arraysForTask[i] % 2 == 0)
                {
                    Console.WriteLine("odd number (index)=" + i + "  value =  " + arraysForTask[i]);
                }

            }
            for (int j = arraysForTask.Length - 1; j >= 0; j--)
            {
                if (arraysForTask[j] % 2 != 0)
                {

                    Console.WriteLine("even number (index)=" + j + "  (value) =  " + arraysForTask[j]);
                }

            }


            // Task#7  (Дан массив A размера N (N — четное число). Вывести его элементы с четными номерами в порядке возрастания номеров: A2, A4, A6, …, AN. Условный оператор не использовать.)
            Console.WriteLine(" \r\n \r\n Response from task #7  ");

            n = 8;
            int[] arrayA = new int[n];
            for (int i = 0; i < arrayA.Length ; i++)
            {
                arrayA[i] = randomForTask.Next(1, 20);
                Console.WriteLine("Array A before sorting   " + arrayA[i]);
            }

            for (int i = 0; i < arrayA.Length ; i++)
            {
                for (int t = i + 1; t < arrayA.Length ; t++)
                {
                    while (arrayA[t] < arrayA[i])
                    {
                        arrayA[i] = arrayA[i] + arrayA[t];
                        arrayA[t] = arrayA[i] - arrayA[t];
                        arrayA[i] = arrayA[i] - arrayA[t];
                    }
                }

            }

            for (int i = 0; i <= arrayA.Length - 1; i++)
            {
                if ((arrayA[i] % 2) == 0)
                {
                    Console.WriteLine("after sorting   array A " + arrayA[i]);
                }
                //Console.WriteLine("test all result" + arrayA[i]);
            }

            // Task#8  (Дан целочисленный массив размера N. Найти количество различных элементов в данном массиве.)
            Console.WriteLine(" \r\n \r\n Response from task #8  ");

            n = 5;             
            int differentElements = 0;            
            int[] arrayB = new int[n] ;
            for (int i =0; i<arrayB.Length;i++)
            {
                arrayB[i] = randomForTask.Next (1, 10);
                Console.WriteLine("Array B before sorting   "+arrayB[i]);
            }

            for (int i =0; i<=arrayB.Length-1;i++)
            {
                bool nextElement = true;
                for (int k =i+1; k<=arrayB.Length-1;k++)
                {
                    if (arrayB[i] == arrayB[k])
                    {                        
                        nextElement = false;
                        break;
                    }                    
                }
                if (nextElement)
                {
                    differentElements++;                  
                }
            }            

            Console.WriteLine("different elements of array B =  "+ differentElements);
       
           




            Console.ReadLine();





            // Task#9  (Дано целое число N (> 0). Найти произведение N! = 1·2·…·N (N–факториал). Чтобы избежать целочисленного переполнения, 
            //          вычислять это произведение с помощью вещественной переменной и вывести его как вещественное число. Использовать рекурсию.)
            Console.WriteLine(" \r\n \r\n Response from task #9  ");

            n = 10;


        }


            
           











            

        
    }




}



