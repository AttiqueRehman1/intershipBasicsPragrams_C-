using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskGPT
{
    internal class ExceptionsClass
    {

        public void Exception() {

            Console.WriteLine("Enter a number");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a number");
            int b = int.Parse(Console.ReadLine());
            int result = a / b;
            Console.WriteLine(result +" ");
            Console.WriteLine("statemnt 1");
            Console.WriteLine("statemnt 2");
            

            Console.ReadLine();
        }


    }
}
