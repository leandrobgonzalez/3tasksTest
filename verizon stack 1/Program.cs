using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace verizon_stack_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "553";
            char[] charArry = str.ToCharArray();
            List<int> familyNumber = new List<int>();
            permute(familyNumber, charArry, 0, 2);
            Console.ReadLine();
        }

        static void permute(List<int> familyNumber, char[] arry, int i, int n)
        {
            int j;
            if (i == n)
            {
                familyNumber.Add(Convert.ToInt32(new string(arry)));
                Console.WriteLine(arry);
            }
            else
            {
                for (j = i; j <= n; j++)
                {
                    swap(ref arry[i], ref arry[j]);
                    permute(familyNumber, arry, i + 1, n);
                    swap(ref arry[i], ref arry[j]); //backtrack
                }
            }
        }

        static void swap(ref char a, ref char b)
        {
            char tmp;
            tmp = a;
            a = b;
            b = tmp;
        }
    }
}
