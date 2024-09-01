namespace Root_Folder
{
    partial class RegisterPage
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            UnameIN = new TextBox();
            GmailIN = new TextBox();
            PassIN = new TextBox();
            ComPassIN = new TextBox();
            RegisterBtn = new Button();
            AgeIN = new MaskedTextBox();
            TelIN = new MaskedTextBox();
            label8 = new Label();
            AdminPassIN = new TextBox();
            ViewPass2 = new PictureBox();
            ViewPass1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ViewPass2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ViewPass1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.backGlowBtn1;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(-5, -5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(63, 60);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Matura MT Script Capitals", 18F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ActiveCaption;
            label1.Location = new Point(175, 41);
            label1.Name = "label1";
            label1.Size = new Size(194, 40);
            label1.TabIndex = 1;
            label1.Text = "Registration";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(86, 112);
            label2.Name = "label2";
            label2.Size = new Size(102, 23);
            label2.TabIndex = 2;
            label2.Text = "User Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(86, 163);
            label3.Name = "label3";
            label3.Size = new Size(62, 23);
            label3.TabIndex = 3;
            label3.Text = "Gmail:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(86, 212);
            label4.Name = "label4";
            label4.Size = new Size(47, 23);
            label4.TabIndex = 4;
            label4.Text = "Age:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(86, 268);
            label5.Name = "label5";
            label5.Size = new Size(70, 23);
            label5.TabIndex = 5;
            label5.Text = "Tel. No:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(86, 321);
            label6.Name = "label6";
            label6.Size = new Size(90, 23);
            label6.TabIndex = 6;
            label6.Text = "Password:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(86, 372);
            label7.Name = "label7";
            label7.Size = new Size(161, 23);
            label7.TabIndex = 7;
            label7.Text = "Confirm Password:";
            // 
            // UnameIN
            // 
            UnameIN.Location = new Point(271, 109);
            UnameIN.Name = "UnameIN";
            UnameIN.Size = new Size(190, 27);
            UnameIN.TabIndex = 0;
            // 
            // GmailIN
            // 
            GmailIN.Location = new Point(271, 160);
            GmailIN.Name = "GmailIN";
            GmailIN.Size = new Size(190, 27);
            GmailIN.TabIndex = 1;
            // 
            // PassIN
            // 
            PassIN.Location = new Point(271, 318);
            PassIN.Name = "PassIN";
            PassIN.PasswordChar = '•';
            PassIN.Size = new Size(159, 27);
            PassIN.TabIndex = 4;
            // 
            // ComPassIN
            // 
            ComPassIN.Location = new Point(271, 369);
            ComPassIN.Name = "ComPassIN";
            ComPassIN.PasswordChar = '•';
            ComPassIN.Size = new Size(159, 27);
            ComPassIN.TabIndex = 5;
            // 
            // RegisterBtn
            // 
            RegisterBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            RegisterBtn.ForeColor = SystemColors.ActiveCaptionText;
            RegisterBtn.Location = new Point(219, 473);
            RegisterBtn.Name = "RegisterBtn";
            RegisterBtn.Size = new Size(94, 29);
            RegisterBtn.TabIndex = 7;
            RegisterBtn.Text = "Register";
            RegisterBtn.UseVisualStyleBackColor = true;
            RegisterBtn.Click += RegisterBtn_Click;
            // 
            // AgeIN
            // 
            AgeIN.Location = new Point(271, 208);
            AgeIN.Mask = "000";
            AgeIN.Name = "AgeIN";
            AgeIN.PromptChar = ' ';
            AgeIN.Size = new Size(190, 27);
            AgeIN.TabIndex = 2;
            AgeIN.MaskInputRejected += AgeIN_MaskInputRejected;
            // 
            // TelIN
            // 
            TelIN.Location = new Point(271, 264);
            TelIN.Mask = "000 000 0000";
            TelIN.Name = "TelIN";
            TelIN.PromptChar = ' ';
            TelIN.Size = new Size(190, 27);
            TelIN.TabIndex = 3;
            TelIN.MaskInputRejected += TelIN_MaskInputRejected;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(86, 420);
            label8.Name = "label8";
            label8.Size = new Size(115, 23);
            label8.TabIndex = 17;
            label8.Text = "Admin Code:";
            // 
            // AdminPassIN
            // 
            AdminPassIN.Location = new Point(271, 420);
            AdminPassIN.Name = "AdminPassIN";
            AdminPassIN.Size = new Size(190, 27);
            AdminPassIN.TabIndex = 6;
            // 
            // ViewPass2
            // 
            ViewPass2.BackColor = Color.Transparent;
            ViewPass2.BackgroundImage = Properties.Resources.viewPassIcon;
            ViewPass2.BackgroundImageLayout = ImageLayout.Stretch;
            ViewPass2.BorderStyle = BorderStyle.Fixed3D;
            ViewPass2.Location = new Point(434, 368);
            ViewPass2.Name = "ViewPass2";
            ViewPass2.Size = new Size(27, 27);
            ViewPass2.TabIndex = 19;
            ViewPass2.TabStop = false;
            ViewPass2.Click += ViewPass2_Click;
            // 
            // ViewPass1
            // 
            ViewPass1.BackColor = Color.Transparent;
            ViewPass1.BackgroundImage = Properties.Resources.viewPassIcon;
            ViewPass1.BackgroundImageLayout = ImageLayout.Stretch;
            ViewPass1.BorderStyle = BorderStyle.Fixed3D;
            ViewPass1.Location = new Point(434, 317);
            ViewPass1.Name = "ViewPass1";
            ViewPass1.Size = new Size(27, 27);
            ViewPass1.TabIndex = 20;
            ViewPass1.TabStop = false;
            ViewPass1.Click += ViewPass1_Click;
            // 
            // RegisterPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.registerBg;
            ClientSize = new Size(555, 538);
            Controls.Add(ViewPass1);
            Controls.Add(ViewPass2);
            Controls.Add(AdminPassIN);
            Controls.Add(label8);
            Controls.Add(TelIN);
            Controls.Add(AgeIN);
            Controls.Add(RegisterBtn);
            Controls.Add(ComPassIN);
            Controls.Add(PassIN);
            Controls.Add(GmailIN);
            Controls.Add(UnameIN);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            ForeColor = SystemColors.ButtonHighlight;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "RegisterPage";
            Text = "RegisterPage";
            Load += RegisterPage_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ViewPass2).EndInit();
            ((System.ComponentModel.ISupportInitialize)ViewPass1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox UnameIN;
        private TextBox GmailIN;
        private TextBox PassIN;
        private TextBox ComPassIN;
        private Button RegisterBtn;
        private MaskedTextBox AgeIN;
        private MaskedTextBox TelIN;
        private Label label8;
        private TextBox AdminPassIN;
        private PictureBox ViewPass2;
        private PictureBox ViewPass1;
    }
}