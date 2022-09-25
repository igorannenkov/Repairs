namespace PostgresTest
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GridView = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.справочникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.моделиБанкоматовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.банкоматыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.устройстваToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.инженерыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.регионыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ремонтыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.запросыИОтчетыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.всеРемонтыToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.ремонтыЗаПериодToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ремонтыПоИнженерамToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ремонтыПоУстройствамToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ремонтыПоКатегориямToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.генераторОтчетовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сервисToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.параметрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.проверкаСоединенияСБДToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GridView
            // 
            this.GridView.AllowUserToAddRows = false;
            this.GridView.AllowUserToDeleteRows = false;
            this.GridView.AllowUserToResizeColumns = false;
            this.GridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.GridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.GridView.Location = new System.Drawing.Point(12, 27);
            this.GridView.Name = "GridView";
            this.GridView.ReadOnly = true;
            this.GridView.Size = new System.Drawing.Size(776, 488);
            this.GridView.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справочникиToolStripMenuItem,
            this.запросыИОтчетыToolStripMenuItem,
            this.сервисToolStripMenuItem,
            this.вExcelToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // справочникиToolStripMenuItem
            // 
            this.справочникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.моделиБанкоматовToolStripMenuItem,
            this.банкоматыToolStripMenuItem,
            this.устройстваToolStripMenuItem,
            this.инженерыToolStripMenuItem,
            this.регионыToolStripMenuItem,
            this.ремонтыToolStripMenuItem});
            this.справочникиToolStripMenuItem.Name = "справочникиToolStripMenuItem";
            this.справочникиToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.справочникиToolStripMenuItem.Text = "Справочники";
            // 
            // моделиБанкоматовToolStripMenuItem
            // 
            this.моделиБанкоматовToolStripMenuItem.Name = "моделиБанкоматовToolStripMenuItem";
            this.моделиБанкоматовToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.моделиБанкоматовToolStripMenuItem.Text = "Модели устр. самообсл.";
            this.моделиБанкоматовToolStripMenuItem.Click += new System.EventHandler(this.моделиБанкоматовToolStripMenuItem_Click);
            // 
            // банкоматыToolStripMenuItem
            // 
            this.банкоматыToolStripMenuItem.Name = "банкоматыToolStripMenuItem";
            this.банкоматыToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.банкоматыToolStripMenuItem.Text = "Устройства самообсл.";
            this.банкоматыToolStripMenuItem.Click += new System.EventHandler(this.банкоматыToolStripMenuItem_Click);
            // 
            // устройстваToolStripMenuItem
            // 
            this.устройстваToolStripMenuItem.Name = "устройстваToolStripMenuItem";
            this.устройстваToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.устройстваToolStripMenuItem.Text = "Категории ремонта";
            this.устройстваToolStripMenuItem.Click += new System.EventHandler(this.устройстваToolStripMenuItem_Click);
            // 
            // инженерыToolStripMenuItem
            // 
            this.инженерыToolStripMenuItem.Name = "инженерыToolStripMenuItem";
            this.инженерыToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.инженерыToolStripMenuItem.Text = "Инженеры";
            this.инженерыToolStripMenuItem.Click += new System.EventHandler(this.инженерыToolStripMenuItem_Click);
            // 
            // регионыToolStripMenuItem
            // 
            this.регионыToolStripMenuItem.Name = "регионыToolStripMenuItem";
            this.регионыToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.регионыToolStripMenuItem.Text = "Регионы";
            this.регионыToolStripMenuItem.Click += new System.EventHandler(this.регионыToolStripMenuItem_Click);
            // 
            // ремонтыToolStripMenuItem
            // 
            this.ремонтыToolStripMenuItem.Name = "ремонтыToolStripMenuItem";
            this.ремонтыToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.ремонтыToolStripMenuItem.Text = "Ремонты";
            this.ремонтыToolStripMenuItem.Click += new System.EventHandler(this.ремонтыToolStripMenuItem_Click);
            // 
            // запросыИОтчетыToolStripMenuItem
            // 
            this.запросыИОтчетыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.всеРемонтыToolStripMenuItem2,
            this.ремонтыЗаПериодToolStripMenuItem,
            this.ремонтыПоИнженерамToolStripMenuItem,
            this.ремонтыПоУстройствамToolStripMenuItem,
            this.ремонтыПоКатегориямToolStripMenuItem,
            this.генераторОтчетовToolStripMenuItem});
            this.запросыИОтчетыToolStripMenuItem.Name = "запросыИОтчетыToolStripMenuItem";
            this.запросыИОтчетыToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.запросыИОтчетыToolStripMenuItem.Text = "Отчеты";
            // 
            // всеРемонтыToolStripMenuItem2
            // 
            this.всеРемонтыToolStripMenuItem2.Name = "всеРемонтыToolStripMenuItem2";
            this.всеРемонтыToolStripMenuItem2.Size = new System.Drawing.Size(214, 22);
            this.всеРемонтыToolStripMenuItem2.Text = "Все ремонты подробно";
            this.всеРемонтыToolStripMenuItem2.Click += new System.EventHandler(this.всеРемонтыToolStripMenuItem2_Click);
            // 
            // ремонтыЗаПериодToolStripMenuItem
            // 
            this.ремонтыЗаПериодToolStripMenuItem.Name = "ремонтыЗаПериодToolStripMenuItem";
            this.ремонтыЗаПериодToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.ремонтыЗаПериодToolStripMenuItem.Text = "Все ремонты за период";
            // 
            // ремонтыПоИнженерамToolStripMenuItem
            // 
            this.ремонтыПоИнженерамToolStripMenuItem.Name = "ремонтыПоИнженерамToolStripMenuItem";
            this.ремонтыПоИнженерамToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.ремонтыПоИнженерамToolStripMenuItem.Text = "Ремонты по инженерам";
            // 
            // ремонтыПоУстройствамToolStripMenuItem
            // 
            this.ремонтыПоУстройствамToolStripMenuItem.Name = "ремонтыПоУстройствамToolStripMenuItem";
            this.ремонтыПоУстройствамToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.ремонтыПоУстройствамToolStripMenuItem.Text = "Ремонты по устройствам";
            // 
            // ремонтыПоКатегориямToolStripMenuItem
            // 
            this.ремонтыПоКатегориямToolStripMenuItem.Name = "ремонтыПоКатегориямToolStripMenuItem";
            this.ремонтыПоКатегориямToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.ремонтыПоКатегориямToolStripMenuItem.Text = "Ремонты по категориям";
            // 
            // генераторОтчетовToolStripMenuItem
            // 
            this.генераторОтчетовToolStripMenuItem.Name = "генераторОтчетовToolStripMenuItem";
            this.генераторОтчетовToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.генераторОтчетовToolStripMenuItem.Text = "Генератор отчетов";
            this.генераторОтчетовToolStripMenuItem.Click += new System.EventHandler(this.генераторОтчетовToolStripMenuItem_Click);
            // 
            // сервисToolStripMenuItem
            // 
            this.сервисToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.параметрыToolStripMenuItem,
            this.проверкаСоединенияСБДToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.сервисToolStripMenuItem.Name = "сервисToolStripMenuItem";
            this.сервисToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.сервисToolStripMenuItem.Text = "Сервис";
            // 
            // параметрыToolStripMenuItem
            // 
            this.параметрыToolStripMenuItem.Name = "параметрыToolStripMenuItem";
            this.параметрыToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.параметрыToolStripMenuItem.Text = "Параметры";
            this.параметрыToolStripMenuItem.Click += new System.EventHandler(this.параметрыToolStripMenuItem_Click);
            // 
            // проверкаСоединенияСБДToolStripMenuItem
            // 
            this.проверкаСоединенияСБДToolStripMenuItem.Name = "проверкаСоединенияСБДToolStripMenuItem";
            this.проверкаСоединенияСБДToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.проверкаСоединенияСБДToolStripMenuItem.Text = "Проверить соединение с БД";
            this.проверкаСоединенияСБДToolStripMenuItem.Click += new System.EventHandler(this.проверкаСоединенияСБДToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            // 
            // вExcelToolStripMenuItem
            // 
            this.вExcelToolStripMenuItem.Name = "вExcelToolStripMenuItem";
            this.вExcelToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.вExcelToolStripMenuItem.Text = "Экспорт в Excel";
            this.вExcelToolStripMenuItem.Click += new System.EventHandler(this.вExcelToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 527);
            this.Controls.Add(this.GridView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ремонты банкоматов";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView GridView;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem справочникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem устройстваToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem банкоматыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem инженерыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem запросыИОтчетыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem регионыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem моделиБанкоматовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сервисToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem параметрыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem всеРемонтыToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem ремонтыЗаПериодToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ремонтыПоИнженерамToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ремонтыПоУстройствамToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ремонтыПоКатегориямToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem генераторОтчетовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вExcelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ремонтыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem проверкаСоединенияСБДToolStripMenuItem;
    }
}

