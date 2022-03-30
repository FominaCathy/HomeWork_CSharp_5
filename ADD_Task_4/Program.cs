using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Задача 1 *.Дан массив массивов, состоящих из натуральных чисел, размер которого 5.
//Для каждого элемента-массива определить найти сумму его элементов и вывести массив с наибольшей суммой. 
//Если таких массивов несколько, вывести массив с наименьшим индексом.

namespace ADD_Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] jaggedArray = new int[5][];

            Creat_JaggedArray();
            Print_JaggedArray(jaggedArray);

            int summ = 0;
            int ind_max = 0;
            int temp_summ = 0;

            for (int i = 0; i < 5; i++)
            {
                temp_summ = 0;
                for (int j = 0; j < jaggedArray[i].Length; j++)
                    temp_summ += jaggedArray[i][j];
                if (temp_summ > summ)
                {
                    ind_max = i;
                    summ = temp_summ;
                }
            }

            Console.WriteLine($"массив с наибольшей суммой {summ}: ");
            Print_Array(jaggedArray, ind_max);

            Console.Read();

            void Creat_JaggedArray()
            {
                Random rng = new Random();
                int temp;

                for (int i = 0; i < 5; i++)
                {
                    temp = rng.Next(1, 6);
                    jaggedArray[i] = new int[temp+1];
                    for (int j = 0; j < temp; j++)
                    {
                        jaggedArray[i][j] = rng.Next(1, 10);
                    }
                }
            }


            void Print_JaggedArray(int[][] array)
            {
                Console.WriteLine("массив массивов: ");
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < array[i].Length; j++)
                        Console.Write($"{array[i][j]}, ");

                    Console.WriteLine();
                }

            }

            void Print_Array(int[][] array, int i)
            {
                for (int j = 0; j < array[i].Length; j++)
                    Console.Write($"{array[i][j]}, ");
                Console.WriteLine();
            }

        }
    }
}
