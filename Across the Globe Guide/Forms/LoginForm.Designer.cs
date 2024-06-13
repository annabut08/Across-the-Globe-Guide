namespace Across_the_Globe_Guide
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            panel1 = new Panel();
            mainPictureBox = new PictureBox();
            loginpanel = new Panel();
            registrerLabel = new Label();
            accountLabel = new Label();
            entryButton = new Button();
            userPictureBox = new PictureBox();
            passwordBox = new TextBox();
            passwordLabel = new Label();
            loginBox = new TextBox();
            loginLabel = new Label();
            closePanel = new Panel();
            programLabel = new Label();
            iconPictureBox = new PictureBox();
            hideButton = new Button();
            closeButton = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)mainPictureBox).BeginInit();
            loginpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)userPictureBox).BeginInit();
            closePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(mainPictureBox);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(430, 589);
            panel1.TabIndex = 0;
            // 
            // mainPictureBox
            // 
            mainPictureBox.BackColor = Color.White;
            mainPictureBox.Dock = DockStyle.Fill;
            mainPictureBox.Image = (Image)resources.GetObject("mainPictureBox.Image");
            mainPictureBox.Location = new Point(0, 0);
            mainPictureBox.Name = "mainPictureBox";
            mainPictureBox.Size = new Size(430, 589);
            mainPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            mainPictureBox.TabIndex = 0;
            mainPictureBox.TabStop = false;

            // 
            // loginpanel
            // 
            loginpanel.BackColor = Color.White;
            loginpanel.Controls.Add(registrerLabel);
            loginpanel.Controls.Add(accountLabel);
            loginpanel.Controls.Add(entryButton);
            loginpanel.Controls.Add(userPictureBox);
            loginpanel.Controls.Add(passwordBox);
            loginpanel.Controls.Add(passwordLabel);
            loginpanel.Controls.Add(loginBox);
            loginpanel.Controls.Add(loginLabel);
            loginpanel.Dock = DockStyle.Right;
            loginpanel.Location = new Point(428, 0);
            loginpanel.Name = "loginpanel";
            loginpanel.Size = new Size(522, 589);
            loginpanel.TabIndex = 1;
            // 
            // registrerLabel
            // 
            registrerLabel.AutoSize = true;
            registrerLabel.Font = new Font("Courier New", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            registrerLabel.ForeColor = Color.RoyalBlue;
            registrerLabel.Location = new Point(235, 463);
            registrerLabel.Name = "registrerLabel";
            registrerLabel.Size = new Size(222, 25);
            registrerLabel.TabIndex = 7;
            registrerLabel.Text = "Зареєструватися";
            registrerLabel.Click += registerLabel_Click;
            // 
            // accountLabel
            // 
            accountLabel.AutoSize = true;
            accountLabel.Font = new Font("Courier New", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            accountLabel.Location = new Point(36, 463);
            accountLabel.Name = "accountLabel";
            accountLabel.Size = new Size(208, 25);
            accountLabel.TabIndex = 7;
            accountLabel.Text = "Немає акаунту?";

            // 
            // entryButton
            // 
            entryButton.BackColor = Color.RoyalBlue;
            entryButton.Cursor = Cursors.Hand;
            entryButton.FlatAppearance.BorderColor = Color.Black;
            entryButton.FlatStyle = FlatStyle.Flat;
            entryButton.Font = new Font("Courier New", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            entryButton.ForeColor = Color.White;
            entryButton.Location = new Point(36, 400);
            entryButton.Name = "entryButton";
            entryButton.Size = new Size(430, 60);
            entryButton.TabIndex = 6;
            entryButton.Text = "Вхід";
            entryButton.UseVisualStyleBackColor = false;
            entryButton.Click += entryButton_Click;
            // 
            // userPictureBox
            // 
            userPictureBox.Image = (Image)resources.GetObject("userPictureBox.Image");
            userPictureBox.Location = new Point(179, 130);
            userPictureBox.Name = "userPictureBox";
            userPictureBox.Size = new Size(141, 74);
            userPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            userPictureBox.TabIndex = 5;
            userPictureBox.TabStop = false;
            // 
            // passwordBox
            // 
            passwordBox.BackColor = Color.AliceBlue;
            passwordBox.BorderStyle = BorderStyle.FixedSingle;
            passwordBox.Location = new Point(36, 324);
            passwordBox.Multiline = true;
            passwordBox.Name = "passwordBox";
            passwordBox.Size = new Size(430, 49);
            passwordBox.TabIndex = 4;
            passwordBox.UseSystemPasswordChar = true;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Courier New", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            passwordLabel.ForeColor = Color.Black;
            passwordLabel.Location = new Point(38, 296);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(96, 25);
            passwordLabel.TabIndex = 3;
            passwordLabel.Text = "Пароль";

            // 
            // loginBox
            // 
            loginBox.BackColor = Color.AliceBlue;
            loginBox.BorderStyle = BorderStyle.FixedSingle;
            loginBox.ForeColor = SystemColors.HotTrack;
            loginBox.Location = new Point(36, 240);
            loginBox.Multiline = true;
            loginBox.Name = "loginBox";
            loginBox.Size = new Size(430, 49);
            loginBox.TabIndex = 2;
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.Font = new Font("Courier New", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            loginLabel.ForeColor = Color.Black;
            loginLabel.Location = new Point(36, 212);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new Size(82, 25);
            loginLabel.TabIndex = 1;
            loginLabel.Text = "Логін";
            // 
            // closePanel
            // 
            closePanel.BackColor = Color.FromArgb(85, 181, 106);
            closePanel.Controls.Add(programLabel);
            closePanel.Controls.Add(iconPictureBox);
            closePanel.Controls.Add(hideButton);
            closePanel.Controls.Add(closeButton);
            closePanel.Cursor = Cursors.SizeAll;
            closePanel.ForeColor = Color.White;
            closePanel.Location = new Point(0, 0);
            closePanel.Name = "closePanel";
            closePanel.Size = new Size(950, 35);
            closePanel.TabIndex = 8;
            closePanel.MouseDown += closePanel_MouseDown;
            closePanel.MouseMove += closePanel_MouseMove;
            closePanel.MouseUp += closePanel_MouseUp;
            // 
            // programLabel
            // 
            programLabel.AutoSize = true;
            programLabel.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            programLabel.Location = new Point(41, 6);
            programLabel.Name = "programLabel";
            programLabel.Size = new Size(221, 23);
            programLabel.TabIndex = 11;
            programLabel.Text = "Across the Globe Guide";
            programLabel.MouseDown += programLabel_MouseDown;
            programLabel.MouseMove += programLabel_MouseMove;
            programLabel.MouseUp += programLabel_MouseUp;
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
            iconPictureBox.TabIndex = 10;
            iconPictureBox.TabStop = false;
            // 
            // hideButton
            // 
            hideButton.Cursor = Cursors.Hand;
            hideButton.Dock = DockStyle.Right;
            hideButton.FlatAppearance.BorderSize = 0;
            hideButton.FlatAppearance.MouseDownBackColor = Color.DarkGreen;
            hideButton.FlatAppearance.MouseOverBackColor = Color.DarkSeaGreen;
            hideButton.FlatStyle = FlatStyle.Flat;
            hideButton.Location = new Point(880, 0);
            hideButton.Name = "hideButton";
            hideButton.Size = new Size(35, 35);
            hideButton.TabIndex = 9;
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
            closeButton.Location = new Point(915, 0);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(35, 35);
            closeButton.TabIndex = 8;
            closeButton.Text = "X";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // LoginForm
            // 
            AccessibleRole = AccessibleRole.TitleBar;
            AutoScaleDimensions = new SizeF(13F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(950, 589);
            Controls.Add(closePanel);
            Controls.Add(panel1);
            Controls.Add(loginpanel);
            Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(6, 4, 6, 4);
            MaximumSize = new Size(950, 620);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Across the Globe Guide";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)mainPictureBox).EndInit();
            loginpanel.ResumeLayout(false);
            loginpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)userPictureBox).EndInit();
            closePanel.ResumeLayout(false);
            closePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel loginpanel;
        private PictureBox mainPictureBox;
        private TextBox loginBox;
        private Label loginLabel;
        private TextBox passwordBox;
        private Label passwordLabel;
        private PictureBox userPictureBox;
        private Button entryButton;
        private Label accountLabel;
        private Label registrerLabel;
        private Panel closePanel;
        private Button closeButton;
        private Button hideButton;
        private Label programLabel;
        private PictureBox iconPictureBox;
    }
}
