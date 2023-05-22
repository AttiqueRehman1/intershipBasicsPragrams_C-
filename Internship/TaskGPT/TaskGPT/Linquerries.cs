using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskGPT
{
    internal class Linquerries
    {
        public void linquerries()
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





            string[] names = { "Attiqq", "Sajad HUSSAIN", "Hussain", "Ali", "Zohaib", "HAMZAMUNIR", "BISM", "sAjad" };
            var myLinqQuery = from name in names
                              where name.Length == 5
                              orderby name.Length descending
                              select name;

            var mylinq = from x in names where x.Contains("a") || x.Contains("B") orderby x select x;
            var lin = names.Where(x => x.Contains("a") || x.Contains("B")).OrderBy(x => x);
            

            var mylinq1 = from x in names where x.StartsWith("A") orderby x select x.Length;
            var lin1 = names.Where(x => x.StartsWith("A")).OrderBy(x => x.Length);

            var mylinq2 = from x in names where x.Contains("a") && x.Contains("A") orderby x.Length ascending select x;
            var lin2 = names.Where(x => x.Contains("a") || x.Contains("A")).OrderBy(x => x.Length);


            var mylinq3 = from x in names where x.Length == 5 && x.StartsWith(("S"), StringComparison.OrdinalIgnoreCase) select x.ToLower();
            var lin3 = names.Where(x => x.Length == 5 && x.Contains("A")).Select(x => x.ToLower());


            var mylinq4 = names.Where(x => x.Contains("a") || x.Contains(("B"), StringComparison.OrdinalIgnoreCase)).Select(x => x.ToLower());
            var lin4 = names.Where(x => x.Contains("a") || x.Contains("B")).Select(x => x.ToLower());


            foreach (var a in mylinq)
            {
                 //Console.WriteLine(a);
            }
            foreach (var aa in mylinq1)
            {
                // Console.WriteLine(aa);
            }

            foreach (var aa in mylinq2)
            {
                //Console.WriteLine(aa);
            }
            foreach (var a in lin3)
            {
                // Console.WriteLine(a);
            }
        }






    }
}
