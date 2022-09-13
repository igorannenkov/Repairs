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
    public partial class AddRegion : Form
    {
        public AddRegion()
        {
            InitializeComponent();
        }

        private void AddRegionBtn_Click(object sender, EventArgs e)
        {
            using (NpgsqlConnection connection = Database.GetConnection())
            {
                connection.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("INSERT INTO \"Regions\" (\"RegionName\") VALUES ('" + AddRegionTextBox.Text + "')", connection);
                cmd.ExecuteNonQuery();
                cmd = new NpgsqlCommand("SELECT \"RegionName\" AS \"Инженер\" FROM \"Regions\" ORDER BY \"RegionName\"", connection);
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                (this.Owner.Controls["RegionsDataGridView"] as DataGridView).DataSource = ds.Tables[0];
            }
            this.Close();
        }
    }
}
