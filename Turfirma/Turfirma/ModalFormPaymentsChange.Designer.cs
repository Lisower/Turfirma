namespace Turfirma
{
    partial class ModalFormPaymentsChange
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
            this.labelAmount = new System.Windows.Forms.Label();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelPaymentDate = new System.Windows.Forms.Label();
            this.textBoxPaymentDate = new System.Windows.Forms.TextBox();
            this.labelBookingid = new System.Windows.Forms.Label();
            this.textBoxBookingid = new System.Windows.Forms.TextBox();
            this.labelMain = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelAmount.Location = new System.Drawing.Point(365, 208);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(69, 25);
            this.labelAmount.TabIndex = 35;
            this.labelAmount.Text = "Сумма";
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxAmount.Location = new System.Drawing.Point(300, 236);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(200, 33);
            this.textBoxAmount.TabIndex = 34;
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonConfirm.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonConfirm.Location = new System.Drawing.Point(300, 303);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(200, 40);
            this.buttonConfirm.TabIndex = 33;
            this.buttonConfirm.Text = "Изменить";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCancel.Location = new System.Drawing.Point(300, 361);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(200, 40);
            this.buttonCancel.TabIndex = 32;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // labelPaymentDate
            // 
            this.labelPaymentDate.AutoSize = true;
            this.labelPaymentDate.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPaymentDate.Location = new System.Drawing.Point(342, 139);
            this.labelPaymentDate.Name = "labelPaymentDate";
            this.labelPaymentDate.Size = new System.Drawing.Size(121, 25);
            this.labelPaymentDate.TabIndex = 31;
            this.labelPaymentDate.Text = "Дата оплаты";
            // 
            // textBoxPaymentDate
            // 
            this.textBoxPaymentDate.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxPaymentDate.Location = new System.Drawing.Point(300, 167);
            this.textBoxPaymentDate.Name = "textBoxPaymentDate";
            this.textBoxPaymentDate.Size = new System.Drawing.Size(200, 33);
            this.textBoxPaymentDate.TabIndex = 30;
            // 
            // labelBookingid
            // 
            this.labelBookingid.AutoSize = true;
            this.labelBookingid.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelBookingid.Location = new System.Drawing.Point(353, 75);
            this.labelBookingid.Name = "labelBookingid";
            this.labelBookingid.Size = new System.Drawing.Size(101, 25);
            this.labelBookingid.TabIndex = 29;
            this.labelBookingid.Text = "Id путёвки";
            // 
            // textBoxBookingid
            // 
            this.textBoxBookingid.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxBookingid.Location = new System.Drawing.Point(300, 103);
            this.textBoxBookingid.Name = "textBoxBookingid";
            this.textBoxBookingid.Size = new System.Drawing.Size(200, 33);
            this.textBoxBookingid.TabIndex = 28;
            // 
            // labelMain
            // 
            this.labelMain.AutoSize = true;
            this.labelMain.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMain.Location = new System.Drawing.Point(248, 9);
            this.labelMain.Name = "labelMain";
            this.labelMain.Size = new System.Drawing.Size(295, 47);
            this.labelMain.TabIndex = 27;
            this.labelMain.Text = "Изменить оплату";
            this.labelMain.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ModalFormPaymentsChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelAmount);
            this.Controls.Add(this.textBoxAmount);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.labelPaymentDate);
            this.Controls.Add(this.textBoxPaymentDate);
            this.Controls.Add(this.labelBookingid);
            this.Controls.Add(this.textBoxBookingid);
            this.Controls.Add(this.labelMain);
            this.Name = "ModalFormPaymentsChange";
            this.Text = "ModalFormPaymentsChange";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelAmount;
        private TextBox textBoxAmount;
        private Button buttonConfirm;
        private Button buttonCancel;
        private Label labelPaymentDate;
        private TextBox textBoxPaymentDate;
        private Label labelBookingid;
        private TextBox textBoxBookingid;
        private Label labelMain;
    }
}