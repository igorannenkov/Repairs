namespace PostgresTest
{
    partial class UpdateDevice
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
            this.DeviceEditBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.UpdateDeviceTextBox = new System.Windows.Forms.TextBox();
            this.DeviceEditCnlBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DeviceEditBtn
            // 
            this.DeviceEditBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeviceEditBtn.Location = new System.Drawing.Point(12, 92);
            this.DeviceEditBtn.Name = "DeviceEditBtn";
            this.DeviceEditBtn.Size = new System.Drawing.Size(137, 39);
            this.DeviceEditBtn.TabIndex = 1;
            this.DeviceEditBtn.Text = "Внести данные";
            this.DeviceEditBtn.UseVisualStyleBackColor = true;
            this.DeviceEditBtn.Click += new System.EventHandler(this.DeviceEditBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Наименование кат.";
            // 
            // UpdateDeviceTextBox
            // 
            this.UpdateDeviceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UpdateDeviceTextBox.Location = new System.Drawing.Point(12, 48);
            this.UpdateDeviceTextBox.Name = "UpdateDeviceTextBox";
            this.UpdateDeviceTextBox.Size = new System.Drawing.Size(277, 26);
            this.UpdateDeviceTextBox.TabIndex = 0;
            this.UpdateDeviceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DeviceEditCnlBtn
            // 
            this.DeviceEditCnlBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeviceEditCnlBtn.Location = new System.Drawing.Point(155, 92);
            this.DeviceEditCnlBtn.Name = "DeviceEditCnlBtn";
            this.DeviceEditCnlBtn.Size = new System.Drawing.Size(137, 39);
            this.DeviceEditCnlBtn.TabIndex = 2;
            this.DeviceEditCnlBtn.Text = "Отмена";
            this.DeviceEditCnlBtn.UseVisualStyleBackColor = true;
            this.DeviceEditCnlBtn.Click += new System.EventHandler(this.DeviceEditCnlBtn_Click);
            // 
            // UpdateDevice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 146);
            this.Controls.Add(this.DeviceEditCnlBtn);
            this.Controls.Add(this.UpdateDeviceTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DeviceEditBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "UpdateDevice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Категория ремонта (ред.)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DeviceEditBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UpdateDeviceTextBox;
        private System.Windows.Forms.Button DeviceEditCnlBtn;
    }
}