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
    public partial class AddDevice : Form
    {
        public AddDevice()
        {
            InitializeComponent();
        }

        private void AddDeviceBtn_Click(object sender, EventArgs e)
        {
            using (NpgsqlConnection connection = Database.GetConnection())
            {
                connection.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("INSERT INTO \"Devices\" (\"DeviceName\") VALUES ('"+addDeviceTextbox.Text+"')", connection);
                cmd.ExecuteNonQuery();
                cmd = new NpgsqlCommand("SELECT \"DeviceName\" AS \"Устройства\" FROM \"Devices\" ORDER BY \"DeviceName\"", connection);
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                (this.Owner.Controls["DevicesGridView"] as DataGridView).DataSource = ds.Tables[0];
            }
            this.Close();
        }

        private void AddDeviceCnlBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
