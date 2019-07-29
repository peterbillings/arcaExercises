using System;
using System.Linq;
using System.Collections.Generic;

namespace CodeTestSandbox
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] {1, 8, 19, 15, 2, 29, 3, 2, 25, 2, 19, 26, 17, 33, 22};

            int[] arr2 = new int[] {1, 29, 94, 15, 87, 100, 20, 55, 100, 45, 82, 80, 100, 100, 3, 53, 100, 2, 100, 100, 100, 100, 100, 100, 1};

            int[] arr3 = new int[] {100};

            int totalSpecial = workbook(15, 20, arr);

            int totalSpecial2 = workbook(25, 10, arr2);

            int totalSpecial3 = workbook(1, 1, arr3);

            Console.WriteLine($"Expected 11, actual {totalSpecial}");

            Console.WriteLine($"Expected 11, actual {totalSpecial2}");

            Console.WriteLine($"Expected 100, actual {totalSpecial3}");
            
        }
        
        static int workbook(int n, int k, int[] arr) 
        {

            int totalSpecialProblems = 0;

            int pageNumber = 1;

            for (int i = 0; i < n; i++)
            {
                for (int j = 1; j <= arr[i]; j++)
                {

                    if (j == pageNumber)
                    {
                        totalSpecialProblems++;
                    }

                    if (j % k == 0)
                    {
                        pageNumber++;
                    }
                }

                if (arr[i] % k != 0)
                {
                    pageNumber++;
                }
            }

            return totalSpecialProblems;
        }
    }

}
