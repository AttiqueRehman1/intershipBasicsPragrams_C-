using OfficeOpenXml;
using System;
using System.IO;

namespace ConsoleP
{
    internal class CopyExcelSheet
    {
        public void cCopyExcelSheet()
        {
            string sourceFilePath = @"C:\\At\\Attiq\\Internship Plan.xlsx";
            string destinationFilePath = @"C:\\At\\Attiq\\destinationFile.xlsx";

            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            try
            {
                using (ExcelPackage sourcePackage = new ExcelPackage(new FileInfo(sourceFilePath)))
                using (ExcelPackage destinationPackage = new ExcelPackage(new FileInfo(destinationFilePath)))
                {
                    ExcelWorkbook sourceWorkbook = sourcePackage.Workbook;
                    ExcelWorkbook destinationWorkbook = destinationPackage.Workbook;

                    string sourceWorksheetName = "Sheet1";
                    string destinationWorksheetName = "Sheet2 ";

                    ExcelWorksheet sourceWorksheet = sourceWorkbook.Worksheets[sourceWorksheetName]; 
                    
                    ExcelWorksheet destinationWorksheet = destinationWorkbook.Worksheets.Add(destinationWorksheetName);

                    int rowCount = sourceWorksheet.Dimension.Rows;
                    int columnCount = sourceWorksheet.Dimension.Columns;

                    for (int row = 1; row <= rowCount; row++)
                    {
                        for (int column = 1; column <= columnCount; column++)
                        {
                            var cellValue = sourceWorksheet.Cells[row, column].Value;

                            // Write the cell value to the destination worksheet
                            destinationWorksheet.Cells[row, column].Value = cellValue;
                        }
                    }

                    destinationPackage.Save();
                    Console.WriteLine("Data copied successfully!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }

            Console.ReadLine();
        }
    }
}
