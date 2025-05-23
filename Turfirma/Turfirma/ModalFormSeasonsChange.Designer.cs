namespace Turfirma
{
    partial class ModalFormSeasonsChange
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            checkBoxIsClosed = new CheckBox();
            labelTourid = new Label();
            textBoxTourid = new TextBox();
            labelAvailableSpots = new Label();
            textBoxAvailableSpots = new TextBox();
            buttonConfirm = new Button();
            buttonCancel = new Button();
            labelEnddate = new Label();
            textBoxEnddate = new TextBox();
            labelMain = new Label();
            labelStartdate = new Label();
            textBoxStartdate = new TextBox();
            SuspendLayout();
            // 
            // checkBoxIsClosed
            // 
            checkBoxIsClosed.AutoSize = true;
            checkBoxIsClosed.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxIsClosed.Location = new Point(237, 247);
            checkBoxIsClosed.Name = "checkBoxIsClosed";
            checkBoxIsClosed.Size = new Size(92, 29);
            checkBoxIsClosed.TabIndex = 51;
            checkBoxIsClosed.Text = "Закрыт";
            checkBoxIsClosed.TextAlign = ContentAlignment.TopLeft;
            checkBoxIsClosed.UseVisualStyleBackColor = true;
            // 
            // labelTourid
            // 
            labelTourid.AutoSize = true;
            labelTourid.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelTourid.Location = new Point(369, 73);
            labelTourid.Name = "labelTourid";
            labelTourid.Size = new Size(71, 25);
            labelTourid.TabIndex = 50;
            labelTourid.Text = "Id тура";
            // 
            // textBoxTourid
            // 
            textBoxTourid.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxTourid.Location = new Point(300, 101);
            textBoxTourid.Name = "textBoxTourid";
            textBoxTourid.Size = new Size(200, 33);
            textBoxTourid.TabIndex = 49;
            // 
            // labelAvailableSpots
            // 
            labelAvailableSpots.AutoSize = true;
            labelAvailableSpots.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelAvailableSpots.Location = new Point(441, 219);
            labelAvailableSpots.Name = "labelAvailableSpots";
            labelAvailableSpots.Size = new Size(162, 25);
            labelAvailableSpots.TabIndex = 48;
            labelAvailableSpots.Text = "Доступные места";
            // 
            // textBoxAvailableSpots
            // 
            textBoxAvailableSpots.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxAvailableSpots.Location = new Point(419, 247);
            textBoxAvailableSpots.Name = "textBoxAvailableSpots";
            textBoxAvailableSpots.Size = new Size(200, 33);
            textBoxAvailableSpots.TabIndex = 47;
            // 
            // buttonConfirm
            // 
            buttonConfirm.DialogResult = DialogResult.OK;
            buttonConfirm.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonConfirm.Location = new Point(300, 326);
            buttonConfirm.Name = "buttonConfirm";
            buttonConfirm.Size = new Size(200, 40);
            buttonConfirm.TabIndex = 46;
            buttonConfirm.Text = "Изменить";
            buttonConfirm.UseVisualStyleBackColor = true;
            buttonConfirm.Click += buttonConfirm_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.DialogResult = DialogResult.Cancel;
            buttonCancel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCancel.Location = new Point(300, 390);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(200, 40);
            buttonCancel.TabIndex = 45;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // labelEnddate
            // 
            labelEnddate.AutoSize = true;
            labelEnddate.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelEnddate.Location = new Point(441, 151);
            labelEnddate.Name = "labelEnddate";
            labelEnddate.Size = new Size(153, 25);
            labelEnddate.TabIndex = 44;
            labelEnddate.Text = "Дата окончания";
            // 
            // textBoxEnddate
            // 
            textBoxEnddate.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxEnddate.Location = new Point(419, 179);
            textBoxEnddate.Name = "textBoxEnddate";
            textBoxEnddate.Size = new Size(200, 33);
            textBoxEnddate.TabIndex = 43;
            // 
            // labelMain
            // 
            labelMain.AutoSize = true;
            labelMain.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelMain.Location = new Point(124, 20);
            labelMain.Name = "labelMain";
            labelMain.Size = new Size(555, 47);
            labelMain.TabIndex = 42;
            labelMain.Text = "Изменить информацию о сезоне";
            labelMain.TextAlign = ContentAlignment.MiddleRight;
            // 
            // labelStartdate
            // 
            labelStartdate.AutoSize = true;
            labelStartdate.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelStartdate.Location = new Point(222, 151);
            labelStartdate.Name = "labelStartdate";
            labelStartdate.Size = new Size(120, 25);
            labelStartdate.TabIndex = 41;
            labelStartdate.Text = "Дата начала";
            // 
            // textBoxStartdate
            // 
            textBoxStartdate.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxStartdate.Location = new Point(187, 179);
            textBoxStartdate.Name = "textBoxStartdate";
            textBoxStartdate.Size = new Size(200, 33);
            textBoxStartdate.TabIndex = 40;
            // 
            // ModalFormSeasonsChange
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(checkBoxIsClosed);
            Controls.Add(labelTourid);
            Controls.Add(textBoxTourid);
            Controls.Add(labelAvailableSpots);
            Controls.Add(textBoxAvailableSpots);
            Controls.Add(buttonConfirm);
            Controls.Add(buttonCancel);
            Controls.Add(labelEnddate);
            Controls.Add(textBoxEnddate);
            Controls.Add(labelMain);
            Controls.Add(labelStartdate);
            Controls.Add(textBoxStartdate);
            Name = "ModalFormSeasonsChange";
            Text = "ModalFormSeasonsChange";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox checkBoxIsClosed;
        private Label labelTourid;
        private TextBox textBoxTourid;
        private Label labelAvailableSpots;
        private TextBox textBoxAvailableSpots;
        private Button buttonConfirm;
        private Button buttonCancel;
        private Label labelEnddate;
        private TextBox textBoxEnddate;
        private Label labelMain;
        private Label labelStartdate;
        private TextBox textBoxStartdate;
    }
}