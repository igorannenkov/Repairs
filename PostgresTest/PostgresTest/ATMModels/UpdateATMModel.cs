using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;

namespace PostgresTest
{
    public partial class UpdateATMModel : Form
    {
        public UpdateATMModel()
        {
            InitializeComponent();
        }

        private void UpdateATMModelBtn_Click(object sender, EventArgs e)
        {
            if (UpdateATMModelTextBox.Text != string.Empty)
            {
                try
                {
                    using (NpgsqlConnection connection = Database.GetConnection())
                    {
                        connection.Open();
                        string previousValue = this.Tag.ToString();
                        string query = "UPDATE \"ATMModels\" SET \"Model\" = \'" + UpdateATMModelTextBox.Text + "\' WHERE \"Model\" = \'" + previousValue + "\'";
                        NpgsqlCommand cmd = new NpgsqlCommand(query, connection);
                        cmd.ExecuteNonQuery();
                        cmd = new NpgsqlCommand("SELECT \"Model\" AS \"Модель УС\" FROM \"ATMModels\" ORDER BY \"Model\"", connection);
                        NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd);
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);
                        (this.Owner.Controls["ATMModelGridView"] as DataGridView).DataSource = ds.Tables[0];
                    }
                    this.Close();
                }
                catch (NpgsqlException ex)
                {
                    if (ex.Message.Contains("23505"))
                    {
                        MessageBox.Show("Модель с данным наименованием существует. Введите другое наименование.", 
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
                MessageBox.Show("Для сохранения информации необходимо указать модель устройства. Проверьте вводимые данные.", 
                                "Проверка корректности ввода данных", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void UpdateATMModelCnlBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
