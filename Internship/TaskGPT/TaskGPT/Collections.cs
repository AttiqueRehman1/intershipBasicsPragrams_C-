using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskGPT
{
    class CollectionsMEthods 
    {
        public void collectionMethod()
        {

            int elementCount = 1000000;

            // List performance example
            List<int> list = new List<int>();

            Stopwatch listStopwatch = Stopwatch.StartNew();
            for (int i = 0; i < elementCount; i++)
            {
                list.Add(i);
            }
            listStopwatch.Stop();

            // ArrayList performance example
            ArrayList arrayList = new ArrayList();


            Stopwatch arrayListStopwatch = Stopwatch.StartNew();
            for (int i = 0; i < elementCount; i++)
            {
                arrayList.Add(i);
            }
            arrayListStopwatch.Stop();

            Console.WriteLine("List<T> elapsed time: " + listStopwatch.ElapsedMilliseconds + " ms");
            Console.WriteLine("ArrayList elapsed time: " + arrayListStopwatch.ElapsedMilliseconds + " ms");

            Console.ReadLine();





            Dictionary<String, int> studentGrades = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);

            studentGrades.Add("Attiq",121234);
            studentGrades.Add("Sajad",31234);
            studentGrades.Add("Blabla",512346);
            
            
            int ABvalue = studentGrades["sajad"];
            Console.WriteLine(ABvalue);
          
            

            var numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.WriteLine(numbers.Count);

            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            numbers.ForEach(
    x => Console.Write(x));

            var salmons = new List<string>();
            salmons.Add("chinook");
            salmons.Add("coho");
            salmons.Add("pink");
            salmons.Add("sockeye");
            for (int i = 0; i < salmons.Count; i++)
            {
                // Console.Write(salmons[i]+"  ");
            }

            // Iterate through the list.
            foreach (var salmon in salmons)
            {

                if (!salmon.Equals("coho", StringComparison.OrdinalIgnoreCase))
                {
                    //  Console.Write(salmon + " ");
                }


            }

        }

    }
}
