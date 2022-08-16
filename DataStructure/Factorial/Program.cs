using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    public class Program
    {
        public int factorialItrative(int n)
        {
            int fact = 1;
            for(int i = 1; i <=n; i++)
            {
                fact *= i;
            }
            return fact;
        }

        public int factorialRecuesive(int n)
        {
            if(n== 0)
            {
                return 1;
            }
            return factorialItrative(n-1)*n;
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            Console.WriteLine(program.factorialRecuesive(5));
            Console.WriteLine(program.factorialItrative(5)); 
        }
    }
}
