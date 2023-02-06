using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alogorithm_Problems
{
    internal class BubbleSort
    {
        public static void Bubblesort()
        {
            //4,1,0,34,21 => 0,1,4,21,34
            Console.WriteLine(" *** Bubble Sort ***\n");
            int temp;
            Console.WriteLine("Enter n elements for to do Bubble Sort  :");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];

            Console.Write("Enter the elements :");

            for (int i = 0; i<n; i++)
            {
               arr[i] = Convert.ToInt32(Console.ReadLine());
               
            }
            Console.WriteLine("\n Entered elements are : ");
            foreach (var i in arr)
            {
                Console.Write(i + " ");

            }
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine("\n Sorted array is :");

            foreach (int a in arr)
            {
                Console.Write(a + " ");
            }
        }
    }
}
