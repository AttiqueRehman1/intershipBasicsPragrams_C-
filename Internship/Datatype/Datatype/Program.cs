using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace MyPRoject
{

    class Program
    {
        static void Main(string[] args)
        {

            string firstname, lastname;
            string name = Console.ReadLine();

            string[] firstName = name.Split(' ');


            if (firstName.Length == 1)
            {
                Console.WriteLine("There is No lastname name ");
            }
            else if (firstName.Length == 2)
            {
                firstname = firstName[0];
                lastname = firstName[1];
              //  Console.WriteLine("FirstNAme : " + firstname + " lastname : " + lastname);
                Console.WriteLine($"fist name : {firstname} and last name : {1}","",lastname);
            }
            else
            {
                Console.WriteLine("Write a proper name ");
            }
            Console.ReadLine();




            int[] intArray = { 1, 2, 3 };
            double[] doubleArray = { 1.0, 2.0, 3.0 };
            String[] stringArray = { "1", "2", "3" };
            float[] floatArray = { 13, 12, 123, 123.4f };

            displayElements(intArray);
            displayElements(doubleArray);
            displayElements(stringArray);
            displayElements(floatArray);

            Console.ReadKey();
        }
        public static void displayElements<T>(T[] array)
        {
            foreach (T item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }

}




