using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using GMap.NET.MapProviders;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using Across_the_Globe_Guide.Models;


namespace Across_the_Globe_Guide.Forms
{
    public partial class MapForm : Form
    {
        private GMapOverlay markersOverlay;
        private GMapOverlay kyivOverlay;

        private Map map = new Map();
        const string PATH_TO_DATA = ".\\markers.txt";
        private List<Coordinate> coordinates = new List<Coordinate>();



        public MapForm()
        {
            InitializeComponent();
            gMapControl1.MouseDoubleClick += new MouseEventHandler(gMapControl1_MouseDoubleClick);

        }

        private void btnLoadMap_Click(object sender, EventArgs e)
        {

            double lat;
            double lng;

            if (string.IsNullOrWhiteSpace(lattitudeTextBox.Text) || string.IsNullOrWhiteSpace(longitudeTextBox.Text))
            {
                // Якщо координати не введені, встановлюємо центр на Київ
                lat = 50.4501;
                lng = 30.5234;
            }
            else
            {
                lat = Convert.ToDouble(lattitudeTextBox.Text);
                lng = Convert.ToDouble(longitudeTextBox.Text);
            }

            gMapControl1.ShowCenter = false;
            gMapControl1.MapProvider = GMapProviders.GoogleMap;
            gMapControl1.DragButton = MouseButtons.Left;

            gMapControl1.Position = new PointLatLng(lat, lng);
            gMapControl1.MinZoom = 5;
            gMapControl1.MaxZoom = 200;
            gMapControl1.Zoom = 15;

            if (markersOverlay == null)
            {
                markersOverlay = new GMapOverlay("markers");
                gMapControl1.Overlays.Add(markersOverlay);
            }

            if (kyivOverlay == null)
            {
                kyivOverlay = new GMapOverlay("Kyiv");

                double kievLat = 50.4501;
                double kievLng = 30.5234;
                PointLatLng pointKyiv = new PointLatLng(kievLat, kievLng);

                string imagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Markers", "ukraine_icon.png");
                Bitmap markImgKyiv;
                try
                {
                    markImgKyiv = (Bitmap)Image.FromFile(imagePath);
                }
                catch (FileNotFoundException ex)
                {
                    MessageBox.Show("Зображення не знайдено: " + ex.Message);
                    return;
                }

                GMapMarker mrkKyiv = new GMarkerGoogle(pointKyiv, markImgKyiv);
                mrkKyiv.ToolTipText = "Столиця України";
                kyivOverlay.Markers.Add(mrkKyiv);

                gMapControl1.Overlays.Add(kyivOverlay);
            }

            // Очищення попередніх маркерів
            markersOverlay.Markers.Clear();

            // Додавання маркера на вибрану точку
            PointLatLng point = new PointLatLng(lat, lng);
            GMapMarker marker = new GMarkerGoogle(point, GMarkerGoogleType.red_pushpin);
            markersOverlay.Markers.Add(marker);

            gMapControl1.Refresh();
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            if (markersOverlay != null)
            {
                markersOverlay.Markers.Clear();
                gMapControl1.Refresh();
            }

            coordinates.Clear();
        }

        private void longitudeTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (!double.TryParse(longitudeTextBox.Text, out double longitude) || longitude < -180 || longitude > 180)
            {
                error1Label.Visible = true;
                MessageBox.Show("Довгота повинна бути числом від -180 до 180. Значення повинні вводитися через кому");
            }
            else
            {
                error1Label.Visible = false;
            }
        }

        private void lattitudeTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (!double.TryParse(lattitudeTextBox.Text, out double latitude) || latitude < -90 || latitude > 90)
            {
                error2Label.Visible = true;
                MessageBox.Show("Широта повинна бути числом від -90 до 90. Значення повинні вводитися через кому.", "Помилка");
            }
            else
            {
                error2Label.Visible = false;
            }
        }

        private void coordinateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var coordinateForm = new CoordinateForm();
            coordinateForm.Show();
        }

        // Збереження координат разом з назвами у файл
        private void saveButton_Click(object sender, EventArgs e)
        {
            if (map.Coordinates.Count == 0)
            {
                MessageBox.Show("Немає координат для збереження.", "Увага");
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog.FileName = PATH_TO_DATA;
            saveFileDialog.Title = "Зберегти файли з координатами";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                try
                {
                    map.SaveData(filePath);
                    MessageBox.Show("Координати успішно збережено.", "Інформація");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Помилка");
                }
            }
        }

        private void gMapControl1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                PointLatLng point = gMapControl1.FromLocalToLatLng(e.X, e.Y);

                string placeName = Microsoft.VisualBasic.Interaction.InputBox("Введіть назву місця:", "Назва місця", "");

                if (string.IsNullOrWhiteSpace(placeName))
                {
                    MessageBox.Show("Будь ласка, введіть назву місця.", "Помилка");
                    return;
                }

                lattitudeTextBox.Text = point.Lat.ToString();
                longitudeTextBox.Text = point.Lng.ToString();

                GMapMarker marker = new GMarkerGoogle(point, GMarkerGoogleType.red_pushpin)
                {
                    ToolTipText = placeName
                };
                markersOverlay.Markers.Add(marker);

                map.Coordinates.Add(new Coordinate { Latitude = point.Lat, Longitude = point.Lng, PlaceName = placeName });

                gMapControl1.Refresh();
            }
        }

        private void mainpageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var mainForm = new MainForm();
            mainForm.Show();
            this.Close();
        }
    }
}
