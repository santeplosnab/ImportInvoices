namespace ImportInvoices
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonCreateDocs = new System.Windows.Forms.Button();
            this.progressBarMainForm = new System.Windows.Forms.ProgressBar();
            this.linkLabelSelectFiles = new System.Windows.Forms.LinkLabel();
            this.labelFilesCountSummary = new System.Windows.Forms.Label();
            this.textBoxFilePath = new System.Windows.Forms.TextBox();
            this.textBoxXmlView = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonOpenFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCreateDocs
            // 
            this.buttonCreateDocs.Location = new System.Drawing.Point(650, 233);
            this.buttonCreateDocs.Name = "buttonCreateDocs";
            this.buttonCreateDocs.Size = new System.Drawing.Size(146, 28);
            this.buttonCreateDocs.TabIndex = 0;
            this.buttonCreateDocs.Text = "Создать документы в 1С";
            this.buttonCreateDocs.UseVisualStyleBackColor = true;
            this.buttonCreateDocs.Click += new System.EventHandler(this.buttonCreateDocs_Click);
            // 
            // progressBarMainForm
            // 
            this.progressBarMainForm.Location = new System.Drawing.Point(16, 233);
            this.progressBarMainForm.Name = "progressBarMainForm";
            this.progressBarMainForm.Size = new System.Drawing.Size(628, 28);
            this.progressBarMainForm.TabIndex = 1;
            // 
            // linkLabelSelectFiles
            // 
            this.linkLabelSelectFiles.Location = new System.Drawing.Point(0, 0);
            this.linkLabelSelectFiles.Name = "linkLabelSelectFiles";
            this.linkLabelSelectFiles.Size = new System.Drawing.Size(100, 23);
            this.linkLabelSelectFiles.TabIndex = 8;
            // 
            // labelFilesCountSummary
            // 
            this.labelFilesCountSummary.AutoSize = true;
            this.labelFilesCountSummary.Location = new System.Drawing.Point(570, 12);
            this.labelFilesCountSummary.Name = "labelFilesCountSummary";
            this.labelFilesCountSummary.Size = new System.Drawing.Size(0, 13);
            this.labelFilesCountSummary.TabIndex = 4;
            // 
            // textBoxFilePath
            // 
            this.textBoxFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxFilePath.Location = new System.Drawing.Point(133, 9);
            this.textBoxFilePath.Name = "textBoxFilePath";
            this.textBoxFilePath.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxFilePath.Size = new System.Drawing.Size(556, 20);
            this.textBoxFilePath.TabIndex = 5;
            // 
            // textBoxXmlView
            // 
            this.textBoxXmlView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxXmlView.Location = new System.Drawing.Point(12, 35);
            this.textBoxXmlView.Multiline = true;
            this.textBoxXmlView.Name = "textBoxXmlView";
            this.textBoxXmlView.ReadOnly = true;
            this.textBoxXmlView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxXmlView.Size = new System.Drawing.Size(780, 185);
            this.textBoxXmlView.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Выберите excel файл";
            // 
            // buttonOpenFile
            // 
            this.buttonOpenFile.Location = new System.Drawing.Point(695, 6);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(97, 23);
            this.buttonOpenFile.TabIndex = 10;
            this.buttonOpenFile.Text = "Открыть";
            this.buttonOpenFile.UseVisualStyleBackColor = true;
            this.buttonOpenFile.Click += new System.EventHandler(this.buttonOpenFile_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 273);
            this.Controls.Add(this.buttonOpenFile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxXmlView);
            this.Controls.Add(this.textBoxFilePath);
            this.Controls.Add(this.labelFilesCountSummary);
            this.Controls.Add(this.linkLabelSelectFiles);
            this.Controls.Add(this.progressBarMainForm);
            this.Controls.Add(this.buttonCreateDocs);
            this.Name = "FormMain";
            this.Text = "Загрузка документов в 1С";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCreateDocs;
        private System.Windows.Forms.ProgressBar progressBarMainForm;
        private System.Windows.Forms.LinkLabel linkLabelSelectFiles;
        private System.Windows.Forms.Label labelFilesCountSummary;
        private System.Windows.Forms.TextBox textBoxFilePath;
        private System.Windows.Forms.TextBox textBoxXmlView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonOpenFile;
    }
}

