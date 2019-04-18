using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProcessing
{
    class program
    {
        static void Main(string[] args)
        {
            int[] arr = { 17, 11, 9, 3, 4, 11, 6, 11, 8, 7 };
            int arr_size = arr.Length;

            printRepeating(arr, arr_size);
        }
        static void printRepeating(int[] arr, int size)
        {
            int i, j;
            Console.Write("elementthatRepeatThreeTimes");
            for (i = 0; i < size; i++)
            {
                for (j = i + 1; j < size; j++)

                {
                    if (arr[i] == arr[j])
                        Console.Write(arr[i] + "");

                }
            }
        }
    }
}