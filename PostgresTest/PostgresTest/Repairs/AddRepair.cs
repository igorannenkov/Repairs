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

namespace PostgresTest.Repairs
{
    public partial class AddRepair : Form
    {
        public AddRepair()
        {
            InitializeComponent();
            using (NpgsqlConnection connection = Database.GetConnection())
            {
                connection.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("SELECT \"ATMID\" AS \"ID\" FROM \"ATMs\" ORDER BY \"ATMID\"", connection);
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                this.AddRepIDAtmComboBox.ValueMember = "ID";
                this.AddRepIDAtmComboBox.DataSource = ds.Tables[0];

                cmd = new NpgsqlCommand("SELECT \"CategoryName\" AS \"Категория\" FROM \"Categories\" ORDER BY \"CategoryName\"", connection);
                adapter = new NpgsqlDataAdapter(cmd);
                ds = new DataSet();
                adapter.Fill(ds);
                this.AddRepCatComboBox.ValueMember = "Категория";
                this.AddRepCatComboBox.DataSource = ds.Tables[0];

                cmd = new NpgsqlCommand("SELECT \"EngineerName\" AS \"Инженер\" FROM \"Engineers\" ORDER BY \"EngineerName\"", connection);
                adapter = new NpgsqlDataAdapter(cmd);
                ds = new DataSet();
                adapter.Fill(ds);
                this.AddRepEngComboBox.ValueMember = "Инженер";
                this.AddRepEngComboBox.DataSource = ds.Tables[0];
            }
        }

        private void AddRepairCnlBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddRepairBtn_Click(object sender, EventArgs e)
        {
            using (NpgsqlConnection connection = Database.GetConnection())
            {
                connection.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("INSERT INTO \"Repairs\" (\"ATMID\",\"Category\",\"Engineer\",\"Date\",\"Comment\") VALUES (\'"+AddRepIDAtmComboBox.Text+"\',\'"+AddRepCatComboBox.Text+"\',\'"+AddRepEngComboBox.Text+"\',\'"+AddRepairDTPicker.Value.ToString("dd/MM/yyyy") + "\',\'" + AddRepCommTextBox.Text+"\')", connection);
                cmd.ExecuteNonQuery();

                cmd = new NpgsqlCommand("SELECT \"RepairID\" AS \"ID\",\"ATMID\" AS \"ID УС\",\"Category\" AS \"Категория\",\"Engineer\" AS \"Инженер\",\"Date\" AS \"Дата\",\"Comment\" AS \"Комментарий\" FROM \"Repairs\" ORDER BY \"RepairID\"", connection);
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                (this.Owner.Controls["RepairGridView"] as DataGridView).DataSource = ds.Tables[0];
            }
            this.Close();
        }
    }
}
