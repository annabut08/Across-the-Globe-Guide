namespace Across_the_Globe_Guide
{
    partial class RegistrationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationForm));
            panel1 = new Panel();
            panel3 = new Panel();
            hideButton = new Button();
            closeButton = new Button();
            label8 = new Label();
            iconPictureBox = new PictureBox();
            label1 = new Label();
            panel2 = new Panel();
            entryLabel = new Label();
            label6 = new Label();
            registrationButton = new Button();
            passwordTextBox = new TextBox();
            label5 = new Label();
            mailTextBox = new TextBox();
            label4 = new Label();
            loginTextBox = new TextBox();
            label3 = new Label();
            nameTextBox = new TextBox();
            label2 = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(527, 134);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(85, 181, 106);
            panel3.Controls.Add(hideButton);
            panel3.Controls.Add(closeButton);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(iconPictureBox);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(527, 35);
            panel3.TabIndex = 2;

            // 
            // hideButton
            // 
            hideButton.Cursor = Cursors.Hand;
            hideButton.Dock = DockStyle.Right;
            hideButton.FlatAppearance.BorderSize = 0;
            hideButton.FlatAppearance.MouseDownBackColor = Color.DarkGreen;
            hideButton.FlatAppearance.MouseOverBackColor = Color.DarkSeaGreen;
            hideButton.FlatStyle = FlatStyle.Flat;
            hideButton.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            hideButton.ForeColor = Color.White;
            hideButton.Location = new Point(457, 0);
            hideButton.Name = "hideButton";
            hideButton.Size = new Size(35, 35);
            hideButton.TabIndex = 15;
            hideButton.Text = "–";
            hideButton.UseVisualStyleBackColor = true;
            hideButton.Click += hideButton_Click;
            // 
            // closeButton
            // 
            closeButton.Cursor = Cursors.Hand;
            closeButton.Dock = DockStyle.Right;
            closeButton.FlatAppearance.BorderSize = 0;
            closeButton.FlatAppearance.MouseDownBackColor = Color.Maroon;
            closeButton.FlatAppearance.MouseOverBackColor = Color.Red;
            closeButton.FlatStyle = FlatStyle.Flat;
            closeButton.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            closeButton.ForeColor = Color.White;
            closeButton.Location = new Point(492, 0);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(35, 35);
            closeButton.TabIndex = 14;
            closeButton.Text = "X";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label8.ForeColor = Color.White;
            label8.Location = new Point(41, 8);
            label8.Name = "label8";
            label8.Size = new Size(200, 21);
            label8.TabIndex = 13;
            label8.Text = "Across the Globe Guide";
            // 
            // iconPictureBox
            // 
            iconPictureBox.Dock = DockStyle.Left;
            iconPictureBox.ErrorImage = Properties.Resources.earth_planet_icon;
            iconPictureBox.Image = Properties.Resources.earth_planet_icon;
            iconPictureBox.Location = new Point(0, 0);
            iconPictureBox.Name = "iconPictureBox";
            iconPictureBox.Size = new Size(35, 35);
            iconPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            iconPictureBox.TabIndex = 12;
            iconPictureBox.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Courier New", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.RoyalBlue;
            label1.Location = new Point(139, 70);
            label1.Name = "label1";
            label1.Size = new Size(238, 41);
            label1.TabIndex = 1;
            label1.Text = "Реєстрація";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(entryLabel);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(registrationButton);
            panel2.Controls.Add(passwordTextBox);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(mailTextBox);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(loginTextBox);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(nameTextBox);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 133);
            panel2.Name = "panel2";
            panel2.Size = new Size(527, 550);
            panel2.TabIndex = 2;
            // 
            // entryLabel
            // 
            entryLabel.AutoSize = true;
            entryLabel.Font = new Font("Courier New", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            entryLabel.ForeColor = Color.RoyalBlue;
            entryLabel.Location = new Point(327, 474);
            entryLabel.Name = "entryLabel";
            entryLabel.Size = new Size(96, 25);
            entryLabel.TabIndex = 3;
            entryLabel.Text = "Увійти\r\n";
            entryLabel.Click += entryLabel_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Courier New", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label6.Location = new Point(71, 474);
            label6.Name = "label6";
            label6.Size = new Size(250, 25);
            label6.TabIndex = 3;
            label6.Text = "Вже маєте акаунт?";
            // 
            // registrationButton
            // 
            registrationButton.BackColor = Color.RoyalBlue;
            registrationButton.Cursor = Cursors.Hand;
            registrationButton.FlatAppearance.BorderColor = Color.Black;
            registrationButton.FlatAppearance.MouseDownBackColor = Color.CornflowerBlue;
            registrationButton.FlatAppearance.MouseOverBackColor = Color.MidnightBlue;
            registrationButton.FlatStyle = FlatStyle.Flat;
            registrationButton.Font = new Font("Courier New", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            registrationButton.ForeColor = Color.White;
            registrationButton.Location = new Point(41, 397);
            registrationButton.Name = "registrationButton";
            registrationButton.Size = new Size(430, 60);
            registrationButton.TabIndex = 2;
            registrationButton.Text = "Зареєструватися";
            registrationButton.UseVisualStyleBackColor = false;
            registrationButton.Click += registrationButton_Click;
            // 
            // passwordTextBox
            // 
            passwordTextBox.BackColor = Color.AliceBlue;
            passwordTextBox.BorderStyle = BorderStyle.FixedSingle;
            passwordTextBox.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            passwordTextBox.Location = new Point(41, 326);
            passwordTextBox.Multiline = true;
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(430, 49);
            passwordTextBox.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Courier New", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.Location = new Point(41, 298);
            label5.Name = "label5";
            label5.Size = new Size(96, 25);
            label5.TabIndex = 0;
            label5.Text = "Пароль";
            // 
            // mailTextBox
            // 
            mailTextBox.BackColor = Color.AliceBlue;
            mailTextBox.BorderStyle = BorderStyle.FixedSingle;
            mailTextBox.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            mailTextBox.Location = new Point(41, 237);
            mailTextBox.Multiline = true;
            mailTextBox.Name = "mailTextBox";
            mailTextBox.Size = new Size(430, 49);
            mailTextBox.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Courier New", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(41, 209);
            label4.Name = "label4";
            label4.Size = new Size(250, 25);
            label4.TabIndex = 0;
            label4.Text = "Електронна пошта ";
            // 
            // loginTextBox
            // 
            loginTextBox.BackColor = Color.AliceBlue;
            loginTextBox.BorderStyle = BorderStyle.FixedSingle;
            loginTextBox.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            loginTextBox.Location = new Point(41, 147);
            loginTextBox.Multiline = true;
            loginTextBox.Name = "loginTextBox";
            loginTextBox.Size = new Size(430, 49);
            loginTextBox.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Courier New", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(41, 119);
            label3.Name = "label3";
            label3.Size = new Size(82, 25);
            label3.TabIndex = 0;
            label3.Text = "Логін";
            // 
            // nameTextBox
            // 
            nameTextBox.BackColor = Color.AliceBlue;
            nameTextBox.BorderStyle = BorderStyle.FixedSingle;
            nameTextBox.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            nameTextBox.Location = new Point(41, 59);
            nameTextBox.Multiline = true;
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(430, 49);
            nameTextBox.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Courier New", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(41, 31);
            label2.Name = "label2";
            label2.Size = new Size(236, 25);
            label2.TabIndex = 0;
            label2.Text = "Ім'я та прізвище";
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(527, 683);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(545, 730);
            Name = "RegistrationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = ";l";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private TextBox nameTextBox;
        private Label label2;
        private TextBox mailTextBox;
        private Label label4;
        private TextBox loginTextBox;
        private Label label3;
        private Button registrationButton;
        private TextBox passwordTextBox;
        private Label label5;
        private Label label6;
        private Label entryLabel;
        private Panel panel3;
        private Label label8;
        private PictureBox iconPictureBox;
        private Button hideButton;
        private Button closeButton;
    }
}