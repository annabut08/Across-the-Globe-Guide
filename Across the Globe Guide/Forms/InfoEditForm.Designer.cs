namespace Across_the_Globe_Guide.Forms
{
    partial class InfoEditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfoEditForm));
            countryTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            capitalTextBox = new TextBox();
            textBoxContinent = new TextBox();
            continentLabel = new Label();
            okButton = new Button();
            button2 = new Button();
            textBoxArea = new TextBox();
            textBoxPopulation = new TextBox();
            title3ErrorLabel = new Label();
            title2ErrorLabel = new Label();
            title1ErrorLabel = new Label();
            title5ErrorLabel = new Label();
            title6ErrorLabel = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label14 = new Label();
            label21 = new Label();
            ageTextBox = new TextBox();
            label15 = new Label();
            label20 = new Label();
            label19 = new Label();
            label18 = new Label();
            label17 = new Label();
            label16 = new Label();
            languageTextBox = new TextBox();
            currencyTextBox = new TextBox();
            politicTextBox = new TextBox();
            workTextBox = new TextBox();
            productTextBox = new TextBox();
            presidentTextBox = new TextBox();
            label10 = new Label();
            title9ErrorLabel = new Label();
            title10ErrorLabel = new Label();
            title12ErrorLabel = new Label();
            title13ErrorLabel = new Label();
            title4ErrorLabel = new Label();
            title8ErrorLabel = new Label();
            title7ErrorLabel = new Label();
            infoTextBox = new TextBox();
            panel2 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // countryTextBox
            // 
            countryTextBox.BorderStyle = BorderStyle.FixedSingle;
            countryTextBox.Location = new Point(36, 49);
            countryTextBox.Multiline = true;
            countryTextBox.Name = "countryTextBox";
            countryTextBox.Size = new Size(166, 34);
            countryTextBox.TabIndex = 0;
            countryTextBox.Validating += countryTextBox_Validating;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Courier New", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(36, 21);
            label1.Name = "label1";
            label1.Size = new Size(96, 27);
            label1.TabIndex = 1;
            label1.Text = "Країна";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Courier New", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(28, 81);
            label2.Name = "label2";
            label2.Size = new Size(110, 27);
            label2.TabIndex = 2;
            label2.Text = "Столиця";
            // 
            // capitalTextBox
            // 
            capitalTextBox.BorderStyle = BorderStyle.FixedSingle;
            capitalTextBox.Location = new Point(28, 111);
            capitalTextBox.Multiline = true;
            capitalTextBox.Name = "capitalTextBox";
            capitalTextBox.Size = new Size(166, 34);
            capitalTextBox.TabIndex = 3;
            capitalTextBox.Validating += capitalTextBox_Validating;
            // 
            // textBoxContinent
            // 
            textBoxContinent.BorderStyle = BorderStyle.FixedSingle;
            textBoxContinent.Location = new Point(221, 37);
            textBoxContinent.Multiline = true;
            textBoxContinent.Name = "textBoxContinent";
            textBoxContinent.Size = new Size(166, 34);
            textBoxContinent.TabIndex = 4;
            textBoxContinent.Validating += textBoxContinent_Validating;
            // 
            // continentLabel
            // 
            continentLabel.AutoSize = true;
            continentLabel.Font = new Font("Courier New", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            continentLabel.Location = new Point(221, 7);
            continentLabel.Name = "continentLabel";
            continentLabel.Size = new Size(124, 27);
            continentLabel.TabIndex = 2;
            continentLabel.Text = "Континет";
            // 
            // okButton
            // 
            okButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            okButton.BackColor = Color.LimeGreen;
            okButton.DialogResult = DialogResult.OK;
            okButton.FlatStyle = FlatStyle.Flat;
            okButton.Font = new Font("Courier New", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            okButton.Location = new Point(37, 17);
            okButton.Name = "okButton";
            okButton.Size = new Size(103, 42);
            okButton.TabIndex = 5;
            okButton.Text = "ОК";
            okButton.UseVisualStyleBackColor = false;
            okButton.Click += okButton_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button2.BackColor = Color.Tomato;
            button2.DialogResult = DialogResult.Cancel;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Courier New", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button2.Location = new Point(146, 17);
            button2.Name = "button2";
            button2.Size = new Size(156, 42);
            button2.TabIndex = 6;
            button2.Text = "Скасувати";
            button2.UseVisualStyleBackColor = false;
            // 
            // textBoxArea
            // 
            textBoxArea.BorderStyle = BorderStyle.FixedSingle;
            textBoxArea.Location = new Point(418, 109);
            textBoxArea.Multiline = true;
            textBoxArea.Name = "textBoxArea";
            textBoxArea.Size = new Size(166, 34);
            textBoxArea.TabIndex = 7;
            textBoxArea.Validating += textBoxArea_Validating;
            // 
            // textBoxPopulation
            // 
            textBoxPopulation.BorderStyle = BorderStyle.FixedSingle;
            textBoxPopulation.Location = new Point(419, 34);
            textBoxPopulation.Multiline = true;
            textBoxPopulation.Name = "textBoxPopulation";
            textBoxPopulation.Size = new Size(166, 34);
            textBoxPopulation.TabIndex = 8;
            textBoxPopulation.Validating += textBoxPopulation_Validating;
            // 
            // title3ErrorLabel
            // 
            title3ErrorLabel.AutoSize = true;
            title3ErrorLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            title3ErrorLabel.ForeColor = Color.Red;
            title3ErrorLabel.Location = new Point(590, 34);
            title3ErrorLabel.Name = "title3ErrorLabel";
            title3ErrorLabel.Size = new Size(21, 28);
            title3ErrorLabel.TabIndex = 9;
            title3ErrorLabel.Text = "*";
            title3ErrorLabel.Visible = false;
            // 
            // title2ErrorLabel
            // 
            title2ErrorLabel.AutoSize = true;
            title2ErrorLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            title2ErrorLabel.ForeColor = Color.Red;
            title2ErrorLabel.Location = new Point(392, 37);
            title2ErrorLabel.Name = "title2ErrorLabel";
            title2ErrorLabel.Size = new Size(21, 28);
            title2ErrorLabel.TabIndex = 9;
            title2ErrorLabel.Text = "*";
            title2ErrorLabel.Visible = false;
            // 
            // title1ErrorLabel
            // 
            title1ErrorLabel.AutoSize = true;
            title1ErrorLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            title1ErrorLabel.ForeColor = Color.Red;
            title1ErrorLabel.Location = new Point(202, 49);
            title1ErrorLabel.Name = "title1ErrorLabel";
            title1ErrorLabel.Size = new Size(21, 28);
            title1ErrorLabel.TabIndex = 9;
            title1ErrorLabel.Text = "*";
            title1ErrorLabel.Visible = false;
            // 
            // title5ErrorLabel
            // 
            title5ErrorLabel.AutoSize = true;
            title5ErrorLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            title5ErrorLabel.ForeColor = Color.Red;
            title5ErrorLabel.Location = new Point(202, 129);
            title5ErrorLabel.Name = "title5ErrorLabel";
            title5ErrorLabel.Size = new Size(21, 28);
            title5ErrorLabel.TabIndex = 9;
            title5ErrorLabel.Text = "*";
            title5ErrorLabel.Visible = false;
            // 
            // title6ErrorLabel
            // 
            title6ErrorLabel.AutoSize = true;
            title6ErrorLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            title6ErrorLabel.ForeColor = Color.Red;
            title6ErrorLabel.Location = new Point(391, 111);
            title6ErrorLabel.Name = "title6ErrorLabel";
            title6ErrorLabel.Size = new Size(21, 28);
            title6ErrorLabel.TabIndex = 9;
            title6ErrorLabel.Text = "*";
            title6ErrorLabel.Visible = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(36, 86);
            label7.Name = "label7";
            label7.Size = new Size(0, 20);
            label7.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Courier New", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label8.Location = new Point(419, 4);
            label8.Name = "label8";
            label8.Size = new Size(138, 27);
            label8.TabIndex = 10;
            label8.Text = "Населення";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Courier New", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label9.Location = new Point(419, 81);
            label9.Name = "label9";
            label9.Size = new Size(82, 27);
            label9.TabIndex = 10;
            label9.Text = "Площа";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(title3ErrorLabel);
            panel1.Controls.Add(label21);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(ageTextBox);
            panel1.Controls.Add(label15);
            panel1.Controls.Add(label20);
            panel1.Controls.Add(label19);
            panel1.Controls.Add(label18);
            panel1.Controls.Add(label17);
            panel1.Controls.Add(label16);
            panel1.Controls.Add(continentLabel);
            panel1.Controls.Add(capitalTextBox);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(languageTextBox);
            panel1.Controls.Add(currencyTextBox);
            panel1.Controls.Add(politicTextBox);
            panel1.Controls.Add(textBoxPopulation);
            panel1.Controls.Add(workTextBox);
            panel1.Controls.Add(productTextBox);
            panel1.Controls.Add(textBoxContinent);
            panel1.Controls.Add(presidentTextBox);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(title9ErrorLabel);
            panel1.Controls.Add(title10ErrorLabel);
            panel1.Controls.Add(title12ErrorLabel);
            panel1.Controls.Add(title13ErrorLabel);
            panel1.Controls.Add(title4ErrorLabel);
            panel1.Controls.Add(title8ErrorLabel);
            panel1.Controls.Add(title7ErrorLabel);
            panel1.Controls.Add(infoTextBox);
            panel1.Controls.Add(title6ErrorLabel);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(textBoxArea);
            panel1.Controls.Add(title2ErrorLabel);
            panel1.Location = new Point(8, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(893, 500);
            panel1.TabIndex = 11;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.free_icon_add_image_1990244;
            pictureBox1.Location = new Point(619, 270);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(176, 151);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Courier New", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label14.Location = new Point(419, 81);
            label14.Name = "label14";
            label14.Size = new Size(0, 27);
            label14.TabIndex = 10;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Courier New", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label21.Location = new Point(619, 81);
            label21.Name = "label21";
            label21.Size = new Size(208, 27);
            label21.TabIndex = 10;
            label21.Text = "Голова держави";
            // 
            // ageTextBox
            // 
            ageTextBox.BorderStyle = BorderStyle.FixedSingle;
            ageTextBox.Location = new Point(28, 184);
            ageTextBox.Multiline = true;
            ageTextBox.Name = "ageTextBox";
            ageTextBox.Size = new Size(166, 34);
            ageTextBox.TabIndex = 11;
            ageTextBox.Validating += ageTextBox_Validating;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Courier New", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label15.Location = new Point(618, 0);
            label15.Name = "label15";
            label15.Size = new Size(250, 27);
            label15.TabIndex = 2;
            label15.Text = "Рівень безробіття";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Courier New", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label20.Location = new Point(418, 154);
            label20.Name = "label20";
            label20.Size = new Size(96, 27);
            label20.TabIndex = 1;
            label20.Text = "Валюта";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Courier New", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label19.Location = new Point(618, 154);
            label19.Name = "label19";
            label19.Size = new Size(222, 27);
            label19.TabIndex = 1;
            label19.Text = "Форма правління";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Courier New", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label18.Location = new Point(221, 154);
            label18.Name = "label18";
            label18.Size = new Size(68, 27);
            label18.TabIndex = 1;
            label18.Text = "Мова";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Courier New", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label17.Location = new Point(28, 154);
            label17.Name = "label17";
            label17.Size = new Size(180, 27);
            label17.TabIndex = 1;
            label17.Text = "Середній вік";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Courier New", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label16.Location = new Point(221, 81);
            label16.Name = "label16";
            label16.Size = new Size(54, 27);
            label16.TabIndex = 1;
            label16.Text = "ВВП";
            // 
            // languageTextBox
            // 
            languageTextBox.BorderStyle = BorderStyle.FixedSingle;
            languageTextBox.Location = new Point(221, 184);
            languageTextBox.Multiline = true;
            languageTextBox.Name = "languageTextBox";
            languageTextBox.Size = new Size(166, 34);
            languageTextBox.TabIndex = 11;
            languageTextBox.Validating += languageTextBox_Validating;
            // 
            // currencyTextBox
            // 
            currencyTextBox.BorderStyle = BorderStyle.FixedSingle;
            currencyTextBox.Location = new Point(419, 184);
            currencyTextBox.Multiline = true;
            currencyTextBox.Name = "currencyTextBox";
            currencyTextBox.Size = new Size(166, 34);
            currencyTextBox.TabIndex = 11;
            currencyTextBox.Validating += currencyTextBox_Validating;
            // 
            // politicTextBox
            // 
            politicTextBox.BorderStyle = BorderStyle.FixedSingle;
            politicTextBox.Location = new Point(618, 184);
            politicTextBox.Multiline = true;
            politicTextBox.Name = "politicTextBox";
            politicTextBox.Size = new Size(166, 34);
            politicTextBox.TabIndex = 11;
            politicTextBox.Validating += politicTextBox_Validating;
            // 
            // workTextBox
            // 
            workTextBox.BorderStyle = BorderStyle.FixedSingle;
            workTextBox.Location = new Point(618, 32);
            workTextBox.Multiline = true;
            workTextBox.Name = "workTextBox";
            workTextBox.Size = new Size(166, 34);
            workTextBox.TabIndex = 11;
            workTextBox.Validating += workTextBox_Validating;
            // 
            // productTextBox
            // 
            productTextBox.BorderStyle = BorderStyle.FixedSingle;
            productTextBox.Location = new Point(221, 111);
            productTextBox.Multiline = true;
            productTextBox.Name = "productTextBox";
            productTextBox.Size = new Size(166, 34);
            productTextBox.TabIndex = 11;
            productTextBox.Validating += productTextBox_Validating;
            // 
            // presidentTextBox
            // 
            presidentTextBox.BorderStyle = BorderStyle.FixedSingle;
            presidentTextBox.Location = new Point(618, 111);
            presidentTextBox.Multiline = true;
            presidentTextBox.Name = "presidentTextBox";
            presidentTextBox.Size = new Size(166, 34);
            presidentTextBox.TabIndex = 10;
            presidentTextBox.Validating += presidentTextBox_Validating;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Courier New", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label10.Location = new Point(28, 240);
            label10.Name = "label10";
            label10.Size = new Size(152, 27);
            label10.TabIndex = 9;
            label10.Text = "Інформація";
            // 
            // title9ErrorLabel
            // 
            title9ErrorLabel.AutoSize = true;
            title9ErrorLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            title9ErrorLabel.ForeColor = Color.Red;
            title9ErrorLabel.Location = new Point(194, 184);
            title9ErrorLabel.Name = "title9ErrorLabel";
            title9ErrorLabel.Size = new Size(21, 28);
            title9ErrorLabel.TabIndex = 9;
            title9ErrorLabel.Text = "*";
            title9ErrorLabel.Visible = false;
            // 
            // title10ErrorLabel
            // 
            title10ErrorLabel.AutoSize = true;
            title10ErrorLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            title10ErrorLabel.ForeColor = Color.Red;
            title10ErrorLabel.Location = new Point(393, 184);
            title10ErrorLabel.Name = "title10ErrorLabel";
            title10ErrorLabel.Size = new Size(21, 28);
            title10ErrorLabel.TabIndex = 9;
            title10ErrorLabel.Text = "*";
            title10ErrorLabel.Visible = false;
            // 
            // title12ErrorLabel
            // 
            title12ErrorLabel.AutoSize = true;
            title12ErrorLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            title12ErrorLabel.ForeColor = Color.Red;
            title12ErrorLabel.Location = new Point(591, 184);
            title12ErrorLabel.Name = "title12ErrorLabel";
            title12ErrorLabel.Size = new Size(21, 28);
            title12ErrorLabel.TabIndex = 9;
            title12ErrorLabel.Text = "*";
            title12ErrorLabel.Visible = false;
            // 
            // title13ErrorLabel
            // 
            title13ErrorLabel.AutoSize = true;
            title13ErrorLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            title13ErrorLabel.ForeColor = Color.Red;
            title13ErrorLabel.Location = new Point(790, 184);
            title13ErrorLabel.Name = "title13ErrorLabel";
            title13ErrorLabel.Size = new Size(21, 28);
            title13ErrorLabel.TabIndex = 9;
            title13ErrorLabel.Text = "*";
            title13ErrorLabel.Visible = false;
            // 
            // title4ErrorLabel
            // 
            title4ErrorLabel.AutoSize = true;
            title4ErrorLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            title4ErrorLabel.ForeColor = Color.Red;
            title4ErrorLabel.Location = new Point(790, 32);
            title4ErrorLabel.Name = "title4ErrorLabel";
            title4ErrorLabel.Size = new Size(21, 28);
            title4ErrorLabel.TabIndex = 9;
            title4ErrorLabel.Text = "*";
            title4ErrorLabel.Visible = false;
            // 
            // title8ErrorLabel
            // 
            title8ErrorLabel.AutoSize = true;
            title8ErrorLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            title8ErrorLabel.ForeColor = Color.Red;
            title8ErrorLabel.Location = new Point(790, 111);
            title8ErrorLabel.Name = "title8ErrorLabel";
            title8ErrorLabel.Size = new Size(21, 28);
            title8ErrorLabel.TabIndex = 9;
            title8ErrorLabel.Text = "*";
            title8ErrorLabel.Visible = false;
            // 
            // title7ErrorLabel
            // 
            title7ErrorLabel.AutoSize = true;
            title7ErrorLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            title7ErrorLabel.ForeColor = Color.Red;
            title7ErrorLabel.Location = new Point(590, 109);
            title7ErrorLabel.Name = "title7ErrorLabel";
            title7ErrorLabel.Size = new Size(21, 28);
            title7ErrorLabel.TabIndex = 9;
            title7ErrorLabel.Text = "*";
            title7ErrorLabel.Visible = false;
            // 
            // infoTextBox
            // 
            infoTextBox.BorderStyle = BorderStyle.FixedSingle;
            infoTextBox.Location = new Point(29, 270);
            infoTextBox.Multiline = true;
            infoTextBox.Name = "infoTextBox";
            infoTextBox.ScrollBars = ScrollBars.Vertical;
            infoTextBox.Size = new Size(556, 151);
            infoTextBox.TabIndex = 8;
            infoTextBox.Validated += infoTextBox_Validated_1;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            panel2.Controls.Add(okButton);
            panel2.Controls.Add(button2);
            panel2.Location = new Point(573, 437);
            panel2.Name = "panel2";
            panel2.Size = new Size(320, 63);
            panel2.TabIndex = 0;
            // 
            // InfoEditForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            ClientSize = new Size(910, 526);
            Controls.Add(title5ErrorLabel);
            Controls.Add(title1ErrorLabel);
            Controls.Add(label7);
            Controls.Add(label1);
            Controls.Add(countryTextBox);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(928, 573);
            Name = "InfoEditForm";
            Text = "InfoEditForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox countryTextBox;
        private Label label1;
        private Label label2;
        private TextBox capitalTextBox;
        private TextBox textBoxContinent;
        private Label continentLabel;
        private Button okButton;
        private Button button2;
        private TextBox textBoxArea;
        private TextBox textBoxPopulation;
        private Label title3ErrorLabel;
        private Label title2ErrorLabel;
        private Label title1ErrorLabel;
        private Label title5ErrorLabel;
        private Label title6ErrorLabel;
        private Label label7;
        private Label label8;
        private Label label9;
        private Panel panel1;
        private Panel panel2;
        private Label label10;
        private TextBox infoTextBox;
        private TextBox presidentTextBox;
        private Label title7ErrorLabel;
        private TextBox workTextBox;
        private TextBox productTextBox;
        private TextBox ageTextBox;
        private TextBox languageTextBox;
        private TextBox currencyTextBox;
        private TextBox politicTextBox;
        private Label title9ErrorLabel;
        private Label title10ErrorLabel;
        private Label title12ErrorLabel;
        private Label title13ErrorLabel;
        private Label title4ErrorLabel;
        private Label title8ErrorLabel;
        private Label label14;
        private Label label15;
        private Label label20;
        private Label label19;
        private Label label18;
        private Label label17;
        private Label label16;
        private PictureBox pictureBox1;
        private Label label21;
    }
}