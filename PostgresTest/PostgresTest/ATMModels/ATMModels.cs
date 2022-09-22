using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PostgresTest
{
    public partial class ATMModels : Form
    {
        public ATMModels()
        {
            InitializeComponent();
            using (NpgsqlConnection connection = Database.GetConnection())
            {
                connection.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("SELECT \"Model\" AS \"Модель УС\" FROM \"ATMModels\" ORDER BY \"Model\"", connection);
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                ATMModelGridView.DataSource = ds.Tables[0];
            }
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddATMModel addATMModelForm = new AddATMModel();
            addATMModelForm.Owner = this;
            addATMModelForm.ShowDialog();
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (NpgsqlConnection connection = Database.GetConnection())
            {
                connection.Open();
                string toDelete = ATMModelGridView.CurrentCell.Value.ToString();


                NpgsqlCommand cmd = new NpgsqlCommand("DELETE FROM \"ATMModels\" WHERE \"Model\"=\'" + toDelete + "\'", connection);
                cmd.ExecuteNonQuery();

                cmd = new NpgsqlCommand("SELECT \"Model\" AS \"Модель УС\" FROM \"ATMModels\" ORDER BY \"Model\"", connection);
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                ATMModelGridView.DataSource = ds.Tables[0];
            }
        }

        private void ATMModelGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                using (NpgsqlConnection connection = Database.GetConnection())
                {
                    connection.Open();
                    string toDelete = ATMModelGridView.CurrentCell.Value.ToString();


                    NpgsqlCommand cmd = new NpgsqlCommand("DELETE FROM \"ATMModels\" WHERE \"Model\"=\'" + toDelete + "\'", connection);
                    cmd.ExecuteNonQuery();

                    cmd = new NpgsqlCommand("SELECT \"Model\" AS \"Модель УС\" FROM \"ATMModels\" ORDER BY \"Model\"", connection);
                    NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    ATMModelGridView.DataSource = ds.Tables[0];
                }
            }
        }

        private void ATMModelGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            UpdateATMModel updATMModelForm = new UpdateATMModel();
            updATMModelForm.Owner = this;
            string prevEngName = ATMModelGridView.CurrentCell.Value.ToString();
            (updATMModelForm.Controls["UpdateATMTextBox"] as TextBox).Text = prevEngName;
            updATMModelForm.Tag = prevEngName;
            updATMModelForm.ShowDialog();
        }
    }
}
