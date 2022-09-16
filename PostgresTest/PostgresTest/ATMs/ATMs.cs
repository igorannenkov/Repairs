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
    public partial class ATMs : Form
    {
        public ATMs()
        {
            InitializeComponent();
            using (NpgsqlConnection connection = Database.GetConnection())
            {
                connection.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("SELECT \"ATMID\" AS \"ID\",\"Address\" AS \"Адрес\",\"Model\" AS \"Модель\",\"Region\" AS \"Регион\" FROM \"ATMs\" ORDER BY \"ATMID\"", connection);
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                ATMsGridView.DataSource = ds.Tables[0];
            }
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ATMsAddATM addATMForm = new ATMsAddATM();
            addATMForm.Owner = this;
            addATMForm.ShowDialog();
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (NpgsqlConnection connection = Database.GetConnection())
            {
                connection.Open();
                string toDelete = ATMsGridView.CurrentRow.Cells[0].Value.ToString();

                NpgsqlCommand cmd = new NpgsqlCommand("DELETE FROM \"ATMs\" WHERE \"ATMID\"=\'" + toDelete + "\'", connection);
                cmd.ExecuteNonQuery();

                cmd = new NpgsqlCommand("SELECT \"ATMID\" AS \"ID\",\"Address\" AS \"Адрес\",\"Model\" AS \"Модель\",\"Region\" AS \"Регион\" FROM \"ATMs\"", connection);

                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                ATMsGridView.DataSource = ds.Tables[0];
            }
        }

        private void ATMsGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                using (NpgsqlConnection connection = Database.GetConnection())
                {
                    connection.Open();
                    string toDelete = ATMsGridView.CurrentRow.Cells[0].Value.ToString();

                    NpgsqlCommand cmd = new NpgsqlCommand("DELETE FROM \"ATMs\" WHERE \"ATMID\"=\'" + toDelete + "\'", connection);
                    cmd.ExecuteNonQuery();

                    cmd = new NpgsqlCommand("SELECT \"ATMID\" AS \"ATM ID\",\"Address\" AS \"Адрес\",\"Model\" AS \"Модель\",\"Region\" AS \"Регион\" FROM \"ATMs\"", connection);

                    NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    ATMsGridView.DataSource = ds.Tables[0];
                }
            }
        }

        private void ATMsGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            UpdateATM updATMForm = new UpdateATM();
            updATMForm.Owner = this;

            using (NpgsqlConnection connection = Database.GetConnection())
            {
                connection.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("SELECT \"Model\" AS \"Модели банкоматов\" FROM \"ATMModels\" ORDER BY \"Model\"", connection);
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);

                (updATMForm.Controls["UpdATMModComboBox"] as ComboBox).ValueMember = "Модели банкоматов";
                (updATMForm.Controls["UpdATMModComboBox"] as ComboBox).DataSource = ds.Tables[0];
                cmd = new NpgsqlCommand("SELECT \"RegionName\" AS \"Регион\" FROM \"Regions\" ORDER BY \"RegionName\"", connection);
                adapter = new NpgsqlDataAdapter(cmd);
                ds = new DataSet();
                adapter.Fill(ds);
                (updATMForm.Controls["UpdATMRegionComboBox"] as ComboBox).ValueMember = "Регион";
                (updATMForm.Controls["UpdATMRegionComboBox"] as ComboBox).DataSource = ds.Tables[0];

            }



            (updATMForm.Controls["UpdATMIDTextBox"] as TextBox).Text = ATMsGridView.CurrentRow.Cells[0].Value.ToString();
            (updATMForm.Controls["UpdATMModComboBox"] as ComboBox).Text = ATMsGridView.CurrentRow.Cells[2].Value.ToString();
            (updATMForm.Controls["UpdATMAddrTextBox"] as TextBox).Text = ATMsGridView.CurrentRow.Cells[1].Value.ToString();
            (updATMForm.Controls["UpdATMRegionComboBox"] as ComboBox).Text = ATMsGridView.CurrentRow.Cells[3].Value.ToString();

            updATMForm.Tag = ATMsGridView.CurrentRow.Cells[0].Value.ToString();
            updATMForm.ShowDialog();

            //string prevEngName = ATMModelGridView.CurrentCell.Value.ToString();
            //(updATMModelForm.Controls["UpdateATMTextBox"] as TextBox).Text = prevEngName;
            //updATMModelForm.Tag = prevEngName;
            //updATMModelForm.ShowDialog();
        }
    }
}
