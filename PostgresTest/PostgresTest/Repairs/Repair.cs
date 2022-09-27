using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;

namespace PostgresTest.Repairs
{
    public partial class Repair : Form
    {
        public Repair()
        {
            InitializeComponent();
            using (NpgsqlConnection connection = Database.GetConnection())
            {
                connection.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("SELECT \"RepairID\" AS \"ID\", \"ATMID\" AS \"ID УС\", \"Category\" AS \"Категория\", \"Engineer\" AS \"Инженер\", \"Date\" AS \"Дата\", COALESCE(\"Comment\", 'н/д') AS \"Комментарий\" FROM \"Repairs\" ORDER BY \"RepairID\"", connection);
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                RepairGridView.DataSource = ds.Tables[0];
            }
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddRepair addRepairForm = new AddRepair();
            addRepairForm.Owner = this;
            addRepairForm.ShowDialog();
        }

        private void RepairGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            UpdateRepair updRepairForm = new UpdateRepair();
            updRepairForm = new UpdateRepair();
            updRepairForm.Owner = this;

            using (NpgsqlConnection connection = Database.GetConnection())
            {
                connection.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("SELECT \"ATMID\" FROM \"ATMs\" AS \"ID УС\" ORDER BY \"ATMID\"", connection);
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                (updRepairForm.Controls["UpdRepIDAtmComboBox"] as ComboBox).ValueMember = "ATMID";
                (updRepairForm.Controls["UpdRepIDAtmComboBox"] as ComboBox).DataSource = ds.Tables[0];

                cmd = new NpgsqlCommand("SELECT \"CategoryName\" FROM \"Categories\" AS \"Категория\" ORDER BY \"CategoryName\"", connection);
                adapter = new NpgsqlDataAdapter(cmd);
                ds = new DataSet();
                adapter.Fill(ds);
                (updRepairForm.Controls["UpdRepCatComboBox"] as ComboBox).ValueMember = "CategoryName";
                (updRepairForm.Controls["UpdRepCatComboBox"] as ComboBox).DataSource = ds.Tables[0];

                cmd = new NpgsqlCommand("SELECT \"EngineerName\" FROM \"Engineers\" AS \"Инженер\" ORDER BY \"EngineerName\"", connection);
                adapter = new NpgsqlDataAdapter(cmd);
                ds = new DataSet();
                adapter.Fill(ds);
                (updRepairForm.Controls["UpdRepEngComboBox"] as ComboBox).ValueMember = "EngineerName";
                (updRepairForm.Controls["UpdRepEngComboBox"] as ComboBox).DataSource = ds.Tables[0];
            }
            (updRepairForm.Controls["UpdRepIDAtmComboBox"] as ComboBox).Text = RepairGridView.CurrentRow.Cells[0].Value.ToString();
            (updRepairForm.Controls["UpdRepIDAtmComboBox"] as ComboBox).Text = RepairGridView.CurrentRow.Cells[1].Value.ToString();
            (updRepairForm.Controls["UpdRepCatComboBox"] as ComboBox).Text = RepairGridView.CurrentRow.Cells[2].Value.ToString();
            (updRepairForm.Controls["UpdRepEngComboBox"] as ComboBox).Text = RepairGridView.CurrentRow.Cells[3].Value.ToString();
            (updRepairForm.Controls["UpdRepairDTPicker"] as DateTimePicker).Text = RepairGridView.CurrentRow.Cells[4].Value.ToString();
            (updRepairForm.Controls["UpdRepCommTextBox"] as TextBox).Text = RepairGridView.CurrentRow.Cells[5].Value.ToString();
            updRepairForm.Tag = RepairGridView.CurrentRow.Cells[0].Value.ToString();
            updRepairForm.ShowDialog();
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (NpgsqlConnection connection = Database.GetConnection())
                {
                    connection.Open();
                    string toDelete = RepairGridView.CurrentRow.Cells[0].Value.ToString();
                    NpgsqlCommand cmd = new NpgsqlCommand("DELETE FROM \"Repairs\" WHERE \"RepairID\"=\'" + toDelete + "\'", connection);
                    cmd.ExecuteNonQuery();
                    cmd = new NpgsqlCommand("SELECT \"RepairID\" AS \"ID\", \"ATMID\" AS \"ID УС\", \"Category\" AS \"Категория\", \"Engineer\" AS \"Инженер\", \"Date\" AS \"Дата\", COALESCE(\"Comment\", 'н/д') AS \"Комментарий\" FROM \"Repairs\" ORDER BY \"RepairID\"", connection);
                    NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    RepairGridView.DataSource = ds.Tables[0];
                }
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка базы данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RepairGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                try
                {
                    using (NpgsqlConnection connection = Database.GetConnection())
                    {
                        connection.Open();
                        string toDelete = RepairGridView.CurrentRow.Cells[0].Value.ToString();
                        NpgsqlCommand cmd = new NpgsqlCommand("DELETE FROM \"Repairs\" WHERE \"RepairID\"=\'" + toDelete + "\'", connection);
                        cmd.ExecuteNonQuery();
                        cmd = new NpgsqlCommand("SELECT \"RepairID\" AS \"ID\", \"ATMID\" AS \"ID УС\", \"Category\" AS \"Категория\", \"Engineer\" AS \"Инженер\", \"Date\" AS \"Дата\", COALESCE(\"Comment\", 'н/д') AS \"Комментарий\" FROM \"Repairs\" ORDER BY \"RepairID\"", connection);
                        NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd);
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);
                        RepairGridView.DataSource = ds.Tables[0];
                    }
                }
                catch (NpgsqlException ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка базы данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
