using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using System;
using System.IO;

namespace ConsoleP
{
    internal class pdf_ITEXTSharpLib
    {
        string pdfPath = @"C:\At\Attiq\pdfItext.pdf";
        string test10MbFile = @"C:\At\Attiq\TestFile10MB.pdf";
        string imgPath = @"C:\At\Attiq\img1.jpg";
        string imgSignature = @"C:\At\Attiq\signature.jpg";

        public void CreateOrAppendTextToPDF()
        {
            try
            {
                if (!File.Exists(pdfPath))
                {
                    CreatePDF();
                }
                else
                {
                    ReadPDFContents();

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }

        private void CreatePDF()
        {
            try
            {
                using (FileStream fs = new FileStream(pdfPath, FileMode.Create))
                {
                    Document document = new Document();
                    PdfWriter writer = PdfWriter.GetInstance(document, fs);

                    document.Open();

                    Paragraph paragraph = new Paragraph("Hello Peter");
                    paragraph.Add("atiiq \n");
                    paragraph.Add("ali\n");
                    paragraph.Add("ahmad\n");
                    paragraph.Add("sajad\n");


                    document.Add(paragraph);

                    document.Close();
                    Console.WriteLine("PDF created successfully.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while creating the PDF: " + ex.Message);
            }
        }




        public void ReadPDFContents()
        {
            try
            {
                if (File.Exists(pdfPath))
                {
                    using (FileStream fs = new FileStream(pdfPath, FileMode.Open, FileAccess.ReadWrite))
                    {
                        PdfReader reader = new PdfReader(fs);
                        int pageCount = reader.NumberOfPages;

                        for (int i = 1; i <= pageCount; i++)
                        {
                            string pageText = PdfTextExtractor.GetTextFromPage(reader, i);

                            using (FileStream fss = new FileStream(pdfPath, FileMode.Open, FileAccess.Write))
                            {
                                Document document = new Document();
                                PdfWriter writer = PdfWriter.GetInstance(document, fss);

                                document.Open();

                                Paragraph paragraph = new Paragraph();
                                String update = null;
                                if (pageText.Contains("ahmad"))
                                {
                                    update = pageText.Replace("ahmad", "MR Ahmad");
                                    Console.WriteLine("Replace successfully");

                                }
                                paragraph.Add(update);
                                document.Add(paragraph);

                                string imagePath = @"C:\At\Attiq\img1.jpg";
                                Image image = Image.GetInstance(imagePath);
                                image.ScaleToFit(150, 150);
                                image.Alignment = Element.ALIGN_LEFT;
                                document.Add(image);


                                document.Close();
                                Console.WriteLine("PDF append successfully.");
                            }


                            Console.WriteLine("Page {0}:\n{1}", i, pageText);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("The PDF file does not exist.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while reading the PDF: " + ex.Message);
            }
        }
        public void ReadPDFContentsFromSpecificPAgetoSpecificPAge()
        {
            try
            {
                if (File.Exists(test10MbFile))
                {
                    using (FileStream fs = new FileStream(test10MbFile, FileMode.Open, FileAccess.ReadWrite))
                    {
                        PdfReader reader = new PdfReader(fs);
                        int pageCount = reader.NumberOfPages;

                        for (int i = 1; i <= pageCount; i++)
                        {
                            string pageText = PdfTextExtractor.GetTextFromPage(reader, i);

                            using (FileStream fss = new FileStream(test10MbFile, FileMode.Open, FileAccess.Write))
                            {
                                Document document = new Document();
                                PdfWriter writer = PdfWriter.GetInstance(document, fss);

                                document.Open();

                                Paragraph paragraph = new Paragraph();
                         ;

                                string imagePath = @"C:\At\Attiq\signature.jpg";
                                Image image = Image.GetInstance(imagePath);
                                image.ScaleToFit(150, 150);
                                image.Alignment = Element.ALIGN_LEFT;
                                document.Add(image);


                                document.Close();
                                Console.WriteLine("PDF append signature successfully.");
                            }


                            Console.WriteLine("Page {0}:\n{1}", i, pageText);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("The PDF file does not exist.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while reading the PDF: " + ex.Message);
            }
        }
    }
}
