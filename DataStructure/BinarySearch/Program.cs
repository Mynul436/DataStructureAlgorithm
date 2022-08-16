using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
   

    public class Program
    {
        public int binarySearch(int[] arr,int  n,int k)
        {
            int l = 0;
            int r = n-1;
            while (l <= r)
            {
                int m=((l+r)/2);
                if (arr[m] == k)
                    return m;
                else if (k < arr[m])
                    r = m - 1;
                else if(k > arr[m])
                    l = m + 1;

            }
            return -1;
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            int[] arr=new int[3] {1,2,3};
           int r= p.binarySearch(arr,arr.Length,3);
            Console.WriteLine(r);
            int[] arr1 = new int[7] { 1, 5, 7, 4, 6, 2, 3 };
            Array.Reverse(arr1);
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.WriteLine(arr1[i]);

            }
           // Console.WriteLine(arr1);
            Array.Reverse(arr1);
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.WriteLine(arr1[i]);

            }
            //Console.WriteLine(arr1);

        }
    }
}
