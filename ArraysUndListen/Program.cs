using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysUndListen
{
    class Program
    {
        static void Main(string[] args)
        {
            //Arrays
            int[] intArray = new int[100];
            for(int i = 0; i < intArray.Length; i++)
            {
                intArray[i] = i + 100;
            }

            //Ganzes Array ausgeben
            PrintArray(intArray);

            //Beispiel Würfel
            Random rand = new Random();
            int wieOftWuerfeln = rand.Next(5, 11);
            int augen = 6;

            int[] wuerfelArray = new int[wieOftWuerfeln];
            for (int i = 0; i < wieOftWuerfeln; i++)
            {
                wuerfelArray[i] = rand.Next(1, augen+1);
            }

            PrintArray(wuerfelArray);

            //2-Dimensionales Array
            long[,] zweiDimArray = new long[10, 80];
            for (int x = 0; x < zweiDimArray.GetLength(0); x++)
            {
                for (int y = 0; y < zweiDimArray.GetLength(1); y++)
                {
                    zweiDimArray[x, y] = 5;
                }
            }

            Print2DArray(zweiDimArray);

            Console.ReadLine();
        }

        static void Print2DArray(long[,] array)
        {
            for (int x = 0; x < array.GetLength(0); x++)
            {
                for (int y = 0; y < array.GetLength(1); y++)
                {
                    Console.Write(array[x, y] + " ");
                }
                Console.WriteLine();
            }
        }

        static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("array[" + i + "]: " + array[i]);
            }
        }
    }
}
