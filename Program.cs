using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp29
{
    class Program
    {
        static void Main(string[] args)
        {
            //Отсортировать одномерный массив по возрастанию 
            //1 способ:
            //int[] array = { -8, 6, 0, 11, 4, -4, 3 };
            //for (int i = 0; i < array.Length - 1; i++)
            //{
            //    for (int j = i + 1; j < array.Length; j++)
            //    {
            //        if (array[i] > array[j])
            //        {
            //            int p = array[i];
            //            array[i] = array[j];
            //            array[j] = p;
            //        }
            //    }
            //}
            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.WriteLine($"array[{i}]={array[i]}");
            //}
            //foreach (int elem in array)
            //{
            //    Console.WriteLine($"{elem}\t");
            //}

            //2 способ:
            //int[] array = { -8, 6, 0, 11, 4, -4, 3 };
            //Array.Sort(array);
            //foreach(int elem in array)
            //{
            //    Console.WriteLine($"{elem}\t");
            //}
            //Array.Reverse(array);
                Console.ReadKey();
        }
    }
}
