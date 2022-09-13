using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace PostgresTest
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }



        public static NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection(@"Server=localhost;Port=5432;User ID=postgres;Password=gwh28DGCMP;Database=Repairs;");  
        }

        public static void TestConnection()
        {
            using (NpgsqlConnection connection = GetConnection())
            {
                connection.Open();
                if (connection.State == ConnectionState.Open)
                {
                    MessageBox.Show("Соединение установлено!");
                }
            }
        }

       
       

        private void showDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (NpgsqlConnection connection = GetConnection())
            {              
                connection.Open();
                NpgsqlCommand cmd = new NpgsqlCommand(textBox1.Text, connection);
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                GridView.DataSource = ds.Tables[0];
                toolStripStatusLabel1.Text = cmd.CommandText;
            }
        }

        private void testConnectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (NpgsqlConnection connection = GetConnection())
            {
                connection.Open();
                if (connection.State == ConnectionState.Open)
                {
                    MessageBox.Show("Соединение установлено!");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (NpgsqlConnection connection = GetConnection())
            {
                connection.Open();
                NpgsqlCommand cmd = new NpgsqlCommand(textBox1.Text, connection);
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                GridView.DataSource = ds.Tables[0];
                toolStripStatusLabel1.Text = cmd.CommandText;
            }
        }

        private void моделиБанкоматовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ATMModels atmmodelsForm = new ATMModels();
            atmmodelsForm.ShowDialog();
        }

        private void устройстваToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Devices devicesForm = new Devices();
            devicesForm.ShowDialog();
        }

        private void банкоматыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ATMs atmsForm = new ATMs();
            atmsForm.Owner = this;
            atmsForm.ShowDialog();
        }

        private void инженерыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Engineers engineersForm = new Engineers();
            engineersForm.Owner = this;
            engineersForm.ShowDialog();
        }

        private void регионыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Regions regionsForm = new Regions();
            regionsForm.Owner = this;
            regionsForm.ShowDialog();
        }

        private void всеРемонтыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (NpgsqlConnection connection = GetConnection())
            {
                connection.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("SELECT \"RepairID\" AS \"ID\", \"ATMID\" AS \"ID ATM\", \"Device\" AS \"Категория\", \"Engineer\" AS \"Кто выполнил\", \"Date\" AS \"Дата\", COALESCE(\"Comment\", 'н/д') AS \"Комментарий\" FROM \"Repairs\" ORDER BY \"RepairID\"", connection);
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                GridView.DataSource = ds.Tables[0];
                toolStripStatusLabel1.Text = cmd.CommandText;
            }
        }


    }
}
