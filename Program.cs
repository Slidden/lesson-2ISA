using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp40
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            WriteLine("Массив");
            Vivod(array);
            WriteLine($"Среднее арифметическое массива: {searchAvereage(array)}");
            WriteLine($"Второе максимальное число: {SecondMax(array)}") ;
            Reverse(array);
            WriteLine("Перевёрнутый массив");
            Vivod(array);
            ReadLine();

        }
        internal static double searchAvereage(int[] array) => array.Sum() / array.Length;
        internal static int SecondMax(int[] array)
        {
            int max1 = array[0];
            int max2 = array[0];
            int ch = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (max1 < array[i])
                {
                    max1 = array[i];
                    ch = i;
                }
            }
            array[ch] = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (max2 < array[i])
                {
                    max2 = array[i];
                }
            }
            return max2;
        }
        internal static void Reverse(int[] array)
        {
            int a;
            int ch = array.Length - 1;
            for (int i = 0; i < array.Length / 2 ; i++)
            {
                a = array[ch];
                array[ch] = array[i];
                array[i] = a;
                if (ch != array.Length /2)
                    ch--;
            }
        }
        internal static void Vivod(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Write($"{array[i]}\t");
            }
            WriteLine("\n");
        }
    }
    
}
