using System;

namespace Bubblesort
{
    class BubbleSorter
    {
        public void Sort(int[] array)
        {
            int n = array.Length;
            bool swapped;

            for (int i = 0; i < n - 1; i++)
            {
                swapped = false;

                for (int j = 0; j < n - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        // Swap elements
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;

                        Console.Clear();
                        Console.WriteLine();
                        Console.WriteLine("╔══════════════════════════╗");
                        Console.WriteLine("║       Sorting Array       ║");
                        Console.WriteLine("╚══════════════════════════╝");
                        Console.WriteLine();
                        PrintArray(array, j + 1);
                        Thread.Sleep(1000);

                        swapped = true;
                    }
                }

                // If no two elements were swapped in the inner loop, the array is already sorted
                if (!swapped)
                {
                    break;
                }
            }
        }

        static void PrintArray(int[] array, int currentSortedIndex)
        {
            Console.Write("╔");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("════");
                if (i < array.Length - 1)
                {
                    Console.Write("╦");
                }
            }
            Console.WriteLine("╗");

            Console.Write("║");
            for (int i = 0; i < array.Length; i++)
            {
                if (i > 0)
                {
                    Console.Write("║");
                }

                PrintBarLine(array[i], i == currentSortedIndex, i == array.Length - 1);
            }
            Console.WriteLine("║");

            Console.Write("╚");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("════");
                if (i < array.Length - 1)
                {
                    Console.Write("╩");
                }
            }
            Console.WriteLine("╝");
        }

        static void PrintBarLine(int value, bool isSorted, bool isLast)
        {
            ConsoleColor previousColor = Console.ForegroundColor;

            if (isSorted)
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }

            for (int i = 0; i < value; i++)
            {
                Console.Write("█");
            }

            Console.ForegroundColor = previousColor;
            Console.Write(" {0,2} Characters", value);

            if (!isLast)
            {
                Console.WriteLine();
            }
        }
    }
}