using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PostgresTest
{
    public partial class AddEngineer : Form
    {
        public AddEngineer()
        {
            InitializeComponent();
        }

        private void addEngineerBtn_Click(object sender, EventArgs e)
        {
            if (addEngineerTextBox.Text != string.Empty)
            {
                try
                {
                    using (NpgsqlConnection connection = Database.GetConnection())
                    {
                        connection.Open();
                        NpgsqlCommand cmd = new NpgsqlCommand("INSERT INTO \"Engineers\" (\"EngineerName\") VALUES ('" + addEngineerTextBox.Text + "')", connection);
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

        private void addEngineerCnlBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
