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

        private void addEngineerCnlBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
