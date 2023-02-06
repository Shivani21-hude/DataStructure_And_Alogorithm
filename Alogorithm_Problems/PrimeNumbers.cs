using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alogorithm_Problems
{
    internal class PrimeNumbers
    {
        public static void FindPrimeNumbers()
        {
            Console.WriteLine(" *** Prime Numbers up to 1000 *** \n ");

            for (int i = 0; i <= 1000; i++)
            {
                bool isPrime = true;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    Console.Write(i + " ");
                }

            }
        }
    }
}

    

