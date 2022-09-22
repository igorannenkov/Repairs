using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;

namespace PostgresTest.Queries_forms
{
    public partial class QueryGen : Form
    {
        public QueryGen()
        {
            InitializeComponent();

            using (NpgsqlConnection connection = Database.GetConnection())
            {
                connection.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("SELECT \"ATMID\" AS \"ID\" FROM \"ATMs\" ORDER BY \"ATMID\"", connection);
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                this.GenATMIDComboBox.ValueMember = "ID";
                this.GenATMIDComboBox.DataSource = ds.Tables[0];

                cmd = new NpgsqlCommand("SELECT \"RegionName\" AS \"Region\" FROM \"Regions\" ORDER BY \"RegionName\"", connection);
                adapter = new NpgsqlDataAdapter(cmd);
                ds = new DataSet();
                adapter.Fill(ds);
                this.GenRegionComboBox.ValueMember = "Region";
                this.GenRegionComboBox.DataSource = ds.Tables[0];

                cmd = new NpgsqlCommand("SELECT \"Model\" AS \"Model\" FROM \"ATMModels\" ORDER BY \"Model\"", connection);
                adapter = new NpgsqlDataAdapter(cmd);
                ds = new DataSet();
                adapter.Fill(ds);
                this.GenModelComboBox.ValueMember = "Model";
                this.GenModelComboBox.DataSource = ds.Tables[0];

                cmd = new NpgsqlCommand("SELECT \"EngineerName\" AS \"Engineer\" FROM \"Engineers\" ORDER BY \"EngineerName\"", connection);
                adapter = new NpgsqlDataAdapter(cmd);
                ds = new DataSet();
                adapter.Fill(ds);
                this.GenEngineerComboBox.ValueMember = "Engineer";
                this.GenEngineerComboBox.DataSource = ds.Tables[0];

                cmd = new NpgsqlCommand("SELECT \"CategoryName\" AS \"Category\" FROM \"Categories\" ORDER BY \"CategoryName\"", connection);
                adapter = new NpgsqlDataAdapter(cmd);
                ds = new DataSet();
                adapter.Fill(ds);
                this.GenCategoryComboBox.ValueMember = "Category";
                this.GenCategoryComboBox.DataSource = ds.Tables[0];
            }
        }
        private void GenIDATMCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (GenATMIDCheckBox.Checked)
                GenATMIDComboBox.Enabled = true;
            else GenATMIDComboBox.Enabled = false;
        }

        private void GenRegionCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (GenRegionCheckBox.Checked)
                GenRegionComboBox.Enabled = true;
            else GenRegionComboBox.Enabled = false;
        }

        private void GenAddressCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (GenAddressCheckBox.Checked)
                GenAddressTextBox.Enabled = true;
            else GenAddressTextBox.Enabled = false;
        }

        private void GenModelCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (GenModelCheckBox.Checked)
                GenModelComboBox.Enabled = true;
            else GenModelComboBox.Enabled = false;
        }

        private void GenEngineerCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (GenEngineerCheckBox.Checked)
                GenEngineerComboBox.Enabled = true;
            else GenEngineerComboBox.Enabled = false;
        }

        private void GenCategoryCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (GenCategoryCheckBox.Checked)
                GenCategoryComboBox.Enabled = true;
            else GenCategoryComboBox.Enabled = false;
        }

        private void GenCommentCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (GenCommentCheckBox.Checked)
                GenCommentTextBox.Enabled = true;
            else GenCommentTextBox.Enabled = false;
        }

        private void GenTimeIntervalCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (GenPeriodCheckBox.Checked)
                GenPeriodGroupBox.Enabled = true;
            else GenPeriodGroupBox.Enabled = false;
        }

        private void GenCnlBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GenShowBtn_Click(object sender, EventArgs e)
        {
            string atmid = string.Empty;
            string region = string.Empty;
            string address = string.Empty;
            string model = string.Empty;
            string engineer = string.Empty;
            string category = string.Empty;
            string comment = string.Empty;
            string period = string.Empty;

            if (GenATMIDCheckBox.Checked)
                atmid = "AND \"Repairs\".\"ATMID\" = \'" + GenATMIDComboBox.Text + "\'";

            if (GenRegionCheckBox.Checked)
                region = "AND \"ATMs\".\"Region\" = \'" + GenRegionComboBox.Text + "\'";

            if (GenAddressCheckBox.Checked)
                address = "AND UPPER(\"ATMs\".\"Address\") LIKE \'%" + GenAddressTextBox.Text.ToUpper() + "%\'";

            if (GenModelCheckBox.Checked)
                model = "AND \"ATMs\".\"Model\" = \'" + GenModelComboBox.Text + "\'";

            if (GenEngineerCheckBox.Checked)
                engineer = "AND \"Repairs\".\"Engineer\" = \'" + GenEngineerComboBox.Text + "\'";

            if (GenCategoryCheckBox.Checked)
                category = "AND \"Repairs\".\"Category\" = \'" + GenCategoryComboBox.Text + "\'";

            if (GenCommentCheckBox.Checked)
                comment = "AND UPPER(\"Repairs\".\"Comment\") LIKE \'%" + GenCommentTextBox.Text.ToUpper() + "%\'";

            if (GenPeriodCheckBox.Checked)
                period = "AND \"Repairs\".\"Date\" BETWEEN \'" + GenFromDTPicker.Value.ToString("dd/MM/yyyy") + "\' AND " + "\'" + GenToDTPicker.Value.ToString("dd/MM/yyyy") + "\'";

            using (NpgsqlConnection connection = Database.GetConnection())
            {
                connection.Open();
                string query = "SELECT \"Repairs\".\"ATMID\" AS \"Устройство\", " +
                                "\"ATMs\".\"Region\" AS \"Принадлежность\"," +
                                "\"ATMs\".\"Address\" AS \"Адрес установки\", " +
                                "\"ATMs\".\"Model\" AS \"Модель\"," +
                                "\"Repairs\".\"Engineer\" AS \"Инженер\"," +
                                "\"Repairs\".\"Category\" AS \"Категория\"," +
                                "\"Repairs\".\"Comment\" AS \"Комментарий\"," +
                                "\"Repairs\".\"Date\" AS \"Дата\" " +
                                "FROM \"Repairs\", \"ATMs\" " +
                                "WHERE \"Repairs\".\"ATMID\" = \"ATMs\".\"ATMID\" " +
                                atmid + region + address + model + engineer + category + comment + period +
                                "ORDER BY \"Repairs\".\"ATMID\",\"Repairs\".\"Date\"";
                NpgsqlCommand cmd = new NpgsqlCommand(query, connection);
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                (this.Owner.Controls["GridView"] as DataGridView).DataSource = ds.Tables[0];
                this.Close();
            }
        }
    }
}
