using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            Console.WriteLine("Unsorted Array:");
            PrintArray(array);

            BubbleSorter bubbleSorter = new BubbleSorter();
            bubbleSorter.Sort(array);

            Console.WriteLine("Sorted Array:");
            PrintArray(array);

            Console.WriteLine("Enter a number to search in the sorted array:");
            int target = int.Parse(Console.ReadLine());

            BinarySearcher binarySearcher = new BinarySearcher();
            int index = binarySearcher.Search(array, target);

            if (index != -1)
            {
                Console.WriteLine($"The number {target} was found at index {index}.");
            }
            else
            {
                Console.WriteLine($"The number {target} was not found in the array.");
            }
        }

        static void PrintArray(int[] array)
        {
            foreach (int element in array) //
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
        }
    }
}
