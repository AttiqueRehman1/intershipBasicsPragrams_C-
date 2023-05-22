using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.IO;
using System.Reflection.Metadata;

namespace ConsoleP
{
    internal class AddImageInPDF
    {
        string path = @"C:\At\Attiq\signarurePDF.pdf";
        string imgPath = @"C:\At\Attiq\img1.jpg";
        string imgPath2 = @"C:\At\Attiq\img2.jpg";
        string sourcePath = @"C:\At\Attiq\testPDF.pdf";
        string outputPath = @"C:\At\Attiq\NewignarurePDF.pdf";
        string srctest10MbFile = @"C:\At\Attiq\TestFile10MB.pdf";
        string outputtest10MbFile = @"C:\At\Attiq\outputTestFile10MB.pdf";


        public void addPdfSignature()
        {
            try
            {
                iTextSharp.text.Document document = new iTextSharp.text.Document();
                using (FileStream fileStream = new FileStream(path, FileMode.Create))
                {
                    PdfWriter writer = PdfWriter.GetInstance(document, fileStream);
                    document.Open();
                    for (int i = 1; i <= 5; i++)
                    {
                        // Create a new page
                        document.NewPage();

                        // Create a new paragraph with the text "Hello"
                        Paragraph paragraph = new Paragraph("Hello");

                        // Add the paragraph to the document
                        document.Add(paragraph);
                        if (i == 5)
                        {// skip the page 5
                            continue; }
                        // pdf content get krny k lea uspy image drawing, shape draw krny k lea PdfcontentByte clas ha 
                        PdfContentByte content = writer.DirectContent;
                        Image image = Image.GetInstance(imgPath);
                        image.ScaleToFit(50, 50);
                        image.SetAbsolutePosition(20, 20); // Adjust the position as needed
                        content.AddImage(image);

                    }

                    //pdfContentByte methd provide krta ha jo lines shape, iamges & text draw kr skty ha PDF page py
                    // layout and also for other customization
                    PdfContentByte pdfContentByte = writer.DirectContent;
                    Image image1 = Image.GetInstance(imgPath2);
                    image1.ScaleToFit(50, 50);
                    image1.SetAbsolutePosition(50, 50);
                    pdfContentByte.AddImage(image1);
                    // Close the document and writer
                    document.Close();
                    writer.Close();

                    Console.WriteLine("PDF created successfully!");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void AddPicture_AtTheEndOFPdf_OR_InTheWHolePDF(string outputPath, string sourcePath)
        {
            try
            {
                // Open the source PDF file
                PdfReader reader = new PdfReader(sourcePath);


                iTextSharp.text.Document document = new iTextSharp.text.Document();
                PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(outputPath, FileMode.Create));

                // Open the document for writing
                document.Open();

                // Iterate over each page of the source PDF
                int pageCount = reader.NumberOfPages;
                for (int i = 1; i <= pageCount; i++)
                {


                    PdfImportedPage importedPage = writer.GetImportedPage(reader, i);
                    document.NewPage();

                    // Add the imported page to the output document
                    PdfContentByte content = writer.DirectContent;
                    content.AddTemplate(importedPage, 0, 0);

                    // Add the signature image at the end of the page
                    int scndlastpage = pageCount - 1;

                    // add signature only at the scend of page 
                    if (i == scndlastpage)
                    {
                        Image image = Image.GetInstance(imgPath2);
                        image.CompressionLevel = 50;
                        image.ScaleAbsolute(200, 200);
                        image.ScaleToFit(56, 60);
                        image.SetAbsolutePosition(document.Left, document.Bottom);
                        content.AddImage(image);
                    }
                    Console.WriteLine(pageCount + "   " + scndlastpage);
                }

                // Close the document and writer
                document.Close();
                writer.Close();

                Console.WriteLine("Signature added to the end of every page successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }



        }
        public void ReadPDFContentsFromSpecificPAgetoSpecificPAge(int fromPage, int toPage)
        {
            try
            {
                // Open the source PDF file
                PdfReader reader = new PdfReader(sourcePath);


                iTextSharp.text.Document document = new iTextSharp.text.Document();
                PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(outputtest10MbFile, FileMode.Create));

                // Open the document for writing
                document.Open();

                // Iterate over each page of the source PDF
                int pageCount = reader.NumberOfPages;
                for (int i = fromPage; i <= toPage; i++)
                {


                    PdfImportedPage importedPage = writer.GetImportedPage(reader, i);
                    document.NewPage();

                    // Add the imported page to the output document
                    PdfContentByte content = writer.DirectContent;
                    content.AddTemplate(importedPage, 0, 0);


                    // Add the signature image at the end of the page
                    //int scndlastpage = pageCount - 1;

                    //// add signature only at the scend of page 
                    //if (i == scndlastpage)
                    //{
                    //    Image image = Image.GetInstance(imgPath2);
                    //    image.CompressionLevel = 50;
                    //    image.ScaleAbsolute(200, 200);
                    //    image.ScaleToFit(56, 60);
                    //    image.SetAbsolutePosition(document.Left, document.Bottom);
                    //    content.AddImage(image);
                    //}
                    
                }

                // Close the document and writer
                document.Close();
                writer.Close();

                Console.WriteLine("PDF File copied from {0} page to {1} page successfully!",fromPage,toPage);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }



        }


    }
}
