namespace PostgresTest
{
    partial class UpdateRegion
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
            this.UpdateRegionLabel = new System.Windows.Forms.Label();
            this.UpdateRegionTextBox = new System.Windows.Forms.TextBox();
            this.UpdateRegionBtn = new System.Windows.Forms.Button();
            this.UpdateRegionCnlBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UpdateRegionLabel
            // 
            this.UpdateRegionLabel.AutoSize = true;
            this.UpdateRegionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UpdateRegionLabel.Location = new System.Drawing.Point(12, 15);
            this.UpdateRegionLabel.Name = "UpdateRegionLabel";
            this.UpdateRegionLabel.Size = new System.Drawing.Size(68, 20);
            this.UpdateRegionLabel.TabIndex = 0;
            this.UpdateRegionLabel.Text = "Регион";
            // 
            // UpdateRegionTextBox
            // 
            this.UpdateRegionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UpdateRegionTextBox.Location = new System.Drawing.Point(12, 48);
            this.UpdateRegionTextBox.Name = "UpdateRegionTextBox";
            this.UpdateRegionTextBox.Size = new System.Drawing.Size(277, 26);
            this.UpdateRegionTextBox.TabIndex = 0;
            this.UpdateRegionTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // UpdateRegionBtn
            // 
            this.UpdateRegionBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UpdateRegionBtn.Location = new System.Drawing.Point(12, 92);
            this.UpdateRegionBtn.Name = "UpdateRegionBtn";
            this.UpdateRegionBtn.Size = new System.Drawing.Size(137, 39);
            this.UpdateRegionBtn.TabIndex = 1;
            this.UpdateRegionBtn.Text = "Сохранить";
            this.UpdateRegionBtn.UseVisualStyleBackColor = true;
            this.UpdateRegionBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // UpdateRegionCnlBtn
            // 
            this.UpdateRegionCnlBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UpdateRegionCnlBtn.Location = new System.Drawing.Point(155, 92);
            this.UpdateRegionCnlBtn.Name = "UpdateRegionCnlBtn";
            this.UpdateRegionCnlBtn.Size = new System.Drawing.Size(137, 39);
            this.UpdateRegionCnlBtn.TabIndex = 2;
            this.UpdateRegionCnlBtn.Text = "Отмена";
            this.UpdateRegionCnlBtn.UseVisualStyleBackColor = true;
            this.UpdateRegionCnlBtn.Click += new System.EventHandler(this.UpdateRegionCnlBtn_Click);
            // 
            // UpdateRegion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 146);
            this.Controls.Add(this.UpdateRegionCnlBtn);
            this.Controls.Add(this.UpdateRegionBtn);
            this.Controls.Add(this.UpdateRegionTextBox);
            this.Controls.Add(this.UpdateRegionLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "UpdateRegion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Регион (ред.)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UpdateRegionLabel;
        private System.Windows.Forms.TextBox UpdateRegionTextBox;
        private System.Windows.Forms.Button UpdateRegionBtn;
        private System.Windows.Forms.Button UpdateRegionCnlBtn;
    }
}