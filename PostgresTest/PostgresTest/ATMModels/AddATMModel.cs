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
    public partial class AddATMModel : Form
    {
        public AddATMModel()
        {
            InitializeComponent();
        }

        private void ATMModelBtn_Click(object sender, EventArgs e)
        {
            if (AddATMModelTextBox.Text != String.Empty)
            {
                using (NpgsqlConnection connection = Database.GetConnection())
                {
                    connection.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand("INSERT INTO \"ATMModels\" (\"Model\") VALUES ('" + AddATMModelTextBox.Text + "')", connection);
                    cmd.ExecuteNonQuery();
                    cmd = new NpgsqlCommand("SELECT \"Model\" AS \"Модели банкоматов\" FROM \"ATMModels\" ORDER BY \"Model\"", connection);
                    NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    (this.Owner.Controls["ATMModelGridView"] as DataGridView).DataSource = ds.Tables[0];
                }
                this.Close();
            }
        }

        private void AddATMModelCnlBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
