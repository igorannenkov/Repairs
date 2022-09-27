using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;

namespace PostgresTest
{
    public partial class UpdateATM : Form
    {
        public UpdateATM()
        {
            InitializeComponent();
        }

        private void ATMsUpdAtmCnlBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ATMsUpdAtmBtn_Click(object sender, EventArgs e)
        {
            if (UpdATMIDTextBox.Text != String.Empty && UpdATMAddrTextBox.Text != String.Empty)
            {
                try
                {
                    using (NpgsqlConnection connection = Database.GetConnection())
                    {
                        connection.Open();
                        NpgsqlCommand cmd = new NpgsqlCommand("UPDATE ");
                        string prevATMID = this.Tag.ToString();
                        string query = "UPDATE \"ATMs\" SET \"ATMID\" = \'" + UpdATMIDTextBox.Text + "\'," +
                                                            "\"Address\" = \'" + UpdATMAddrTextBox.Text + "\'," +
                                                            "\"Model\" = \'" + UpdATMModComboBox.Text + "\'," +
                                                            "\"Region\" = \'" + UpdATMRegionComboBox.Text + "\' " +
                                                            "WHERE \"ATMID\" = \'" + prevATMID + "\'";
                        cmd = new NpgsqlCommand(query, connection);
                        cmd.ExecuteNonQuery();
                        cmd = new NpgsqlCommand("SELECT \"ATMID\" AS \"ID\"," +
                                                        "\"Address\" AS \"Адрес\"," +
                                                        "\"Model\" AS \"Модель\"," +
                                                        "\"Region\" AS \"Регион\" " +
                                                        "FROM \"ATMs\" ORDER BY \"ATMID\"", connection);
                        NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd);
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);
                        (this.Owner.Controls["ATMsGridView"] as DataGridView).DataSource = ds.Tables[0];
                        this.Close();
                    }
                }
                catch (NpgsqlException ex)
                {
                    if (ex.Message.Contains("23505"))
                    {
                        MessageBox.Show("Запись с таким ID существует. Введите другой идентификатор.", "Проверка уникальности данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show(ex.Message, "Ошибка базы данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Для сохранения информации необходимо заполнить все поля. Проверьте вводимые данные.", "Проверка корректности ввода данных", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
