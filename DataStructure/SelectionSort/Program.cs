using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort
{
    public class Program
    {
        public void selectionSort(int[] A ,int n)
        {
            for (int i = 0; i < A.Length-1; i++)
            {
                int position = i;
                for (int j = i + 1; j < n; j++)
                    if (A[j] < A[position])
                        position = j;
                int temp = A[i];
                A[i] = A[position];
                A[position] = temp;
            }

        }
        public void display(int[] A,int n)
        {
            for (int i = 0; i < A.Length; i++)
            {
                Console.Write(A[i]+ " ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            int[] A = new int[5] { 4, 2, 3, 1, 7 };

            // string[] cars = new string[4] { "Volvo", "BMW", "Ford", "Mazda" };
            Console.WriteLine("Original Array:");
            p.display(A, A.Length);
            p.selectionSort(A,A.Length);
            Console.WriteLine("Sorted Array: ");
            p.display(A,A.Length);
            Console.ReadKey();
        


        }
    }

}