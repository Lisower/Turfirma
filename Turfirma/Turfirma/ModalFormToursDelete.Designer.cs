namespace Turfirma
{
    partial class ModalFormToursDelete
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
            labelDown = new Label();
            buttonConfirm = new Button();
            buttonCancel = new Button();
            labelMain = new Label();
            labelUp = new Label();
            SuspendLayout();
            // 
            // labelDown
            // 
            labelDown.AutoSize = true;
            labelDown.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelDown.Location = new Point(245, 197);
            labelDown.Name = "labelDown";
            labelDown.Size = new Size(42, 25);
            labelDown.TabIndex = 32;
            labelDown.Text = "Тур";
            // 
            // buttonConfirm
            // 
            buttonConfirm.DialogResult = DialogResult.OK;
            buttonConfirm.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonConfirm.Location = new Point(302, 274);
            buttonConfirm.Name = "buttonConfirm";
            buttonConfirm.Size = new Size(200, 40);
            buttonConfirm.TabIndex = 31;
            buttonConfirm.Text = "Удалить";
            buttonConfirm.UseVisualStyleBackColor = true;
            buttonConfirm.Click += buttonConfirm_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.DialogResult = DialogResult.Cancel;
            buttonCancel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCancel.Location = new Point(302, 341);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(200, 40);
            buttonCancel.TabIndex = 30;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // labelMain
            // 
            labelMain.AutoSize = true;
            labelMain.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelMain.Location = new Point(293, 35);
            labelMain.Name = "labelMain";
            labelMain.Size = new Size(209, 47);
            labelMain.TabIndex = 29;
            labelMain.Text = "Удалить тур";
            labelMain.TextAlign = ContentAlignment.MiddleRight;
            // 
            // labelUp
            // 
            labelUp.AutoSize = true;
            labelUp.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelUp.Location = new Point(216, 126);
            labelUp.Name = "labelUp";
            labelUp.Size = new Size(322, 25);
            labelUp.TabIndex = 28;
            labelUp.Text = "Вы уверены, что хотите удалить тур";
            // 
            // ModalFormToursDelete
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelDown);
            Controls.Add(buttonConfirm);
            Controls.Add(buttonCancel);
            Controls.Add(labelMain);
            Controls.Add(labelUp);
            Name = "ModalFormToursDelete";
            Text = "ModalFormToursDelete";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelDown;
        private Button buttonConfirm;
        private Button buttonCancel;
        private Label labelMain;
        private Label labelUp;
    }
}