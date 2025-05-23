namespace Turfirma
{
    partial class TurFirma
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            tabPagePayments = new TabPage();
            buttonPaymentsDelete = new Button();
            dataGridViewPayments = new DataGridView();
            buttonPaymentsChange = new Button();
            buttonPaymentsAdd = new Button();
            tabPageBookings = new TabPage();
            buttonBookingsDelete = new Button();
            dataGridViewBookings = new DataGridView();
            buttonBookingsChange = new Button();
            buttonBookingsAdd = new Button();
            tabPageSeasons = new TabPage();
            buttonSeasonsDelete = new Button();
            dataGridViewSeasons = new DataGridView();
            buttonSeasonsChange = new Button();
            buttonSeasonsAdd = new Button();
            tabPageTours = new TabPage();
            buttonToursDelete = new Button();
            dataGridViewTours = new DataGridView();
            buttonToursChange = new Button();
            buttonToursAdd = new Button();
            tabPageTouristInfo = new TabPage();
            buttonTouristInfoDelete = new Button();
            dataGridViewTouristInfo = new DataGridView();
            buttonTouristInfoChange = new Button();
            buttonTouristInfoAdd = new Button();
            tabPageTourists = new TabPage();
            buttonTouristsDelete = new Button();
            buttonTouristsChange = new Button();
            buttonTouristsAdd = new Button();
            dataGridViewTourists = new DataGridView();
            tabControl1 = new TabControl();
            tabPageRequests = new TabPage();
            comboBoxRequestsParameterized = new ComboBox();
            comboBoxRequestsAgregation = new ComboBox();
            buttonExportXmlDocument = new Button();
            buttonExportXmlWriter = new Button();
            buttonImportXmlDocument = new Button();
            buttonImportXmlReader = new Button();
            buttonExportExcel = new Button();
            buttonImportExcel = new Button();
            dataGridViewRequests = new DataGridView();
            buttonRequestsParameterized = new Button();
            labelRequestsParameterized = new Label();
            buttonRequestsAgregation = new Button();
            labelRequestsAgregation = new Label();
            richTextBoxRequestsParameterized = new RichTextBox();
            textBoxRequestsAgregation = new TextBox();
            labelRequestsMain = new Label();
            tabPageGraphics = new TabPage();
            label1 = new Label();
            buttonTrigger = new Button();
            tabPagePayments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPayments).BeginInit();
            tabPageBookings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBookings).BeginInit();
            tabPageSeasons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSeasons).BeginInit();
            tabPageTours.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTours).BeginInit();
            tabPageTouristInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTouristInfo).BeginInit();
            tabPageTourists.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTourists).BeginInit();
            tabControl1.SuspendLayout();
            tabPageRequests.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRequests).BeginInit();
            tabPageGraphics.SuspendLayout();
            SuspendLayout();
            // 
            // tabPagePayments
            // 
            tabPagePayments.Controls.Add(buttonPaymentsDelete);
            tabPagePayments.Controls.Add(dataGridViewPayments);
            tabPagePayments.Controls.Add(buttonPaymentsChange);
            tabPagePayments.Controls.Add(buttonPaymentsAdd);
            tabPagePayments.Location = new Point(4, 24);
            tabPagePayments.Name = "tabPagePayments";
            tabPagePayments.Padding = new Padding(3);
            tabPagePayments.Size = new Size(833, 535);
            tabPagePayments.TabIndex = 5;
            tabPagePayments.Text = "Оплата";
            tabPagePayments.UseVisualStyleBackColor = true;
            // 
            // buttonPaymentsDelete
            // 
            buttonPaymentsDelete.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonPaymentsDelete.Location = new Point(600, 450);
            buttonPaymentsDelete.Name = "buttonPaymentsDelete";
            buttonPaymentsDelete.Size = new Size(200, 50);
            buttonPaymentsDelete.TabIndex = 12;
            buttonPaymentsDelete.Text = "Удалить";
            buttonPaymentsDelete.UseVisualStyleBackColor = true;
            buttonPaymentsDelete.Click += buttonPaymentsDelete_Click;
            // 
            // dataGridViewPayments
            // 
            dataGridViewPayments.AllowUserToAddRows = false;
            dataGridViewPayments.AllowUserToDeleteRows = false;
            dataGridViewPayments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewPayments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPayments.Location = new Point(20, 20);
            dataGridViewPayments.Name = "dataGridViewPayments";
            dataGridViewPayments.ReadOnly = true;
            dataGridViewPayments.RowTemplate.Height = 25;
            dataGridViewPayments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewPayments.Size = new Size(800, 400);
            dataGridViewPayments.TabIndex = 0;
            // 
            // buttonPaymentsChange
            // 
            buttonPaymentsChange.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonPaymentsChange.Location = new Point(325, 450);
            buttonPaymentsChange.Name = "buttonPaymentsChange";
            buttonPaymentsChange.Size = new Size(200, 50);
            buttonPaymentsChange.TabIndex = 11;
            buttonPaymentsChange.Text = "Изменить";
            buttonPaymentsChange.UseVisualStyleBackColor = true;
            buttonPaymentsChange.Click += buttonPaymentsChange_Click;
            // 
            // buttonPaymentsAdd
            // 
            buttonPaymentsAdd.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonPaymentsAdd.Location = new Point(50, 450);
            buttonPaymentsAdd.Name = "buttonPaymentsAdd";
            buttonPaymentsAdd.Size = new Size(200, 50);
            buttonPaymentsAdd.TabIndex = 10;
            buttonPaymentsAdd.Text = "Добавить";
            buttonPaymentsAdd.UseVisualStyleBackColor = true;
            buttonPaymentsAdd.Click += buttonPaymentsAdd_Click;
            // 
            // tabPageBookings
            // 
            tabPageBookings.Controls.Add(buttonBookingsDelete);
            tabPageBookings.Controls.Add(dataGridViewBookings);
            tabPageBookings.Controls.Add(buttonBookingsChange);
            tabPageBookings.Controls.Add(buttonBookingsAdd);
            tabPageBookings.Location = new Point(4, 24);
            tabPageBookings.Name = "tabPageBookings";
            tabPageBookings.Padding = new Padding(3);
            tabPageBookings.Size = new Size(833, 535);
            tabPageBookings.TabIndex = 4;
            tabPageBookings.Text = "Путёвки";
            tabPageBookings.UseVisualStyleBackColor = true;
            // 
            // buttonBookingsDelete
            // 
            buttonBookingsDelete.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonBookingsDelete.Location = new Point(600, 450);
            buttonBookingsDelete.Name = "buttonBookingsDelete";
            buttonBookingsDelete.Size = new Size(200, 50);
            buttonBookingsDelete.TabIndex = 12;
            buttonBookingsDelete.Text = "Удалить";
            buttonBookingsDelete.UseVisualStyleBackColor = true;
            buttonBookingsDelete.Click += buttonBookingsDelete_Click;
            // 
            // dataGridViewBookings
            // 
            dataGridViewBookings.AllowUserToAddRows = false;
            dataGridViewBookings.AllowUserToDeleteRows = false;
            dataGridViewBookings.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewBookings.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBookings.Location = new Point(20, 20);
            dataGridViewBookings.Name = "dataGridViewBookings";
            dataGridViewBookings.ReadOnly = true;
            dataGridViewBookings.RowTemplate.Height = 25;
            dataGridViewBookings.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewBookings.Size = new Size(800, 400);
            dataGridViewBookings.TabIndex = 0;
            // 
            // buttonBookingsChange
            // 
            buttonBookingsChange.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonBookingsChange.Location = new Point(325, 450);
            buttonBookingsChange.Name = "buttonBookingsChange";
            buttonBookingsChange.Size = new Size(200, 50);
            buttonBookingsChange.TabIndex = 11;
            buttonBookingsChange.Text = "Изменить";
            buttonBookingsChange.UseVisualStyleBackColor = true;
            buttonBookingsChange.Click += buttonBookingsChange_Click;
            // 
            // buttonBookingsAdd
            // 
            buttonBookingsAdd.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonBookingsAdd.Location = new Point(50, 450);
            buttonBookingsAdd.Name = "buttonBookingsAdd";
            buttonBookingsAdd.Size = new Size(200, 50);
            buttonBookingsAdd.TabIndex = 10;
            buttonBookingsAdd.Text = "Добавить";
            buttonBookingsAdd.UseVisualStyleBackColor = true;
            buttonBookingsAdd.Click += buttonBookingsAdd_Click;
            // 
            // tabPageSeasons
            // 
            tabPageSeasons.Controls.Add(buttonSeasonsDelete);
            tabPageSeasons.Controls.Add(dataGridViewSeasons);
            tabPageSeasons.Controls.Add(buttonSeasonsChange);
            tabPageSeasons.Controls.Add(buttonSeasonsAdd);
            tabPageSeasons.Location = new Point(4, 24);
            tabPageSeasons.Name = "tabPageSeasons";
            tabPageSeasons.Padding = new Padding(3);
            tabPageSeasons.Size = new Size(833, 535);
            tabPageSeasons.TabIndex = 3;
            tabPageSeasons.Text = "Сезоны";
            tabPageSeasons.UseVisualStyleBackColor = true;
            // 
            // buttonSeasonsDelete
            // 
            buttonSeasonsDelete.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSeasonsDelete.Location = new Point(600, 450);
            buttonSeasonsDelete.Name = "buttonSeasonsDelete";
            buttonSeasonsDelete.Size = new Size(200, 50);
            buttonSeasonsDelete.TabIndex = 12;
            buttonSeasonsDelete.Text = "Удалить";
            buttonSeasonsDelete.UseVisualStyleBackColor = true;
            buttonSeasonsDelete.Click += buttonSeasonsDelete_Click;
            // 
            // dataGridViewSeasons
            // 
            dataGridViewSeasons.AllowUserToAddRows = false;
            dataGridViewSeasons.AllowUserToDeleteRows = false;
            dataGridViewSeasons.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewSeasons.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSeasons.Location = new Point(20, 20);
            dataGridViewSeasons.Name = "dataGridViewSeasons";
            dataGridViewSeasons.ReadOnly = true;
            dataGridViewSeasons.RowTemplate.Height = 25;
            dataGridViewSeasons.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewSeasons.Size = new Size(800, 400);
            dataGridViewSeasons.TabIndex = 0;
            // 
            // buttonSeasonsChange
            // 
            buttonSeasonsChange.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSeasonsChange.Location = new Point(325, 450);
            buttonSeasonsChange.Name = "buttonSeasonsChange";
            buttonSeasonsChange.Size = new Size(200, 50);
            buttonSeasonsChange.TabIndex = 11;
            buttonSeasonsChange.Text = "Изменить";
            buttonSeasonsChange.UseVisualStyleBackColor = true;
            buttonSeasonsChange.Click += buttonSeasonsChange_Click;
            // 
            // buttonSeasonsAdd
            // 
            buttonSeasonsAdd.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSeasonsAdd.Location = new Point(50, 450);
            buttonSeasonsAdd.Name = "buttonSeasonsAdd";
            buttonSeasonsAdd.Size = new Size(200, 50);
            buttonSeasonsAdd.TabIndex = 10;
            buttonSeasonsAdd.Text = "Добавить";
            buttonSeasonsAdd.UseVisualStyleBackColor = true;
            buttonSeasonsAdd.Click += buttonSeasonsAdd_Click;
            // 
            // tabPageTours
            // 
            tabPageTours.Controls.Add(buttonToursDelete);
            tabPageTours.Controls.Add(dataGridViewTours);
            tabPageTours.Controls.Add(buttonToursChange);
            tabPageTours.Controls.Add(buttonToursAdd);
            tabPageTours.Location = new Point(4, 24);
            tabPageTours.Name = "tabPageTours";
            tabPageTours.Padding = new Padding(3);
            tabPageTours.Size = new Size(833, 535);
            tabPageTours.TabIndex = 2;
            tabPageTours.Text = "Туры";
            tabPageTours.UseVisualStyleBackColor = true;
            // 
            // buttonToursDelete
            // 
            buttonToursDelete.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonToursDelete.Location = new Point(600, 450);
            buttonToursDelete.Name = "buttonToursDelete";
            buttonToursDelete.Size = new Size(200, 50);
            buttonToursDelete.TabIndex = 9;
            buttonToursDelete.Text = "Удалить";
            buttonToursDelete.UseVisualStyleBackColor = true;
            buttonToursDelete.Click += buttonToursDelete_Click;
            // 
            // dataGridViewTours
            // 
            dataGridViewTours.AllowUserToAddRows = false;
            dataGridViewTours.AllowUserToDeleteRows = false;
            dataGridViewTours.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewTours.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTours.Location = new Point(20, 20);
            dataGridViewTours.Name = "dataGridViewTours";
            dataGridViewTours.ReadOnly = true;
            dataGridViewTours.RowTemplate.Height = 25;
            dataGridViewTours.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewTours.Size = new Size(800, 400);
            dataGridViewTours.TabIndex = 0;
            // 
            // buttonToursChange
            // 
            buttonToursChange.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonToursChange.Location = new Point(325, 450);
            buttonToursChange.Name = "buttonToursChange";
            buttonToursChange.Size = new Size(200, 50);
            buttonToursChange.TabIndex = 8;
            buttonToursChange.Text = "Изменить";
            buttonToursChange.UseVisualStyleBackColor = true;
            buttonToursChange.Click += buttonToursChange_Click;
            // 
            // buttonToursAdd
            // 
            buttonToursAdd.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonToursAdd.Location = new Point(50, 450);
            buttonToursAdd.Name = "buttonToursAdd";
            buttonToursAdd.Size = new Size(200, 50);
            buttonToursAdd.TabIndex = 7;
            buttonToursAdd.Text = "Добавить";
            buttonToursAdd.UseVisualStyleBackColor = true;
            buttonToursAdd.Click += buttonToursAdd_Click;
            // 
            // tabPageTouristInfo
            // 
            tabPageTouristInfo.Controls.Add(buttonTouristInfoDelete);
            tabPageTouristInfo.Controls.Add(dataGridViewTouristInfo);
            tabPageTouristInfo.Controls.Add(buttonTouristInfoChange);
            tabPageTouristInfo.Controls.Add(buttonTouristInfoAdd);
            tabPageTouristInfo.Location = new Point(4, 24);
            tabPageTouristInfo.Name = "tabPageTouristInfo";
            tabPageTouristInfo.Padding = new Padding(3);
            tabPageTouristInfo.Size = new Size(833, 535);
            tabPageTouristInfo.TabIndex = 1;
            tabPageTouristInfo.Text = "Информация о туристах";
            tabPageTouristInfo.UseVisualStyleBackColor = true;
            // 
            // buttonTouristInfoDelete
            // 
            buttonTouristInfoDelete.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonTouristInfoDelete.Location = new Point(600, 450);
            buttonTouristInfoDelete.Name = "buttonTouristInfoDelete";
            buttonTouristInfoDelete.Size = new Size(200, 50);
            buttonTouristInfoDelete.TabIndex = 6;
            buttonTouristInfoDelete.Text = "Удалить";
            buttonTouristInfoDelete.UseVisualStyleBackColor = true;
            buttonTouristInfoDelete.Click += buttonTouristInfoDelete_Click;
            // 
            // dataGridViewTouristInfo
            // 
            dataGridViewTouristInfo.AllowUserToAddRows = false;
            dataGridViewTouristInfo.AllowUserToDeleteRows = false;
            dataGridViewTouristInfo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewTouristInfo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTouristInfo.Location = new Point(20, 20);
            dataGridViewTouristInfo.Name = "dataGridViewTouristInfo";
            dataGridViewTouristInfo.ReadOnly = true;
            dataGridViewTouristInfo.RowTemplate.Height = 25;
            dataGridViewTouristInfo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewTouristInfo.Size = new Size(800, 400);
            dataGridViewTouristInfo.TabIndex = 0;
            // 
            // buttonTouristInfoChange
            // 
            buttonTouristInfoChange.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonTouristInfoChange.Location = new Point(325, 450);
            buttonTouristInfoChange.Name = "buttonTouristInfoChange";
            buttonTouristInfoChange.Size = new Size(200, 50);
            buttonTouristInfoChange.TabIndex = 5;
            buttonTouristInfoChange.Text = "Изменить";
            buttonTouristInfoChange.UseVisualStyleBackColor = true;
            buttonTouristInfoChange.Click += buttonTouristInfoChange_Click;
            // 
            // buttonTouristInfoAdd
            // 
            buttonTouristInfoAdd.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonTouristInfoAdd.Location = new Point(50, 450);
            buttonTouristInfoAdd.Name = "buttonTouristInfoAdd";
            buttonTouristInfoAdd.Size = new Size(200, 50);
            buttonTouristInfoAdd.TabIndex = 4;
            buttonTouristInfoAdd.Text = "Добавить";
            buttonTouristInfoAdd.UseVisualStyleBackColor = true;
            buttonTouristInfoAdd.Click += buttonTouristInfoAdd_Click;
            // 
            // tabPageTourists
            // 
            tabPageTourists.Controls.Add(buttonTrigger);
            tabPageTourists.Controls.Add(buttonTouristsDelete);
            tabPageTourists.Controls.Add(buttonTouristsChange);
            tabPageTourists.Controls.Add(buttonTouristsAdd);
            tabPageTourists.Controls.Add(dataGridViewTourists);
            tabPageTourists.Location = new Point(4, 24);
            tabPageTourists.Name = "tabPageTourists";
            tabPageTourists.Padding = new Padding(3);
            tabPageTourists.Size = new Size(833, 535);
            tabPageTourists.TabIndex = 0;
            tabPageTourists.Text = "Туристы";
            tabPageTourists.UseVisualStyleBackColor = true;
            // 
            // buttonTouristsDelete
            // 
            buttonTouristsDelete.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonTouristsDelete.Location = new Point(441, 450);
            buttonTouristsDelete.Name = "buttonTouristsDelete";
            buttonTouristsDelete.Size = new Size(150, 50);
            buttonTouristsDelete.TabIndex = 3;
            buttonTouristsDelete.Text = "Удалить";
            buttonTouristsDelete.UseVisualStyleBackColor = true;
            buttonTouristsDelete.Click += buttonTouristsDelete_Click;
            // 
            // buttonTouristsChange
            // 
            buttonTouristsChange.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonTouristsChange.Location = new Point(244, 450);
            buttonTouristsChange.Name = "buttonTouristsChange";
            buttonTouristsChange.Size = new Size(150, 50);
            buttonTouristsChange.TabIndex = 2;
            buttonTouristsChange.Text = "Изменить";
            buttonTouristsChange.UseVisualStyleBackColor = true;
            buttonTouristsChange.Click += buttonTouristsChange_Click;
            // 
            // buttonTouristsAdd
            // 
            buttonTouristsAdd.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonTouristsAdd.Location = new Point(45, 450);
            buttonTouristsAdd.Name = "buttonTouristsAdd";
            buttonTouristsAdd.Size = new Size(150, 50);
            buttonTouristsAdd.TabIndex = 1;
            buttonTouristsAdd.Text = "Добавить";
            buttonTouristsAdd.UseVisualStyleBackColor = true;
            buttonTouristsAdd.Click += buttonTouristsAdd_Click;
            // 
            // dataGridViewTourists
            // 
            dataGridViewTourists.AllowUserToAddRows = false;
            dataGridViewTourists.AllowUserToDeleteRows = false;
            dataGridViewTourists.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewTourists.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTourists.Location = new Point(20, 20);
            dataGridViewTourists.Name = "dataGridViewTourists";
            dataGridViewTourists.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewTourists.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewTourists.RowTemplate.Height = 25;
            dataGridViewTourists.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewTourists.Size = new Size(800, 400);
            dataGridViewTourists.TabIndex = 0;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageTourists);
            tabControl1.Controls.Add(tabPageTouristInfo);
            tabControl1.Controls.Add(tabPageTours);
            tabControl1.Controls.Add(tabPageSeasons);
            tabControl1.Controls.Add(tabPageBookings);
            tabControl1.Controls.Add(tabPagePayments);
            tabControl1.Controls.Add(tabPageRequests);
            tabControl1.Controls.Add(tabPageGraphics);
            tabControl1.Location = new Point(1, -1);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(841, 563);
            tabControl1.TabIndex = 1;
            // 
            // tabPageRequests
            // 
            tabPageRequests.Controls.Add(comboBoxRequestsParameterized);
            tabPageRequests.Controls.Add(comboBoxRequestsAgregation);
            tabPageRequests.Controls.Add(buttonExportXmlDocument);
            tabPageRequests.Controls.Add(buttonExportXmlWriter);
            tabPageRequests.Controls.Add(buttonImportXmlDocument);
            tabPageRequests.Controls.Add(buttonImportXmlReader);
            tabPageRequests.Controls.Add(buttonExportExcel);
            tabPageRequests.Controls.Add(buttonImportExcel);
            tabPageRequests.Controls.Add(dataGridViewRequests);
            tabPageRequests.Controls.Add(buttonRequestsParameterized);
            tabPageRequests.Controls.Add(labelRequestsParameterized);
            tabPageRequests.Controls.Add(buttonRequestsAgregation);
            tabPageRequests.Controls.Add(labelRequestsAgregation);
            tabPageRequests.Controls.Add(richTextBoxRequestsParameterized);
            tabPageRequests.Controls.Add(textBoxRequestsAgregation);
            tabPageRequests.Controls.Add(labelRequestsMain);
            tabPageRequests.Location = new Point(4, 24);
            tabPageRequests.Name = "tabPageRequests";
            tabPageRequests.Size = new Size(833, 535);
            tabPageRequests.TabIndex = 6;
            tabPageRequests.Text = "Запросы";
            tabPageRequests.UseVisualStyleBackColor = true;
            // 
            // comboBoxRequestsParameterized
            // 
            comboBoxRequestsParameterized.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxRequestsParameterized.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxRequestsParameterized.FormattingEnabled = true;
            comboBoxRequestsParameterized.Location = new Point(442, 207);
            comboBoxRequestsParameterized.Name = "comboBoxRequestsParameterized";
            comboBoxRequestsParameterized.Size = new Size(376, 33);
            comboBoxRequestsParameterized.TabIndex = 15;
            comboBoxRequestsParameterized.SelectedIndexChanged += comboBoxRequestsParameterized_SelectedIndexChanged;
            // 
            // comboBoxRequestsAgregation
            // 
            comboBoxRequestsAgregation.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxRequestsAgregation.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxRequestsAgregation.FormattingEnabled = true;
            comboBoxRequestsAgregation.Location = new Point(442, 63);
            comboBoxRequestsAgregation.Name = "comboBoxRequestsAgregation";
            comboBoxRequestsAgregation.Size = new Size(376, 33);
            comboBoxRequestsAgregation.TabIndex = 14;
            comboBoxRequestsAgregation.SelectedIndexChanged += comboBoxRequestsAgregation_SelectedIndexChanged;
            // 
            // buttonExportXmlDocument
            // 
            buttonExportXmlDocument.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttonExportXmlDocument.Location = new Point(563, 471);
            buttonExportXmlDocument.Name = "buttonExportXmlDocument";
            buttonExportXmlDocument.Size = new Size(255, 36);
            buttonExportXmlDocument.TabIndex = 13;
            buttonExportXmlDocument.Text = "Экспорт XmlDocument";
            buttonExportXmlDocument.UseVisualStyleBackColor = true;
            buttonExportXmlDocument.Click += buttonExportXmlDocument_Click;
            // 
            // buttonExportXmlWriter
            // 
            buttonExportXmlWriter.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttonExportXmlWriter.Location = new Point(291, 471);
            buttonExportXmlWriter.Name = "buttonExportXmlWriter";
            buttonExportXmlWriter.Size = new Size(255, 36);
            buttonExportXmlWriter.TabIndex = 12;
            buttonExportXmlWriter.Text = "Экспорт XmlWriter";
            buttonExportXmlWriter.UseVisualStyleBackColor = true;
            buttonExportXmlWriter.Click += buttonExportXmlWriter_Click;
            // 
            // buttonImportXmlDocument
            // 
            buttonImportXmlDocument.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttonImportXmlDocument.Location = new Point(563, 418);
            buttonImportXmlDocument.Name = "buttonImportXmlDocument";
            buttonImportXmlDocument.Size = new Size(255, 36);
            buttonImportXmlDocument.TabIndex = 11;
            buttonImportXmlDocument.Text = "Импорт XmlDocument";
            buttonImportXmlDocument.UseVisualStyleBackColor = true;
            buttonImportXmlDocument.Click += buttonImportXmlDocument_Click;
            // 
            // buttonImportXmlReader
            // 
            buttonImportXmlReader.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttonImportXmlReader.Location = new Point(291, 418);
            buttonImportXmlReader.Name = "buttonImportXmlReader";
            buttonImportXmlReader.Size = new Size(255, 36);
            buttonImportXmlReader.TabIndex = 10;
            buttonImportXmlReader.Text = "Импорт XmlReader";
            buttonImportXmlReader.UseVisualStyleBackColor = true;
            buttonImportXmlReader.Click += buttonImportXmlReader_Click;
            // 
            // buttonExportExcel
            // 
            buttonExportExcel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttonExportExcel.Location = new Point(19, 471);
            buttonExportExcel.Name = "buttonExportExcel";
            buttonExportExcel.Size = new Size(255, 36);
            buttonExportExcel.TabIndex = 9;
            buttonExportExcel.Text = "Экспорт в Excel";
            buttonExportExcel.UseVisualStyleBackColor = true;
            buttonExportExcel.Click += buttonExportExcel_Click;
            // 
            // buttonImportExcel
            // 
            buttonImportExcel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttonImportExcel.Location = new Point(19, 418);
            buttonImportExcel.Name = "buttonImportExcel";
            buttonImportExcel.Size = new Size(255, 36);
            buttonImportExcel.TabIndex = 8;
            buttonImportExcel.Text = "Импорт из Excel";
            buttonImportExcel.UseVisualStyleBackColor = true;
            buttonImportExcel.Click += buttonImportExcel_Click;
            // 
            // dataGridViewRequests
            // 
            dataGridViewRequests.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRequests.Location = new Point(7, 48);
            dataGridViewRequests.Name = "dataGridViewRequests";
            dataGridViewRequests.RowTemplate.Height = 25;
            dataGridViewRequests.Size = new Size(429, 351);
            dataGridViewRequests.TabIndex = 7;
            // 
            // buttonRequestsParameterized
            // 
            buttonRequestsParameterized.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttonRequestsParameterized.Location = new Point(463, 363);
            buttonRequestsParameterized.Name = "buttonRequestsParameterized";
            buttonRequestsParameterized.Size = new Size(331, 36);
            buttonRequestsParameterized.TabIndex = 6;
            buttonRequestsParameterized.Text = "Выполнить запрос";
            buttonRequestsParameterized.UseVisualStyleBackColor = true;
            buttonRequestsParameterized.Click += buttonRequestsParameterized_Click;
            // 
            // labelRequestsParameterized
            // 
            labelRequestsParameterized.AutoSize = true;
            labelRequestsParameterized.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelRequestsParameterized.Location = new Point(541, 179);
            labelRequestsParameterized.Name = "labelRequestsParameterized";
            labelRequestsParameterized.Size = new Size(171, 25);
            labelRequestsParameterized.TabIndex = 5;
            labelRequestsParameterized.Text = "Сложные запросы";
            labelRequestsParameterized.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonRequestsAgregation
            // 
            buttonRequestsAgregation.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttonRequestsAgregation.Location = new Point(463, 140);
            buttonRequestsAgregation.Name = "buttonRequestsAgregation";
            buttonRequestsAgregation.Size = new Size(331, 36);
            buttonRequestsAgregation.TabIndex = 4;
            buttonRequestsAgregation.Text = "Выполнить запрос";
            buttonRequestsAgregation.UseVisualStyleBackColor = true;
            buttonRequestsAgregation.Click += buttonRequestsAgregation_Click;
            // 
            // labelRequestsAgregation
            // 
            labelRequestsAgregation.AutoSize = true;
            labelRequestsAgregation.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelRequestsAgregation.Location = new Point(546, 35);
            labelRequestsAgregation.Name = "labelRequestsAgregation";
            labelRequestsAgregation.Size = new Size(166, 25);
            labelRequestsAgregation.TabIndex = 3;
            labelRequestsAgregation.Text = "Простые запросы";
            // 
            // richTextBoxRequestsParameterized
            // 
            richTextBoxRequestsParameterized.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBoxRequestsParameterized.Location = new Point(442, 246);
            richTextBoxRequestsParameterized.Name = "richTextBoxRequestsParameterized";
            richTextBoxRequestsParameterized.Size = new Size(376, 111);
            richTextBoxRequestsParameterized.TabIndex = 2;
            richTextBoxRequestsParameterized.Text = "";
            // 
            // textBoxRequestsAgregation
            // 
            textBoxRequestsAgregation.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxRequestsAgregation.Location = new Point(442, 102);
            textBoxRequestsAgregation.Name = "textBoxRequestsAgregation";
            textBoxRequestsAgregation.Size = new Size(376, 32);
            textBoxRequestsAgregation.TabIndex = 1;
            // 
            // labelRequestsMain
            // 
            labelRequestsMain.AutoSize = true;
            labelRequestsMain.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            labelRequestsMain.Location = new Point(231, 0);
            labelRequestsMain.Name = "labelRequestsMain";
            labelRequestsMain.Size = new Size(364, 45);
            labelRequestsMain.TabIndex = 0;
            labelRequestsMain.Text = "Запросы к базе данных";
            // 
            // tabPageGraphics
            // 
            tabPageGraphics.Controls.Add(label1);
            tabPageGraphics.Location = new Point(4, 24);
            tabPageGraphics.Name = "tabPageGraphics";
            tabPageGraphics.Size = new Size(833, 535);
            tabPageGraphics.TabIndex = 7;
            tabPageGraphics.Text = "Графики";
            tabPageGraphics.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(305, 1);
            label1.Name = "label1";
            label1.Size = new Size(191, 45);
            label1.TabIndex = 2;
            label1.Text = "Диаграммы";
            // 
            // buttonTrigger
            // 
            buttonTrigger.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonTrigger.Location = new Point(641, 450);
            buttonTrigger.Name = "buttonTrigger";
            buttonTrigger.Size = new Size(150, 50);
            buttonTrigger.TabIndex = 4;
            buttonTrigger.Text = "Триггер";
            buttonTrigger.UseVisualStyleBackColor = true;
            buttonTrigger.Click += buttonTrigger_Click;
            // 
            // TurFirma
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(844, 561);
            Controls.Add(tabControl1);
            Name = "TurFirma";
            Text = "БД Турфирма";
            tabPagePayments.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewPayments).EndInit();
            tabPageBookings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewBookings).EndInit();
            tabPageSeasons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewSeasons).EndInit();
            tabPageTours.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewTours).EndInit();
            tabPageTouristInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewTouristInfo).EndInit();
            tabPageTourists.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewTourists).EndInit();
            tabControl1.ResumeLayout(false);
            tabPageRequests.ResumeLayout(false);
            tabPageRequests.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRequests).EndInit();
            tabPageGraphics.ResumeLayout(false);
            tabPageGraphics.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabPage tabPagePayments;
        private DataGridView dataGridViewPayments;
        private TabPage tabPageBookings;
        private DataGridView dataGridViewBookings;
        private TabPage tabPageSeasons;
        private DataGridView dataGridViewSeasons;
        private TabPage tabPageTours;
        private DataGridView dataGridViewTours;
        private TabPage tabPageTouristInfo;
        private DataGridView dataGridViewTouristInfo;
        private TabPage tabPageTourists;
        private Button buttonTouristsDelete;
        private Button buttonTouristsChange;
        private Button buttonTouristsAdd;
        private DataGridView dataGridViewTourists;
        private TabControl tabControl1;
        private Button buttonTouristInfoDelete;
        private Button buttonTouristInfoChange;
        private Button buttonTouristInfoAdd;
        private Button buttonPaymentsDelete;
        private Button buttonPaymentsChange;
        private Button buttonPaymentsAdd;
        private Button buttonBookingsDelete;
        private Button buttonBookingsChange;
        private Button buttonBookingsAdd;
        private Button buttonSeasonsDelete;
        private Button buttonSeasonsChange;
        private Button buttonSeasonsAdd;
        private Button buttonToursDelete;
        private Button buttonToursChange;
        private Button buttonToursAdd;
        private TabPage tabPageRequests;
        private DataGridView dataGridViewRequests;
        private Button buttonRequestsParameterized;
        private Label labelRequestsParameterized;
        private Button buttonRequestsAgregation;
        private Label labelRequestsAgregation;
        private RichTextBox richTextBoxRequestsParameterized;
        private TextBox textBoxRequestsAgregation;
        private Label labelRequestsMain;
        private Button buttonExportXmlDocument;
        private Button buttonExportXmlWriter;
        private Button buttonImportXmlDocument;
        private Button buttonImportXmlReader;
        private Button buttonExportExcel;
        private Button buttonImportExcel;
        private ComboBox comboBoxRequestsParameterized;
        private ComboBox comboBoxRequestsAgregation;
        private TabPage tabPageGraphics;
        private Label label1;
        private Button buttonTrigger;
    }
}