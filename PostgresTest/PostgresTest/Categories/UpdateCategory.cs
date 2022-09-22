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
    public partial class UpdateCategory : Form
    {
        public UpdateCategory()
        {
            InitializeComponent();
        }

        private void DeviceEditBtn_Click(object sender, EventArgs e)
        {
            using (NpgsqlConnection connection = Database.GetConnection())
            {
                connection.Open();
                string previousValue = this.Tag.ToString();
                string query = "UPDATE \"Categories\" SET \"CategoryName\" = \'"+ UpdCatTextBox.Text + "\' WHERE \"CategoryName\" = \'" + previousValue+"\'"; 
                NpgsqlCommand cmd = new NpgsqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                cmd = new NpgsqlCommand("SELECT \"CategoryName\" AS \"Категория\" FROM \"Categories\" ORDER BY \"CategoryName\"", connection);
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                (this.Owner.Controls["CategoriesGridView"] as DataGridView).DataSource = ds.Tables[0];
            }
            this.Close();
        }

        private void DeviceEditCnlBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
