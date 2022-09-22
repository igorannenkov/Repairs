namespace PostgresTest
{
    partial class Engineers
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.EngineersGridView = new System.Windows.Forms.DataGridView();
            this.engineersContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.engineersMenuStrip = new System.Windows.Forms.MenuStrip();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.EngineersGridView)).BeginInit();
            this.engineersContextMenuStrip.SuspendLayout();
            this.engineersMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // EngineersGridView
            // 
            this.EngineersGridView.AllowUserToAddRows = false;
            this.EngineersGridView.AllowUserToDeleteRows = false;
            this.EngineersGridView.AllowUserToResizeColumns = false;
            this.EngineersGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EngineersGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.EngineersGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EngineersGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.EngineersGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.EngineersGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.EngineersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EngineersGridView.ContextMenuStrip = this.engineersContextMenuStrip;
            this.EngineersGridView.Location = new System.Drawing.Point(10, 30);
            this.EngineersGridView.Name = "EngineersGridView";
            this.EngineersGridView.ReadOnly = true;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EngineersGridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.EngineersGridView.Size = new System.Drawing.Size(332, 400);
            this.EngineersGridView.TabIndex = 0;
            this.EngineersGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.EgineersGridView_CellMouseDoubleClick);
            this.EngineersGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EngineersGridView_KeyDown);
            // 
            // engineersContextMenuStrip
            // 
            this.engineersContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.удалитьToolStripMenuItem});
            this.engineersContextMenuStrip.Name = "engineersContextMenuStrip";
            this.engineersContextMenuStrip.Size = new System.Drawing.Size(119, 26);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // engineersMenuStrip
            // 
            this.engineersMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem});
            this.engineersMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.engineersMenuStrip.Name = "engineersMenuStrip";
            this.engineersMenuStrip.Size = new System.Drawing.Size(354, 24);
            this.engineersMenuStrip.TabIndex = 1;
            this.engineersMenuStrip.Text = "menuStrip1";
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.добавитьToolStripMenuItem_Click);
            // 
            // Engineers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 441);
            this.Controls.Add(this.EngineersGridView);
            this.Controls.Add(this.engineersMenuStrip);
            this.MainMenuStrip = this.engineersMenuStrip;
            this.Name = "Engineers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Инженеры";
            ((System.ComponentModel.ISupportInitialize)(this.EngineersGridView)).EndInit();
            this.engineersContextMenuStrip.ResumeLayout(false);
            this.engineersMenuStrip.ResumeLayout(false);
            this.engineersMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView EngineersGridView;
        private System.Windows.Forms.MenuStrip engineersMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip engineersContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
    }
}