using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DArrayRotate
{
    class Program
    {
        const int n = 3;
        static void Main(string[] args)
        {
            int[,] numbers = new int[n, n] { { 1, 4, 7 }, { 2, 5, 8 }, { 3, 6, 9 } };
            printArray(numbers);
            rotateArray(numbers);
            printArray(numbers);
            Console.ReadLine();
        }

        public static void printArray(int[,] numbers)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(numbers[j, i]);
                }
                Console.WriteLine();
            }
        }

        public static void rotateArray(int[,] numbers)
        {
            int n = 3;
            int[,] rotatedArray = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    rotatedArray[i, j] = numbers[j, n - i - 1];
                    Console.WriteLine("Replacing " + i + "," + j + " with the number at " + (n - j - 1) + "," + i + "(" + numbers[n - j - 1, i] + ")");
                }
            }
            Array.Copy(rotatedArray, numbers, 9);
        }
    }
}
