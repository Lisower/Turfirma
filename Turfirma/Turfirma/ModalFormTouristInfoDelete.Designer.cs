namespace Turfirma
{
    partial class ModalFormTouristInfoDelete
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
            this.labelDown = new System.Windows.Forms.Label();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelMain = new System.Windows.Forms.Label();
            this.labelUp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelDown
            // 
            this.labelDown.AutoSize = true;
            this.labelDown.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDown.Location = new System.Drawing.Point(175, 179);
            this.labelDown.Name = "labelDown";
            this.labelDown.Size = new System.Drawing.Size(70, 25);
            this.labelDown.TabIndex = 32;
            this.labelDown.Text = "Турист";
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonConfirm.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonConfirm.Location = new System.Drawing.Point(303, 261);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(200, 40);
            this.buttonConfirm.TabIndex = 31;
            this.buttonConfirm.Text = "Удалить";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCancel.Location = new System.Drawing.Point(303, 328);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(200, 40);
            this.buttonCancel.TabIndex = 30;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // labelMain
            // 
            this.labelMain.AutoSize = true;
            this.labelMain.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMain.Location = new System.Drawing.Point(137, 21);
            this.labelMain.Name = "labelMain";
            this.labelMain.Size = new System.Drawing.Size(536, 47);
            this.labelMain.TabIndex = 29;
            this.labelMain.Text = "Удалить информацию о туристе";
            this.labelMain.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelUp
            // 
            this.labelUp.AutoSize = true;
            this.labelUp.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelUp.Location = new System.Drawing.Point(175, 115);
            this.labelUp.Name = "labelUp";
            this.labelUp.Size = new System.Drawing.Size(498, 25);
            this.labelUp.TabIndex = 28;
            this.labelUp.Text = "Вы уверены, что хотите удалить информацию о туристе";
            // 
            // ModalFormTouristInfoDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelDown);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.labelMain);
            this.Controls.Add(this.labelUp);
            this.Name = "ModalFormTouristInfoDelete";
            this.Text = "ModalFormTouristInfoDelete";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelDown;
        private Button buttonConfirm;
        private Button buttonCancel;
        private Label labelMain;
        private Label labelUp;
    }
}