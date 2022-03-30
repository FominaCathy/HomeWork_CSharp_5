using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.

namespace Task_36
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] arr = new int[7];
            int summ = 0;

            Creat_Array(arr);
            Print_Array(arr);
            Console.Write($" Сумма нечетных элементов в массиве: {Summ_Odd(arr)}");


            Console.Read();

            void Creat_Array(int[] array)
            {
                Random rng = new Random();
                int temp = array.Length;
                for (int i = 0; i < temp; i++)
                    array[i] = rng.Next(1, 10);
            }


            void Print_Array(int[] array)
            {
                Console.Write($" массив: {array[0]}, ");
                for (int i = 1; i < array.Length; i++)
                    Console.Write($"{array[i]}, ");
                Console.WriteLine();

            }

            int Summ_Odd(int[] array)
            {
                for (int i = 0; i < array.Length; i+=2)
                     summ += array[i];
                return summ;
            }
        }
    }
}
