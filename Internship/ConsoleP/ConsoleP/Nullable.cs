using ConsoleP;
using System;
using System.Collections.Concurrent;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq.Expressions;
using System.Text;

public class Nullable
{
    public static void Main(string[] args)
    {
        AddImageInPDF obj1 = new AddImageInPDF();
        obj1.ReadPDFContentsFromSpecificPAgetoSpecificPAge(5,10);



        Console.ReadLine();
        AddImageInPDF addImageInPDF = new AddImageInPDF( );
        addImageInPDF.AddPicture_AtTheEndOFPdf_OR_InTheWHolePDF(@"C:\At\Attiq\NewignarurePDF.pdf", @"C:\At\Attiq\testPDF.pdf");
        Console.ReadLine();
        addImageInPDF.addPdfSignature();

        Console.ReadLine();

        pdf_ITEXTSharpLib pdf_ITEXTSharpLib = new pdf_ITEXTSharpLib();
        pdf_ITEXTSharpLib.CreateOrAppendTextToPDF();
        Console.ReadLine();



        Console.ReadLine();
        CopyExcelSheet copyExcelSheet = new CopyExcelSheet();
        copyExcelSheet.cCopyExcelSheet();

        BinaryWriterTest binaryWriter = new BinaryWriterTest();
        binaryWriter.BinaryWriterTEst();
        Console.ReadLine();


        ExcelFIleReader reader = new ExcelFIleReader();
        reader.ExcelFileREadfun();
        Console.ReadLine();

        ReadWriteDirectory readWriteDirectory = new ReadWriteDirectory();
        readWriteDirectory.ReadWrite();
        Console.ReadLine();


        //FileSt file = new FileSt();
        //file.fileStream();
        Console.ReadLine();

        try
        {
            DirectoryInfo directory = new DirectoryInfo(@"C:\at");
            String dri = Directory.GetCurrentDirectory();
            string parentDirectory = @"C:\at";
            string[] directories = Directory.GetDirectories(parentDirectory);


            foreach (string d in directories)
            {
                Console.WriteLine(d);
            }

            if (!directory.Exists)
            {
                directory.Create();

                Console.WriteLine("The directory is created successfully.");
            }
            else
            {

                directory.Delete();
                Console.WriteLine("The directory is Deleted successfully.");
            }

            Console.WriteLine(directory.CreationTime + dri);
            Console.ReadLine();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);


        }

        String cmpr1 = "heloom";
        String cmpr2 = "heloo";
        Console.WriteLine(String.Compare(cmpr1, cmpr2));

        StringBuilder stringBuilder = new StringBuilder();
        StringBuilder sb = new StringBuilder();

        // Appending strings
        sb.Append("Hello, ");
        sb.Append("Hello, ");
        Console.WriteLine(sb);
        sb.AppendLine();
        sb.Insert(5, "qwer");

        Console.WriteLine(sb);


        Console.ReadLine();





        string dateString = "12-April-2023";

        DateTime tm = DateTime.Parse(dateString);
        Console.WriteLine(tm);


        try
        {
            String dbl = "3.12";
            double dbStr = Double.Parse(dbl);
            Console.WriteLine(dbl);

        }
        catch (Exception ex) { Console.WriteLine(ex.Message); }

        int aaa = int.MaxValue;
        int bbb = 1;
        String abab = "Hello";
        Console.WriteLine(abab.Length);

        Console.WriteLine(abab.PadLeft((7), '-') + abab.Length);
        Console.WriteLine(abab.Length);

        unchecked
        {
            int result = aaa + bbb;
            Console.WriteLine("Result: " + result);

        }


        Console.ReadLine();

        CheckUnchecked checkUnchecked = new CheckUnchecked();
        checkUnchecked.CheckedUnchecked();

        Console.ReadLine();

        int chk = int.MaxValue;
        int chk2 = int.MinValue;
        Console.WriteLine(chk);
        String str = " ";

        str = str ?? "asasdfdf";
        Nullable<int> asd = null;
        Console.WriteLine(asd);

        int? a = null;
        int ba = 12;
        int? abb = null;
        Console.WriteLine(abb == ba);
        int abc = 10;
        Console.WriteLine(abc.GetType());



        if (!a.HasValue)
        {
            a = a ?? 10;


        }


        Console.WriteLine(a + "  " + a.Value + str);
        Console.ReadLine();
    }
}
