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
    }
}