using Npgsql;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PostgresTest.Repairs
{
    public partial class UpdateRepair : Form
    {
        public UpdateRepair()
        {
            InitializeComponent();
        }

        private void UpdRepairCnlBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdRepairBtn_Click(object sender, EventArgs e)
        {
            using (NpgsqlConnection connection = Database.GetConnection())
            {
                connection.Open();
                string prevRepairID = this.Tag.ToString();
                string query = "UPDATE \"Repairs\" SET \"ATMID\" = \'" + UpdRepIDAtmComboBox.Text + "\'," +"\"Category\" = \'" + UpdRepCatComboBox.Text + "\'," +
                    "\"Engineer\" = \'" + UpdRepEngComboBox.Text + "\'," +"\"Date\" = \'" + UpdRepairDTPicker.Value.ToString("dd/MM/yyyy") + "\'," + "\"Comment\" = \'" 
                    + UpdRepCommTextBox.Text + "\' WHERE \"RepairID\" = \'" + prevRepairID + "\'";                                                                                                                                                                                                     
                NpgsqlCommand cmd = new NpgsqlCommand(query, connection);
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
