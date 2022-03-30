using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADD_Task_3
{
    //Задача 3. Найдите все числа от 1 до 1000000,
    //сумма цифр которых в три раза меньше их произведений.
    //Подсчитайте их количество.

    internal class Program
    {
        static void Main(string[] args)
        {
            int summ = 0;
            int mult = 1;
            int temp;
            int counter = 0;
            Console.WriteLine("Числа, удовлетворяющие условию: ");

            for (int i = 1; i <= 1000000; i++)
            {
                temp = i;
                summ = 0;
                mult = 1;
                
                while (temp > 0)
                {
                    summ += temp % 10;
                    mult *= temp % 10;
                    temp /= 10;
                    
                }
                if (summ * 3 == mult)
                {
                    counter++;
                    Console.Write($"{i}, ");
                }
            }
            Console.WriteLine($"Кол-во чисел, удовлетворяющие условию: {counter}");

            Console.ReadLine();
 
        }
    }
}
