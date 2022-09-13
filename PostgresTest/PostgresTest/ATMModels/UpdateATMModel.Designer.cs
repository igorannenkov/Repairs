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
            this.UpdateATMTextBox = new System.Windows.Forms.TextBox();
            this.UpdateATMLabel = new System.Windows.Forms.Label();
            this.UpdateATMModelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UpdateATMTextBox
            // 
            this.UpdateATMTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UpdateATMTextBox.Location = new System.Drawing.Point(12, 32);
            this.UpdateATMTextBox.Name = "UpdateATMTextBox";
            this.UpdateATMTextBox.Size = new System.Drawing.Size(172, 26);
            this.UpdateATMTextBox.TabIndex = 0;
            this.UpdateATMTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // UpdateATMLabel
            // 
            this.UpdateATMLabel.AutoSize = true;
            this.UpdateATMLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UpdateATMLabel.Location = new System.Drawing.Point(12, 9);
            this.UpdateATMLabel.Name = "UpdateATMLabel";
            this.UpdateATMLabel.Size = new System.Drawing.Size(172, 20);
            this.UpdateATMLabel.TabIndex = 1;
            this.UpdateATMLabel.Text = "Модель банкомата";
            // 
            // UpdateATMModelBtn
            // 
            this.UpdateATMModelBtn.Location = new System.Drawing.Point(12, 64);
            this.UpdateATMModelBtn.Name = "UpdateATMModelBtn";
            this.UpdateATMModelBtn.Size = new System.Drawing.Size(172, 41);
            this.UpdateATMModelBtn.TabIndex = 2;
            this.UpdateATMModelBtn.Text = "Сохранить и закрыть";
            this.UpdateATMModelBtn.UseVisualStyleBackColor = true;
            this.UpdateATMModelBtn.Click += new System.EventHandler(this.UpdateATMModelBtn_Click);
            // 
            // UpdateATMModel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(198, 115);
            this.Controls.Add(this.UpdateATMModelBtn);
            this.Controls.Add(this.UpdateATMLabel);
            this.Controls.Add(this.UpdateATMTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "UpdateATMModel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Модель банкомата";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UpdateATMTextBox;
        private System.Windows.Forms.Label UpdateATMLabel;
        private System.Windows.Forms.Button UpdateATMModelBtn;
    }
}