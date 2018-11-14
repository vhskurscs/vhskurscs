using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysUndListen
{
    class ArraysUndListen
    {
        static void Main(string[] args)
        {

            #region Ein- und Mehrdimensionale-Arrays
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
            #endregion

            //-------------------------------------------------------
            //Listen
            Console.WriteLine();
            Console.WriteLine("--- LISTEN ---");

            List<int> integerList = new List<int>();
            integerList.Add(12);
            integerList.Add(42);

            //Liste mit 10 zusätzlichen Werten befüllen
            for (int i = 0; i < 10; i++)
            {
                integerList.Add(i + 1000);
            }

            integerList.Remove(42);

            integerList.RemoveAt(0);

            //Liste ausgeben
            for (int i = 0; i < integerList.Count; i++)
            {
                Console.WriteLine(integerList[i]);
            }

            List<string> stringList = new List<string>();
            stringList.Add("Mein String 1");
            stringList.Add("Mein String 2");
            stringList.Add("Mein String 3");
            stringList.Add("Mein String 4");
            stringList.Add("Mein String 1");

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
