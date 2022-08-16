using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearSearch
{
    public class Program
    {

      public  int LenearSearch(int[] A,int n, int Key)
        {
            int index = 0;
            while(index < n)
            {
                if(A[index] == Key)
                    return index;
                index++;
            }

            return -1;
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            int[] arr = { 42, 2, 33, 4, 5 };
            String[] str = new String[5] {"a","b","c","d","e"};
            string str2 = "tug";
            Console.WriteLine(str2.Length+" "+str2.IndexOf("g"));

            Array.Sort(arr);
            foreach (var item in arr)
            {
                Console.Write(item+" ");
            }
            Console.WriteLine(arr.Max());
            Console.WriteLine(arr.Min());
            Console.WriteLine(arr.Sum());
            int r= p.LenearSearch(arr,arr.Length,5);
            Console.WriteLine();
            Console.WriteLine( r+1);
            string writeText = "Hello World!";  // Create a text string
            File.WriteAllText("filename.txt", writeText);  // Create a file and write the content of writeText to it

            string readText = File.ReadAllText("filename.txt");  // Read the contents of the file
            Console.WriteLine(readText);  // Output the content
            Console.ReadKey();

        }
    }
}
