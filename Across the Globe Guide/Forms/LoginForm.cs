using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Across_the_Globe_Guide.Models;
using System.Text.Json;
using Newtonsoft.Json;

namespace Across_the_Globe_Guide
{
    public partial class LoginForm : Form
    {
        bool drag = false;
        Point start_point = new Point(0, 0);
        public LoginForm()
        {
            InitializeComponent();
        }


        private void registerLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistrationForm registerForm = new RegistrationForm();
            registerForm.Show();
        }


        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void hideButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void closePanel_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            start_point = new Point(e.X, e.Y);
        }

        private void closePanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - start_point.X, p.Y - start_point.Y);
            }
        }

        private void closePanel_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void programLabel_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - start_point.X, p.Y - start_point.Y);
            }
        }

        private void programLabel_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void programLabel_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            start_point = new Point(e.X, e.Y);
        }

        private void entryButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(loginBox.Text) || string.IsNullOrEmpty(passwordBox.Text))
                {
                    MessageBox.Show("Будь ласка, введіть логін та пароль.");
                    return;
                }

                string userFilePath = Path.Combine(Application.StartupPath, "users.txt");

                if (!File.Exists(userFilePath))
                {
                    MessageBox.Show("Файл з даними користувачів не знайдено.");
                    return;
                }

                Registration registration;
                try
                {
                    string json = File.ReadAllText(userFilePath);
                    registration = JsonConvert.DeserializeObject<Registration>(json);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Помилка при читанні файлу користувача: {ex.Message}");
                    return;
                }

                var user = registration.Users.FirstOrDefault(u => u.Login == loginBox.Text && u.Password == passwordBox.Text);

                if (user == null)
                {
                    MessageBox.Show("Невірний логін або пароль.");
                    return;
                }

                MessageBox.Show("Вхід успішний.");
                Hide();
                MainForm mainForm = new MainForm();
                mainForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Сталася помилка: {ex.Message}");
            }
        }
    }
}
