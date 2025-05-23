namespace Turfirma
{
    partial class ModalFormTouristsChange
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
            labelMiddlename = new Label();
            textBoxMiddlename = new TextBox();
            labelFirstname = new Label();
            textBoxFirstname = new TextBox();
            labelMain = new Label();
            labelLastname = new Label();
            textBoxLastname = new TextBox();
            SuspendLayout();
            // 
            // buttonConfirm
            // 
            buttonConfirm.DialogResult = DialogResult.OK;
            buttonConfirm.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonConfirm.Location = new Point(307, 298);
            buttonConfirm.Name = "buttonConfirm";
            buttonConfirm.Size = new Size(200, 40);
            buttonConfirm.TabIndex = 17;
            buttonConfirm.Text = "Изменить";
            buttonConfirm.UseVisualStyleBackColor = true;
            buttonConfirm.Click += buttonConfirm_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.DialogResult = DialogResult.Cancel;
            buttonCancel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCancel.Location = new Point(307, 368);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(200, 40);
            buttonCancel.TabIndex = 16;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // labelMiddlename
            // 
            labelMiddlename.AutoSize = true;
            labelMiddlename.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelMiddlename.Location = new Point(366, 205);
            labelMiddlename.Name = "labelMiddlename";
            labelMiddlename.Size = new Size(93, 25);
            labelMiddlename.TabIndex = 15;
            labelMiddlename.Text = "Отчество";
            // 
            // textBoxMiddlename
            // 
            textBoxMiddlename.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxMiddlename.Location = new Point(307, 233);
            textBoxMiddlename.Name = "textBoxMiddlename";
            textBoxMiddlename.Size = new Size(200, 33);
            textBoxMiddlename.TabIndex = 14;
            // 
            // labelFirstname
            // 
            labelFirstname.AutoSize = true;
            labelFirstname.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelFirstname.Location = new Point(386, 133);
            labelFirstname.Name = "labelFirstname";
            labelFirstname.Size = new Size(49, 25);
            labelFirstname.TabIndex = 13;
            labelFirstname.Text = "Имя";
            // 
            // textBoxFirstname
            // 
            textBoxFirstname.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxFirstname.Location = new Point(307, 161);
            textBoxFirstname.Name = "textBoxFirstname";
            textBoxFirstname.Size = new Size(200, 33);
            textBoxFirstname.TabIndex = 12;
            // 
            // labelMain
            // 
            labelMain.AutoSize = true;
            labelMain.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelMain.Location = new Point(255, 9);
            labelMain.Name = "labelMain";
            labelMain.Size = new Size(307, 47);
            labelMain.TabIndex = 11;
            labelMain.Text = "Изменить туриста";
            labelMain.TextAlign = ContentAlignment.MiddleRight;
            // 
            // labelLastname
            // 
            labelLastname.AutoSize = true;
            labelLastname.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelLastname.Location = new Point(366, 67);
            labelLastname.Name = "labelLastname";
            labelLastname.Size = new Size(91, 25);
            labelLastname.TabIndex = 10;
            labelLastname.Text = "Фамилия";
            // 
            // textBoxLastname
            // 
            textBoxLastname.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxLastname.Location = new Point(307, 95);
            textBoxLastname.Name = "textBoxLastname";
            textBoxLastname.Size = new Size(200, 33);
            textBoxLastname.TabIndex = 9;
            // 
            // ModalFormTouristsChange
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
            Name = "ModalFormTouristsChange";
            Text = "ModalFormTouristsChange";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonConfirm;
        private Button buttonCancel;
        private Label labelMiddlename;
        private TextBox textBoxMiddlename;
        private Label labelFirstname;
        private TextBox textBoxFirstname;
        private Label labelMain;
        private Label labelLastname;
        private TextBox textBoxLastname;
    }
}