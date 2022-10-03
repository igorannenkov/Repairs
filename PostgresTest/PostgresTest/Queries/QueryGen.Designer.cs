namespace PostgresTest.Queries_forms
{
    partial class QueryGen
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
            this.PeriodFromLabel = new System.Windows.Forms.Label();
            this.PeriodToLabel = new System.Windows.Forms.Label();
            this.GenFromDTPicker = new System.Windows.Forms.DateTimePicker();
            this.GenToDTPicker = new System.Windows.Forms.DateTimePicker();
            this.GenShowBtn = new System.Windows.Forms.Button();
            this.GenCnlBtn = new System.Windows.Forms.Button();
            this.GenPeriodGroupBox = new System.Windows.Forms.GroupBox();
            this.GenATMIDComboBox = new System.Windows.Forms.ComboBox();
            this.GenCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.GenEngineerComboBox = new System.Windows.Forms.ComboBox();
            this.GenCommentTextBox = new System.Windows.Forms.TextBox();
            this.GenRegionComboBox = new System.Windows.Forms.ComboBox();
            this.GenAddressTextBox = new System.Windows.Forms.TextBox();
            this.GenModelComboBox = new System.Windows.Forms.ComboBox();
            this.GenATMIDCheckBox = new System.Windows.Forms.CheckBox();
            this.GenRegionCheckBox = new System.Windows.Forms.CheckBox();
            this.GenAddressCheckBox = new System.Windows.Forms.CheckBox();
            this.GenModelCheckBox = new System.Windows.Forms.CheckBox();
            this.GenEngineerCheckBox = new System.Windows.Forms.CheckBox();
            this.GenCategoryCheckBox = new System.Windows.Forms.CheckBox();
            this.GenCommentCheckBox = new System.Windows.Forms.CheckBox();
            this.GenPeriodCheckBox = new System.Windows.Forms.CheckBox();
            this.GenPeriodGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // PeriodFromLabel
            // 
            this.PeriodFromLabel.AutoSize = true;
            this.PeriodFromLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PeriodFromLabel.Location = new System.Drawing.Point(6, 14);
            this.PeriodFromLabel.Name = "PeriodFromLabel";
            this.PeriodFromLabel.Size = new System.Drawing.Size(116, 16);
            this.PeriodFromLabel.TabIndex = 0;
            this.PeriodFromLabel.Text = "Начало периода";
            // 
            // PeriodToLabel
            // 
            this.PeriodToLabel.AutoSize = true;
            this.PeriodToLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PeriodToLabel.Location = new System.Drawing.Point(6, 60);
            this.PeriodToLabel.Name = "PeriodToLabel";
            this.PeriodToLabel.Size = new System.Drawing.Size(106, 16);
            this.PeriodToLabel.TabIndex = 1;
            this.PeriodToLabel.Text = "Конец периода";
            // 
            // GenFromDTPicker
            // 
            this.GenFromDTPicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GenFromDTPicker.Location = new System.Drawing.Point(6, 32);
            this.GenFromDTPicker.Name = "GenFromDTPicker";
            this.GenFromDTPicker.Size = new System.Drawing.Size(313, 26);
            this.GenFromDTPicker.TabIndex = 2;
            // 
            // GenToDTPicker
            // 
            this.GenToDTPicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GenToDTPicker.Location = new System.Drawing.Point(6, 78);
            this.GenToDTPicker.Name = "GenToDTPicker";
            this.GenToDTPicker.Size = new System.Drawing.Size(313, 26);
            this.GenToDTPicker.TabIndex = 3;
            // 
            // GenShowBtn
            // 
            this.GenShowBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GenShowBtn.Location = new System.Drawing.Point(117, 383);
            this.GenShowBtn.Name = "GenShowBtn";
            this.GenShowBtn.Size = new System.Drawing.Size(135, 40);
            this.GenShowBtn.TabIndex = 4;
            this.GenShowBtn.Text = "Показать";
            this.GenShowBtn.UseVisualStyleBackColor = true;
            this.GenShowBtn.Click += new System.EventHandler(this.GenShowBtn_Click);
            // 
            // GenCnlBtn
            // 
            this.GenCnlBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GenCnlBtn.Location = new System.Drawing.Point(262, 383);
            this.GenCnlBtn.Name = "GenCnlBtn";
            this.GenCnlBtn.Size = new System.Drawing.Size(135, 40);
            this.GenCnlBtn.TabIndex = 5;
            this.GenCnlBtn.Text = "Отмена";
            this.GenCnlBtn.UseVisualStyleBackColor = true;
            this.GenCnlBtn.Click += new System.EventHandler(this.GenCnlBtn_Click);
            // 
            // GenPeriodGroupBox
            // 
            this.GenPeriodGroupBox.Controls.Add(this.PeriodToLabel);
            this.GenPeriodGroupBox.Controls.Add(this.PeriodFromLabel);
            this.GenPeriodGroupBox.Controls.Add(this.GenToDTPicker);
            this.GenPeriodGroupBox.Controls.Add(this.GenFromDTPicker);
            this.GenPeriodGroupBox.Enabled = false;
            this.GenPeriodGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GenPeriodGroupBox.Location = new System.Drawing.Point(193, 256);
            this.GenPeriodGroupBox.Name = "GenPeriodGroupBox";
            this.GenPeriodGroupBox.Size = new System.Drawing.Size(325, 115);
            this.GenPeriodGroupBox.TabIndex = 6;
            this.GenPeriodGroupBox.TabStop = false;
            // 
            // GenATMIDComboBox
            // 
            this.GenATMIDComboBox.DropDownHeight = 300;
            this.GenATMIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GenATMIDComboBox.Enabled = false;
            this.GenATMIDComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GenATMIDComboBox.FormattingEnabled = true;
            this.GenATMIDComboBox.IntegralHeight = false;
            this.GenATMIDComboBox.Location = new System.Drawing.Point(193, 10);
            this.GenATMIDComboBox.Name = "GenATMIDComboBox";
            this.GenATMIDComboBox.Size = new System.Drawing.Size(325, 28);
            this.GenATMIDComboBox.TabIndex = 8;
            // 
            // GenCategoryComboBox
            // 
            this.GenCategoryComboBox.DropDownHeight = 300;
            this.GenCategoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GenCategoryComboBox.Enabled = false;
            this.GenCategoryComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GenCategoryComboBox.FormattingEnabled = true;
            this.GenCategoryComboBox.IntegralHeight = false;
            this.GenCategoryComboBox.Location = new System.Drawing.Point(193, 188);
            this.GenCategoryComboBox.Name = "GenCategoryComboBox";
            this.GenCategoryComboBox.Size = new System.Drawing.Size(325, 28);
            this.GenCategoryComboBox.TabIndex = 10;
            // 
            // GenEngineerComboBox
            // 
            this.GenEngineerComboBox.DropDownHeight = 300;
            this.GenEngineerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GenEngineerComboBox.Enabled = false;
            this.GenEngineerComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GenEngineerComboBox.FormattingEnabled = true;
            this.GenEngineerComboBox.IntegralHeight = false;
            this.GenEngineerComboBox.Location = new System.Drawing.Point(193, 152);
            this.GenEngineerComboBox.Name = "GenEngineerComboBox";
            this.GenEngineerComboBox.Size = new System.Drawing.Size(325, 28);
            this.GenEngineerComboBox.TabIndex = 12;
            // 
            // GenCommentTextBox
            // 
            this.GenCommentTextBox.Enabled = false;
            this.GenCommentTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GenCommentTextBox.Location = new System.Drawing.Point(193, 224);
            this.GenCommentTextBox.Name = "GenCommentTextBox";
            this.GenCommentTextBox.Size = new System.Drawing.Size(325, 26);
            this.GenCommentTextBox.TabIndex = 14;
            // 
            // GenRegionComboBox
            // 
            this.GenRegionComboBox.DropDownHeight = 300;
            this.GenRegionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GenRegionComboBox.Enabled = false;
            this.GenRegionComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GenRegionComboBox.FormattingEnabled = true;
            this.GenRegionComboBox.IntegralHeight = false;
            this.GenRegionComboBox.Location = new System.Drawing.Point(193, 46);
            this.GenRegionComboBox.Name = "GenRegionComboBox";
            this.GenRegionComboBox.Size = new System.Drawing.Size(325, 28);
            this.GenRegionComboBox.TabIndex = 16;
            // 
            // GenAddressTextBox
            // 
            this.GenAddressTextBox.Enabled = false;
            this.GenAddressTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GenAddressTextBox.Location = new System.Drawing.Point(193, 82);
            this.GenAddressTextBox.Name = "GenAddressTextBox";
            this.GenAddressTextBox.Size = new System.Drawing.Size(325, 26);
            this.GenAddressTextBox.TabIndex = 18;
            // 
            // GenModelComboBox
            // 
            this.GenModelComboBox.DropDownHeight = 300;
            this.GenModelComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GenModelComboBox.Enabled = false;
            this.GenModelComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GenModelComboBox.FormattingEnabled = true;
            this.GenModelComboBox.IntegralHeight = false;
            this.GenModelComboBox.Location = new System.Drawing.Point(193, 116);
            this.GenModelComboBox.Name = "GenModelComboBox";
            this.GenModelComboBox.Size = new System.Drawing.Size(325, 28);
            this.GenModelComboBox.TabIndex = 20;
            // 
            // GenATMIDCheckBox
            // 
            this.GenATMIDCheckBox.AutoSize = true;
            this.GenATMIDCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GenATMIDCheckBox.Location = new System.Drawing.Point(117, 12);
            this.GenATMIDCheckBox.Name = "GenATMIDCheckBox";
            this.GenATMIDCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GenATMIDCheckBox.Size = new System.Drawing.Size(70, 24);
            this.GenATMIDCheckBox.TabIndex = 21;
            this.GenATMIDCheckBox.Text = "ID УС";
            this.GenATMIDCheckBox.UseVisualStyleBackColor = true;
            this.GenATMIDCheckBox.CheckedChanged += new System.EventHandler(this.GenIDATMCheckBox_CheckedChanged);
            // 
            // GenRegionCheckBox
            // 
            this.GenRegionCheckBox.AutoSize = true;
            this.GenRegionCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GenRegionCheckBox.Location = new System.Drawing.Point(26, 47);
            this.GenRegionCheckBox.Name = "GenRegionCheckBox";
            this.GenRegionCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GenRegionCheckBox.Size = new System.Drawing.Size(161, 24);
            this.GenRegionCheckBox.TabIndex = 22;
            this.GenRegionCheckBox.Text = "Принадлежность";
            this.GenRegionCheckBox.UseVisualStyleBackColor = true;
            this.GenRegionCheckBox.CheckedChanged += new System.EventHandler(this.GenRegionCheckBox_CheckedChanged);
            // 
            // GenAddressCheckBox
            // 
            this.GenAddressCheckBox.AutoSize = true;
            this.GenAddressCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GenAddressCheckBox.Location = new System.Drawing.Point(30, 71);
            this.GenAddressCheckBox.Name = "GenAddressCheckBox";
            this.GenAddressCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GenAddressCheckBox.Size = new System.Drawing.Size(157, 44);
            this.GenAddressCheckBox.TabIndex = 23;
            this.GenAddressCheckBox.Text = "Адрес установки\r\nсодержит текст";
            this.GenAddressCheckBox.UseVisualStyleBackColor = true;
            this.GenAddressCheckBox.CheckedChanged += new System.EventHandler(this.GenAddressCheckBox_CheckedChanged);
            // 
            // GenModelCheckBox
            // 
            this.GenModelCheckBox.AutoSize = true;
            this.GenModelCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GenModelCheckBox.Location = new System.Drawing.Point(73, 117);
            this.GenModelCheckBox.Name = "GenModelCheckBox";
            this.GenModelCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GenModelCheckBox.Size = new System.Drawing.Size(114, 24);
            this.GenModelCheckBox.TabIndex = 24;
            this.GenModelCheckBox.Text = "Модель УС";
            this.GenModelCheckBox.UseVisualStyleBackColor = true;
            this.GenModelCheckBox.CheckedChanged += new System.EventHandler(this.GenModelCheckBox_CheckedChanged);
            // 
            // GenEngineerCheckBox
            // 
            this.GenEngineerCheckBox.AutoSize = true;
            this.GenEngineerCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GenEngineerCheckBox.Location = new System.Drawing.Point(92, 153);
            this.GenEngineerCheckBox.Name = "GenEngineerCheckBox";
            this.GenEngineerCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GenEngineerCheckBox.Size = new System.Drawing.Size(95, 24);
            this.GenEngineerCheckBox.TabIndex = 25;
            this.GenEngineerCheckBox.Text = "Инженер";
            this.GenEngineerCheckBox.UseVisualStyleBackColor = true;
            this.GenEngineerCheckBox.CheckedChanged += new System.EventHandler(this.GenEngineerCheckBox_CheckedChanged);
            // 
            // GenCategoryCheckBox
            // 
            this.GenCategoryCheckBox.AutoSize = true;
            this.GenCategoryCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GenCategoryCheckBox.Location = new System.Drawing.Point(30, 188);
            this.GenCategoryCheckBox.Name = "GenCategoryCheckBox";
            this.GenCategoryCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GenCategoryCheckBox.Size = new System.Drawing.Size(157, 24);
            this.GenCategoryCheckBox.TabIndex = 26;
            this.GenCategoryCheckBox.Text = "Категория работ";
            this.GenCategoryCheckBox.UseVisualStyleBackColor = true;
            this.GenCategoryCheckBox.CheckedChanged += new System.EventHandler(this.GenCategoryCheckBox_CheckedChanged);
            // 
            // GenCommentCheckBox
            // 
            this.GenCommentCheckBox.AutoSize = true;
            this.GenCommentCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GenCommentCheckBox.Location = new System.Drawing.Point(37, 216);
            this.GenCommentCheckBox.Name = "GenCommentCheckBox";
            this.GenCommentCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GenCommentCheckBox.Size = new System.Drawing.Size(150, 44);
            this.GenCommentCheckBox.TabIndex = 27;
            this.GenCommentCheckBox.Text = "Комментарий\r\nсодержит текст";
            this.GenCommentCheckBox.UseVisualStyleBackColor = true;
            this.GenCommentCheckBox.CheckedChanged += new System.EventHandler(this.GenCommentCheckBox_CheckedChanged);
            // 
            // GenPeriodCheckBox
            // 
            this.GenPeriodCheckBox.AutoSize = true;
            this.GenPeriodCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GenPeriodCheckBox.Location = new System.Drawing.Point(15, 268);
            this.GenPeriodCheckBox.Name = "GenPeriodCheckBox";
            this.GenPeriodCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GenPeriodCheckBox.Size = new System.Drawing.Size(172, 24);
            this.GenPeriodCheckBox.TabIndex = 28;
            this.GenPeriodCheckBox.Text = "Интервал времени";
            this.GenPeriodCheckBox.UseVisualStyleBackColor = true;
            this.GenPeriodCheckBox.CheckedChanged += new System.EventHandler(this.GenTimeIntervalCheckBox_CheckedChanged);
            // 
            // QueryGen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 436);
            this.Controls.Add(this.GenPeriodCheckBox);
            this.Controls.Add(this.GenCommentCheckBox);
            this.Controls.Add(this.GenCategoryCheckBox);
            this.Controls.Add(this.GenEngineerCheckBox);
            this.Controls.Add(this.GenModelCheckBox);
            this.Controls.Add(this.GenAddressCheckBox);
            this.Controls.Add(this.GenRegionCheckBox);
            this.Controls.Add(this.GenATMIDCheckBox);
            this.Controls.Add(this.GenModelComboBox);
            this.Controls.Add(this.GenAddressTextBox);
            this.Controls.Add(this.GenRegionComboBox);
            this.Controls.Add(this.GenCommentTextBox);
            this.Controls.Add(this.GenEngineerComboBox);
            this.Controls.Add(this.GenCategoryComboBox);
            this.Controls.Add(this.GenATMIDComboBox);
            this.Controls.Add(this.GenPeriodGroupBox);
            this.Controls.Add(this.GenCnlBtn);
            this.Controls.Add(this.GenShowBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "QueryGen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Генератор отчетов";
            this.GenPeriodGroupBox.ResumeLayout(false);
            this.GenPeriodGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PeriodFromLabel;
        private System.Windows.Forms.Label PeriodToLabel;
        private System.Windows.Forms.DateTimePicker GenFromDTPicker;
        private System.Windows.Forms.DateTimePicker GenToDTPicker;
        private System.Windows.Forms.Button GenShowBtn;
        private System.Windows.Forms.Button GenCnlBtn;
        private System.Windows.Forms.GroupBox GenPeriodGroupBox;
        private System.Windows.Forms.ComboBox GenATMIDComboBox;
        private System.Windows.Forms.ComboBox GenCategoryComboBox;
        private System.Windows.Forms.ComboBox GenEngineerComboBox;
        private System.Windows.Forms.TextBox GenCommentTextBox;
        private System.Windows.Forms.ComboBox GenRegionComboBox;
        private System.Windows.Forms.TextBox GenAddressTextBox;
        private System.Windows.Forms.ComboBox GenModelComboBox;
        private System.Windows.Forms.CheckBox GenATMIDCheckBox;
        private System.Windows.Forms.CheckBox GenRegionCheckBox;
        private System.Windows.Forms.CheckBox GenAddressCheckBox;
        private System.Windows.Forms.CheckBox GenModelCheckBox;
        private System.Windows.Forms.CheckBox GenEngineerCheckBox;
        private System.Windows.Forms.CheckBox GenCategoryCheckBox;
        private System.Windows.Forms.CheckBox GenCommentCheckBox;
        private System.Windows.Forms.CheckBox GenPeriodCheckBox;
    }
}