namespace Turfirma
{
    partial class ModalFormToursChange
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
            buttonConfirm = new Button();
            buttonCancel = new Button();
            labelDescription = new Label();
            textBoxDescription = new TextBox();
            labelPrice = new Label();
            textBoxPrice = new TextBox();
            labelMain = new Label();
            labelTourname = new Label();
            textBoxTourname = new TextBox();
            SuspendLayout();
            // 
            // buttonConfirm
            // 
            buttonConfirm.DialogResult = DialogResult.OK;
            buttonConfirm.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonConfirm.Location = new Point(294, 289);
            buttonConfirm.Name = "buttonConfirm";
            buttonConfirm.Size = new Size(200, 40);
            buttonConfirm.TabIndex = 26;
            buttonConfirm.Text = "Изменить";
            buttonConfirm.UseVisualStyleBackColor = true;
            buttonConfirm.Click += buttonConfirm_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.DialogResult = DialogResult.Cancel;
            buttonCancel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCancel.Location = new Point(294, 359);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(200, 40);
            buttonCancel.TabIndex = 25;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // labelDescription
            // 
            labelDescription.AutoSize = true;
            labelDescription.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelDescription.Location = new Point(479, 102);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(99, 25);
            labelDescription.TabIndex = 24;
            labelDescription.Text = "Описание";
            // 
            // textBoxDescription
            // 
            textBoxDescription.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxDescription.Location = new Point(323, 130);
            textBoxDescription.Multiline = true;
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(398, 99);
            textBoxDescription.TabIndex = 23;
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelPrice.Location = new Point(116, 168);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(57, 25);
            labelPrice.TabIndex = 22;
            labelPrice.Text = "Цена";
            // 
            // textBoxPrice
            // 
            textBoxPrice.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPrice.Location = new Point(42, 196);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(200, 33);
            textBoxPrice.TabIndex = 21;
            // 
            // labelMain
            // 
            labelMain.AutoSize = true;
            labelMain.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelMain.Location = new Point(283, 9);
            labelMain.Name = "labelMain";
            labelMain.Size = new Size(239, 47);
            labelMain.TabIndex = 20;
            labelMain.Text = "Изменить тур";
            labelMain.TextAlign = ContentAlignment.MiddleRight;
            // 
            // labelTourname
            // 
            labelTourname.AutoSize = true;
            labelTourname.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelTourname.Location = new Point(69, 102);
            labelTourname.Name = "labelTourname";
            labelTourname.Size = new Size(143, 25);
            labelTourname.TabIndex = 19;
            labelTourname.Text = "Наименование";
            // 
            // textBoxTourname
            // 
            textBoxTourname.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxTourname.Location = new Point(42, 130);
            textBoxTourname.Name = "textBoxTourname";
            textBoxTourname.Size = new Size(200, 33);
            textBoxTourname.TabIndex = 18;
            // 
            // ModalFormToursChange
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonConfirm);
            Controls.Add(buttonCancel);
            Controls.Add(labelDescription);
            Controls.Add(textBoxDescription);
            Controls.Add(labelPrice);
            Controls.Add(textBoxPrice);
            Controls.Add(labelMain);
            Controls.Add(labelTourname);
            Controls.Add(textBoxTourname);
            Name = "ModalFormToursChange";
            Text = "ModalFormToursChange";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonConfirm;
        private Button buttonCancel;
        private Label labelDescription;
        private TextBox textBoxDescription;
        private Label labelPrice;
        private TextBox textBoxPrice;
        private Label labelMain;
        private Label labelTourname;
        private TextBox textBoxTourname;
    }
}