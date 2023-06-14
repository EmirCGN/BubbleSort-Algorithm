using System;

namespace Bubblesort
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the number of elements:");
            int count = GetValidInput();

            int[] array = new int[count];

            Console.WriteLine("Enter the elements:");

            for (int i = 0; i < count; i++)
            {
                array[i] = GetValidInput();
            }

            Console.WriteLine();
            Console.WriteLine("╔══════════════════════════╗");
            Console.WriteLine("║      Unsorted Array      ║");
            Console.WriteLine("╚══════════════════════════╝");
            Console.WriteLine();
            PrintArray(array);

            BubbleSorter bubbleSorter = new BubbleSorter();
            bubbleSorter.Sort(array);

            Console.WriteLine();
            Console.WriteLine("╔═════════════════════════╗");
            Console.WriteLine("║       Sorted Array      ║");
            Console.WriteLine("╚═════════════════════════╝");
            Console.WriteLine();
            PrintArray(array);
        }

        static int GetValidInput()
        {
            int input;
            while (!int.TryParse(Console.ReadLine(), out input))
            {
                Console.WriteLine("Invalid input. Please enter a valid integer:");
            }
            return input;
        }

        static void PrintArray(int[] array)
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

                PrintBarLine(array[i], i == array.Length - 1);
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

        static void PrintBarLine(int value, bool isLast)
        {
            ConsoleColor previousColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Green;

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