using OfficeOpenXml;
using OfficeOpenXml.Style;
using System;
using System.IO;
using System.Drawing;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;
using System.Numerics;

namespace ConsoleP
{
    internal class ExcelFIleReader
    {
        public void ExcelFileREadfun()
        {
            string folderPath = @"C:\At";
            string subfolderPath = Path.Combine(folderPath, "Attiq");
            string filePath = Path.Combine(subfolderPath, "example.txt");
            string excelNewFilePath = Path.Combine(subfolderPath, "Internship Plan.xlsx");
            string asfd = @"C:\\At\\Attiq\\Internship Plan.xlsx";
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            try
            {
                using (ExcelPackage excelPackage = new ExcelPackage(new FileInfo(asfd)))
                {
                    string sheetInterhsipPlan = "Sheet1";

                    ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets[sheetInterhsipPlan];

                    int rowCount = worksheet.Dimension.Rows;
                    int columnCount = worksheet.Dimension.Columns;
                    List<object> values = new List<object>();

                    for (int row = 1; row <= rowCount; row++)
                    {
                        for (int column = 1; column <= columnCount; column++)
                        {
                            var cell = worksheet.Cells[row, column];
                            if (cell.Merge)
                            {
                                
                                var mergedCell = worksheet.Cells[cell.Start.Row, cell.Start.Column];
                                values.Add(mergedCell.Value+" ");
                            }
                            else
                            {
                                values.Add(cell.Value);
                            }
                        }
                    }

                    foreach (var item in values)
                    {
                        if (item != null)
                        {

                            Console.WriteLine(item);
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }



            try
            {
                using (ExcelPackage excelPackage = new ExcelPackage(new FileInfo(excelNewFilePath)))
                {
                    string sheetName = "sheet number 1";
                    string sheetInterhsipPlan = "Internship Plan";

                    ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets[sheetName];

                    if (worksheet == null)
                    {
                        worksheet = excelPackage.Workbook.Worksheets.Add(sheetName);
                    }

                    worksheet.Cells[1, 1].Value = "Attiq";
                    worksheet.Cells[2, 2].Value = "Attiq";
                    worksheet.Cells[5, 5].Value = "Attiq";
                    worksheet.Cells[10, 10].Value = "attiq";
                    worksheet.Cells[5, 5].Style.Fill.PatternType = ExcelFillStyle.Solid;
                    worksheet.Cells[5, 5].Style.Fill.BackgroundColor.SetColor(Color.Yellow);

                    int rowCount = worksheet.Dimension.Rows;
                    int columnCount = worksheet.Dimension.Columns;
                    List<object> values = new List<object>();

                    for (int row = 1; row <= rowCount; row++)
                    {
                        for (int column = 1; column <= columnCount; column++)
                        {
                            worksheet.Row(row).Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                            worksheet.Row(row).Style.WrapText = true;

                            var cellValue = worksheet.Cells[row, column].Value;
                            if (cellValue != null && cellValue.ToString().Equals("attiq"))
                            {
                                worksheet.Cells[row, column].Value = "MR " + cellValue.ToString();
                                for (int ccolumn = 1; ccolumn <= columnCount; ccolumn++)
                                {
                                    worksheet.Cells[row, ccolumn].Style.Fill.PatternType = ExcelFillStyle.Solid;
                                    worksheet.Cells[row, ccolumn].Style.Fill.BackgroundColor.SetColor(Color.Yellow);
                                }

                            }

                            values.Add(cellValue);
                        }
                    }

                    foreach (var item in values)
                    {
                        if (item != null)
                        {

                            Console.WriteLine(item);
                        }
                    }

                    excelPackage.Save();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
