using System;
using System.Diagnostics.CodeAnalysis;
using System.Threading;

namespace app
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[]{1, 2, 3};
            int size = array.Sum() / array.Length;
            int counter = 0;

            while (array.Max() != size)
            {
                int index = Array.IndexOf(array, array.Max());
                int after = index - 1;
                int before = (index + 1) % array.Length;
                array[array[after] > array[before] ? before : after] += array[index] - size;
                counter += array[index] - size;
                array[index] -= array[index] - size;
            }
            Console.WriteLine(counter);
        }
    }
}
