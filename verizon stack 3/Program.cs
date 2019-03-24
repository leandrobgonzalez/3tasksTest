using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace verizon_stack_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[10];
            int K;
            A[0] = 1;
            A[1] = 1;
            A[2] = 3;
            A[3] = 3;
            A[4] = 3;
            A[5] = 4;
            A[6] = 5;
            A[7] = 5;
            A[8] = 5;
            A[9] = 5;
            K = 2;
            int n = A.Length;
            int best = 0;
            int count = 0;
            for (int i = 0; i < n - K - 1; i++)
            {
                if (A[i] == A[i + 1])
                    count = count + 1;
                else
                    count = 0;
                if (count > best)
                    best = count;
            }
            int result = best + 1 + K;

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
