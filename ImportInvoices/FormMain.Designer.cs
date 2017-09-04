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
            this.buttonReadDocument = new System.Windows.Forms.Button();
            this.progressBarMainForm = new System.Windows.Forms.ProgressBar();
            this.linkLabelSelectFiles = new System.Windows.Forms.LinkLabel();
            this.labelFilesCountText = new System.Windows.Forms.Label();
            this.labelFilesCountSummary = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonReadDocument
            // 
            this.buttonReadDocument.Location = new System.Drawing.Point(646, 39);
            this.buttonReadDocument.Name = "buttonReadDocument";
            this.buttonReadDocument.Size = new System.Drawing.Size(146, 28);
            this.buttonReadDocument.TabIndex = 0;
            this.buttonReadDocument.Text = "Прочитать файл";
            this.buttonReadDocument.UseVisualStyleBackColor = true;
            // 
            // progressBarMainForm
            // 
            this.progressBarMainForm.Location = new System.Drawing.Point(12, 39);
            this.progressBarMainForm.Name = "progressBarMainForm";
            this.progressBarMainForm.Size = new System.Drawing.Size(628, 28);
            this.progressBarMainForm.TabIndex = 1;
            // 
            // linkLabelSelectFiles
            // 
            this.linkLabelSelectFiles.AutoSize = true;
            this.linkLabelSelectFiles.Location = new System.Drawing.Point(13, 9);
            this.linkLabelSelectFiles.Name = "linkLabelSelectFiles";
            this.linkLabelSelectFiles.Size = new System.Drawing.Size(441, 13);
            this.linkLabelSelectFiles.TabIndex = 2;
            this.linkLabelSelectFiles.TabStop = true;
            this.linkLabelSelectFiles.Text = "Выберите файлы, щелкнув по этой ссылке или перетащите нужные файлы на форму";
            this.linkLabelSelectFiles.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelSelectFiles_LinkClicked);
            // 
            // labelFilesCountText
            // 
            this.labelFilesCountText.AutoSize = true;
            this.labelFilesCountText.Location = new System.Drawing.Point(468, 12);
            this.labelFilesCountText.Name = "labelFilesCountText";
            this.labelFilesCountText.Size = new System.Drawing.Size(96, 13);
            this.labelFilesCountText.TabIndex = 3;
            this.labelFilesCountText.Text = "Выбрано файлов:";
            // 
            // labelFilesCountSummary
            // 
            this.labelFilesCountSummary.AutoSize = true;
            this.labelFilesCountSummary.Location = new System.Drawing.Point(570, 12);
            this.labelFilesCountSummary.Name = "labelFilesCountSummary";
            this.labelFilesCountSummary.Size = new System.Drawing.Size(0, 13);
            this.labelFilesCountSummary.TabIndex = 4;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 273);
            this.Controls.Add(this.labelFilesCountSummary);
            this.Controls.Add(this.labelFilesCountText);
            this.Controls.Add(this.linkLabelSelectFiles);
            this.Controls.Add(this.progressBarMainForm);
            this.Controls.Add(this.buttonReadDocument);
            this.Name = "FormMain";
            this.Text = "Загрузка документов в 1С";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonReadDocument;
        private System.Windows.Forms.ProgressBar progressBarMainForm;
        private System.Windows.Forms.LinkLabel linkLabelSelectFiles;
        private System.Windows.Forms.Label labelFilesCountText;
        private System.Windows.Forms.Label labelFilesCountSummary;
    }
}

