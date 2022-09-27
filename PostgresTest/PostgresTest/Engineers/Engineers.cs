using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;

namespace PostgresTest
{
    public partial class Engineers : Form
    {
        public Engineers()
        {
            InitializeComponent();
            using (NpgsqlConnection connection = Database.GetConnection())
            {
                connection.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("SELECT \"EngineerName\" AS \"Инженер\" FROM \"Engineers\" ORDER BY \"EngineerName\"", connection);
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                EngineersGridView.DataSource = ds.Tables[0];
            }

        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddEngineer addEngineerForm = new AddEngineer();
            addEngineerForm.Owner = this;
            addEngineerForm.ShowDialog();
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (NpgsqlConnection connection = Database.GetConnection())
                {
                    connection.Open();
                    string toDelete = EngineersGridView.CurrentCell.Value.ToString();


                    NpgsqlCommand cmd = new NpgsqlCommand("DELETE FROM \"Engineers\" WHERE \"EngineerName\"=\'" + toDelete + "\'", connection);
                    cmd.ExecuteNonQuery();

                    cmd = new NpgsqlCommand("SELECT \"EngineerName\" AS \"Инженер\" FROM \"Engineers\" ORDER BY \"EngineerName\"", connection);
                    NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    EngineersGridView.DataSource = ds.Tables[0];
                }
            }
            catch (NpgsqlException ex)
            {
                if (ex.Message.Contains("23503"))
                {
                    MessageBox.Show("Удаление данных невозможно, т.к. текущий инженер задействован в работах.", "Ограничение ссылочной целостности данных", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show(ex.Message, "Ошибка базы данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void EgineersGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            UpdateEngineer updEngineerForm = new UpdateEngineer();
            updEngineerForm.Owner = this;
            string prevEngName = EngineersGridView.CurrentCell.Value.ToString();
            (updEngineerForm.Controls["UpdateEngineerTextBox"] as TextBox).Text = prevEngName;
            updEngineerForm.Tag = prevEngName;
            updEngineerForm.ShowDialog();
        }

        private void EngineersGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                try
                {
                    using (NpgsqlConnection connection = Database.GetConnection())
                    {
                        connection.Open();
                        string toDelete = EngineersGridView.CurrentCell.Value.ToString();


                        NpgsqlCommand cmd = new NpgsqlCommand("DELETE FROM \"Engineers\" WHERE \"EngineerName\"=\'" + toDelete + "\'", connection);
                        cmd.ExecuteNonQuery();

                        cmd = new NpgsqlCommand("SELECT \"EngineerName\" AS \"Инженер\" FROM \"Engineers\" ORDER BY \"EngineerName\"", connection);
                        NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd);
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);
                        EngineersGridView.DataSource = ds.Tables[0];
                    }
                }
                catch (NpgsqlException ex)
                {
                    if (ex.Message.Contains("23503"))
                    {
                        MessageBox.Show("Удаление данных невозможно, т.к. текущий инженер задействован в работах.", "Ограничение ссылочной целостности данных", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
