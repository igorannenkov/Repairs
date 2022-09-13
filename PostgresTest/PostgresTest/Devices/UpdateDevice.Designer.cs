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
            this.SuspendLayout();
            // 
            // DeviceEditBtn
            // 
            this.DeviceEditBtn.Location = new System.Drawing.Point(3, 51);
            this.DeviceEditBtn.Name = "DeviceEditBtn";
            this.DeviceEditBtn.Size = new System.Drawing.Size(188, 33);
            this.DeviceEditBtn.TabIndex = 0;
            this.DeviceEditBtn.Text = "Сохранить и закрыть";
            this.DeviceEditBtn.UseVisualStyleBackColor = true;
            this.DeviceEditBtn.Click += new System.EventHandler(this.DeviceEditBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите наименование:";
            // 
            // UpdateDeviceTextBox
            // 
            this.UpdateDeviceTextBox.Location = new System.Drawing.Point(3, 25);
            this.UpdateDeviceTextBox.Name = "UpdateDeviceTextBox";
            this.UpdateDeviceTextBox.Size = new System.Drawing.Size(188, 20);
            this.UpdateDeviceTextBox.TabIndex = 2;
            // 
            // UpdateDevice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(196, 91);
            this.Controls.Add(this.UpdateDeviceTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DeviceEditBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "UpdateDevice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Редактировать наименование";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DeviceEditBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UpdateDeviceTextBox;
    }
}