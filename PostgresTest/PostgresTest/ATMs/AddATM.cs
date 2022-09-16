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
    public partial class ATMsAddATM : Form
    {
        public ATMsAddATM()
        {
            InitializeComponent();
            using (NpgsqlConnection connection = Database.GetConnection())
            {
                connection.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("SELECT \"Model\" AS \"Модели банкоматов\" FROM \"ATMModels\" ORDER BY \"Model\"", connection);
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                this.ATMsModelComboBox.ValueMember = "Модели банкоматов";
                this.ATMsModelComboBox.DataSource = ds.Tables[0];
                cmd = new NpgsqlCommand("SELECT \"RegionName\" AS \"Регион\" FROM \"Regions\" ORDER BY \"RegionName\"", connection);
                adapter = new NpgsqlDataAdapter(cmd);
                ds = new DataSet();
                adapter.Fill(ds);
                this.ATMsRegionComboBox.ValueMember = "Регион";
                this.ATMsRegionComboBox.DataSource = ds.Tables[0];

            }
        }

        private void ATMsAddAtmBtn_Click(object sender, EventArgs e)
        {
            if (ATMsATMIDTextBox.Text != String.Empty && ATMsModelComboBox.Text != String.Empty && ATMsAddressTextBox.Text != String.Empty && ATMsRegionComboBox.Text != String.Empty)
            {
                using (NpgsqlConnection connection = Database.GetConnection())
                {
                    connection.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand("INSERT INTO \"ATMs\" (\"ATMID\",\"Address\",\"Model\",\"Region\") VALUES ('" + ATMsATMIDTextBox.Text + "','" + ATMsAddressTextBox.Text + "','" + ATMsModelComboBox.Text + "','" + ATMsRegionComboBox.Text + "')", connection);
                    cmd.ExecuteNonQuery();

                    cmd = new NpgsqlCommand("SELECT \"ATMID\" AS \"ID\",\"Address\" AS \"Адрес\",\"Model\" AS \"Модель\",\"Region\" AS \"Регион\" FROM \"ATMs\"", connection);
                    NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    (this.Owner.Controls["ATMsGridView"] as DataGridView).DataSource = ds.Tables[0];
                }
            }
            this.Close();
        }

        private void ATMsAddAtmCnlBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
