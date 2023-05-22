using OfficeOpenXml;
using System;
using System.IO;

namespace ConsoleP
{
    internal class ReadWriteDirectory
    {
        public void ReadWrite()
        {
            string folderPath = @"C:\At";
            string subfolderPath = Path.Combine(folderPath, "Attiq");
            string filePath = Path.Combine(subfolderPath, "example.txt");
            string excelNewFilePath = Path.Combine(subfolderPath, "excelsheet1.xlsx");

            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
                Console.WriteLine("Folder created: " + folderPath);
            }

            if (!Directory.Exists(subfolderPath))
            {
                Directory.CreateDirectory(subfolderPath);
                Console.WriteLine("Subfolder created: " + subfolderPath);
            }

            if (!File.Exists(filePath))
            {
                File.Create(filePath).Close();
                Console.WriteLine("Text file created: " + filePath);
            }
            else
            {
                Console.WriteLine("Enter something to write to the file " + filePath);
                string input = Console.ReadLine();
                File.WriteAllText(filePath, input);
                Console.WriteLine("Text written to the file.");
            }

            try
            {
                if (!File.Exists(excelNewFilePath))
                {
                    using (ExcelPackage excelPackage = new ExcelPackage(new FileInfo(excelNewFilePath)))
                    {
                        ExcelWorkbook workbook = excelPackage.Workbook;
                        ExcelWorksheet worksheet = workbook.Worksheets.Add("Task1");

                        Console.WriteLine("Write the value for A2");
                        string a2 = Console.ReadLine();
                        worksheet.Cells["A2"].Value = a2;

                        excelPackage.Save();
                        Console.WriteLine("Excel file created: " + excelNewFilePath);
                    }
                }
                else
                {
                    
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }
    }
}
