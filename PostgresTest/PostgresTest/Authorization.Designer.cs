namespace PostgresTest
{
    partial class Authorization
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
            this.AuthLoginLabel = new System.Windows.Forms.Label();
            this.AuthPasswordLabel = new System.Windows.Forms.Label();
            this.AuthUserIDTextBox = new System.Windows.Forms.TextBox();
            this.AuthPasswordTextBox = new System.Windows.Forms.TextBox();
            this.AuthEnterBtn = new System.Windows.Forms.Button();
            this.AuthCnlBtn = new System.Windows.Forms.Button();
            this.AuthLinkLabel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // AuthLoginLabel
            // 
            this.AuthLoginLabel.AutoSize = true;
            this.AuthLoginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AuthLoginLabel.Location = new System.Drawing.Point(12, 18);
            this.AuthLoginLabel.Name = "AuthLoginLabel";
            this.AuthLoginLabel.Size = new System.Drawing.Size(55, 20);
            this.AuthLoginLabel.TabIndex = 0;
            this.AuthLoginLabel.Text = "Логин";
            // 
            // AuthPasswordLabel
            // 
            this.AuthPasswordLabel.AutoSize = true;
            this.AuthPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AuthPasswordLabel.Location = new System.Drawing.Point(12, 73);
            this.AuthPasswordLabel.Name = "AuthPasswordLabel";
            this.AuthPasswordLabel.Size = new System.Drawing.Size(67, 20);
            this.AuthPasswordLabel.TabIndex = 1;
            this.AuthPasswordLabel.Text = "Пароль";
            // 
            // AuthUserIDTextBox
            // 
            this.AuthUserIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AuthUserIDTextBox.Location = new System.Drawing.Point(16, 41);
            this.AuthUserIDTextBox.Name = "AuthUserIDTextBox";
            this.AuthUserIDTextBox.Size = new System.Drawing.Size(274, 26);
            this.AuthUserIDTextBox.TabIndex = 2;
            this.AuthUserIDTextBox.Text = "postgres";
            this.AuthUserIDTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AuthPasswordTextBox
            // 
            this.AuthPasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AuthPasswordTextBox.Location = new System.Drawing.Point(16, 96);
            this.AuthPasswordTextBox.Name = "AuthPasswordTextBox";
            this.AuthPasswordTextBox.PasswordChar = '*';
            this.AuthPasswordTextBox.Size = new System.Drawing.Size(274, 26);
            this.AuthPasswordTextBox.TabIndex = 3;
            this.AuthPasswordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AuthEnterBtn
            // 
            this.AuthEnterBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AuthEnterBtn.Location = new System.Drawing.Point(18, 138);
            this.AuthEnterBtn.Name = "AuthEnterBtn";
            this.AuthEnterBtn.Size = new System.Drawing.Size(130, 47);
            this.AuthEnterBtn.TabIndex = 4;
            this.AuthEnterBtn.Text = "Авторизация";
            this.AuthEnterBtn.UseVisualStyleBackColor = true;
            this.AuthEnterBtn.Click += new System.EventHandler(this.AuthEnterBtn_Click);
            // 
            // AuthCnlBtn
            // 
            this.AuthCnlBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AuthCnlBtn.Location = new System.Drawing.Point(158, 138);
            this.AuthCnlBtn.Name = "AuthCnlBtn";
            this.AuthCnlBtn.Size = new System.Drawing.Size(130, 47);
            this.AuthCnlBtn.TabIndex = 5;
            this.AuthCnlBtn.Text = "Выход";
            this.AuthCnlBtn.UseVisualStyleBackColor = true;
            this.AuthCnlBtn.Click += new System.EventHandler(this.AuthCnlBtn_Click);
            // 
            // AuthLinkLabel
            // 
            this.AuthLinkLabel.AutoSize = true;
            this.AuthLinkLabel.LinkColor = System.Drawing.Color.DarkGray;
            this.AuthLinkLabel.Location = new System.Drawing.Point(69, 199);
            this.AuthLinkLabel.Name = "AuthLinkLabel";
            this.AuthLinkLabel.Size = new System.Drawing.Size(164, 13);
            this.AuthLinkLabel.TabIndex = 6;
            this.AuthLinkLabel.TabStop = true;
            this.AuthLinkLabel.Text = "Параметры подключения к БД";
            this.AuthLinkLabel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.AuthLinkLabel_MouseClick);
            // 
            // Authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 226);
            this.ControlBox = false;
            this.Controls.Add(this.AuthLinkLabel);
            this.Controls.Add(this.AuthCnlBtn);
            this.Controls.Add(this.AuthEnterBtn);
            this.Controls.Add(this.AuthPasswordTextBox);
            this.Controls.Add(this.AuthUserIDTextBox);
            this.Controls.Add(this.AuthPasswordLabel);
            this.Controls.Add(this.AuthLoginLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Authorization";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AuthLoginLabel;
        private System.Windows.Forms.Label AuthPasswordLabel;
        private System.Windows.Forms.TextBox AuthUserIDTextBox;
        private System.Windows.Forms.TextBox AuthPasswordTextBox;
        private System.Windows.Forms.Button AuthEnterBtn;
        private System.Windows.Forms.Button AuthCnlBtn;
        private System.Windows.Forms.LinkLabel AuthLinkLabel;
    }
}