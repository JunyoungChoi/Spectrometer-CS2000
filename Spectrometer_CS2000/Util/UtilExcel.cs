using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Diagnostics;
using OfficeOpenXml;
using OfficeOpenXml.Drawing;
using OfficeOpenXml.Style;

namespace ISSOFT.Util
{
    public static class UtilExcel
    {
        public static string[,] ReadAll(string fileName, string sheetName)
        {
            string[,] result = new string[0, 0];

            FileInfo existingFile = new FileInfo(fileName);

            using (ExcelPackage package = new ExcelPackage(existingFile))
            {
                var workbook = package.Workbook;

                foreach (var worksheet in workbook.Worksheets)
                {
                    if (worksheet.Name.Trim().ToLower().Equals(sheetName.Trim().ToLower()))
                    {
                        Debug.WriteLine($"ExcelController.Read Name = {worksheet.Name}, Dimension = {worksheet.Dimension}");

                        result = new string[worksheet.Dimension.Rows, worksheet.Dimension.Columns];

                        for (int row = worksheet.Dimension.Start.Row; row <= worksheet.Dimension.End.Row; row++)
                        {
                            for (int col = worksheet.Dimension.Start.Column; col <= worksheet.Dimension.End.Column; col++)
                            {
                                object value = worksheet.GetValue(row, col);
                                string vs = "";
                                if (value != null)
                                {
                                    vs = value.ToString();
                                }
                                else
                                {
                                }
                                result[row - worksheet.Dimension.Start.Row, col - worksheet.Dimension.Start.Column] = vs;
                            }
                        }
                    }
                }
            }

            return result;
        }

        public static string ReadCell(string fileName, string sheetName, string cellAddress)
        {
            string result = string.Empty;

            FileInfo existingFile = new FileInfo(fileName);

            using (ExcelPackage package = new ExcelPackage(existingFile))
            {
                var workbook = package.Workbook;

                var worksheet = workbook.Worksheets[sheetName];

                Debug.WriteLine($"ExcelController.Read Name = {worksheet.Name}, Dimension = {worksheet.Dimension}");
                try
                {
                    result = worksheet.Cells[cellAddress].Value.ToString();
                }
                catch
                {
                    return result;
                }
            }

            return result;
        }

        public static string ReadCell(string fileName, string sheetName, int row, int column)
        {
            string result = string.Empty;

            FileInfo existingFile = new FileInfo(fileName);

            using (ExcelPackage package = new ExcelPackage(existingFile))
            {
                var workbook = package.Workbook;

                var worksheet = workbook.Worksheets[sheetName];

                Debug.WriteLine($"ExcelController.Read Name = {worksheet.Name}, Dimension = {worksheet.Dimension}");
                try
                {
                    result = worksheet.Cells[row, column].Value.ToString();
                }
                catch
                {
                    return result;
                }
            }

            return result;
        }

        public static List<string> GetSheetNames(string fileName)
        {
            List<string> sheetNames = new List<string>();

            FileInfo existingFile = new FileInfo(fileName);

            using (ExcelPackage package = new ExcelPackage(existingFile))
            {
                var workbook = package.Workbook;

                foreach (var worksheet in workbook.Worksheets)
                {
                    sheetNames.Add(worksheet.Name);
                }
            }

            return sheetNames;
        }

        /// <summary>
        /// Write a cell.
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="sheetName"></param>
        /// <param name="row"></param>
        /// <param name="column"></param>
        /// <param name="data"></param>
        public static void Write(string fileName, string sheetName, int row, int column, string data)
        {
            Write(fileName, sheetName, row, column, new string[,] { { data } });
        }

        public static void Write(string fileName, string sheetName, string address, string data)
        {
            ExcelCellAddress excelCellAddress = new ExcelCellAddress(address);

            Write(fileName, sheetName, excelCellAddress.Row, excelCellAddress.Column, data);
        }

        /// <summary>
        /// Write cells.
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="sheetName"></param>
        /// <param name="row"></param>
        /// <param name="column"></param>
        /// <param name="data"></param>
        public static void Write(string fileName, string sheetName, int row, int column, string[,] data)
        {
            FileInfo existingFile = new FileInfo(fileName);

            using (ExcelPackage package = new ExcelPackage(existingFile))
            {
                var workbook = package.Workbook;

                foreach (var worksheet in workbook.Worksheets)
                {
                    if (worksheet.Name.Trim().ToLower().Equals(sheetName.Trim().ToLower()))
                    {
                        for (int i = 0; i < data.GetLength(0); i++)
                        {
                            for (int j = 0; j < data.GetLength(1); j++)
                            {
                                Debug.WriteLine($"ExcelController.Write Name = {worksheet.Name}, Row = {row + i}, Column = {column + j}, Data = {data[i, j]}");

                                worksheet.SetValue(row + i, column + j, data[i, j]);
                            }
                        }
                    }
                }

                package.Save();
            }
        }

