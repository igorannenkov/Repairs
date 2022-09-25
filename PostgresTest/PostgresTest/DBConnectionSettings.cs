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

namespace PostgresTest
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void SettingsCancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SettingsSaveBtn_Click(object sender, EventArgs e)
        {
            //@"Server=localhost;Port=5432;User ID=postgres; Password = gwh28DGCMP; Database = Repairs; "
            string ConnectionString = "";
            if (SettingsServernameTextBox.Text != string.Empty && SettingsServerPortTextBox.Text != string.Empty &&
                SettingsDBNameTextBox.Text != string.Empty && SettingsUsernameTextBox.Text != string.Empty &&
                SettingsPasswordTextBox.Text != string.Empty)
            {
                ConnectionString = @"Server=" + SettingsServernameTextBox.Text + ";" +
                                    "Port=" + SettingsServerPortTextBox.Text + ";" +
                                    "User ID=" + SettingsUsernameTextBox.Text + ";" +
                                    "Password=" + SettingsPasswordTextBox.Text + ";" +
                                    "Database=" + SettingsDBNameTextBox.Text + ";";


                //ConfigurationManager.ConnectionStrings["DBConnection"]. //ConnectionString = ConnectionString;

                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

                config.ConnectionStrings.ConnectionStrings.Remove("DBConnection");
                config.ConnectionStrings.ConnectionStrings.Add(new ConnectionStringSettings("DBConnection", ConnectionString));  

          
                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("connectionStrings");
               // config.AppSettings.Settings["DBConnection"].Value = ConnectionString;


                MessageBox.Show("Изменения приняты. Проверьте подключение к БД.");
                this.Close();
            }
            else
            { MessageBox.Show("Необходимо заполнить одно из полей, конфигурация НЕ СОХРАНЕНА!"); }

        }
    }
}
