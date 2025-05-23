namespace Turfirma
{
    partial class ModalFormBookingsChange
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
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelSeasonid = new System.Windows.Forms.Label();
            this.textBoxSeasonid = new System.Windows.Forms.TextBox();
            this.labelTouristid = new System.Windows.Forms.Label();
            this.textBoxTouristid = new System.Windows.Forms.TextBox();
            this.labelMain = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonConfirm.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonConfirm.Location = new System.Drawing.Point(295, 291);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(200, 40);
            this.buttonConfirm.TabIndex = 24;
            this.buttonConfirm.Text = "Изменить";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCancel.Location = new System.Drawing.Point(295, 361);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(200, 40);
            this.buttonCancel.TabIndex = 23;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // labelSeasonid
            // 
            this.labelSeasonid.AutoSize = true;
            this.labelSeasonid.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSeasonid.Location = new System.Drawing.Point(348, 166);
            this.labelSeasonid.Name = "labelSeasonid";
            this.labelSeasonid.Size = new System.Drawing.Size(92, 25);
            this.labelSeasonid.TabIndex = 22;
            this.labelSeasonid.Text = "Id сезона";
            // 
            // textBoxSeasonid
            // 
            this.textBoxSeasonid.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxSeasonid.Location = new System.Drawing.Point(295, 194);
            this.textBoxSeasonid.Name = "textBoxSeasonid";
            this.textBoxSeasonid.Size = new System.Drawing.Size(200, 33);
            this.textBoxSeasonid.TabIndex = 21;
            // 
            // labelTouristid
            // 
            this.labelTouristid.AutoSize = true;
            this.labelTouristid.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTouristid.Location = new System.Drawing.Point(348, 102);
            this.labelTouristid.Name = "labelTouristid";
            this.labelTouristid.Size = new System.Drawing.Size(99, 25);
            this.labelTouristid.TabIndex = 20;
            this.labelTouristid.Text = "Id туриста";
            // 
            // textBoxTouristid
            // 
            this.textBoxTouristid.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxTouristid.Location = new System.Drawing.Point(295, 130);
            this.textBoxTouristid.Name = "textBoxTouristid";
            this.textBoxTouristid.Size = new System.Drawing.Size(200, 33);
            this.textBoxTouristid.TabIndex = 19;
            // 
            // labelMain
            // 
            this.labelMain.AutoSize = true;
            this.labelMain.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMain.Location = new System.Drawing.Point(243, 9);
            this.labelMain.Name = "labelMain";
            this.labelMain.Size = new System.Drawing.Size(309, 47);
            this.labelMain.TabIndex = 18;
            this.labelMain.Text = "Изменить путёвку";
            this.labelMain.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ModalFormBookingsChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.labelSeasonid);
            this.Controls.Add(this.textBoxSeasonid);
            this.Controls.Add(this.labelTouristid);
            this.Controls.Add(this.textBoxTouristid);
            this.Controls.Add(this.labelMain);
            this.Name = "ModalFormBookingsChange";
            this.Text = "ModalFormBookingsChange";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonConfirm;
        private Button buttonCancel;
        private Label labelSeasonid;
        private TextBox textBoxSeasonid;
        private Label labelTouristid;
        private TextBox textBoxTouristid;
        private Label labelMain;
    }
}