        public static void SetBackColor(string fileName, string sheetName, int row, int column, System.Drawing.Color color)
        {
            FileInfo existingFile = new FileInfo(fileName);

            using (ExcelPackage package = new ExcelPackage(existingFile))
            {
                var workbook = package.Workbook;

                foreach (var worksheet in workbook.Worksheets)
                {
                    if (worksheet.Name.Trim().ToLower().Equals(sheetName.Trim().ToLower()))
                    {
                        worksheet.Cells[row, column].Style.Fill.BackgroundColor.SetColor(color);
                    }
                }

                package.Save();
            }
        }

        public static List<ExcelRange> GetIntersectCells(ExcelWorksheet workSheet, ExcelRange excelRange)
        {
            List<ExcelRange> intersectCells = new List<ExcelRange>();

            foreach (var mergedCell in workSheet.MergedCells)
            {
                if (mergedCell == null)
                {
                    continue;
                }

                int top = excelRange.Start.Row;
                int left = excelRange.Start.Column;
                int bottom = excelRange.End.Row;
                int right = excelRange.End.Column;

                int topMergeCells = workSheet.Cells[mergedCell].Start.Row;
                int leftMergeCells = workSheet.Cells[mergedCell].Start.Column;
                int bottomMergeCells = workSheet.Cells[mergedCell].End.Row;
                int rightMergeCells = workSheet.Cells[mergedCell].End.Column;

                if ((leftMergeCells <= left && left <= rightMergeCells) ||
                    (leftMergeCells <= right && right <= rightMergeCells) ||
                    (topMergeCells <= top && top <= bottomMergeCells) ||
                    (topMergeCells <= bottom && bottom <= bottomMergeCells))
                {
                    intersectCells.Add(workSheet.Cells[mergedCell]);
                }
            }

            return intersectCells;
        }

        public static string GetBackColor(string fileName, string sheetName, string cellAddress)
        {
            ExcelColor color = null;

            FileInfo existingFile = new FileInfo(fileName);

            using (ExcelPackage package = new ExcelPackage(existingFile))
            {
                try
                {
                    color = package.Workbook.Worksheets[sheetName].Cells[cellAddress].Style.Fill.BackgroundColor;
                }
                catch
                {
                    return null;
                }
            }

            return color.Rgb;
        }

        public static string GetBackColor(string fileName, string sheetName, int row, int column)
        {
            ExcelColor color = null;

            FileInfo existingFile = new FileInfo(fileName);

            using (ExcelPackage package = new ExcelPackage(existingFile))
            {
                try
                {
                    color = package.Workbook.Worksheets[sheetName].Cells[row, column].Style.Fill.BackgroundColor;
                }
                catch
                {
                    return null;
                }
            }

            return color.Rgb;
        }

        public static bool Merge(string fileName, string sheetName, int fromRow, int fromColumn, int toRow, int toColumn, bool isForce = false)
        {
            FileInfo existingFile = new FileInfo(fileName);

            using (ExcelPackage package = new ExcelPackage(existingFile))
            {
                try
                {
                    var workbook = package.Workbook;

                    bool isExistWorkSheet = false;

                    foreach (var worksheet in workbook.Worksheets)
                    {
                        if (worksheet.Name.Trim().ToLower().Equals(sheetName.Trim().ToLower()))
                        {
                            isExistWorkSheet = true;

                            if (isForce)
                            {
                                foreach (var intersectCell in GetIntersectCells(worksheet, worksheet.Cells[fromRow, fromColumn, toRow, toColumn]))
                                {
                                    intersectCell.Merge = false;
                                }
                            }

                            if (!worksheet.Cells[fromRow, fromColumn, toRow, toColumn].Merge)
                            {
                                worksheet.Cells[fromRow, fromColumn, toRow, toColumn].Merge = true;
                            }
                            else
                            {
                                return false;
                            }
                        }
                    }

                    if (isExistWorkSheet == false)
                    {
                        Debug.WriteLine(string.Format("Worksheet {0} is not existed.", sheetName));

                        return false;
                    }

                    package.Save();

                    return true;
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);

                    return false;
                }
            }
        }
    }
}
