using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSort
{
    public class Program
    {
        public void InsertionSortMethod(int[] A,int n)
        {
            for (int i = 1; i < A.Length; i++)
            {
                int temp = A[i];
                int position = i;
                while (position>0 && A[position-1]>temp)
                {
                    A[position]=A[position-1];
                    position--;
                }
                A[position]=temp;

            }
        }
        void display(int[] A ,int n)
        {
            for (int i = 0; i < A.Length; i++)
            {
                Console.WriteLine("Array {0} : {1} ",i,A[i]);
            }
            Console.WriteLine(  );
        }
        static void Main(string[] args)
        {
            int[] A = { 5, 4, 3, 2, 1, 0 };
            Program p = new Program();  
            p.display(A,A.Length);
            Console.WriteLine("-------------------");
            p.InsertionSortMethod(A,A.Length);
            Console.WriteLine("After sort: ");
            p.display(A,A.Length);
        }
    }
}
