using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecurtionTree
{
    internal class Program
    {
        public void Calculate(int n)
        {
            if (n > 0)
            {
               //tree recursion 
                Calculate(n - 1);
                int k = n * n;
                Console.WriteLine(k);
                Calculate(n-1);
            }
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Calculate(4);
            Console.ReadKey();
        }
    }
}
