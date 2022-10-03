using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using Npgsql;

namespace PostgresTest
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();

            string s = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
            NpgsqlConnectionStringBuilder builder = new NpgsqlConnectionStringBuilder(s);
            this.SettingsDBNameTextBox.Text = builder.Database;
            this.SettingsServerPortTextBox.Text = builder.Port.ToString();
            this.SettingsHostnameTextBox.Text = builder.Host;
            this.Refresh();
        }

        private void SettingsCancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SettingsSaveBtn_Click(object sender, EventArgs e)
        {
            string ConnectionString = "";
            if (SettingsHostnameTextBox.Text != string.Empty && 
                SettingsServerPortTextBox.Text != string.Empty &&
                SettingsDBNameTextBox.Text != string.Empty)
            {
                ConnectionString = @"Server=" + SettingsHostnameTextBox.Text + ";" +
                                    "Port=" + SettingsServerPortTextBox.Text + ";" +
                                 //   "User ID=" + SettingsUsernameTextBox.Text + ";" +
                                  //  "Password=" + SettingsPasswordTextBox.Text + ";" +
                                    "Database=" + SettingsDBNameTextBox.Text + ";";

                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

                config.ConnectionStrings.ConnectionStrings.Remove("DBConnection");
                config.ConnectionStrings.ConnectionStrings.Add(new ConnectionStringSettings("DBConnection", ConnectionString));  
          
                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("connectionStrings");

                Credentials.UserID = SettingsUsernameTextBox.Text;
                Credentials.Password = SettingsPasswordTextBox.Text;

                MessageBox.Show("Параметры соединения изменены. Проверьте подключение к БД.",
                                "Информация",MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.Close();
            }
            else
            { 
                MessageBox.Show("Необходимо заполнить каждое из полей, конфигурация подключения НЕ СОХРАНЕНА!", 
                                "Ошибка сохранения параметров", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }

        }
    }
}
