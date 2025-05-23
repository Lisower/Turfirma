namespace Turfirma
{
    partial class ModalFormTouristsDelete
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
            labelMain = new Label();
            labelUp = new Label();
            labelDown = new Label();
            SuspendLayout();
            // 
            // buttonConfirm
            // 
            buttonConfirm.DialogResult = DialogResult.OK;
            buttonConfirm.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonConfirm.Location = new Point(298, 248);
            buttonConfirm.Name = "buttonConfirm";
            buttonConfirm.Size = new Size(200, 40);
            buttonConfirm.TabIndex = 26;
            buttonConfirm.Text = "Удалить";
            buttonConfirm.UseVisualStyleBackColor = true;
            buttonConfirm.Click += buttonConfirm_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.DialogResult = DialogResult.Cancel;
            buttonCancel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCancel.Location = new Point(298, 315);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(200, 40);
            buttonCancel.TabIndex = 25;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // labelMain
            // 
            labelMain.AutoSize = true;
            labelMain.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelMain.Location = new Point(255, 9);
            labelMain.Name = "labelMain";
            labelMain.Size = new Size(277, 47);
            labelMain.TabIndex = 20;
            labelMain.Text = "Удалить туриста";
            labelMain.TextAlign = ContentAlignment.MiddleRight;
            // 
            // labelUp
            // 
            labelUp.AutoSize = true;
            labelUp.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelUp.Location = new Point(212, 100);
            labelUp.Name = "labelUp";
            labelUp.Size = new Size(360, 25);
            labelUp.TabIndex = 19;
            labelUp.Text = "Вы уверены, что хотите удалить туриста";
            // 
            // labelDown
            // 
            labelDown.AutoSize = true;
            labelDown.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelDown.Location = new Point(241, 171);
            labelDown.Name = "labelDown";
            labelDown.Size = new Size(70, 25);
            labelDown.TabIndex = 27;
            labelDown.Text = "Турист";
            // 
            // ModalFormTouristsDelete
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelDown);
            Controls.Add(buttonConfirm);
            Controls.Add(buttonCancel);
            Controls.Add(labelMain);
            Controls.Add(labelUp);
            Name = "ModalFormTouristsDelete";
            Text = "ModalFormTouristsDelete";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonConfirm;
        private Button buttonCancel;
        private Label labelMain;
        private Label labelUp;
        private Label labelDown;
    }
}