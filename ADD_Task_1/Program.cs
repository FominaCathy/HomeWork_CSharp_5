using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Задача 1. Задан массив из случайных цифр на 15 элементов.
//На вход подаётся трёхзначное натуральное число.
//Напишите программу, которая определяет, есть в массиве последовательность из трёх элементов,
//совпадающая с введённым числом.
// {0, 5, 6, 2, 7, 7, 8, 1, 1, 9} - 277 -> да
// { 4, 4, 3, 6, 7, 0, 8, 5, 1, 2} -812->нет




namespace ADD_Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] arr =  new int[15];
            int number;
            Boolean flag = false;
            int length_arr = arr.Length;

            Creat_Array(arr); // создаем массив из 15 случайных цифр
            Print_Array(arr); // выводим на печать

            Console.Write("Введите 3х значное число: "); // предлагаем пользователю ввести 3х значное число
            number = int.Parse(Console.ReadLine());

            Search_Сontain(arr, number);

            if (flag == true) 
                Console.Write($" в массиве ЕСТЬ посл-ть из трёх элементов числа {number}");
            else 
                Console.Write($" последовательность цифр {number} в массиве НЕТ");


            Console.Read();

            void Print_Array(int[] array)
            {
                Console.Write($" массив: {array[0]}, ");
                for (int i = 1; i < array.Length; i++)
                    Console.Write($"{array[i]}, ");
                Console.WriteLine();

            }

            void Creat_Array(int[] array)
            {
                Random rng = new Random();
                int temp = array.Length;
                for (int i = 0; i < temp; i++)
                    array[i] = rng.Next(0, 10);
            }

            void Search_Сontain(int[] array, int numm)
            {
                for (int i = 0; i < (length_arr - 3); i++)
                {
                    if ((arr[i] == numm / 100) && (arr[i + 1] == (numm / 10)%10) && (arr[i + 2] == numm % 10))
                    {
                        flag = true;
                        break;
                    }
                        
                        
                }

            }
        }
    }
}
