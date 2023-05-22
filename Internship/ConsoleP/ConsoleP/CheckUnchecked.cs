using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleP
{
    internal class CheckUnchecked
    {
        public void CheckedUnchecked()
        {
            int a = int.MaxValue;
            int b = 1;

            Console.WriteLine("Without checked/unchecked:");
            int result1 = a + b;
            Console.WriteLine("Result 1: " + result1);  // Output: Result 1: -2147483648 (overflow)

            Console.WriteLine();

            Console.WriteLine("Using checked:");
            checked
            {
                int result2 = a + b;  // This will throw an OverflowException
                Console.WriteLine("Result 2: " + result2);
            }

            Console.WriteLine();

            Console.WriteLine("Using unchecked:");
            unchecked
            {
                int result3 = a + b;  // This will produce undefined behavior
                Console.WriteLine("Result 3: " + result3);
            }


        }
    }
}
