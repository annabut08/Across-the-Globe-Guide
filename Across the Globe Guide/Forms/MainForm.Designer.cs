namespace Across_the_Globe_Guide
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            panel2 = new Panel();
            label5 = new Label();
            countrytextBox = new TextBox();
            dataGridView = new DataGridView();
            countryDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            capitalDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            regionBindingSource = new BindingSource(components);
            searchBtn = new Button();
            InfoTextBox = new TextBox();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator = new ToolStripSeparator();
            saveToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            loadToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            exitToolStripMenuItem = new ToolStripMenuItem();
            материкиToolStripMenuItem = new ToolStripMenuItem();
            mapToolStripMenuItem = new ToolStripMenuItem();
            toolsToolStripMenuItem = new ToolStripMenuItem();
            aboutProgramToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            productTextBox = new TextBox();
            ageTextBox = new TextBox();
            panel7 = new Panel();
            label12 = new Label();
            panel10 = new Panel();
            continentTextBox = new TextBox();
            label14 = new Label();
            textBox1 = new TextBox();
            label10 = new Label();
            areaTextBox = new TextBox();
            capitaltextBox = new TextBox();
            countryTextBox1 = new TextBox();
            languageTextBox = new TextBox();
            panel9 = new Panel();
            label11 = new Label();
            pictureBox1 = new PictureBox();
            currencyTextBox = new TextBox();
            presidentTextBox = new TextBox();
            label6 = new Label();
            label3 = new Label();
            label2 = new Label();
            label9 = new Label();
            label13 = new Label();
            workTextBox = new TextBox();
            label7 = new Label();
            label8 = new Label();
            politicTextBox = new TextBox();
            panel4 = new Panel();
            label1 = new Label();
            panel8 = new Panel();
            label4 = new Label();
            panel6 = new Panel();
            addButton = new Button();
            deleteButton = new Button();
            mainPanel = new Panel();
            panel3 = new Panel();
            saveButton = new Button();
            toolTip1 = new ToolTip(components);
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)regionBindingSource).BeginInit();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            panel7.SuspendLayout();
            panel10.SuspendLayout();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel4.SuspendLayout();
            panel8.SuspendLayout();
            mainPanel.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(label5);
            panel2.Controls.Add(countrytextBox);
            panel2.Controls.Add(dataGridView);
            panel2.Controls.Add(searchBtn);
            panel2.Controls.Add(InfoTextBox);
            panel2.Location = new Point(12, 59);
            panel2.Name = "panel2";
            panel2.Size = new Size(597, 637);
            panel2.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Courier New", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label5.Location = new Point(3, 6);
            label5.Name = "label5";
            label5.Size = new Size(82, 27);
            label5.TabIndex = 11;
            label5.Text = "Пошук";
            // 
            // countrytextBox
            // 
            countrytextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            countrytextBox.BorderStyle = BorderStyle.FixedSingle;
            countrytextBox.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            countrytextBox.HideSelection = false;
            countrytextBox.Location = new Point(3, 33);
            countrytextBox.Multiline = true;
            countrytextBox.Name = "countrytextBox";
            countrytextBox.Size = new Size(436, 40);
            countrytextBox.TabIndex = 10;
            // 
            // dataGridView
            // 
            dataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView.AutoGenerateColumns = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { countryDataGridViewTextBoxColumn, capitalDataGridViewTextBoxColumn });
            dataGridView.DataSource = regionBindingSource;
            dataGridView.Location = new Point(3, 77);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(591, 384);
            dataGridView.TabIndex = 9;
            dataGridView.SelectionChanged += dataGridView_SelectionChanged;
            dataGridView.DoubleClick += dataGridView_DoubleClick_1;
            // 
            // countryDataGridViewTextBoxColumn
            // 
            countryDataGridViewTextBoxColumn.DataPropertyName = "Country";
            countryDataGridViewTextBoxColumn.HeaderText = "Країна";
            countryDataGridViewTextBoxColumn.MinimumWidth = 6;
            countryDataGridViewTextBoxColumn.Name = "countryDataGridViewTextBoxColumn";
            // 
            // capitalDataGridViewTextBoxColumn
            // 
            capitalDataGridViewTextBoxColumn.DataPropertyName = "Capital";
            capitalDataGridViewTextBoxColumn.HeaderText = "Столиця";
            capitalDataGridViewTextBoxColumn.MinimumWidth = 6;
            capitalDataGridViewTextBoxColumn.Name = "capitalDataGridViewTextBoxColumn";
            // 
            // regionBindingSource
            // 
            regionBindingSource.DataSource = typeof(Models.Region);
            // 
            // searchBtn
            // 
            searchBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            searchBtn.AutoSize = true;
            searchBtn.BackColor = Color.Yellow;
            searchBtn.Cursor = Cursors.Hand;
            searchBtn.FlatStyle = FlatStyle.Flat;
            searchBtn.Font = new Font("Courier New", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            searchBtn.Location = new Point(445, 33);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(149, 40);
            searchBtn.TabIndex = 3;
            searchBtn.Text = "Знайти";
            searchBtn.UseVisualStyleBackColor = false;
            searchBtn.Click += searchBtn_Click;
            // 
            // InfoTextBox
            // 
            InfoTextBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            InfoTextBox.BackColor = Color.Honeydew;
            InfoTextBox.BorderStyle = BorderStyle.FixedSingle;
            InfoTextBox.DataBindings.Add(new Binding("Text", regionBindingSource, "Info", true));
            InfoTextBox.Font = new Font("Courier New", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            InfoTextBox.Location = new Point(3, 467);
            InfoTextBox.Multiline = true;
            InfoTextBox.Name = "InfoTextBox";
            InfoTextBox.ReadOnly = true;
            InfoTextBox.ScrollBars = ScrollBars.Vertical;
            InfoTextBox.Size = new Size(591, 167);
            InfoTextBox.TabIndex = 12;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.PaleGreen;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, материкиToolStripMenuItem, toolsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1329, 56);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.BackColor = Color.PaleGreen;
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripSeparator, saveToolStripMenuItem, toolStripSeparator1, loadToolStripMenuItem, toolStripSeparator2, exitToolStripMenuItem });
            fileToolStripMenuItem.Font = new Font("Courier New", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            fileToolStripMenuItem.ForeColor = Color.Black;
            fileToolStripMenuItem.Image = (Image)resources.GetObject("fileToolStripMenuItem.Image");
            fileToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(130, 52);
            fileToolStripMenuItem.Text = "Файл";
            // 
            // toolStripSeparator
            // 
            toolStripSeparator.Name = "toolStripSeparator";
            toolStripSeparator.Size = new Size(331, 6);
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Image = (Image)resources.GetObject("saveToolStripMenuItem.Image");
            saveToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            saveToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            saveToolStripMenuItem.Size = new Size(334, 54);
            saveToolStripMenuItem.Text = "Зберегти";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(331, 6);
            // 
            // loadToolStripMenuItem
            // 
            loadToolStripMenuItem.Image = (Image)resources.GetObject("loadToolStripMenuItem.Image");
            loadToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            loadToolStripMenuItem.Size = new Size(334, 54);
            loadToolStripMenuItem.Text = "Завантажити";
            loadToolStripMenuItem.Click += loadToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(331, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Image = (Image)resources.GetObject("exitToolStripMenuItem.Image");
            exitToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(334, 54);
            exitToolStripMenuItem.Text = "Вихід";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // материкиToolStripMenuItem
            // 
            материкиToolStripMenuItem.BackColor = Color.PaleGreen;
            материкиToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mapToolStripMenuItem });
            материкиToolStripMenuItem.Font = new Font("Courier New", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            материкиToolStripMenuItem.Image = (Image)resources.GetObject("материкиToolStripMenuItem.Image");
            материкиToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            материкиToolStripMenuItem.Name = "материкиToolStripMenuItem";
            материкиToolStripMenuItem.Size = new Size(186, 52);
            материкиToolStripMenuItem.Text = "Материки";
            // 
            // mapToolStripMenuItem
            // 
            mapToolStripMenuItem.Image = (Image)resources.GetObject("mapToolStripMenuItem.Image");
            mapToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            mapToolStripMenuItem.Name = "mapToolStripMenuItem";
            mapToolStripMenuItem.Size = new Size(252, 54);
            mapToolStripMenuItem.Text = "Мапа";
            mapToolStripMenuItem.Click += mapToolStripMenuItem_Click_1;
            // 
            // toolsToolStripMenuItem
            // 
            toolsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutProgramToolStripMenuItem });
            toolsToolStripMenuItem.Font = new Font("Courier New", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            toolsToolStripMenuItem.Image = (Image)resources.GetObject("toolsToolStripMenuItem.Image");
            toolsToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            toolsToolStripMenuItem.Size = new Size(186, 52);
            toolsToolStripMenuItem.Text = "Допомога";
            // 
            // aboutProgramToolStripMenuItem
            // 
            aboutProgramToolStripMenuItem.Image = Properties.Resources._4698581_find_info_information_magnifier_search_icon;
            aboutProgramToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            aboutProgramToolStripMenuItem.Name = "aboutProgramToolStripMenuItem";
            aboutProgramToolStripMenuItem.Size = new Size(294, 54);
            aboutProgramToolStripMenuItem.Text = "Про програму";
            aboutProgramToolStripMenuItem.Click += aboutProgramToolStripMenuItem_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(productTextBox);
            panel1.Controls.Add(ageTextBox);
            panel1.Controls.Add(panel7);
            panel1.Controls.Add(panel10);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(areaTextBox);
            panel1.Controls.Add(capitaltextBox);
            panel1.Controls.Add(countryTextBox1);
            panel1.Controls.Add(languageTextBox);
            panel1.Controls.Add(panel9);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(currencyTextBox);
            panel1.Controls.Add(presidentTextBox);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(workTextBox);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(politicTextBox);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel8);
            panel1.Controls.Add(panel6);
            panel1.Location = new Point(615, 59);
            panel1.Name = "panel1";
            panel1.Size = new Size(721, 661);
            panel1.TabIndex = 9;
            // 
            // productTextBox
            // 
            productTextBox.BackColor = Color.FromArgb(218, 245, 218);
            productTextBox.BorderStyle = BorderStyle.None;
            productTextBox.DataBindings.Add(new Binding("Text", regionBindingSource, "Product", true));
            productTextBox.Font = new Font("Courier New", 13.8F);
            productTextBox.Location = new Point(249, 485);
            productTextBox.Multiline = true;
            productTextBox.Name = "productTextBox";
            productTextBox.Size = new Size(428, 45);
            productTextBox.TabIndex = 18;
            // 
            // ageTextBox
            // 
            ageTextBox.BackColor = Color.FromArgb(218, 245, 218);
            ageTextBox.BorderStyle = BorderStyle.None;
            ageTextBox.DataBindings.Add(new Binding("Text", regionBindingSource, "Age", true));
            ageTextBox.Font = new Font("Courier New", 13.8F);
            ageTextBox.Location = new Point(249, 383);
            ageTextBox.Multiline = true;
            ageTextBox.Name = "ageTextBox";
            ageTextBox.Size = new Size(428, 45);
            ageTextBox.TabIndex = 19;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(218, 245, 218);
            panel7.Controls.Add(label12);
            panel7.Location = new Point(0, 381);
            panel7.Name = "panel7";
            panel7.Size = new Size(718, 50);
            panel7.TabIndex = 27;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.FromArgb(218, 245, 218);
            label12.Font = new Font("Courier New", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label12.Location = new Point(7, 2);
            label12.Name = "label12";
            label12.Size = new Size(180, 27);
            label12.TabIndex = 5;
            label12.Text = "Середній вік";
            // 
            // panel10
            // 
            panel10.BackColor = Color.FromArgb(218, 245, 218);
            panel10.Controls.Add(continentTextBox);
            panel10.Controls.Add(label14);
            panel10.Location = new Point(0, 587);
            panel10.Name = "panel10";
            panel10.Size = new Size(721, 50);
            panel10.TabIndex = 27;
            // 
            // continentTextBox
            // 
            continentTextBox.BackColor = Color.FromArgb(218, 245, 218);
            continentTextBox.BorderStyle = BorderStyle.None;
            continentTextBox.DataBindings.Add(new Binding("Text", regionBindingSource, "Continent", true));
            continentTextBox.Font = new Font("Courier New", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            continentTextBox.Location = new Point(249, 2);
            continentTextBox.Multiline = true;
            continentTextBox.Name = "continentTextBox";
            continentTextBox.Size = new Size(429, 45);
            continentTextBox.TabIndex = 28;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.FromArgb(218, 245, 218);
            label14.Font = new Font("Courier New", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label14.Location = new Point(7, 2);
            label14.Name = "label14";
            label14.Size = new Size(124, 27);
            label14.TabIndex = 5;
            label14.Text = "Континет";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(218, 245, 218);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.DataBindings.Add(new Binding("Text", regionBindingSource, "Population", true));
            textBox1.Font = new Font("Courier New", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox1.Location = new Point(249, 179);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(257, 45);
            textBox1.TabIndex = 26;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Courier New", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label10.Location = new Point(7, 534);
            label10.Name = "label10";
            label10.Size = new Size(96, 27);
            label10.TabIndex = 5;
            label10.Text = "Валюта";
            // 
            // areaTextBox
            // 
            areaTextBox.BackColor = Color.Honeydew;
            areaTextBox.BorderStyle = BorderStyle.None;
            areaTextBox.DataBindings.Add(new Binding("Text", regionBindingSource, "Area", true));
            areaTextBox.Font = new Font("Courier New", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            areaTextBox.Location = new Point(249, 128);
            areaTextBox.Multiline = true;
            areaTextBox.Name = "areaTextBox";
            areaTextBox.Size = new Size(197, 45);
            areaTextBox.TabIndex = 25;
            // 
            // capitaltextBox
            // 
            capitaltextBox.BackColor = Color.FromArgb(218, 245, 218);
            capitaltextBox.BorderStyle = BorderStyle.None;
            capitaltextBox.DataBindings.Add(new Binding("Text", regionBindingSource, "Capital", true));
            capitaltextBox.Font = new Font("Courier New", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            capitaltextBox.Location = new Point(249, 77);
            capitaltextBox.Multiline = true;
            capitaltextBox.Name = "capitaltextBox";
            capitaltextBox.Size = new Size(257, 42);
            capitaltextBox.TabIndex = 24;
            // 
            // countryTextBox1
            // 
            countryTextBox1.BackColor = Color.Honeydew;
            countryTextBox1.BorderStyle = BorderStyle.None;
            countryTextBox1.DataBindings.Add(new Binding("Text", regionBindingSource, "Country", true));
            countryTextBox1.Font = new Font("Courier New", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 204);
            countryTextBox1.Location = new Point(116, 18);
            countryTextBox1.Multiline = true;
            countryTextBox1.Name = "countryTextBox1";
            countryTextBox1.Size = new Size(479, 48);
            countryTextBox1.TabIndex = 23;
            countryTextBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // languageTextBox
            // 
            languageTextBox.BackColor = Color.Honeydew;
            languageTextBox.BorderStyle = BorderStyle.None;
            languageTextBox.DataBindings.Add(new Binding("Text", regionBindingSource, "Language", true));
            languageTextBox.Font = new Font("Courier New", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            languageTextBox.Location = new Point(249, 230);
            languageTextBox.Multiline = true;
            languageTextBox.Name = "languageTextBox";
            languageTextBox.Size = new Size(420, 45);
            languageTextBox.TabIndex = 22;
            // 
            // panel9
            // 
            panel9.BackColor = Color.FromArgb(218, 245, 218);
            panel9.Controls.Add(label11);
            panel9.Location = new Point(0, 483);
            panel9.Name = "panel9";
            panel9.Size = new Size(721, 50);
            panel9.TabIndex = 27;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.FromArgb(218, 245, 218);
            label11.Font = new Font("Courier New", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label11.Location = new Point(7, 2);
            label11.Name = "label11";
            label11.Size = new Size(54, 27);
            label11.TabIndex = 5;
            label11.Text = "ВВП";
            toolTip1.SetToolTip(label11, "Внутрішні валовий продукт на душу населення — це показник рівня\r\nекономічної активності та якості життя населення в окремих країнах і \r\nрегіонах за певний період.");
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(521, 72);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(190, 147);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // currencyTextBox
            // 
            currencyTextBox.BackColor = Color.Honeydew;
            currencyTextBox.BorderStyle = BorderStyle.None;
            currencyTextBox.DataBindings.Add(new Binding("Text", regionBindingSource, "Currency", true));
            currencyTextBox.Font = new Font("Courier New", 13.8F);
            currencyTextBox.Location = new Point(249, 536);
            currencyTextBox.Multiline = true;
            currencyTextBox.Name = "currencyTextBox";
            currencyTextBox.Size = new Size(428, 45);
            currencyTextBox.TabIndex = 20;
            // 
            // presidentTextBox
            // 
            presidentTextBox.BackColor = Color.FromArgb(218, 245, 218);
            presidentTextBox.BorderStyle = BorderStyle.None;
            presidentTextBox.DataBindings.Add(new Binding("Text", regionBindingSource, "President", true));
            presidentTextBox.Font = new Font("Courier New", 13.8F);
            presidentTextBox.Location = new Point(249, 281);
            presidentTextBox.Multiline = true;
            presidentTextBox.Name = "presidentTextBox";
            presidentTextBox.ScrollBars = ScrollBars.Vertical;
            presidentTextBox.Size = new Size(428, 45);
            presidentTextBox.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.LightSkyBlue;
            label6.Font = new Font("Courier New", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label6.Location = new Point(358, 434);
            label6.Name = "label6";
            label6.Size = new Size(26, 27);
            label6.TabIndex = 7;
            label6.Text = "%";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.LightSkyBlue;
            label3.Font = new Font("Courier New", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.Location = new Point(452, 127);
            label3.Name = "label3";
            label3.Size = new Size(54, 27);
            label3.TabIndex = 7;
            label3.Text = "км²";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Courier New", 13.8F, FontStyle.Bold);
            label2.Location = new Point(7, 125);
            label2.Name = "label2";
            label2.Size = new Size(82, 27);
            label2.TabIndex = 7;
            label2.Text = "Площа";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Courier New", 13.8F, FontStyle.Bold);
            label9.Location = new Point(7, 231);
            label9.Name = "label9";
            label9.Size = new Size(68, 27);
            label9.TabIndex = 7;
            label9.Text = "Мова";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Courier New", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label13.Location = new Point(7, 434);
            label13.Name = "label13";
            label13.Size = new Size(236, 27);
            label13.TabIndex = 5;
            label13.Text = "Рівеь безробіття";
            // 
            // workTextBox
            // 
            workTextBox.BackColor = Color.Honeydew;
            workTextBox.BorderStyle = BorderStyle.None;
            workTextBox.DataBindings.Add(new Binding("Text", regionBindingSource, "Work", true));
            workTextBox.Font = new Font("Courier New", 13.8F);
            workTextBox.Location = new Point(249, 434);
            workTextBox.Multiline = true;
            workTextBox.Name = "workTextBox";
            workTextBox.Size = new Size(197, 45);
            workTextBox.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(218, 245, 218);
            label7.Font = new Font("Courier New", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label7.Location = new Point(7, 279);
            label7.Name = "label7";
            label7.Size = new Size(208, 27);
            label7.TabIndex = 7;
            label7.Text = "Голова держави";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Courier New", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label8.Location = new Point(7, 332);
            label8.Name = "label8";
            label8.Size = new Size(222, 27);
            label8.TabIndex = 15;
            label8.Text = "Форма правління";
            // 
            // politicTextBox
            // 
            politicTextBox.BackColor = Color.Honeydew;
            politicTextBox.BorderStyle = BorderStyle.None;
            politicTextBox.DataBindings.Add(new Binding("Text", regionBindingSource, "Politic", true));
            politicTextBox.Font = new Font("Courier New", 13.8F);
            politicTextBox.Location = new Point(249, 332);
            politicTextBox.Multiline = true;
            politicTextBox.Name = "politicTextBox";
            politicTextBox.ScrollBars = ScrollBars.Vertical;
            politicTextBox.Size = new Size(428, 45);
            politicTextBox.TabIndex = 16;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel4.BackColor = Color.FromArgb(218, 245, 218);
            panel4.Controls.Add(label1);
            panel4.Location = new Point(0, 72);
            panel4.Name = "panel4";
            panel4.Size = new Size(519, 50);
            panel4.TabIndex = 27;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Courier New", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(7, 0);
            label1.Name = "label1";
            label1.Size = new Size(110, 27);
            label1.TabIndex = 7;
            label1.Text = "Столиця";
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(218, 245, 218);
            panel8.Controls.Add(label4);
            panel8.Location = new Point(0, 178);
            panel8.Name = "panel8";
            panel8.Size = new Size(519, 50);
            panel8.TabIndex = 27;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(218, 245, 218);
            label4.Font = new Font("Courier New", 13.8F, FontStyle.Bold);
            label4.Location = new Point(7, 1);
            label4.Name = "label4";
            label4.Size = new Size(138, 27);
            label4.TabIndex = 7;
            label4.Text = "Населення";
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(218, 245, 218);
            panel6.Location = new Point(0, 279);
            panel6.Name = "panel6";
            panel6.Size = new Size(714, 50);
            panel6.TabIndex = 27;
            // 
            // addButton
            // 
            addButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            addButton.BackColor = Color.LightSkyBlue;
            addButton.Cursor = Cursors.Hand;
            addButton.FlatStyle = FlatStyle.Flat;
            addButton.Font = new Font("Courier New", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            addButton.ForeColor = Color.Black;
            addButton.Location = new Point(315, 3);
            addButton.Name = "addButton";
            addButton.Size = new Size(150, 42);
            addButton.TabIndex = 10;
            addButton.Text = "Додати";
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += addButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.BackColor = Color.LightCoral;
            deleteButton.FlatStyle = FlatStyle.Flat;
            deleteButton.Font = new Font("Courier New", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            deleteButton.Location = new Point(3, 3);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(150, 42);
            deleteButton.TabIndex = 10;
            deleteButton.Text = "Видалити";
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += deleteButton_Click;
            // 
            // mainPanel
            // 
            mainPanel.AutoScroll = true;
            mainPanel.BackColor = Color.Honeydew;
            mainPanel.Controls.Add(panel3);
            mainPanel.Controls.Add(panel1);
            mainPanel.Controls.Add(menuStrip1);
            mainPanel.Controls.Add(panel2);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(0, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(1329, 750);
            mainPanel.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            panel3.Controls.Add(saveButton);
            panel3.Controls.Add(deleteButton);
            panel3.Controls.Add(addButton);
            panel3.Location = new Point(15, 699);
            panel3.Name = "panel3";
            panel3.Size = new Size(594, 48);
            panel3.TabIndex = 12;
            // 
            // saveButton
            // 
            saveButton.BackColor = Color.LightGray;
            saveButton.FlatStyle = FlatStyle.Flat;
            saveButton.Font = new Font("Courier New", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            saveButton.Location = new Point(159, 3);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(150, 42);
            saveButton.TabIndex = 11;
            saveButton.Text = "Зберегти";
            saveButton.UseVisualStyleBackColor = false;
            saveButton.Click += saveButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1329, 750);
            Controls.Add(mainPanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MinimumSize = new Size(840, 512);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Across the Globe Guide";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)regionBindingSource).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            mainPanel.ResumeLayout(false);
            mainPanel.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem printToolStripMenuItem;
        private ToolStripMenuItem printPreviewToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem материкиToolStripMenuItem;
        private ToolStripMenuItem toolsToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private Button searchBtn;
        private Panel panel1;
        private Button addButton;
        private Button button3;
        private Button deleteButton;
        private Panel mainPanel;
        private Panel panel3;
        private DataGridView dataGridView;
        private BindingSource regionBindingSource;
        private ToolStripMenuItem mapToolStripMenuItem;
        private TextBox countrytextBox;
        private ToolStripMenuItem loadToolStripMenuItem;
        private Label label5;
        private TextBox InfoTextBox;
        private Button saveButton;
        private ToolStripMenuItem aboutProgramToolStripMenuItem;
        private Label label8;
        private TextBox presidentTextBox;
        private Label label7;
        private Label label9;
        private TextBox currencyTextBox;
        private TextBox ageTextBox;
        private TextBox productTextBox;
        private TextBox politicTextBox;
        private Label label12;
        private Label label11;
        private Label label10;
        private PictureBox pictureBox1;
        private TextBox languageTextBox;
        private TextBox workTextBox;
        private Label label13;
        private DataGridViewTextBoxColumn countryDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn capitalDataGridViewTextBoxColumn;
        private TextBox countryTextBox1;
        private TextBox capitaltextBox;
        private Label label1;
        private TextBox areaTextBox;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private Label label4;
        private Panel panel4;
        private Panel panel7;
        private Panel panel9;
        private Panel panel8;
        private Panel panel6;
        private TextBox continentTextBox;
        private Panel panel10;
        private Label label14;
        private Label label6;
        private ToolTip toolTip1;
    }
}