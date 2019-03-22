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
            Console.WriteLine("count of numbers = "+ countNumbersFirstTask);

            // Task#2  (Даны два целых числа A и B (A < B). Вывести в порядке убывания все целые числа, расположенные между A и B (не включая числа A и B), а также количество N этих чисел.)
            Console.WriteLine(" \r\n \r\n Response from task #2  ");
            for (int i = b-1; i > a; i--)
            {
                countNumbersSecondTask++;
                Console.WriteLine(i);                
            }
            Console.WriteLine("count of numbers = " + countNumbersSecondTask);


            // Task#3  (Начальный вклад в банке равен $1000. Через каждый месяц размер вклада увеличивается на P процентов от имеющейся суммы (P — вещественное число, 0 < P < 25). По данному P определить, через сколько месяцев размер вклада превысит $1100, и вывести найденное количество месяцев K (целое число) и итоговый размер вклада S (вещественное число).)
            Console.WriteLine(" \r\n \r\n Response from task #3  ");

            int startCapital = 1000;
            int percent = 5;
            int sFinalCapital = 0;
            int kMonths = 0;

            for (int i = 1; startCapital <= 1100; i++) {
                startCapital = startCapital / 100 * percent + startCapital;
                kMonths++;               
                //Console.WriteLine(startCapital);
                    }
            Console.WriteLine("Month count = "+kMonths);
            Console.WriteLine("Final capital "+startCapital );

            // Task#4  (Дано целое число N (> 0). Сформировать и вывести целочисленный массив размера N, содержащий N первых положительных нечетных чисел: 1, 3, 5, … .)
            Console.WriteLine(" \r\n \r\n Response from task #4  ");

            int n = 20;
            int[] array = new int [n];
            for (int i = 1; i < array.Length;i+=2)
            {
                array[i] =i;
                Console.WriteLine(array[i]);
            }

            






            Console.ReadLine();

        }

   

       

}


       
         
      

    
}
