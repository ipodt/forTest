using System;
using System.Collections.Generic;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            Console.WriteLine();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Вывод массива, остортированного по 1-му типу:");
            for (int i = 0; i < sort1(arr).Length; i++)
            {
                Console.WriteLine(sort1(arr)[i]);
            }

            Console.WriteLine("Вывод массива, остортированного по 2-му типу:");
            for (int i = 0; i < sort2(arr).Length; i++)
            {
                Console.WriteLine(sort2(arr)[i]);
            }

            Console.WriteLine("Вывод массива, остортированного по 3-му типу:");
            for (int i = 0; i < sort3(arr).Length; i++)
            {
                Console.WriteLine(sort3(arr)[i]);
            }

        }

        static int[] sort1(int[] arr)
        {
            List<int> temp_list= new List<int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    temp_list.Add(arr[i]);
                }
            }

            temp_list.Sort();

            int[] new_arr = temp_list.ToArray();

            return new_arr;
        }

        static int[] sort2(int[] arr)
        {
            List<int> temp_list = new List<int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    temp_list.Add(arr[i]);
                }
            }

            temp_list.Reverse();

            int[] new_arr = temp_list.ToArray();

            return new_arr;
        }

        static int[] sort3(int[] arr)
        {
            List<int> temp_list = new List<int>();

            Array.Sort(arr);

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    temp_list.Add(arr[i]);
                }
            }

            for (int i = arr.Length - 1; i > 0; i--)
            {
                if (arr[i] % 2 != 0)
                {
                    temp_list.Add(arr[i]);
                }
            }

            int[] new_arr = temp_list.ToArray();

            return new_arr;
        }



    }
}
