namespace PostgresTest
{
    partial class AddEngineer
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
            this.addEngineerBtn = new System.Windows.Forms.Button();
            this.addEngineerLabel = new System.Windows.Forms.Label();
            this.addEngineerTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // addEngineerBtn
            // 
            this.addEngineerBtn.Location = new System.Drawing.Point(12, 64);
            this.addEngineerBtn.Name = "addEngineerBtn";
            this.addEngineerBtn.Size = new System.Drawing.Size(188, 35);
            this.addEngineerBtn.TabIndex = 0;
            this.addEngineerBtn.Text = "Добавить";
            this.addEngineerBtn.UseVisualStyleBackColor = true;
            this.addEngineerBtn.Click += new System.EventHandler(this.addEngineerBtn_Click);
            // 
            // addEngineerLabel
            // 
            this.addEngineerLabel.AutoSize = true;
            this.addEngineerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addEngineerLabel.Location = new System.Drawing.Point(12, 9);
            this.addEngineerLabel.Name = "addEngineerLabel";
            this.addEngineerLabel.Size = new System.Drawing.Size(83, 20);
            this.addEngineerLabel.TabIndex = 1;
            this.addEngineerLabel.Text = "Инженер";
            // 
            // addEngineerTextBox
            // 
            this.addEngineerTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addEngineerTextBox.Location = new System.Drawing.Point(12, 32);
            this.addEngineerTextBox.Name = "addEngineerTextBox";
            this.addEngineerTextBox.Size = new System.Drawing.Size(188, 26);
            this.addEngineerTextBox.TabIndex = 2;
            // 
            // AddEngineer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(212, 109);
            this.Controls.Add(this.addEngineerTextBox);
            this.Controls.Add(this.addEngineerLabel);
            this.Controls.Add(this.addEngineerBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddEngineer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавить инженера";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addEngineerBtn;
        private System.Windows.Forms.Label addEngineerLabel;
        private System.Windows.Forms.TextBox addEngineerTextBox;
    }
}