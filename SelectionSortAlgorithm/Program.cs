using System;

namespace SelectionSortAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            int i,j,tmp;
            int[] array = { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            for (i=0; i<array.Length; i++)
            {
                int minimum = i;
                for (j = i; j<array.Length; j++)
                {
                    if (array[j] < array[minimum])
                    {
                        minimum = j;
                    }
                }
                tmp = array[minimum];
                array[minimum] = array[i];
                array[i] = tmp;
                Console.WriteLine(array[i]);
            }
        }
    }
}