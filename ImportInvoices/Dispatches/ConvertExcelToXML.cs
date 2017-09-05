using System;
using System.Data;
using System.Data.OleDb;
using System.IO;

namespace ImportInvoices.Dispatches
{
    class ConvertExcelToXML
    {
        /// <summary>
        /// Конвертирует DataTable в Xml
        /// </summary>
        /// <param name="fileName">Путь к xls файлу</param>
        /// <returns>XML строка</returns>
        public string GetXML(string filePath)
        {
            DataTable dataTable = ExcelToDataTable(filePath);

            using (DataSet ds = new DataSet())
            {
                DataTable dtCopy = dataTable.Copy();

                ds.Tables.Add(dtCopy);

                return ds.GetXml();
            }
        }

        /// <summary>
        /// Конвертирует excel файл в объект DataTable
        /// </summary>
        /// <param name="filePath">Путь к файлу</param>
        /// <returns>объект DataTable</returns>
        private static DataTable ExcelToDataTable(string filePath)
        {
            string strConn = null;

            if (Path.GetExtension(filePath).Equals(".xls"))
            {
                strConn = String.Format("Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties=\"Excel 8.0;HDR=Yes;IMEX=2\"", 
                    filePath);
            }
            else if (Path.GetExtension(filePath).Equals(".xlsx"))
            {
                strConn = String.Format("Provider=Microsoft.Ace.OLEDB.12.0;Data Source={0};Extended Properties=\"Excel 12.0;HDR=Yes;IMEX=1\"", 
                    filePath);
            }
            else
            {
                return null;
            }

            DataTable dt = null;

            using (OleDbConnection conn = new OleDbConnection(strConn))
            {
                conn.Open();

                DataTable dbSchema = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);

                string firstSheetName = dbSchema.Rows[0]["TABLE_NAME"].ToString();

                string strExcel = $"select * from [{firstSheetName}]";

                OleDbDataAdapter cmd = new OleDbDataAdapter(strExcel, strConn);

                DataSet ds = new DataSet();

                cmd.Fill(ds, "table");

                dt = ds.Tables["table"];
            }

            return dt;
        }

    }
}
