﻿namespace Root_Folder
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            label2.Location = new Point(86, 125);
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
            label3.Location = new Point(86, 176);
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
            label4.Location = new Point(86, 225);
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
            label5.Location = new Point(86, 281);
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
            label6.Location = new Point(86, 334);
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
            label7.Location = new Point(86, 385);
            label7.Name = "label7";
            label7.Size = new Size(171, 23);
            label7.TabIndex = 7;
            label7.Text = "Comferm Password:";
            // 
            // UnameIN
            // 
            UnameIN.Location = new Point(271, 122);
            UnameIN.Name = "UnameIN";
            UnameIN.Size = new Size(190, 27);
            UnameIN.TabIndex = 8;
            // 
            // GmailIN
            // 
            GmailIN.Location = new Point(271, 173);
            GmailIN.Name = "GmailIN";
            GmailIN.Size = new Size(190, 27);
            GmailIN.TabIndex = 9;
            // 
            // PassIN
            // 
            PassIN.Location = new Point(271, 331);
            PassIN.Name = "PassIN";
            PassIN.PasswordChar = '•';
            PassIN.Size = new Size(190, 27);
            PassIN.TabIndex = 12;
            // 
            // ComPassIN
            // 
            ComPassIN.Location = new Point(271, 382);
            ComPassIN.Name = "ComPassIN";
            ComPassIN.PasswordChar = '•';
            ComPassIN.Size = new Size(190, 27);
            ComPassIN.TabIndex = 13;
            // 
            // RegisterBtn
            // 
            RegisterBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            RegisterBtn.ForeColor = SystemColors.ActiveCaptionText;
            RegisterBtn.Location = new Point(219, 459);
            RegisterBtn.Name = "RegisterBtn";
            RegisterBtn.Size = new Size(94, 29);
            RegisterBtn.TabIndex = 14;
            RegisterBtn.Text = "Register";
            RegisterBtn.UseVisualStyleBackColor = true;
            RegisterBtn.Click += RegisterBtn_Click;
            // 
            // AgeIN
            // 
            AgeIN.Location = new Point(271, 221);
            AgeIN.Mask = "000";
            AgeIN.Name = "AgeIN";
            AgeIN.PromptChar = ' ';
            AgeIN.Size = new Size(190, 27);
            AgeIN.TabIndex = 15;
            AgeIN.MaskInputRejected += AgeIN_MaskInputRejected;
            // 
            // TelIN
            // 
            TelIN.Location = new Point(271, 277);
            TelIN.Mask = "000 000 0000";
            TelIN.Name = "TelIN";
            TelIN.PromptChar = ' ';
            TelIN.Size = new Size(190, 27);
            TelIN.TabIndex = 16;
            TelIN.MaskInputRejected += TelIN_MaskInputRejected;
            // 
            // RegisterPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.registerBg;
            ClientSize = new Size(555, 538);
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
            Name = "RegisterPage";
            Text = "RegisterPage";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
    }
}