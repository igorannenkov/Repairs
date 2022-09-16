namespace PostgresTest
{
    partial class ATMModels
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
            this.ATMModelGridView = new System.Windows.Forms.DataGridView();
            this.ATMModelContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ATMModelMenuStrip = new System.Windows.Forms.MenuStrip();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.ATMModelGridView)).BeginInit();
            this.ATMModelContextMenuStrip.SuspendLayout();
            this.ATMModelMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // ATMModelGridView
            // 
            this.ATMModelGridView.AllowUserToAddRows = false;
            this.ATMModelGridView.AllowUserToDeleteRows = false;
            this.ATMModelGridView.AllowUserToResizeColumns = false;
            this.ATMModelGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ATMModelGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ATMModelGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ATMModelGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ATMModelGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ATMModelGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ATMModelGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ATMModelGridView.ContextMenuStrip = this.ATMModelContextMenuStrip;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ATMModelGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.ATMModelGridView.Location = new System.Drawing.Point(10, 30);
            this.ATMModelGridView.Name = "ATMModelGridView";
            this.ATMModelGridView.ReadOnly = true;
            this.ATMModelGridView.Size = new System.Drawing.Size(600, 400);
            this.ATMModelGridView.TabIndex = 0;
            this.ATMModelGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ATMModelGridView_CellMouseDoubleClick);
            this.ATMModelGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ATMModelGridView_KeyDown);
            // 
            // ATMModelContextMenuStrip
            // 
            this.ATMModelContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.удалитьToolStripMenuItem});
            this.ATMModelContextMenuStrip.Name = "ATMModelContextMenuStrip";
            this.ATMModelContextMenuStrip.Size = new System.Drawing.Size(119, 26);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // ATMModelMenuStrip
            // 
            this.ATMModelMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem});
            this.ATMModelMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.ATMModelMenuStrip.Name = "ATMModelMenuStrip";
            this.ATMModelMenuStrip.Size = new System.Drawing.Size(624, 24);
            this.ATMModelMenuStrip.TabIndex = 2;
            this.ATMModelMenuStrip.Text = "menuStrip1";
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.добавитьToolStripMenuItem_Click);
            // 
            // ATMModels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.ATMModelMenuStrip);
            this.Controls.Add(this.ATMModelGridView);
            this.MainMenuStrip = this.ATMModelMenuStrip;
            this.Name = "ATMModels";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Модели УС";
            ((System.ComponentModel.ISupportInitialize)(this.ATMModelGridView)).EndInit();
            this.ATMModelContextMenuStrip.ResumeLayout(false);
            this.ATMModelMenuStrip.ResumeLayout(false);
            this.ATMModelMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ATMModelGridView;
        private System.Windows.Forms.ContextMenuStrip ATMModelContextMenuStrip;
        private System.Windows.Forms.MenuStrip ATMModelMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
    }
}