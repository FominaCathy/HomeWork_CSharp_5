using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
//Напишите программу, которая покажет количество чётных чисел в массиве.

namespace Task_34
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            int count = 0;

            Creat_Array(arr);
            Print_Array(arr);
            Console.Write($" кол-во положительных чисел в массиве: {Count_Even(arr)}");  


            Console.Read();

            void Creat_Array(int[] array)
            {
                Random rng = new Random();
                int temp = array.Length;
                for (int i = 0; i < temp; i++)
                    array[i] = rng.Next(100, 1000);
            }

            
            void Print_Array(int[] array)
            {
                Console.Write($" массив: {array[0]},");
                for (int i = 1; i < array.Length; i++)
                    Console.Write($"{array[i]}, ");
                Console.WriteLine();

            }

            int Count_Even(int[] array)
            {
                int temp = array.Length;
                for (int i = 0; i < temp; i++)
                    if (array[i] % 2 == 0) count++;
                return count;
            }
        }
    }
}
