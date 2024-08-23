namespace Root_Folder
{
    partial class LoginPage
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
            pictureBox1 = new PictureBox();
            linkLabel1 = new LinkLabel();
            label1 = new Label();
            label2 = new Label();
            UnameIN = new TextBox();
            LoginBtn = new Button();
            ShowPassBtn = new PictureBox();
            PassIN = new MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ShowPassBtn).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.backBtn2;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(-5, -5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(63, 60);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.Transparent;
            linkLabel1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            linkLabel1.LinkBehavior = LinkBehavior.NeverUnderline;
            linkLabel1.LinkColor = Color.Snow;
            linkLabel1.Location = new Point(715, 8);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(84, 25);
            linkLabel1.TabIndex = 1;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Register";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(183, 128);
            label1.Name = "label1";
            label1.Size = new Size(115, 28);
            label1.TabIndex = 2;
            label1.Text = "UserName:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(183, 195);
            label2.Name = "label2";
            label2.Size = new Size(106, 28);
            label2.TabIndex = 3;
            label2.Text = "Password:";
            // 
            // UnameIN
            // 
            UnameIN.Location = new Point(418, 132);
            UnameIN.Name = "UnameIN";
            UnameIN.Size = new Size(240, 27);
            UnameIN.TabIndex = 4;
            // 
            // LoginBtn
            // 
            LoginBtn.BackColor = SystemColors.ActiveBorder;
            LoginBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            LoginBtn.Location = new Point(360, 304);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(94, 29);
            LoginBtn.TabIndex = 6;
            LoginBtn.Text = "LogIn";
            LoginBtn.UseVisualStyleBackColor = false;
            LoginBtn.Click += button1_Click;
            // 
            // ShowPassBtn
            // 
            ShowPassBtn.BackColor = Color.Transparent;
            ShowPassBtn.BackgroundImage = Properties.Resources.viewPassIcon;
            ShowPassBtn.BackgroundImageLayout = ImageLayout.Stretch;
            ShowPassBtn.BorderStyle = BorderStyle.Fixed3D;
            ShowPassBtn.Location = new Point(631, 199);
            ShowPassBtn.Name = "ShowPassBtn";
            ShowPassBtn.Size = new Size(27, 27);
            ShowPassBtn.TabIndex = 7;
            ShowPassBtn.TabStop = false;
            ShowPassBtn.Click += ShowPassBtn_Click;
            // 
            // PassIN
            // 
            PassIN.Location = new Point(418, 199);
            PassIN.Name = "PassIN";
            PassIN.PasswordChar = '•';
            PassIN.Size = new Size(207, 27);
            PassIN.TabIndex = 8;
            // 
            // LoginPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.logInBg;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(PassIN);
            Controls.Add(ShowPassBtn);
            Controls.Add(LoginBtn);
            Controls.Add(UnameIN);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(linkLabel1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "LoginPage";
            Text = "LoginPage";
            Load += LoginPage_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ShowPassBtn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private LinkLabel linkLabel1;
        private Label label1;
        private Label label2;
        private TextBox UnameIN;
        private Button LoginBtn;
        private PictureBox ShowPassBtn;
        private MaskedTextBox PassIN;
    }
}