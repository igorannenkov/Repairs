namespace PostgresTest
{
    partial class AddRegion
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
            this.AddRegionBtn = new System.Windows.Forms.Button();
            this.AddRegionTextBox = new System.Windows.Forms.TextBox();
            this.AddRegionLabel = new System.Windows.Forms.Label();
            this.AddRegionCnlBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddRegionBtn
            // 
            this.AddRegionBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddRegionBtn.Location = new System.Drawing.Point(12, 92);
            this.AddRegionBtn.Name = "AddRegionBtn";
            this.AddRegionBtn.Size = new System.Drawing.Size(137, 39);
            this.AddRegionBtn.TabIndex = 1;
            this.AddRegionBtn.Text = "Внести данные";
            this.AddRegionBtn.UseVisualStyleBackColor = true;
            this.AddRegionBtn.Click += new System.EventHandler(this.AddRegionBtn_Click);
            // 
            // AddRegionTextBox
            // 
            this.AddRegionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddRegionTextBox.Location = new System.Drawing.Point(12, 48);
            this.AddRegionTextBox.Name = "AddRegionTextBox";
            this.AddRegionTextBox.Size = new System.Drawing.Size(277, 26);
            this.AddRegionTextBox.TabIndex = 0;
            this.AddRegionTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AddRegionLabel
            // 
            this.AddRegionLabel.AutoSize = true;
            this.AddRegionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddRegionLabel.Location = new System.Drawing.Point(12, 15);
            this.AddRegionLabel.Name = "AddRegionLabel";
            this.AddRegionLabel.Size = new System.Drawing.Size(68, 20);
            this.AddRegionLabel.TabIndex = 2;
            this.AddRegionLabel.Text = "Регион";
            // 
            // AddRegionCnlBtn
            // 
            this.AddRegionCnlBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddRegionCnlBtn.Location = new System.Drawing.Point(155, 92);
            this.AddRegionCnlBtn.Name = "AddRegionCnlBtn";
            this.AddRegionCnlBtn.Size = new System.Drawing.Size(137, 39);
            this.AddRegionCnlBtn.TabIndex = 2;
            this.AddRegionCnlBtn.Text = "Отмена";
            this.AddRegionCnlBtn.UseVisualStyleBackColor = true;
            this.AddRegionCnlBtn.Click += new System.EventHandler(this.AddRegionCnlBtn_Click);
            // 
            // AddRegion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 146);
            this.Controls.Add(this.AddRegionCnlBtn);
            this.Controls.Add(this.AddRegionLabel);
            this.Controls.Add(this.AddRegionTextBox);
            this.Controls.Add(this.AddRegionBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AddRegion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Регион";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddRegionBtn;
        private System.Windows.Forms.TextBox AddRegionTextBox;
        private System.Windows.Forms.Label AddRegionLabel;
        private System.Windows.Forms.Button AddRegionCnlBtn;
    }
}