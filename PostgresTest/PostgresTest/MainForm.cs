using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using PostgresTest.Queries_forms;
using PostgresTest.Repairs;
using Microsoft.Office.Interop.Excel;
using System.Configuration;


namespace PostgresTest
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public static void TestConnection()
        {
            using (NpgsqlConnection connection = Database.GetConnection())
            {
                connection.Open();
                if (connection.State == ConnectionState.Open)
                {
                    MessageBox.Show("Соединение установлено!");
                }
                else MessageBox.Show("Неудачно.");
            }
        }

        private void моделиБанкоматовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ATMModels atmmodelsForm = new ATMModels();
            atmmodelsForm.ShowDialog();
        }

        private void устройстваToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Categories devicesForm = new Categories();
            devicesForm.ShowDialog();
        }

        private void банкоматыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ATMs atmsForm = new ATMs();
            atmsForm.Owner = this;
            atmsForm.ShowDialog();
        }

        private void инженерыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Engineers engineersForm = new Engineers();
            engineersForm.Owner = this;
            engineersForm.ShowDialog();
        }

        private void регионыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Regions regionsForm = new Regions();
            regionsForm.Owner = this;
            regionsForm.ShowDialog();
        }

        private void всеРемонтыToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            using (NpgsqlConnection connection = Database.GetConnection())
            {
                connection.Open();
                string query = "SELECT \"Repairs\".\"ATMID\" AS \"Устройство\", " +
                                "\"ATMs\".\"Region\" AS \"Принадлежность\"," +
                                "\"ATMs\".\"Address\" AS \"Адрес установки\", " +
                                "\"ATMs\".\"Model\" AS \"Модель\"," +
                                "\"Repairs\".\"Engineer\" AS \"Инженер\"," +
                                "\"Repairs\".\"Category\" AS \"Категория\"," +
                                "\"Repairs\".\"Comment\" AS \"Комментарий\"," +
                                "\"Repairs\".\"Date\" AS \"Дата\" FROM \"Repairs\" " +
                                "INNER JOIN public.\"ATMs\" ON " +
                                "\"ATMs\".\"ATMID\" = \"Repairs\".\"ATMID\" " +
                                "ORDER BY \"Repairs\".\"ATMID\", \"Repairs\".\"Date\"";
                NpgsqlCommand cmd = new NpgsqlCommand(query, connection);
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                GridView.DataSource = ds.Tables[0];
            }
        }

        private void генераторОтчетовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QueryGen generator = new QueryGen();
            generator.Owner = this;
            generator.ShowDialog();
        }


        private void ремонтыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Repair repairsForm = new Repair();
            repairsForm.Owner = this;
            repairsForm.ShowDialog();
        }

        private void вExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _Application app = new Microsoft.Office.Interop.Excel.Application();
            _Workbook workbook = app.Workbooks.Add(Type.Missing);
            _Worksheet worksheet = null;
            app.Visible = true;
            worksheet = workbook.Sheets["Лист1"];
            worksheet = workbook.ActiveSheet;

            // Устанавливаем текстовый формат ячеек.
            Range cells = workbook.Worksheets[1].Cells;
            cells.NumberFormat = "@";

            // Вынужденная мера. Удаляем вхождение 0:00:00 в датах, пока не разобрался.
            char[] toTrim = { '0',':','0','0',':','0','0' };

            for (int i = 1; i < GridView.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = GridView.Columns[i - 1].HeaderText;
                app.ActiveCell.EntireRow.Font.Bold = true;
            }
            for (int i = 0; i < GridView.Rows.Count; i++)// GridView.Rows.Count-1 было неверно.
            {
                for (int j = 0; j < GridView.Columns.Count; j++)
                {
                    if (GridView.Rows[i].Cells[j].Value != null)
                    {
                        worksheet.Cells[i + 2, j + 1] = GridView.Rows[i].Cells[j].Value.ToString().Replace("0:00:00", ""); //TrimEnd(toTrim);
                    }
                    else
                    {
                        worksheet.Cells[i + 2, j + 1] = "";
                    }
                }
            }
            app.Columns.AutoFit();
        }

        private void проверкаСоединенияСБДToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TestConnection();
        }

        private void параметрыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.Owner = this;
            settingsForm.ShowDialog();
        }
    }
}
