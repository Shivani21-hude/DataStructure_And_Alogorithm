using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alogorithm_Problems
{
    internal class InsertionSort
    {
        public static void Insertionsort()
        {

            int  j, temp;
            Console.WriteLine("Enter n elements for to do insertion sort  :");
            int n=Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];

            Console.Write("Enter the elements :");

            for (int i = 0; i <n; i++)
            {
               arr[i] = Convert.ToInt32(Console.ReadLine());
               
            }
            Console.WriteLine("\n Entered elements are : ");
            foreach (var i in arr)
            {
                Console.Write(i+" ");
               
            }
            for (int i = 1; i < arr.Length; i++)
            {
                temp = arr[i];
                j = i - 1;
                for(j= i - 1; j >= 0;)
                {
                    if (temp < arr[j])
                    {
                        arr[j + 1] = arr[j];
                        j--;
                        arr[j + 1] = temp;
                    }
                    else
                    {
                        break;
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
