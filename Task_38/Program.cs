using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Задача 38: Задайте массив вещественных чисел.
//Найдите разницу между максимальным и минимальным элементов массива.

namespace Task_38
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] arr = new double[10];
            double max = 0;
            double min = 0;

            Creat_Array(arr);
            Print_Array(arr);
            Count_Diff(arr);
            Console.Write($" разница между макс. {max} и мин. {min} элементов массива: {(max-min)}");


            Console.Read();

            void Creat_Array(double[] array)
            {
                Random rng = new Random();
                int temp = array.Length;
                for (int i = 0; i < temp; i++)
                    array[i] = rng.NextDouble();
            }


            void Print_Array(double[] array)
            {
                Console.Write($" массив: {array[0]},");
                for (int i = 1; i < array.Length; i++)
                    Console.Write($"{array[i]}, ");
                Console.WriteLine();

            }

            void Count_Diff(double[] array)
            {
                int temp = array.Length;
                max = array[0];
                min = array[0];
                for (int i = 1; i < temp; i++)
                {
                    if (array[i] > max) max = array[i];
                    if (array[i] < min) min = array[i];
                }

            }

        }
    }
}
