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
    public partial class Form1 : Form
    {
        public Form1()
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
            using (NpgsqlConnection connection = GetConnection())
            {
                connection.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("SELECT \"Model\" AS \"Модели банкоматов\" FROM \"ATMModels\" ORDER BY \"Model\"", connection);
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                GridView.DataSource = ds.Tables[0];
                toolStripStatusLabel1.Text = cmd.CommandText;
            }
        }

        private void устройстваToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Devices devicesForm = new Devices();
            devicesForm.ShowDialog();
            //using (NpgsqlConnection connection = GetConnection())
            //{
            //    connection.Open();
            //    NpgsqlCommand cmd = new NpgsqlCommand("SELECT \"DeviceName\" AS \"Устройства\" FROM \"Devices\" ORDER BY \"DeviceName\"", connection);
            //    NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd);
            //    DataSet ds = new DataSet();
            //    adapter.Fill(ds);
            //    GridView.DataSource = ds.Tables[0];
            //    toolStripStatusLabel1.Text = cmd.CommandText;
            //}
        }

        private void банкоматыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (NpgsqlConnection connection = GetConnection())
            {
                connection.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("SELECT \"ATMID\" AS \"ATM ID\",\"Address\" AS \"Адрес\",\"Model\" AS \"Модель\",\"Region\" AS \"Принадлежность\" FROM \"ATMs\"", connection);
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                GridView.DataSource = ds.Tables[0];
                toolStripStatusLabel1.Text = cmd.CommandText;
            }
        }

        private void инженерыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (NpgsqlConnection connection = GetConnection())
            {
                connection.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("SELECT \"EngineerName\" AS \"Инженеры\" FROM \"Engineers\" ORDER BY \"EngineerName\"", connection);
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                GridView.DataSource = ds.Tables[0];
                toolStripStatusLabel1.Text = cmd.CommandText;
            }
        }

        private void регионыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (NpgsqlConnection connection = GetConnection())
            {
                connection.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("SELECT \"RegionName\" AS \"Регионы\" FROM \"Regions\" ORDER BY \"RegionName\"", connection);
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                GridView.DataSource = ds.Tables[0];
                toolStripStatusLabel1.Text = cmd.CommandText;
            }
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
