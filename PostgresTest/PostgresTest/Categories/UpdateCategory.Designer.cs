namespace PostgresTest
{
    partial class UpdateCategory
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
            this.CatEditBtn = new System.Windows.Forms.Button();
            this.UpdCatLbl = new System.Windows.Forms.Label();
            this.UpdCatTextBox = new System.Windows.Forms.TextBox();
            this.CatEditCnlBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CatEditBtn
            // 
            this.CatEditBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CatEditBtn.Location = new System.Drawing.Point(12, 92);
            this.CatEditBtn.Name = "CatEditBtn";
            this.CatEditBtn.Size = new System.Drawing.Size(137, 39);
            this.CatEditBtn.TabIndex = 1;
            this.CatEditBtn.Text = "Внести данные";
            this.CatEditBtn.UseVisualStyleBackColor = true;
            this.CatEditBtn.Click += new System.EventHandler(this.DeviceEditBtn_Click);
            // 
            // UpdCatLbl
            // 
            this.UpdCatLbl.AutoSize = true;
            this.UpdCatLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UpdCatLbl.Location = new System.Drawing.Point(12, 15);
            this.UpdCatLbl.Name = "UpdCatLbl";
            this.UpdCatLbl.Size = new System.Drawing.Size(173, 20);
            this.UpdCatLbl.TabIndex = 1;
            this.UpdCatLbl.Text = "Наименование кат.";
            // 
            // UpdCatTextBox
            // 
            this.UpdCatTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UpdCatTextBox.Location = new System.Drawing.Point(12, 48);
            this.UpdCatTextBox.Name = "UpdCatTextBox";
            this.UpdCatTextBox.Size = new System.Drawing.Size(277, 26);
            this.UpdCatTextBox.TabIndex = 0;
            this.UpdCatTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CatEditCnlBtn
            // 
            this.CatEditCnlBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CatEditCnlBtn.Location = new System.Drawing.Point(155, 92);
            this.CatEditCnlBtn.Name = "CatEditCnlBtn";
            this.CatEditCnlBtn.Size = new System.Drawing.Size(137, 39);
            this.CatEditCnlBtn.TabIndex = 2;
            this.CatEditCnlBtn.Text = "Отмена";
            this.CatEditCnlBtn.UseVisualStyleBackColor = true;
            this.CatEditCnlBtn.Click += new System.EventHandler(this.DeviceEditCnlBtn_Click);
            // 
            // UpdateCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 146);
            this.Controls.Add(this.CatEditCnlBtn);
            this.Controls.Add(this.UpdCatTextBox);
            this.Controls.Add(this.UpdCatLbl);
            this.Controls.Add(this.CatEditBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "UpdateCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Категория (ред.)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CatEditBtn;
        private System.Windows.Forms.Label UpdCatLbl;
        private System.Windows.Forms.TextBox UpdCatTextBox;
        private System.Windows.Forms.Button CatEditCnlBtn;
    }
}