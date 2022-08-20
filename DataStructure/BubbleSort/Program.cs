using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    public class Program
    {
        void BubbleSortMethod(int[] A ,int n)
        {
            for (int pass= n-1; pass >=0; pass--)
            {
                for (int i = 0; i < pass; i++)
                {
                    if (A[i] > A[i + 1])
                    {
                        int temp =A[i];
                        A[i] = A[i + 1];
                        A[i + 1] = temp;
                    }
                }
            }
        }
        void display(int[]A,int a)
        {
            for (int i = 0; i < A.Length; i++)
            {
                Console.WriteLine(A[i]);
            }
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            int[] A = { 6, 4, 3, 2, 1, 0, 12 };
            p.display(A, A.Length);
            Console.WriteLine("---------");
            p.BubbleSortMethod(A,A.Length);
            p.display(A, A.Length);
        }
    }
}
