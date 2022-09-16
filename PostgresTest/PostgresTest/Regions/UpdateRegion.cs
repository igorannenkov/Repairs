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
    public partial class UpdateRegion : Form
    {
        public UpdateRegion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (NpgsqlConnection connection = Database.GetConnection())
            {
                connection.Open();
                string previousValue = this.Tag.ToString();
                string query = "UPDATE \"Regions\" SET \"RegionName\" = \'" + UpdateRegionTextBox.Text + "\' WHERE \"RegionName\" = \'" + previousValue + "\'";
                NpgsqlCommand cmd = new NpgsqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                cmd = new NpgsqlCommand("SELECT \"RegionName\" AS \"Регионы\" FROM \"Regions\" ORDER BY \"RegionName\"", connection);
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                (this.Owner.Controls["RegionsDataGridView"] as DataGridView).DataSource = ds.Tables[0];
            }
            this.Close();
        }

        private void UpdateRegionCnlBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
