using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Across_the_Globe_Guide.Models;

namespace Across_the_Globe_Guide
{
    public partial class RegistrationForm : Form
    {
        private Registration registration = new Registration();
        private string dataPath = "users.txt";

        public RegistrationForm()
        {
            InitializeComponent();

            if (File.Exists(dataPath))
            {
                registration = Registration.LoadData(dataPath);
            }
        }

        private void entryLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void hideButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void registrationButton_Click(object sender, EventArgs e)
        {
            // Перевірка на заповненість усіх полів
            if (string.IsNullOrEmpty(nameTextBox.Text) || string.IsNullOrEmpty(loginTextBox.Text) ||
                string.IsNullOrEmpty(mailTextBox.Text) || string.IsNullOrEmpty(passwordTextBox.Text))
            {
                MessageBox.Show("Будь ласка, заповніть всі поля.");
                return;
            }

            try
            {
                var mailAddress = new System.Net.Mail.MailAddress(mailTextBox.Text);
            }
            catch
            {
                MessageBox.Show("Будь ласка, введіть дійсну електронну адресу.");
                return;
            }

            if (passwordTextBox.Text.Length < 3 || loginTextBox.Text.Length < 3)
            {
                MessageBox.Show("Логін та пароль повинні містити принаймні 3 символи.");
                return;
            }

            if (registration.Users.Any(u => u.Login == loginTextBox.Text))
            {
                MessageBox.Show("Користувач з таким логіном вже існує. Будь ласка, оберіть інший логін.");
                return;
            }

            User newUser = new User
            {
                Name = nameTextBox.Text,
                Login = loginTextBox.Text,
                Mail = mailTextBox.Text,
                Password = passwordTextBox.Text
            };

            registration.Users.Add(newUser);
            registration.SaveData(dataPath);

            MessageBox.Show("Реєстрація пройшла успішно.");

            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }
    }
}
