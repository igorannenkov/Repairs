using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;

namespace PostgresTest
{
    public partial class Regions : Form
    {
        public Regions()
        {
            InitializeComponent();
            using (NpgsqlConnection connection = Database.GetConnection())
            {
                connection.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("SELECT \"RegionName\" AS \"Регион\" FROM \"Regions\" ORDER BY \"RegionName\"", connection);
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                RegionsDataGridView.DataSource = ds.Tables[0];
            }
        }

        private void добавитьToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            AddRegion addRegionForm = new AddRegion();
            addRegionForm.Owner = this;
            addRegionForm.ShowDialog();
        }

        private void удалитьToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            try
            {
                using (NpgsqlConnection connection = Database.GetConnection())
                {
                    connection.Open();
                    string toDelete = RegionsDataGridView.CurrentCell.Value.ToString();
                    NpgsqlCommand cmd = new NpgsqlCommand("DELETE FROM \"Regions\" WHERE \"RegionName\"=\'" + toDelete + "\'", connection);
                    cmd.ExecuteNonQuery();
                    cmd = new NpgsqlCommand("SELECT \"RegionName\" AS \"Регион\" FROM \"Regions\" ORDER BY \"RegionName\"", connection);
                    NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    RegionsDataGridView.DataSource = ds.Tables[0];
                }
            }
            catch (NpgsqlException ex)
            {
                if (ex.Message.Contains("23503"))
                {
                    MessageBox.Show("Удаление данных невозможно, т.к. по данному региону в базе зарегистрированы работы.", "Ограничение ссылочной целостности данных", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show(ex.Message, "Ошибка базы данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void RegionsDataGridView_CellMouseDoubleClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            UpdateRegion updRegionForm = new UpdateRegion();
            updRegionForm.Owner = this;
            string prevRegionName = RegionsDataGridView.CurrentCell.Value.ToString();
            (updRegionForm.Controls["UpdateRegionTextBox"] as TextBox).Text = prevRegionName;
            updRegionForm.Tag = prevRegionName;
            updRegionForm.ShowDialog();
        }



        private void RegionsDataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                try
                {
                    using (NpgsqlConnection connection = Database.GetConnection())
                    {
                        connection.Open();
                        string toDelete = RegionsDataGridView.CurrentCell.Value.ToString();
                        NpgsqlCommand cmd = new NpgsqlCommand("DELETE FROM \"Regions\" WHERE \"RegionName\"=\'" + toDelete + "\'", connection);
                        cmd.ExecuteNonQuery();
                        cmd = new NpgsqlCommand("SELECT \"RegionName\" AS \"Регион\" FROM \"Regions\" ORDER BY \"RegionName\"", connection);
                        NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd);
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);
                        RegionsDataGridView.DataSource = ds.Tables[0];
                    }
                }
                catch (NpgsqlException ex)
                {
                    if (ex.Message.Contains("23503"))
                    {
                        MessageBox.Show("Удаление данных невозможно, т.к. по данному региону в базе зарегистрированы работы.", "Ограничение ссылочной целостности данных", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show(ex.Message, "Ошибка базы данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}