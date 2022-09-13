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
    public partial class Devices : Form
    {
        public Devices()
        {
            InitializeComponent();
            using (NpgsqlConnection connection = Database.GetConnection())
            {
                connection.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("SELECT \"DeviceName\" AS \"Устройства\" FROM \"Devices\" ORDER BY \"DeviceName\"", connection);
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                DevicesGridView.DataSource = ds.Tables[0];
            }
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddDevice addDeviceForm = new AddDevice();
            addDeviceForm.Owner = this;
            addDeviceForm.ShowDialog();
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (NpgsqlConnection connection = Database.GetConnection())
            {
                connection.Open();
                string toDelete = DevicesGridView.CurrentCell.Value.ToString();


                NpgsqlCommand cmd = new NpgsqlCommand("DELETE FROM \"Devices\" WHERE \"DeviceName\"=\'"+toDelete+"\'", connection);
                cmd.ExecuteNonQuery();

                cmd = new NpgsqlCommand("SELECT \"DeviceName\" AS \"Устройства\" FROM \"Devices\" ORDER BY \"DeviceName\"", connection);
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                DevicesGridView.DataSource = ds.Tables[0];
            }
        }

        private void DevicesGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                using (NpgsqlConnection connection = Database.GetConnection())
                {
                    connection.Open();
                    string toDelete = DevicesGridView.CurrentCell.Value.ToString();


                    NpgsqlCommand cmd = new NpgsqlCommand("DELETE FROM \"Devices\" WHERE \"DeviceName\"=\'" + toDelete + "\'", connection);
                    cmd.ExecuteNonQuery();

                    cmd = new NpgsqlCommand("SELECT \"DeviceName\" AS \"Устройства\" FROM \"Devices\" ORDER BY \"DeviceName\"", connection);
                    NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    DevicesGridView.DataSource = ds.Tables[0];
                }
            }
        }


        private void DevicesGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            UpdateDevice updDeviceForm = new UpdateDevice();
            updDeviceForm.Owner = this;
            string prevDevName = DevicesGridView.CurrentCell.Value.ToString();
            (updDeviceForm.Controls["UpdateDeviceTextBox"] as TextBox).Text = prevDevName;
            updDeviceForm.Tag = prevDevName;
            updDeviceForm.ShowDialog();
        }

        
    }
}
