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
            this.SuspendLayout();
            // 
            // UpdateRegionLabel
            // 
            this.UpdateRegionLabel.AutoSize = true;
            this.UpdateRegionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UpdateRegionLabel.Location = new System.Drawing.Point(12, 9);
            this.UpdateRegionLabel.Name = "UpdateRegionLabel";
            this.UpdateRegionLabel.Size = new System.Drawing.Size(68, 20);
            this.UpdateRegionLabel.TabIndex = 0;
            this.UpdateRegionLabel.Text = "Регион";
            // 
            // UpdateRegionTextBox
            // 
            this.UpdateRegionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UpdateRegionTextBox.Location = new System.Drawing.Point(16, 32);
            this.UpdateRegionTextBox.Name = "UpdateRegionTextBox";
            this.UpdateRegionTextBox.Size = new System.Drawing.Size(188, 26);
            this.UpdateRegionTextBox.TabIndex = 1;
            // 
            // UpdateRegionBtn
            // 
            this.UpdateRegionBtn.Location = new System.Drawing.Point(16, 64);
            this.UpdateRegionBtn.Name = "UpdateRegionBtn";
            this.UpdateRegionBtn.Size = new System.Drawing.Size(188, 29);
            this.UpdateRegionBtn.TabIndex = 2;
            this.UpdateRegionBtn.Text = "Обновить и закрыть";
            this.UpdateRegionBtn.UseVisualStyleBackColor = true;
            this.UpdateRegionBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // UpdateRegion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(217, 105);
            this.Controls.Add(this.UpdateRegionBtn);
            this.Controls.Add(this.UpdateRegionTextBox);
            this.Controls.Add(this.UpdateRegionLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "UpdateRegion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Обновление региона";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UpdateRegionLabel;
        private System.Windows.Forms.TextBox UpdateRegionTextBox;
        private System.Windows.Forms.Button UpdateRegionBtn;
    }
}