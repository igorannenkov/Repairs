namespace PostgresTest
{
    partial class SettingsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.SettingsServerHostnameLabel = new System.Windows.Forms.Label();
            this.SettingsServerPortLabel = new System.Windows.Forms.Label();
            this.SettingsUsernameLabel = new System.Windows.Forms.Label();
            this.SettingsPasswordLabel = new System.Windows.Forms.Label();
            this.SettingsDBNameLabel = new System.Windows.Forms.Label();
            this.SettingsServernameTextBox = new System.Windows.Forms.TextBox();
            this.SettingsServerPortTextBox = new System.Windows.Forms.TextBox();
            this.SettingsUsernameTextBox = new System.Windows.Forms.TextBox();
            this.SettingsPasswordTextBox = new System.Windows.Forms.TextBox();
            this.SettingsDBNameTextBox = new System.Windows.Forms.TextBox();
            this.SettingsCancelBtn = new System.Windows.Forms.Button();
            this.SettingsSaveBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "@\"Server=localhost;Port=5432;User ID=postgres;\r\nPassword=**********;Database=Repa" +
    "irs;\"";
            // 
            // SettingsServerHostnameLabel
            // 
            this.SettingsServerHostnameLabel.AutoSize = true;
            this.SettingsServerHostnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SettingsServerHostnameLabel.Location = new System.Drawing.Point(11, 44);
            this.SettingsServerHostnameLabel.Name = "SettingsServerHostnameLabel";
            this.SettingsServerHostnameLabel.Size = new System.Drawing.Size(65, 20);
            this.SettingsServerHostnameLabel.TabIndex = 1;
            this.SettingsServerHostnameLabel.Text = "Сервер";
            // 
            // SettingsServerPortLabel
            // 
            this.SettingsServerPortLabel.AutoSize = true;
            this.SettingsServerPortLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SettingsServerPortLabel.Location = new System.Drawing.Point(11, 96);
            this.SettingsServerPortLabel.Name = "SettingsServerPortLabel";
            this.SettingsServerPortLabel.Size = new System.Drawing.Size(48, 20);
            this.SettingsServerPortLabel.TabIndex = 2;
            this.SettingsServerPortLabel.Text = "Порт";
            // 
            // SettingsUsernameLabel
            // 
            this.SettingsUsernameLabel.AutoSize = true;
            this.SettingsUsernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SettingsUsernameLabel.Location = new System.Drawing.Point(11, 200);
            this.SettingsUsernameLabel.Name = "SettingsUsernameLabel";
            this.SettingsUsernameLabel.Size = new System.Drawing.Size(153, 20);
            this.SettingsUsernameLabel.TabIndex = 3;
            this.SettingsUsernameLabel.Text = "Имя пользователя";
            // 
            // SettingsPasswordLabel
            // 
            this.SettingsPasswordLabel.AutoSize = true;
            this.SettingsPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SettingsPasswordLabel.Location = new System.Drawing.Point(11, 252);
            this.SettingsPasswordLabel.Name = "SettingsPasswordLabel";
            this.SettingsPasswordLabel.Size = new System.Drawing.Size(67, 20);
            this.SettingsPasswordLabel.TabIndex = 4;
            this.SettingsPasswordLabel.Text = "Пароль";
            // 
            // SettingsDBNameLabel
            // 
            this.SettingsDBNameLabel.AutoSize = true;
            this.SettingsDBNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SettingsDBNameLabel.Location = new System.Drawing.Point(11, 148);
            this.SettingsDBNameLabel.Name = "SettingsDBNameLabel";
            this.SettingsDBNameLabel.Size = new System.Drawing.Size(67, 20);
            this.SettingsDBNameLabel.TabIndex = 5;
            this.SettingsDBNameLabel.Text = "Имя БД";
            // 
            // SettingsServernameTextBox
            // 
            this.SettingsServernameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SettingsServernameTextBox.Location = new System.Drawing.Point(14, 67);
            this.SettingsServernameTextBox.Name = "SettingsServernameTextBox";
            this.SettingsServernameTextBox.Size = new System.Drawing.Size(244, 26);
            this.SettingsServernameTextBox.TabIndex = 0;
            this.SettingsServernameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SettingsServerPortTextBox
            // 
            this.SettingsServerPortTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SettingsServerPortTextBox.Location = new System.Drawing.Point(15, 119);
            this.SettingsServerPortTextBox.Name = "SettingsServerPortTextBox";
            this.SettingsServerPortTextBox.Size = new System.Drawing.Size(243, 26);
            this.SettingsServerPortTextBox.TabIndex = 1;
            this.SettingsServerPortTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SettingsUsernameTextBox
            // 
            this.SettingsUsernameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SettingsUsernameTextBox.Location = new System.Drawing.Point(15, 223);
            this.SettingsUsernameTextBox.Name = "SettingsUsernameTextBox";
            this.SettingsUsernameTextBox.Size = new System.Drawing.Size(244, 26);
            this.SettingsUsernameTextBox.TabIndex = 3;
            this.SettingsUsernameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SettingsPasswordTextBox
            // 
            this.SettingsPasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SettingsPasswordTextBox.Location = new System.Drawing.Point(16, 275);
            this.SettingsPasswordTextBox.Name = "SettingsPasswordTextBox";
            this.SettingsPasswordTextBox.PasswordChar = '*';
            this.SettingsPasswordTextBox.Size = new System.Drawing.Size(243, 26);
            this.SettingsPasswordTextBox.TabIndex = 4;
            this.SettingsPasswordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SettingsDBNameTextBox
            // 
            this.SettingsDBNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SettingsDBNameTextBox.Location = new System.Drawing.Point(14, 171);
            this.SettingsDBNameTextBox.Name = "SettingsDBNameTextBox";
            this.SettingsDBNameTextBox.Size = new System.Drawing.Size(244, 26);
            this.SettingsDBNameTextBox.TabIndex = 2;
            this.SettingsDBNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SettingsCancelBtn
            // 
            this.SettingsCancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SettingsCancelBtn.Location = new System.Drawing.Point(138, 316);
            this.SettingsCancelBtn.Name = "SettingsCancelBtn";
            this.SettingsCancelBtn.Size = new System.Drawing.Size(120, 40);
            this.SettingsCancelBtn.TabIndex = 6;
            this.SettingsCancelBtn.Text = "Отмена";
            this.SettingsCancelBtn.UseVisualStyleBackColor = true;
            this.SettingsCancelBtn.Click += new System.EventHandler(this.SettingsCancelBtn_Click);
            // 
            // SettingsSaveBtn
            // 
            this.SettingsSaveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SettingsSaveBtn.Location = new System.Drawing.Point(12, 316);
            this.SettingsSaveBtn.Name = "SettingsSaveBtn";
            this.SettingsSaveBtn.Size = new System.Drawing.Size(120, 40);
            this.SettingsSaveBtn.TabIndex = 5;
            this.SettingsSaveBtn.Text = "Сохранить";
            this.SettingsSaveBtn.UseVisualStyleBackColor = true;
            this.SettingsSaveBtn.Click += new System.EventHandler(this.SettingsSaveBtn_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 375);
            this.Controls.Add(this.SettingsSaveBtn);
            this.Controls.Add(this.SettingsCancelBtn);
            this.Controls.Add(this.SettingsDBNameTextBox);
            this.Controls.Add(this.SettingsPasswordTextBox);
            this.Controls.Add(this.SettingsUsernameTextBox);
            this.Controls.Add(this.SettingsServerPortTextBox);
            this.Controls.Add(this.SettingsServernameTextBox);
            this.Controls.Add(this.SettingsDBNameLabel);
            this.Controls.Add(this.SettingsPasswordLabel);
            this.Controls.Add(this.SettingsUsernameLabel);
            this.Controls.Add(this.SettingsServerPortLabel);
            this.Controls.Add(this.SettingsServerHostnameLabel);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Параметры";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label SettingsServerHostnameLabel;
        private System.Windows.Forms.Label SettingsServerPortLabel;
        private System.Windows.Forms.Label SettingsUsernameLabel;
        private System.Windows.Forms.Label SettingsPasswordLabel;
        private System.Windows.Forms.Label SettingsDBNameLabel;
        private System.Windows.Forms.TextBox SettingsServernameTextBox;
        private System.Windows.Forms.TextBox SettingsServerPortTextBox;
        private System.Windows.Forms.TextBox SettingsUsernameTextBox;
        private System.Windows.Forms.TextBox SettingsPasswordTextBox;
        private System.Windows.Forms.TextBox SettingsDBNameTextBox;
        private System.Windows.Forms.Button SettingsCancelBtn;
        private System.Windows.Forms.Button SettingsSaveBtn;
    }
}