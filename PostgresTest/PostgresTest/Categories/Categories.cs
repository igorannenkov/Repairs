using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;

namespace PostgresTest
{
    public partial class Categories : Form
    {
        public Categories()
        {
            InitializeComponent();
            using (NpgsqlConnection connection = Database.GetConnection())
            {
                connection.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("SELECT \"CategoryName\" AS \"Категория\" FROM \"Categories\" ORDER BY \"CategoryName\"", connection);
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                CategoriesGridView.DataSource = ds.Tables[0];
            }
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCategory addDeviceForm = new AddCategory();
            addDeviceForm.Owner = this;
            addDeviceForm.ShowDialog();
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (NpgsqlConnection connection = Database.GetConnection())
                {
                    connection.Open();
                    string toDelete = CategoriesGridView.CurrentCell.Value.ToString();

                    NpgsqlCommand cmd = new NpgsqlCommand("DELETE FROM \"Categories\" WHERE \"CategoryName\"=\'" + toDelete + "\'", connection);
                    cmd.ExecuteNonQuery();

                    cmd = new NpgsqlCommand("SELECT \"CategoryName\" AS \"Категория\" FROM \"Categories\" ORDER BY \"CategoryName\"", connection);
                    NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    CategoriesGridView.DataSource = ds.Tables[0];
                }
            }
            catch (NpgsqlException ex)
            {
                if (ex.Message.Contains("23503"))
                {
                    MessageBox.Show("Удаление данных невозможно, т.к. по текущей категории в базе зарегистрированы работы.", 
                                    "Ограничение ссылочной целостности данных", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show(ex.Message, "Ошибка базы данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void DevicesGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                try
                {
                    using (NpgsqlConnection connection = Database.GetConnection())
                    {
                        connection.Open();
                        string toDelete = CategoriesGridView.CurrentCell.Value.ToString();


                        NpgsqlCommand cmd = new NpgsqlCommand("DELETE FROM \"Categories\" WHERE \"CategoryName\"=\'" + toDelete + "\'", connection);
                        cmd.ExecuteNonQuery();

                        cmd = new NpgsqlCommand("SELECT \"CategoryName\" AS \"Категория\" FROM \"Categories\" ORDER BY \"CategoryName\"", connection);
                        NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd);
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);
                        CategoriesGridView.DataSource = ds.Tables[0];
                    }
                }
                catch (NpgsqlException ex)
                {
                    if (ex.Message.Contains("23503"))
                    {
                        MessageBox.Show("Удаление данных невозможно, т.к. по текущей категории в базе зарегистрированы работы.", 
                                        "Ограничение ссылочной целостности данных", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show(ex.Message, "Ошибка базы данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void DevicesGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            UpdateCategory updDeviceForm = new UpdateCategory();
            updDeviceForm.Owner = this;
            string prevDevName = CategoriesGridView.CurrentCell.Value.ToString();
            (updDeviceForm.Controls["UpdCatTextBox"] as TextBox).Text = prevDevName;
            updDeviceForm.Tag = prevDevName;
            updDeviceForm.ShowDialog();
        }

        private void выгрузитьВExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExcelReporter.GetReport(CategoriesGridView);
        }
    }
}
