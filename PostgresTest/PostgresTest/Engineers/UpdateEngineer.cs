using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;

namespace PostgresTest
{
    public partial class UpdateEngineer : Form
    {
        public UpdateEngineer()
        {
            InitializeComponent();
        }

        private void UpdateEngineerBtn_Click(object sender, EventArgs e)
        {
            if (UpdateEngineerTextBox.Text != string.Empty)
            {
                try
                {
                    using (NpgsqlConnection connection = Database.GetConnection())
                    {
                        connection.Open();
                        string previousValue = this.Tag.ToString();
                        string query = "UPDATE \"Engineers\" SET \"EngineerName\" = \'" + UpdateEngineerTextBox.Text + "\' WHERE \"EngineerName\" = \'" + previousValue + "\'";
                        NpgsqlCommand cmd = new NpgsqlCommand(query, connection);
                        cmd.ExecuteNonQuery();
                        cmd = new NpgsqlCommand("SELECT \"EngineerName\" AS \"Инженер\" FROM \"Engineers\" ORDER BY \"EngineerName\"", connection);
                        NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd);
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);
                        (this.Owner.Controls["EngineersGridView"] as DataGridView).DataSource = ds.Tables[0];
                    }
                    this.Close();
                }
                catch (NpgsqlException ex)
                {
                    if (ex.Message.Contains("23505"))
                    {
                        MessageBox.Show("Запись с данным инженером существует в базе. Введите другие данные инженера.", 
                                        "Проверка уникальности данных", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show(ex.Message, "Ошибка базы данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Для сохранения информации необходимо ввести данные инженера. Проверьте вводимые данные.", 
                                "Проверка корректности ввода данных", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void UpdateEngineerCnlBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
