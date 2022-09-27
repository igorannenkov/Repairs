namespace PostgresTest
{
    partial class UpdateATMModel
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
            this.UpdateATMModelTextBox = new System.Windows.Forms.TextBox();
            this.UpdateATMLabel = new System.Windows.Forms.Label();
            this.UpdateATMModelBtn = new System.Windows.Forms.Button();
            this.UpdateATMModelCnlBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UpdateATMModelTextBox
            // 
            this.UpdateATMModelTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UpdateATMModelTextBox.Location = new System.Drawing.Point(12, 48);
            this.UpdateATMModelTextBox.Name = "UpdateATMModelTextBox";
            this.UpdateATMModelTextBox.Size = new System.Drawing.Size(277, 26);
            this.UpdateATMModelTextBox.TabIndex = 0;
            this.UpdateATMModelTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // UpdateATMLabel
            // 
            this.UpdateATMLabel.AutoSize = true;
            this.UpdateATMLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UpdateATMLabel.Location = new System.Drawing.Point(12, 15);
            this.UpdateATMLabel.Name = "UpdateATMLabel";
            this.UpdateATMLabel.Size = new System.Drawing.Size(268, 20);
            this.UpdateATMLabel.TabIndex = 1;
            this.UpdateATMLabel.Text = "Модель устройства самообсл.";
            // 
            // UpdateATMModelBtn
            // 
            this.UpdateATMModelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UpdateATMModelBtn.Location = new System.Drawing.Point(12, 92);
            this.UpdateATMModelBtn.Name = "UpdateATMModelBtn";
            this.UpdateATMModelBtn.Size = new System.Drawing.Size(137, 39);
            this.UpdateATMModelBtn.TabIndex = 1;
            this.UpdateATMModelBtn.Text = "Внести данные";
            this.UpdateATMModelBtn.UseVisualStyleBackColor = true;
            this.UpdateATMModelBtn.Click += new System.EventHandler(this.UpdateATMModelBtn_Click);
            // 
            // UpdateATMModelCnlBtn
            // 
            this.UpdateATMModelCnlBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UpdateATMModelCnlBtn.Location = new System.Drawing.Point(155, 92);
            this.UpdateATMModelCnlBtn.Name = "UpdateATMModelCnlBtn";
            this.UpdateATMModelCnlBtn.Size = new System.Drawing.Size(137, 39);
            this.UpdateATMModelCnlBtn.TabIndex = 2;
            this.UpdateATMModelCnlBtn.Text = "Отмена";
            this.UpdateATMModelCnlBtn.UseVisualStyleBackColor = true;
            this.UpdateATMModelCnlBtn.Click += new System.EventHandler(this.UpdateATMModelCnlBtn_Click);
            // 
            // UpdateATMModel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 146);
            this.Controls.Add(this.UpdateATMModelCnlBtn);
            this.Controls.Add(this.UpdateATMModelBtn);
            this.Controls.Add(this.UpdateATMLabel);
            this.Controls.Add(this.UpdateATMModelTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "UpdateATMModel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Модель УС (ред.)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UpdateATMModelTextBox;
        private System.Windows.Forms.Label UpdateATMLabel;
        private System.Windows.Forms.Button UpdateATMModelBtn;
        private System.Windows.Forms.Button UpdateATMModelCnlBtn;
    }
}