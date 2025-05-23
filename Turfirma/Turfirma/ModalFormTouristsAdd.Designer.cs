namespace Turfirma
{
    partial class ModalFormTouristsAdd
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
            textBoxLastname = new TextBox();
            labelLastname = new Label();
            labelMain = new Label();
            labelFirstname = new Label();
            textBoxFirstname = new TextBox();
            labelMiddlename = new Label();
            textBoxMiddlename = new TextBox();
            buttonCancel = new Button();
            buttonConfirm = new Button();
            SuspendLayout();
            // 
            // textBoxLastname
            // 
            textBoxLastname.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxLastname.Location = new Point(307, 95);
            textBoxLastname.Name = "textBoxLastname";
            textBoxLastname.Size = new Size(200, 33);
            textBoxLastname.TabIndex = 0;
            // 
            // labelLastname
            // 
            labelLastname.AutoSize = true;
            labelLastname.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelLastname.Location = new Point(366, 67);
            labelLastname.Name = "labelLastname";
            labelLastname.Size = new Size(91, 25);
            labelLastname.TabIndex = 1;
            labelLastname.Text = "Фамилия";
            // 
            // labelMain
            // 
            labelMain.AutoSize = true;
            labelMain.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelMain.Location = new Point(255, 9);
            labelMain.Name = "labelMain";
            labelMain.Size = new Size(304, 47);
            labelMain.TabIndex = 2;
            labelMain.Text = "Добавить туриста";
            labelMain.TextAlign = ContentAlignment.MiddleRight;
            // 
            // labelFirstname
            // 
            labelFirstname.AutoSize = true;
            labelFirstname.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelFirstname.Location = new Point(386, 133);
            labelFirstname.Name = "labelFirstname";
            labelFirstname.Size = new Size(49, 25);
            labelFirstname.TabIndex = 4;
            labelFirstname.Text = "Имя";
            // 
            // textBoxFirstname
            // 
            textBoxFirstname.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxFirstname.Location = new Point(307, 161);
            textBoxFirstname.Name = "textBoxFirstname";
            textBoxFirstname.Size = new Size(200, 33);
            textBoxFirstname.TabIndex = 3;
            // 
            // labelMiddlename
            // 
            labelMiddlename.AutoSize = true;
            labelMiddlename.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelMiddlename.Location = new Point(366, 205);
            labelMiddlename.Name = "labelMiddlename";
            labelMiddlename.Size = new Size(93, 25);
            labelMiddlename.TabIndex = 6;
            labelMiddlename.Text = "Отчество";
            // 
            // textBoxMiddlename
            // 
            textBoxMiddlename.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxMiddlename.Location = new Point(307, 233);
            textBoxMiddlename.Name = "textBoxMiddlename";
            textBoxMiddlename.Size = new Size(200, 33);
            textBoxMiddlename.TabIndex = 5;
            // 
            // buttonCancel
            // 
            buttonCancel.DialogResult = DialogResult.Cancel;
            buttonCancel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCancel.Location = new Point(307, 368);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(200, 40);
            buttonCancel.TabIndex = 7;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonConfirm
            // 
            buttonConfirm.DialogResult = DialogResult.OK;
            buttonConfirm.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonConfirm.Location = new Point(307, 298);
            buttonConfirm.Name = "buttonConfirm";
            buttonConfirm.Size = new Size(200, 40);
            buttonConfirm.TabIndex = 8;
            buttonConfirm.Text = "Добавить";
            buttonConfirm.UseVisualStyleBackColor = true;
            buttonConfirm.Click += buttonConfirm_Click;
            // 
            // ModalFormTouristsAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonConfirm);
            Controls.Add(buttonCancel);
            Controls.Add(labelMiddlename);
            Controls.Add(textBoxMiddlename);
            Controls.Add(labelFirstname);
            Controls.Add(textBoxFirstname);
            Controls.Add(labelMain);
            Controls.Add(labelLastname);
            Controls.Add(textBoxLastname);
            Name = "ModalFormTouristsAdd";
            Text = "ModalFormTouristsAdd";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxLastname;
        private Label labelLastname;
        private Label labelMain;
        private Label labelFirstname;
        private TextBox textBoxFirstname;
        private Label labelMiddlename;
        private TextBox textBoxMiddlename;
        private Button buttonCancel;
        private Button buttonConfirm;
    }
}