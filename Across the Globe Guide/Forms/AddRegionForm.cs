using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Across_the_Globe_Guide.Forms
{
    public partial class AddRegionForm : Form
    {
        public Models.Region NewRegion { get; private set; }

        public AddRegionForm()
        {
            InitializeComponent();
            NewRegion = new Models.Region();

        }

        private void okButton_Click(object sender, EventArgs e)
        {

            var region = new Models.Region
            {
                Capital = capitalTextBox.Text,
                Country = countryTextBox.Text,
                Continent = textBoxContinent.Text,
                Info = infoTextBox.Text,
                Area = double.Parse(textBoxArea.Text),
                Population = int.Parse(textBoxPopulation.Text),
                Currency = currencyTextBox.Text,
                President = presidentTextBox.Text,
                Politic = politicTextBox.Text,
                Age = double.Parse(ageTextBox.Text),
                Work = double.Parse(workTextBox.Text),
                Product = double.Parse(productTextBox.Text),
                Language = languageTextBox.Text,
                ImagePath = pictureBox1.ImageLocation
            };

            NewRegion = region;
        }

        // Валідація 
        private void countryTextBox_Validating(object sender, CancelEventArgs e)
        {
            string text = countryTextBox.Text.Trim();

            if (text.Length == 0)
            {
                title1ErrorLabel.Visible = true;
                MessageBox.Show("Поле 'Країна' не може бути порожнім.");
                e.Cancel = true;
            }
            else if (text.Any(char.IsDigit))
            {
                title1ErrorLabel.Visible = true;
                MessageBox.Show("Поле 'Країна' не може містити чисел.");
                e.Cancel = true;
            }
            else
            {
                title1ErrorLabel.Visible = false;
            }
        }

        private void capitalTextBox_Validating(object sender, CancelEventArgs e)
        {
            string text = capitalTextBox.Text.Trim();

            if (capitalTextBox.Text.Trim().Length == 0)
            {
                title5ErrorLabel.Visible = true;
                MessageBox.Show("Поле 'Столиця' не може бути порожнім.");
                e.Cancel = true;
            }
            else if (text.Any(char.IsDigit))
            {
                title5ErrorLabel.Visible = true;
                MessageBox.Show("Поле 'Столиця' не може містити чисел.");
                e.Cancel = true;
            }
            else
            {
                title5ErrorLabel.Visible = false;
            }
        }

        private void textBoxContinent_Validating(object sender, CancelEventArgs e)
        {
            string text = capitalTextBox.Text.Trim();

            if (textBoxContinent.Text.Trim().Length == 0)
            {
                title2ErrorLabel.Visible = true;
                MessageBox.Show("Поле 'Континент' не може бути порожнім.");
                e.Cancel = true;
            }
            else if (text.Any(char.IsDigit))
            {
                title2ErrorLabel.Visible = true;
                MessageBox.Show("Поле 'Континент' не може містити чисел.");
                e.Cancel = true;
            }
            else
            {
                title2ErrorLabel.Visible = false;
            }
        }

        private void textBoxArea_Validating(object sender, CancelEventArgs e)
        {
            if (!double.TryParse(textBoxArea.Text, out double area) || area <= 0.44 || area >= 17125191)
            {
                title7ErrorLabel.Visible = true;
                MessageBox.Show("Площа повинна бути числом від 0.44 до 17125191.");
                e.Cancel = true;
            }
            else
            {
                title7ErrorLabel.Visible = false;
            }
        }

        private void textBoxPopulation_Validating(object sender, CancelEventArgs e)
        {
            if (!int.TryParse(textBoxPopulation.Text, out int population) || population < 0)
            {
                title3ErrorLabel.Visible = true;
                MessageBox.Show("Населення повинно бути не від'ємним числом.");
                e.Cancel = true;
            }
            else
            {
                title3ErrorLabel.Visible = false;
            }
        }

        private void workTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (!double.TryParse(workTextBox.Text, out double work) || work <= 0)
            {
                title4ErrorLabel.Visible = true;
                MessageBox.Show("Значення в полі 'Рівень безробіття' повинне бути більше нуля.");
                e.Cancel = true;
            }
            else
            {
                title4ErrorLabel.Visible = false;
            }
        }

        private void productTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (!int.TryParse(productTextBox.Text, out int value))
            {
                title6ErrorLabel.Visible = true;
                MessageBox.Show("Будь ласка, введіть числове значення.");
                e.Cancel = true;
                return;
            }

            if (value < 0)
            {
                title6ErrorLabel.Visible = true;
                MessageBox.Show("Значення повинно бути не менше 0.");
                e.Cancel = true;
                return;
            }
            else
            {
                title6ErrorLabel.Visible = false;
            }
        }

        private void presidentTextBox_Validating(object sender, CancelEventArgs e)
        {
            string text = presidentTextBox.Text.Trim();

            if (presidentTextBox.Text.Trim().Length == 0)
            {
                title8ErrorLabel.Visible = true;
                MessageBox.Show("Поле 'Голова держави' не може бути порожнім.");
                e.Cancel = true;
            }
            else if (text.Any(char.IsDigit))
            {
                title8ErrorLabel.Visible = true;
                MessageBox.Show("Поле 'Голова держави' не може містити чисел.");
                e.Cancel = true;
            }
            else
            {
                title8ErrorLabel.Visible = false;
            }
        }

        private void ageTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (!double.TryParse(ageTextBox.Text, out double age) || age < 0 || age > 100)
            {
                title9ErrorLabel.Visible = true;
                MessageBox.Show("Значення в полі 'Середній вік' повинне бути числом від 0 до 100.");
                e.Cancel = true;
            }
            else
            {
                title9ErrorLabel.Visible = false;
            }
        }

        private void languageTextBox_Validating(object sender, CancelEventArgs e)
        {
            string text = presidentTextBox.Text.Trim();

            if (languageTextBox.Text.Trim().Length == 0)
            {
                title10ErrorLabel.Visible = true;
                MessageBox.Show("Поле 'Мова' не може бути порожнім.");
                e.Cancel = true;
            }
            else if (text.Any(char.IsDigit))
            {
                title10ErrorLabel.Visible = true;
                MessageBox.Show("Поле 'Мова' не може містити чисел.");
                e.Cancel = true;
            }
            else
            {
                title10ErrorLabel.Visible = false;
            }
        }

        private void currencyTextBox_Validating(object sender, CancelEventArgs e)
        {
            string text = presidentTextBox.Text.Trim();

            if (currencyTextBox.Text.Trim().Length == 0)
            {
                title11ErrorLabel.Visible = true;
                MessageBox.Show("Поле 'Валюта' не може бути порожнім.");
                e.Cancel = true;
            }
            else if (text.Any(char.IsDigit))
            {
                title11ErrorLabel.Visible = true;
                MessageBox.Show("Поле 'Валюта' не може містити чисел.");
                e.Cancel = true;
            }
            else
            {
                title11ErrorLabel.Visible = false;
            }
        }

        private void politicTextBox_Validating(object sender, CancelEventArgs e)
        {
            string text = presidentTextBox.Text.Trim();

            if (politicTextBox.Text.Trim().Length == 0)
            {
                title12ErrorLabel.Visible = true;
                MessageBox.Show("Поле 'Форма правління' не може бути порожнім.");
                e.Cancel = true;
            }
            else if (text.Any(char.IsDigit))
            {
                title12ErrorLabel.Visible = true;
                MessageBox.Show("Поле 'Форма правління' не може містити чисел.");
                e.Cancel = true;
            }
            else
            {
                title12ErrorLabel.Visible = false;
            }
        }

        private void infoTextBox_Validated(object sender, EventArgs e)
        {
            string[] words = infoTextBox.Text.Split(new char[] { ' ', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

            if (words.Length > 50)
            {
                MessageBox.Show("Текст повинен містити не більше 50 слів.");

            }
        }

        //Додавання зображення
        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {

                    string sourceFilePath = openFileDialog.FileName;
                    string fileName = Path.GetFileName(sourceFilePath);
                    string destFilePath = Path.Combine(Application.StartupPath, "Flag", fileName);

                    Directory.CreateDirectory(Path.Combine(Application.StartupPath, "Flag"));


                    File.Copy(sourceFilePath, destFilePath, true);


                    pictureBox1.ImageLocation = destFilePath;

                    NewRegion.ImagePath = destFilePath;
                }
            }
        }

        
    }
}