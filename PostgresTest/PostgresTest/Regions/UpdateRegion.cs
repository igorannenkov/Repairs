using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;

namespace PostgresTest
{
    public partial class UpdateRegion : Form
    {
        public UpdateRegion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (UpdateRegionTextBox.Text != string.Empty)
                try
                {
                    using (NpgsqlConnection connection = Database.GetConnection())
                    {
                        connection.Open();
                        string previousValue = this.Tag.ToString();
                        string query = "UPDATE \"Regions\" SET \"RegionName\" = \'" + UpdateRegionTextBox.Text + "\' WHERE \"RegionName\" = \'" + previousValue + "\'";
                        NpgsqlCommand cmd = new NpgsqlCommand(query, connection);
                        cmd.ExecuteNonQuery();
                        cmd = new NpgsqlCommand("SELECT \"RegionName\" AS \"Регион\" FROM \"Regions\" ORDER BY \"RegionName\"", connection);
                        NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd);
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);
                        (this.Owner.Controls["RegionsDataGridView"] as DataGridView).DataSource = ds.Tables[0];
                    }
                    this.Close();
                }
                catch (NpgsqlException ex)
                {
                    if (ex.Message.Contains("23505"))
                    {
                        MessageBox.Show("Регион с таким наименованием существует. Введите другое наименование.", 
                                        "Проверка уникальности данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show(ex.Message, "Ошибка базы данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            else
            {
                MessageBox.Show("Для сохранения информации необходимо ввести наименование региона. Проверьте вводимые данные.", 
                                "Проверка корректности ввода данных", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void UpdateRegionCnlBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
