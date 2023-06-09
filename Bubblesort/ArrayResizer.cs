using System;

namespace Bubblesort
{
    class ArrayResizer
    {
        public int[] ResizeArray(int[] array, int newSize)
        {
            int[] newArray = new int[newSize];
            Array.Copy(array, newArray, Math.Min(array.Length, newSize));
            return newArray;
        }

        public void InsertNumber(int[] array, int count, int newNumber)
        {
            int i = count - 1;

            while (i >= 0 && array[i] > newNumber)
            {
                array[i + 1] = array[i];
                i--;
            }

            array[i + 1] = newNumber;
        }
    }
}