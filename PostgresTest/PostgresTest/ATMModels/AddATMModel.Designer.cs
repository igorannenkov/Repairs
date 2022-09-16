namespace PostgresTest
{
    partial class AddATMModel
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
            this.AddATMModelBtn = new System.Windows.Forms.Button();
            this.AddATMModelLabel = new System.Windows.Forms.Label();
            this.AddATMModelTextBox = new System.Windows.Forms.TextBox();
            this.AddATMModelCnlBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddATMModelBtn
            // 
            this.AddATMModelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddATMModelBtn.Location = new System.Drawing.Point(12, 92);
            this.AddATMModelBtn.Name = "AddATMModelBtn";
            this.AddATMModelBtn.Size = new System.Drawing.Size(137, 39);
            this.AddATMModelBtn.TabIndex = 1;
            this.AddATMModelBtn.Text = "Внести данные";
            this.AddATMModelBtn.UseVisualStyleBackColor = true;
            this.AddATMModelBtn.Click += new System.EventHandler(this.ATMModelBtn_Click);
            // 
            // AddATMModelLabel
            // 
            this.AddATMModelLabel.AutoSize = true;
            this.AddATMModelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddATMModelLabel.Location = new System.Drawing.Point(12, 15);
            this.AddATMModelLabel.Name = "AddATMModelLabel";
            this.AddATMModelLabel.Size = new System.Drawing.Size(268, 20);
            this.AddATMModelLabel.TabIndex = 1;
            this.AddATMModelLabel.Text = "Модель устройства самообсл.";
            // 
            // AddATMModelTextBox
            // 
            this.AddATMModelTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddATMModelTextBox.Location = new System.Drawing.Point(12, 48);
            this.AddATMModelTextBox.Name = "AddATMModelTextBox";
            this.AddATMModelTextBox.Size = new System.Drawing.Size(277, 26);
            this.AddATMModelTextBox.TabIndex = 0;
            this.AddATMModelTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AddATMModelCnlBtn
            // 
            this.AddATMModelCnlBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddATMModelCnlBtn.Location = new System.Drawing.Point(155, 92);
            this.AddATMModelCnlBtn.Name = "AddATMModelCnlBtn";
            this.AddATMModelCnlBtn.Size = new System.Drawing.Size(137, 39);
            this.AddATMModelCnlBtn.TabIndex = 2;
            this.AddATMModelCnlBtn.Text = "Отмена";
            this.AddATMModelCnlBtn.UseVisualStyleBackColor = true;
            this.AddATMModelCnlBtn.Click += new System.EventHandler(this.AddATMModelCnlBtn_Click);
            // 
            // AddATMModel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 146);
            this.Controls.Add(this.AddATMModelCnlBtn);
            this.Controls.Add(this.AddATMModelTextBox);
            this.Controls.Add(this.AddATMModelLabel);
            this.Controls.Add(this.AddATMModelBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AddATMModel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Модель УС";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddATMModelBtn;
        private System.Windows.Forms.Label AddATMModelLabel;
        private System.Windows.Forms.TextBox AddATMModelTextBox;
        private System.Windows.Forms.Button AddATMModelCnlBtn;
    }
}