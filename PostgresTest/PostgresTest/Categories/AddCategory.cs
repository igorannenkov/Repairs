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
    public partial class AddCategory : Form
    {
        public AddCategory()
        {
            InitializeComponent();
        }

        private void AddDeviceBtn_Click(object sender, EventArgs e)
        {
            using (NpgsqlConnection connection = Database.GetConnection())
            {
                connection.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("INSERT INTO \"Categories\" (\"CategoryName\") VALUES ('"+AddCategoryTextbox.Text+"')", connection);
                cmd.ExecuteNonQuery();
                cmd = new NpgsqlCommand("SELECT \"CategoryName\" AS \"Категория\" FROM \"Categories\" ORDER BY \"CategoryName\"", connection);
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                (this.Owner.Controls["CategoriesGridView"] as DataGridView).DataSource = ds.Tables[0];
            }
            this.Close();
        }

        private void AddDeviceCnlBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
