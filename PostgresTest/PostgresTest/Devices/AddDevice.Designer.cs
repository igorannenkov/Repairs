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
            this.SuspendLayout();
            // 
            // AddDeviceBtn
            // 
            this.AddDeviceBtn.Location = new System.Drawing.Point(4, 51);
            this.AddDeviceBtn.Name = "AddDeviceBtn";
            this.AddDeviceBtn.Size = new System.Drawing.Size(188, 33);
            this.AddDeviceBtn.TabIndex = 0;
            this.AddDeviceBtn.Text = "Добавить и закрыть";
            this.AddDeviceBtn.UseVisualStyleBackColor = true;
            this.AddDeviceBtn.Click += new System.EventHandler(this.AddDeviceBtn_Click);
            // 
            // addDeviceTextbox
            // 
            this.addDeviceTextbox.Location = new System.Drawing.Point(4, 25);
            this.addDeviceTextbox.Name = "addDeviceTextbox";
            this.addDeviceTextbox.Size = new System.Drawing.Size(188, 20);
            this.addDeviceTextbox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Введите наименование:";
            // 
            // AddDevice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(196, 91);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addDeviceTextbox);
            this.Controls.Add(this.AddDeviceBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "AddDevice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавление устройства";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddDeviceBtn;
        private System.Windows.Forms.TextBox addDeviceTextbox;
        private System.Windows.Forms.Label label1;
    }
}