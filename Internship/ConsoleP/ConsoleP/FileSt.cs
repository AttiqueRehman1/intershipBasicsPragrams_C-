using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleP
{
    internal class FileSt
    {


        public void fileStream()
        {
            String pathnew = @"C:\at";
            try
            {
                DirectoryInfo dir = new DirectoryInfo(pathnew);


                if (dir.Exists)
                    Console.WriteLine("Exist");
                



                using (FileStream fs = new FileStream(pathnew, FileMode.OpenOrCreate, FileAccess.ReadWrite))
                {

                    Console.ReadLine();

                }
            }
            catch (Exception ex)

            {

                Console.WriteLine(ex.Message);
            }



            //try
            //{
            //    string filePath = @"C:\myfile.txt";

            //    using (FileStream fsfs = new FileStream(filePath, FileMode.Append, FileAccess.Write))
            //    {


            //        using (StreamWriter wr = new StreamWriter(fsfs))
            //        {
            //            wr.WriteLine("statemnt 123");
            //            wr.WriteLine("statemnt 1234");
            //            Console.WriteLine("write successfully");
            //        }
            //        //using (BinaryWriter br = new BinaryWriter(fsfs))
            //        //{
            //        //    br.Write(DateTime.Now.ToString());
            //        //}


            //    }
            //    //using (FileStream FSrEADER = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            //    //{


            //    //    //    using (StreamReader rdr = new StreamReader(FSrEADER))
            //    //    //    {
            //    //    //        String lines = "";
            //    //    //        lines = rdr.ReadLine();
            //    //    //        foreach (var item in lines)

            //    //    //        {
            //    //    //            Console.WriteLine(lines);
            //    //    //        }


            //    //    //    }
            //    //    //    Console.ReadLine();

            //    //    //}
            //    //}
            //}
            //catch (Exception ex) { Console.WriteLine(ex.Message); }
        }

    }
}
