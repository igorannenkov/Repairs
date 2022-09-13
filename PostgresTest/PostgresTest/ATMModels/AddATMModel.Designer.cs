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
            this.SuspendLayout();
            // 
            // AddATMModelBtn
            // 
            this.AddATMModelBtn.Location = new System.Drawing.Point(16, 64);
            this.AddATMModelBtn.Name = "AddATMModelBtn";
            this.AddATMModelBtn.Size = new System.Drawing.Size(179, 39);
            this.AddATMModelBtn.TabIndex = 0;
            this.AddATMModelBtn.Text = "Сохранить и закрыть";
            this.AddATMModelBtn.UseVisualStyleBackColor = true;
            this.AddATMModelBtn.Click += new System.EventHandler(this.ATMModelBtn_Click);
            // 
            // AddATMModelLabel
            // 
            this.AddATMModelLabel.AutoSize = true;
            this.AddATMModelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddATMModelLabel.Location = new System.Drawing.Point(12, 9);
            this.AddATMModelLabel.Name = "AddATMModelLabel";
            this.AddATMModelLabel.Size = new System.Drawing.Size(172, 20);
            this.AddATMModelLabel.TabIndex = 1;
            this.AddATMModelLabel.Text = "Модель банкомата";
            // 
            // AddATMModelTextBox
            // 
            this.AddATMModelTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddATMModelTextBox.Location = new System.Drawing.Point(16, 32);
            this.AddATMModelTextBox.Name = "AddATMModelTextBox";
            this.AddATMModelTextBox.Size = new System.Drawing.Size(179, 26);
            this.AddATMModelTextBox.TabIndex = 2;
            // 
            // AddATMModel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(203, 112);
            this.Controls.Add(this.AddATMModelTextBox);
            this.Controls.Add(this.AddATMModelLabel);
            this.Controls.Add(this.AddATMModelBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddATMModel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Модель банкомата";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddATMModelBtn;
        private System.Windows.Forms.Label AddATMModelLabel;
        private System.Windows.Forms.TextBox AddATMModelTextBox;
    }
}