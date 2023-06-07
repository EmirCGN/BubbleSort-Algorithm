using System;

namespace Bubblesort
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the number of elements:");
            int count = int.Parse(Console.ReadLine());

            int[] array = new int[count];

            Console.WriteLine("Enter the elements:");

            for (int i = 0; i < count; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
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

            Console.WriteLine();
            Console.WriteLine("Enter a number to search in the sorted array:");
            int target = int.Parse(Console.ReadLine());

            BinarySearcher binarySearcher = new BinarySearcher();
            int index = binarySearcher.Search(array, target);

            Console.WriteLine();
            Console.WriteLine("╔══════════════════════════════════════════╗");
            if (index != -1)
            {
                Console.WriteLine($"║ The number {target} was found at index {index}! ║");
            }
            else
            {
                Console.WriteLine($"║ The number {target} was not found in the array.  ║");
            }
            Console.WriteLine("╚══════════════════════════════════════════╝");
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
                Console.Write($" {array[i]} ");
                if (i < array.Length - 1)
                {
                    Console.Write("║");
                }
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
    }
}