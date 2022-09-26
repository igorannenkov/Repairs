namespace PostgresTest
{
    partial class AddCategory
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
            this.AddCategoryBtn = new System.Windows.Forms.Button();
            this.AddCategoryTextbox = new System.Windows.Forms.TextBox();
            this.AddCategoryLbl = new System.Windows.Forms.Label();
            this.AddCategoryCnlBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddCategoryBtn
            // 
            this.AddCategoryBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddCategoryBtn.Location = new System.Drawing.Point(12, 92);
            this.AddCategoryBtn.Name = "AddCategoryBtn";
            this.AddCategoryBtn.Size = new System.Drawing.Size(137, 39);
            this.AddCategoryBtn.TabIndex = 1;
            this.AddCategoryBtn.Text = "Внести данные";
            this.AddCategoryBtn.UseVisualStyleBackColor = true;
            this.AddCategoryBtn.Click += new System.EventHandler(this.AddDeviceBtn_Click);
            // 
            // AddCategoryTextbox
            // 
            this.AddCategoryTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddCategoryTextbox.Location = new System.Drawing.Point(12, 48);
            this.AddCategoryTextbox.Name = "AddCategoryTextbox";
            this.AddCategoryTextbox.Size = new System.Drawing.Size(277, 26);
            this.AddCategoryTextbox.TabIndex = 0;
            this.AddCategoryTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AddCategoryLbl
            // 
            this.AddCategoryLbl.AutoSize = true;
            this.AddCategoryLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddCategoryLbl.Location = new System.Drawing.Point(12, 15);
            this.AddCategoryLbl.Name = "AddCategoryLbl";
            this.AddCategoryLbl.Size = new System.Drawing.Size(226, 20);
            this.AddCategoryLbl.TabIndex = 2;
            this.AddCategoryLbl.Text = "Наименование категории";
            // 
            // AddCategoryCnlBtn
            // 
            this.AddCategoryCnlBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddCategoryCnlBtn.Location = new System.Drawing.Point(155, 92);
            this.AddCategoryCnlBtn.Name = "AddCategoryCnlBtn";
            this.AddCategoryCnlBtn.Size = new System.Drawing.Size(137, 39);
            this.AddCategoryCnlBtn.TabIndex = 2;
            this.AddCategoryCnlBtn.Text = "Отмена";
            this.AddCategoryCnlBtn.UseVisualStyleBackColor = true;
            this.AddCategoryCnlBtn.Click += new System.EventHandler(this.AddDeviceCnlBtn_Click);
            // 
            // AddCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 146);
            this.Controls.Add(this.AddCategoryCnlBtn);
            this.Controls.Add(this.AddCategoryLbl);
            this.Controls.Add(this.AddCategoryTextbox);
            this.Controls.Add(this.AddCategoryBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AddCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Категория";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddCategoryBtn;
        private System.Windows.Forms.TextBox AddCategoryTextbox;
        private System.Windows.Forms.Label AddCategoryLbl;
        private System.Windows.Forms.Button AddCategoryCnlBtn;
    }
}