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
    public partial class UpdateATMModel : Form
    {
        public UpdateATMModel()
        {
            InitializeComponent();
        }

        private void UpdateATMModelBtn_Click(object sender, EventArgs e)
        {
            using (NpgsqlConnection connection = Database.GetConnection())
            {
                connection.Open();
                string previousValue = this.Tag.ToString();
                string query = "UPDATE \"ATMModels\" SET \"Model\" = \'" + UpdateATMTextBox.Text + "\' WHERE \"Model\" = \'" + previousValue + "\'";
                NpgsqlCommand cmd = new NpgsqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                cmd = new NpgsqlCommand("SELECT \"Model\" AS \"Модели банкоматов\" FROM \"ATMModels\" ORDER BY \"Model\"", connection);
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                (this.Owner.Controls["ATMModelGridView"] as DataGridView).DataSource = ds.Tables[0];
            }
            this.Close();
        }

        private void UpdateATMModelCnlBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
