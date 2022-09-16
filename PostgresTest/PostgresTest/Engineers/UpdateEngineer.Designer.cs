namespace PostgresTest
{
    partial class UpdateEngineer
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
            this.UpdateEngineerBtn = new System.Windows.Forms.Button();
            this.UpdateEngineerLabel = new System.Windows.Forms.Label();
            this.UpdateEngineerTextBox = new System.Windows.Forms.TextBox();
            this.UpdateEngineerCnlBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UpdateEngineerBtn
            // 
            this.UpdateEngineerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UpdateEngineerBtn.Location = new System.Drawing.Point(12, 92);
            this.UpdateEngineerBtn.Name = "UpdateEngineerBtn";
            this.UpdateEngineerBtn.Size = new System.Drawing.Size(137, 39);
            this.UpdateEngineerBtn.TabIndex = 1;
            this.UpdateEngineerBtn.Text = "Внести данные";
            this.UpdateEngineerBtn.UseVisualStyleBackColor = true;
            this.UpdateEngineerBtn.Click += new System.EventHandler(this.UpdateEngineerBtn_Click);
            // 
            // UpdateEngineerLabel
            // 
            this.UpdateEngineerLabel.AutoSize = true;
            this.UpdateEngineerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UpdateEngineerLabel.Location = new System.Drawing.Point(12, 15);
            this.UpdateEngineerLabel.Name = "UpdateEngineerLabel";
            this.UpdateEngineerLabel.Size = new System.Drawing.Size(83, 20);
            this.UpdateEngineerLabel.TabIndex = 1;
            this.UpdateEngineerLabel.Text = "Инженер";
            // 
            // UpdateEngineerTextBox
            // 
            this.UpdateEngineerTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UpdateEngineerTextBox.Location = new System.Drawing.Point(12, 48);
            this.UpdateEngineerTextBox.Name = "UpdateEngineerTextBox";
            this.UpdateEngineerTextBox.Size = new System.Drawing.Size(277, 26);
            this.UpdateEngineerTextBox.TabIndex = 0;
            this.UpdateEngineerTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // UpdateEngineerCnlBtn
            // 
            this.UpdateEngineerCnlBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UpdateEngineerCnlBtn.Location = new System.Drawing.Point(155, 92);
            this.UpdateEngineerCnlBtn.Name = "UpdateEngineerCnlBtn";
            this.UpdateEngineerCnlBtn.Size = new System.Drawing.Size(137, 39);
            this.UpdateEngineerCnlBtn.TabIndex = 2;
            this.UpdateEngineerCnlBtn.Text = "Отмена";
            this.UpdateEngineerCnlBtn.UseVisualStyleBackColor = true;
            this.UpdateEngineerCnlBtn.Click += new System.EventHandler(this.UpdateEngineerCnlBtn_Click);
            // 
            // UpdateEngineer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 146);
            this.Controls.Add(this.UpdateEngineerCnlBtn);
            this.Controls.Add(this.UpdateEngineerTextBox);
            this.Controls.Add(this.UpdateEngineerLabel);
            this.Controls.Add(this.UpdateEngineerBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "UpdateEngineer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Инженер (ред.)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UpdateEngineerBtn;
        private System.Windows.Forms.Label UpdateEngineerLabel;
        private System.Windows.Forms.TextBox UpdateEngineerTextBox;
        private System.Windows.Forms.Button UpdateEngineerCnlBtn;
    }
}