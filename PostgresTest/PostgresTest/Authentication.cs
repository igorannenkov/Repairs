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
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
        }

        private void AuthCnlBtn_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void AuthEnterBtn_Click(object sender, EventArgs e)
        {
                Credentials.UserID = AuthUserIDTextBox.Text;
                Credentials.Password = AuthPasswordTextBox.Text;

                if (Database.TestConnection())
                {
                    this.Close();
                    MessageBox.Show("Соединение c БД установлено.","Информация", MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else MessageBox.Show("Ошибка подключения к базе данных.\r\n\r\n Возможные причины: \r\n 1.Введен неправильный логин или пароль; \r\n 2. Некорректные параметры подключения: \r\n адрес сервера, номер порта, имя БД.", "Ошибка",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

        private void AuthLinkLabel_MouseClick(object sender, MouseEventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.Owner = this;
            settingsForm.ShowDialog();
        }
    }
}
