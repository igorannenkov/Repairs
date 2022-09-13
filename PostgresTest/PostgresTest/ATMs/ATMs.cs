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
                NpgsqlCommand cmd = new NpgsqlCommand("SELECT \"ATMID\" AS \"ATM ID\",\"Address\" AS \"Адрес\",\"Model\" AS \"Модель\",\"Region\" AS \"Регион\" FROM \"ATMs\"", connection);
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
    }
}
