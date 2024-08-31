namespace Root_Folder
{
    partial class ViewParticipant
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
            BackBtn = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            RemoveUserBtn = new Button();
            KickUserBtn = new Button();
            NameIN = new Label();
            TelIN = new Label();
            GmailIN = new Label();
            ((System.ComponentModel.ISupportInitialize)BackBtn).BeginInit();
            SuspendLayout();
            // 
            // BackBtn
            // 
            BackBtn.BackColor = Color.Transparent;
            BackBtn.BackgroundImage = Properties.Resources.backGlowBtn1;
            BackBtn.BackgroundImageLayout = ImageLayout.Stretch;
            BackBtn.Location = new Point(-5, -5);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(63, 60);
            BackBtn.TabIndex = 0;
            BackBtn.TabStop = false;
            BackBtn.Click += BackBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Rockwell Extra Bold", 20F, FontStyle.Bold);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(122, 27);
            label1.Name = "label1";
            label1.Size = new Size(254, 40);
            label1.TabIndex = 1;
            label1.Text = "User Profile";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(73, 108);
            label2.Name = "label2";
            label2.Size = new Size(73, 28);
            label2.TabIndex = 2;
            label2.Text = "Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(73, 155);
            label3.Name = "label3";
            label3.Size = new Size(83, 28);
            label3.TabIndex = 3;
            label3.Text = "Tel. No:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(73, 197);
            label4.Name = "label4";
            label4.Size = new Size(72, 28);
            label4.TabIndex = 4;
            label4.Text = "Gmail:";
            // 
            // RemoveUserBtn
            // 
            RemoveUserBtn.BackColor = SystemColors.ControlDark;
            RemoveUserBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            RemoveUserBtn.Location = new Point(371, 280);
            RemoveUserBtn.Name = "RemoveUserBtn";
            RemoveUserBtn.Size = new Size(118, 29);
            RemoveUserBtn.TabIndex = 8;
            RemoveUserBtn.Text = "Remove User";
            RemoveUserBtn.UseVisualStyleBackColor = false;
            // 
            // KickUserBtn
            // 
            KickUserBtn.BackColor = SystemColors.ControlDark;
            KickUserBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            KickUserBtn.Location = new Point(12, 280);
            KickUserBtn.Name = "KickUserBtn";
            KickUserBtn.Size = new Size(118, 29);
            KickUserBtn.TabIndex = 9;
            KickUserBtn.Text = "Kick User";
            KickUserBtn.UseVisualStyleBackColor = false;
            // 
            // NameIN
            // 
            NameIN.BackColor = SystemColors.Window;
            NameIN.Location = new Point(245, 111);
            NameIN.Name = "NameIN";
            NameIN.Padding = new Padding(0, 2, 0, 2);
            NameIN.Size = new Size(186, 27);
            NameIN.TabIndex = 10;
            NameIN.Text = " ";
            // 
            // TelIN
            // 
            TelIN.BackColor = SystemColors.Window;
            TelIN.Location = new Point(245, 157);
            TelIN.Name = "TelIN";
            TelIN.Padding = new Padding(0, 2, 0, 2);
            TelIN.Size = new Size(186, 27);
            TelIN.TabIndex = 11;
            TelIN.Text = " ";
            // 
            // GmailIN
            // 
            GmailIN.BackColor = SystemColors.Window;
            GmailIN.Location = new Point(245, 201);
            GmailIN.Name = "GmailIN";
            GmailIN.Padding = new Padding(0, 2, 0, 2);
            GmailIN.Size = new Size(186, 27);
            GmailIN.TabIndex = 12;
            GmailIN.Text = " ";
            // 
            // ViewParticipant
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.viewUserProfileBg;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(501, 321);
            Controls.Add(GmailIN);
            Controls.Add(TelIN);
            Controls.Add(NameIN);
            Controls.Add(KickUserBtn);
            Controls.Add(RemoveUserBtn);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BackBtn);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ViewParticipant";
            Text = "View Particepent Detais";
            Load += ViewParticepent_Load;
            ((System.ComponentModel.ISupportInitialize)BackBtn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox BackBtn;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button RemoveUserBtn;
        private Button KickUserBtn;
        private Label NameIN;
        private Label TelIN;
        private Label GmailIN;
    }
}