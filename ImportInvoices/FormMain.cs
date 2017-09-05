using ImportInvoices.Dispatches;
using System;
using System.IO;
using System.Windows.Forms;

namespace ImportInvoices
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Открывает диалог выбора xls файла
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonOpenFile_Click(object sender, System.EventArgs e)
        {
            // Initializes a OpenFileDialog instance 
            using (OpenFileDialog openfileDialog = new OpenFileDialog())
            {
                openfileDialog.RestoreDirectory = true;
                openfileDialog.Filter = "Excel files(*.xlsx;*.xls)|*.xlsx;*.xls";

                if (openfileDialog.ShowDialog() == DialogResult.OK)
                {
                    textBoxFilePath.Text = openfileDialog.FileName;
                }
            }

        }

        /// <summary>
        /// Конвертирует выбранный Excell файл в xml и определяет тип документа
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCreateDocs_Click(object sender, System.EventArgs e)
        {
            textBoxXmlView.Clear();

            string excelFileName = textBoxFilePath.Text;
            
            if (string.IsNullOrEmpty(excelFileName) || !File.Exists(excelFileName))
            {
                MessageBox.Show($"По указанному пути {excelFileName} файла не существует");
                return;
            }

            try
            {
                string xmlFormatString = new ConvertExcelToXML().GetXML(excelFileName);

                if (string.IsNullOrEmpty(xmlFormatString))
                {
                    MessageBox.Show($"Файл {excelFileName} не содержит данных для импорта");
                }

                textBoxXmlView.Text = xmlFormatString;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка импорта! Подробности: {ex.Message}");
            }
        }
    }
}
