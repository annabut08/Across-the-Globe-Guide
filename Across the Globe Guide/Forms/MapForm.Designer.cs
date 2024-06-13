namespace Across_the_Globe_Guide.Forms
{
    partial class MapForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MapForm));
            gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            panel1 = new Panel();
            saveButton = new Button();
            error2Label = new Label();
            error1Label = new Label();
            label3 = new Label();
            removeBtn = new Button();
            btnLoadMap = new Button();
            lattitudeTextBox = new TextBox();
            longitudeTextBox = new TextBox();
            label2 = new Label();
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            hintToolStripMenuItem = new ToolStripMenuItem();
            coordinateToolStripMenuItem = new ToolStripMenuItem();
            mainpageToolStripMenuItem = new ToolStripMenuItem();
            panel1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // gMapControl1
            // 
            gMapControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gMapControl1.Bearing = 0F;
            gMapControl1.CanDragMap = true;
            gMapControl1.EmptyTileColor = Color.Navy;
            gMapControl1.GrayScaleMode = false;
            gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            gMapControl1.LevelsKeepInMemory = 5;
            gMapControl1.Location = new Point(12, 59);
            gMapControl1.MarkersEnabled = true;
            gMapControl1.MaxZoom = 2;
            gMapControl1.MinZoom = 2;
            gMapControl1.MouseWheelZoomEnabled = true;
            gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            gMapControl1.Name = "gMapControl1";
            gMapControl1.NegativeMode = false;
            gMapControl1.PolygonsEnabled = true;
            gMapControl1.RetryLoadTile = 0;
            gMapControl1.RoutesEnabled = true;
            gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            gMapControl1.SelectedAreaFillColor = Color.FromArgb(33, 65, 105, 225);
            gMapControl1.ShowTileGridLines = false;
            gMapControl1.Size = new Size(457, 451);
            gMapControl1.TabIndex = 0;
            gMapControl1.Zoom = 0D;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel1.Controls.Add(saveButton);
            panel1.Controls.Add(error2Label);
            panel1.Controls.Add(error1Label);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(removeBtn);
            panel1.Controls.Add(btnLoadMap);
            panel1.Controls.Add(lattitudeTextBox);
            panel1.Controls.Add(longitudeTextBox);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(475, 59);
            panel1.Name = "panel1";
            panel1.Size = new Size(412, 451);
            panel1.TabIndex = 1;
            // 
            // saveButton
            // 
            saveButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            saveButton.BackColor = Color.Silver;
            saveButton.FlatStyle = FlatStyle.Flat;
            saveButton.Font = new Font("Courier New", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            saveButton.Location = new Point(102, 413);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(146, 35);
            saveButton.TabIndex = 8;
            saveButton.Text = "Зберегти";
            saveButton.UseVisualStyleBackColor = false;
            saveButton.Click += saveButton_Click;
            // 
            // error2Label
            // 
            error2Label.AutoSize = true;
            error2Label.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            error2Label.ForeColor = Color.Red;
            error2Label.Location = new Point(388, 100);
            error2Label.Name = "error2Label";
            error2Label.Size = new Size(21, 28);
            error2Label.TabIndex = 7;
            error2Label.Text = "*";
            error2Label.Visible = false;
            // 
            // error1Label
            // 
            error1Label.AutoSize = true;
            error1Label.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            error1Label.ForeColor = Color.Red;
            error1Label.Location = new Point(388, 46);
            error1Label.Name = "error1Label";
            error1Label.Size = new Size(21, 28);
            error1Label.TabIndex = 7;
            error1Label.Text = "*";
            error1Label.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Courier New", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.Location = new Point(102, 12);
            label3.Name = "label3";
            label3.Size = new Size(201, 31);
            label3.TabIndex = 6;
            label3.Text = "Координати ";
            // 
            // removeBtn
            // 
            removeBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            removeBtn.BackColor = Color.LightCoral;
            removeBtn.FlatStyle = FlatStyle.Flat;
            removeBtn.Font = new Font("Courier New", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            removeBtn.Location = new Point(254, 413);
            removeBtn.Name = "removeBtn";
            removeBtn.Size = new Size(155, 35);
            removeBtn.TabIndex = 3;
            removeBtn.Text = "Очистити";
            removeBtn.UseVisualStyleBackColor = false;
            removeBtn.Click += removeBtn_Click;
            // 
            // btnLoadMap
            // 
            btnLoadMap.BackColor = Color.PaleGreen;
            btnLoadMap.Cursor = Cursors.Hand;
            btnLoadMap.FlatStyle = FlatStyle.Flat;
            btnLoadMap.Font = new Font("Courier New", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnLoadMap.Location = new Point(75, 178);
            btnLoadMap.Name = "btnLoadMap";
            btnLoadMap.Size = new Size(247, 64);
            btnLoadMap.TabIndex = 2;
            btnLoadMap.Text = "Завантажити на мапі\r\n";
            btnLoadMap.UseVisualStyleBackColor = false;
            btnLoadMap.Click += btnLoadMap_Click;
            // 
            // lattitudeTextBox
            // 
            lattitudeTextBox.BorderStyle = BorderStyle.FixedSingle;
            lattitudeTextBox.Font = new Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lattitudeTextBox.Location = new Point(248, 113);
            lattitudeTextBox.Multiline = true;
            lattitudeTextBox.Name = "lattitudeTextBox";
            lattitudeTextBox.Size = new Size(134, 45);
            lattitudeTextBox.TabIndex = 1;
            lattitudeTextBox.Validating += lattitudeTextBox_Validating;
            // 
            // longitudeTextBox
            // 
            longitudeTextBox.BorderStyle = BorderStyle.FixedSingle;
            longitudeTextBox.Font = new Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            longitudeTextBox.Location = new Point(248, 50);
            longitudeTextBox.Multiline = true;
            longitudeTextBox.Name = "longitudeTextBox";
            longitudeTextBox.Size = new Size(134, 45);
            longitudeTextBox.TabIndex = 1;
            longitudeTextBox.Validating += longitudeTextBox_Validating;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(16, 115);
            label2.Name = "label2";
            label2.Size = new Size(214, 22);
            label2.TabIndex = 0;
            label2.Text = "Latitude (широта)";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(16, 52);
            label1.Name = "label1";
            label1.Size = new Size(238, 22);
            label1.TabIndex = 0;
            label1.Text = "Longitude (довгота)";
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.PaleGreen;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { hintToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(890, 56);
            menuStrip1.TabIndex = 7;
            menuStrip1.Text = "menuStrip1";
            // 
            // hintToolStripMenuItem
            // 
            hintToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { coordinateToolStripMenuItem, mainpageToolStripMenuItem });
            hintToolStripMenuItem.Font = new Font("Courier New", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            hintToolStripMenuItem.Image = Properties.Resources._3148068_bot_droid_gears_robot_icon;
            hintToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            hintToolStripMenuItem.Name = "hintToolStripMenuItem";
            hintToolStripMenuItem.Size = new Size(186, 52);
            hintToolStripMenuItem.Text = "Підказка";
            // 
            // coordinateToolStripMenuItem
            // 
            coordinateToolStripMenuItem.Font = new Font("Courier New", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            coordinateToolStripMenuItem.Image = Properties.Resources._4698575_building_business_finance_office_icon__1_;
            coordinateToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            coordinateToolStripMenuItem.Name = "coordinateToolStripMenuItem";
            coordinateToolStripMenuItem.Size = new Size(350, 54);
            coordinateToolStripMenuItem.Text = "Координати міст";
            coordinateToolStripMenuItem.Click += coordinateToolStripMenuItem_Click;
            // 
            // mainpageToolStripMenuItem
            // 
            mainpageToolStripMenuItem.Name = "mainpageToolStripMenuItem";
            mainpageToolStripMenuItem.Size = new Size(350, 54);
            mainpageToolStripMenuItem.Text = "Головна сторінка";
            mainpageToolStripMenuItem.Click += mainpageToolStripMenuItem_Click;
            // 
            // MapForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            ClientSize = new Size(890, 522);
            Controls.Add(panel1);
            Controls.Add(gMapControl1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MinimumSize = new Size(908, 497);
            Name = "MapForm";
            Text = "Across the Globe Guide";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private Panel panel1;
        private Button btnLoadMap;
        private TextBox lattitudeTextBox;
        private TextBox longitudeTextBox;
        private Label label2;
        private Label label1;
        private Button removeBtn;
        private Label label3;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem hintToolStripMenuItem;
        private ToolStripMenuItem coordinateToolStripMenuItem;
        private Label error2Label;
        private Label error1Label;
        private Button saveButton;
        private ToolStripMenuItem mainpageToolStripMenuItem;
    }
}