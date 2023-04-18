using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static WindowsFormsApp2.Form1;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public class User
        {
            public string Fio { get; set; }
            public string Login { get; set; }
            public string Password { get; set; }
            public string Group { get; set; }
            public DateTime LastLoginDate { get; set; }
            public DateTime CreationDate { get; set; }
            public int Warnings { get; set; }

            public User(string fio, string login, string password, string group, DateTime lastLoginDate, DateTime creationDate, int warnings)
            {
                Fio = fio;
                Login = login;
                Password = password;
                Group = group;
                LastLoginDate = lastLoginDate;
                CreationDate = creationDate;
                Warnings = warnings;
            }

            public void UpdateWarnings()
            {
                Warnings++;
            }
        }

        private void tableBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            string fio = textBox1.Text;
            string login = textBox2.Text;
            string password = textBox3.Text;
            string group = textBox4.Text;
            DateTime lastLoginDate = DateTime.Parse(textBox5.Text);
            DateTime creationDate = DateTime.Parse(textBox6.Text);
            int warnings = int.Parse(textBox7.Text);

            User user = new User(fio, login, password, group, lastLoginDate, creationDate, warnings);

            // очищаем текстовое поле richTextBox1 перед добавлением новой информации
            richTextBox1.Clear();

            richTextBox1.AppendText($"ФИО: {user.Fio}\n");
            richTextBox1.AppendText($"Логин: {user.Login}\n");
            richTextBox1.AppendText($"Пароль: {user.Password}\n");
            richTextBox1.AppendText($"Группа: {user.Group}\n");
            richTextBox1.AppendText($"Дата последнего входа: {user.LastLoginDate}\n");
            richTextBox1.AppendText($"Дата создания учетной записи: {user.CreationDate}\n");
            richTextBox1.AppendText($"Количество предупреждений: {user.Warnings}\n");
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string fio = textBox1.Text;
            string login = textBox2.Text;
            string password = textBox3.Text;
            string group = textBox4.Text;
            DateTime lastLoginDate = DateTime.Parse(textBox5.Text);
            DateTime creationDate = DateTime.Parse(textBox6.Text);
            int warnings = int.Parse(textBox7.Text);

            User user = new User(fio, login, password, group, lastLoginDate, creationDate, warnings);
            user.UpdateWarnings();

            // очищаем текстовое поле richTextBox1 перед добавлением новой информации
            richTextBox1.Clear();

            richTextBox1.AppendText($"ФИО: {user.Fio}\n");
            richTextBox1.AppendText($"Логин: {user.Login}\n");
            richTextBox1.AppendText($"Пароль: {user.Password}\n");
            richTextBox1.AppendText($"Группа: {user.Group}\n");
            richTextBox1.AppendText($"Дата последнего входа: {user.LastLoginDate}\n");
            richTextBox1.AppendText($"Дата создания учетной записи: {user.CreationDate}\n");
            richTextBox1.AppendText($"Количество предупреждений: {user.Warnings}\n");
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.AppendText("Пользователь удален");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.AppendText("Пользователь создан");
        }
    }
}