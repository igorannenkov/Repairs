namespace PostgresTest
{
    partial class AddDevice
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
            this.AddDeviceBtn = new System.Windows.Forms.Button();
            this.addDeviceTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AddDeviceCnlBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddDeviceBtn
            // 
            this.AddDeviceBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddDeviceBtn.Location = new System.Drawing.Point(12, 92);
            this.AddDeviceBtn.Name = "AddDeviceBtn";
            this.AddDeviceBtn.Size = new System.Drawing.Size(137, 39);
            this.AddDeviceBtn.TabIndex = 1;
            this.AddDeviceBtn.Text = "Внести данные";
            this.AddDeviceBtn.UseVisualStyleBackColor = true;
            this.AddDeviceBtn.Click += new System.EventHandler(this.AddDeviceBtn_Click);
            // 
            // addDeviceTextbox
            // 
            this.addDeviceTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addDeviceTextbox.Location = new System.Drawing.Point(12, 48);
            this.addDeviceTextbox.Name = "addDeviceTextbox";
            this.addDeviceTextbox.Size = new System.Drawing.Size(277, 26);
            this.addDeviceTextbox.TabIndex = 0;
            this.addDeviceTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Наименование кат.";
            // 
            // AddDeviceCnlBtn
            // 
            this.AddDeviceCnlBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddDeviceCnlBtn.Location = new System.Drawing.Point(155, 92);
            this.AddDeviceCnlBtn.Name = "AddDeviceCnlBtn";
            this.AddDeviceCnlBtn.Size = new System.Drawing.Size(137, 39);
            this.AddDeviceCnlBtn.TabIndex = 2;
            this.AddDeviceCnlBtn.Text = "Отмена";
            this.AddDeviceCnlBtn.UseVisualStyleBackColor = true;
            this.AddDeviceCnlBtn.Click += new System.EventHandler(this.AddDeviceCnlBtn_Click);
            // 
            // AddDevice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 146);
            this.Controls.Add(this.AddDeviceCnlBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addDeviceTextbox);
            this.Controls.Add(this.AddDeviceBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AddDevice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Категория ремонта";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddDeviceBtn;
        private System.Windows.Forms.TextBox addDeviceTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddDeviceCnlBtn;
    }
}