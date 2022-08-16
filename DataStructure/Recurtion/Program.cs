using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionHeadTail
{
    public class Recursion
    {
        public void Calculate(int n)
        {
            if (n > 0)
            {
                // Head recursion 
                Calculate(n - 1);
                int k = n * n;
                Console.WriteLine(k);
               // Calculate(n-1);//Tail recursion
            }
        }
        static void Main(string[] args)
        {
            Recursion program = new Recursion();
            program.Calculate(10);
            Console.ReadKey();
            
        }
    }
}
