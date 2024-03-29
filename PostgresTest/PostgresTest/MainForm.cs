﻿using System;
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
using PostgresTest.Queries_forms;
using PostgresTest.Repairs;
using Microsoft.Office.Interop.Excel;
using System.Configuration;


namespace PostgresTest
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.Show();
            Authorization AuthForm = new Authorization();
            AuthForm.Owner = this;
            AuthForm.ShowDialog();
        }      

        private void моделиБанкоматовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ATMModels atmmodelsForm = new ATMModels();
            atmmodelsForm.ShowDialog();
        }
        private void устройстваToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Categories devicesForm = new Categories();
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
        private void всеРемонтыToolStripMenuItem2_Click(object sender, EventArgs e)
        {
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
                               "\"Repairs\".\"Date\" AS \"Дата\" FROM \"Repairs\" " +
                               "INNER JOIN public.\"ATMs\" ON " +
                               "\"ATMs\".\"ATMID\" = \"Repairs\".\"ATMID\" " +
                               "ORDER BY \"Repairs\".\"ATMID\", \"Repairs\".\"Date\"";
                NpgsqlCommand cmd = new NpgsqlCommand(query, connection);
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                GridView.DataSource = ds.Tables[0];
            }
        }

        private void генераторОтчетовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QueryGen generator = new QueryGen();
            generator.Owner = this;
            generator.ShowDialog();
        }

        private void ремонтыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Repair repairsForm = new Repair();
            repairsForm.Owner = this;
            repairsForm.ShowDialog();
        }

        private void вExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExcelReporter.GetReport(this.GridView);
        }

        private void проверкаСоединенияСБДToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Database.TestConnection())
            {
                MessageBox.Show("Соединение с БД установлено.","Информация",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else MessageBox.Show("Ошибка подключения к БД. Проверьте параметры соединения.","Ошибка",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

        private void параметрыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.Owner = this;
            settingsForm.ShowDialog();
        }
    }
}
