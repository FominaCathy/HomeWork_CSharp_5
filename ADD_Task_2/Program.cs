using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading.Tasks;

// Задача 2. На вход подаются два числа случайной длины.
// Найдите произведение каждого разряда первого числа на каждый разряд второго.
// Ответ запишите в массив.

// 24, 132-> { 2, 6, 4, 4, 12, 8}


namespace ADD_Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string number1, number2;
            
            Console.Write("Введите первое число: "); 
            number1 = Console.ReadLine();
            Console.Write("Введите второе число: ");
            number2 = Console.ReadLine();

            int length_arr = number1.Length * number2.Length;
            int[] arr = new int[length_arr];
            
            Fill_Array(arr); // заполняем массив 
            Print_Array(arr); // выводим на печать

            Console.Read();

            void Print_Array(int[] array)
            {
                Console.Write($" массив: {array[0]}, ");
                for (int i = 1; i < array.Length; i++)
                    Console.Write($"{array[i]}, ");
                Console.WriteLine();

            }

            void Fill_Array(int[] array)
            {
                int k = 0;
                for (int i = 0; i < number1.Length; i++)
                    for (int j = 0; j < number2.Length; j++)
                    {
                        array[k] = Convert.ToInt32(Char.GetNumericValue(number1[i]) * Char.GetNumericValue(number2[j]));
                        k++;
                    }
            }

            
        }
    }
}
