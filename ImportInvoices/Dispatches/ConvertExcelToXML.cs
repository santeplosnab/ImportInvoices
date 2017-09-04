using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using System.Data;
using System.IO;
using System.Text.RegularExpressions;

namespace ImportInvoices.Dispatches
{
    class ConvertExcelToXML
    {
        /// <summary>
        /// Считывание данных из файла Excel в объект DataTable
        /// </summary>
        /// <param name="fileName">путь к Excel-файлу</param>
        /// <returns></returns>
        private DataTable ReadExcelFile(string fileName)
        {
            DataTable dt = new DataTable();

            try
            {
                using (SpreadsheetDocument spreadsheetDocument = SpreadsheetDocument.Open(fileName, false))
                {
                    // получение части книги
                    WorkbookPart workbookPart = spreadsheetDocument.WorkbookPart;

                    // получение всех листов выбранной части книги
                    IEnumerable<Sheet> sheetCollection = spreadsheetDocument.WorkbookPart.Workbook
                        .GetFirstChild<Sheets>().Elements<Sheet>();

                    // получение идентификатора
                    string relationshipId = sheetCollection.First().Id.Value;

                    // получение листа 1 книги
                    WorksheetPart worksheetPart = (WorksheetPart)spreadsheetDocument.WorkbookPart
                        .GetPartById(relationshipId);

                    // Получание данных
                    SheetData sheetData = worksheetPart.Worksheet.Elements<SheetData>().First();
                    IEnumerable<Row> rowCollection = sheetData.Descendants<Row>();

                    if (rowCollection.Count() == 0)
                    {
                        return dt;
                    }

                    // добавление столбцов
                    foreach (Cell cell in rowCollection.ElementAt(0))
                    {
                        dt.Columns.Add(GetValueOfCell(spreadsheetDocument, cell));
                    }

                    // Добавление строк в Data Table
                    foreach (Row row in rowCollection)
                    {
                        DataRow tempRow = dt.NewRow();
                        int columnIndex = 0;

                        foreach (Cell cell in row.Descendants<Cell>())
                        {
                            // Получение индекса столбца ячейки
                            int cellColumnIndex = GetColumnIndex(GetColumnName(cell.CellReference));

                            if (columnIndex < cellColumnIndex)
                            {
                                do
                                {
                                    tempRow[columnIndex] = string.Empty;
                                    columnIndex++;
                                }

                                while (columnIndex < cellColumnIndex);
                            }

                            tempRow[columnIndex] = GetValueOfCell(spreadsheetDocument, cell);
                            columnIndex++;
                        }
                        // Добавление строки в DataTable
                        // включая заголовок
                        dt.Rows.Add(tempRow);
                    }
                }
                // Удаляем строку заголовка
                dt.Rows.RemoveAt(0);
                return dt;
            }
            catch (IOException ex)
            {
               throw new IOException(ex.Message);
            }
        }

        /// <summary>
        /// Получение значения ячейки
        /// </summary>
        /// <param name="spreadsheetDocument"></param>
        /// <param name="cell">Объект cell</param>
        /// <returns></returns>
        private static string GetValueOfCell(SpreadsheetDocument spreadsheetDocument, Cell cell)
        {
            // Получение значения в ячейке
            SharedStringTablePart sharedString = spreadsheetDocument.WorkbookPart.SharedStringTablePart;

            if(cell.CellValue == null)
            {
                return string.Empty;
            }

            string cellValue = cell.CellValue.InnerText;

            // Если тип данных ячейки представлен типом SharedString
            if (cell.DataType != null && cell.DataType.Value == CellValues.SharedString)
            {
                return sharedString.SharedStringTable.ChildElements[int.Parse(cellValue)].InnerText;
            }
            else
            {
                return cellValue;
            }
        }

        /// <summary>
        /// Получает индекс колонки по ее имени
        /// </summary>
        /// <param name="columnName">Column Name(For Example,A or AA)</param>
        /// <returns>Column Index</returns>
        private int GetColumnIndex(string columnName)
        {
            int columnIndex = 0;
            int factor = 1;

            // From right to left
            for (int position = columnName.Length - 1; position >= 0; position--)
            {
                // For letters
                if (Char.IsLetter(columnName[position]))
                {
                    columnIndex += factor * ((columnName[position] - 'A') + 1) - 1;
                    factor *= 26;
                }
            }

            return columnIndex;
        }

        /// <summary>
        /// Получает Имя колонки по имени ячейки
        /// </summary>
        /// <param name="cellReference">Cell Name(For example,A1)</param>
        /// <returns>Column Name(For example, A)</returns>
        private string GetColumnName(string cellReference)
        {
            // Create a regular expression to match the column name of cell
            Regex regex = new Regex("[A-Za-z]+");
            Match match = regex.Match(cellReference);
            return match.Value;
        }
    }
}
