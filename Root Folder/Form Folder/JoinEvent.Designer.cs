namespace Root_Folder
{
    partial class JoinEvent
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            JoinBtn = new Button();
            CancleBtn = new Button();
            BackBtn = new PictureBox();
            DateTimeIN = new Label();
            PriceIN = new Label();
            LocationIN = new Label();
            label6 = new Label();
            NameIN = new Label();
            ((System.ComponentModel.ISupportInitialize)BackBtn).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Rockwell Extra Bold", 20F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(191, 29);
            label1.Name = "label1";
            label1.Size = new Size(224, 40);
            label1.TabIndex = 0;
            label1.Text = "Join Event";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(79, 154);
            label2.Name = "label2";
            label2.Size = new Size(67, 28);
            label2.TabIndex = 1;
            label2.Text = "Place:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(79, 209);
            label3.Name = "label3";
            label3.Size = new Size(64, 28);
            label3.TabIndex = 2;
            label3.Text = "Time:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(79, 263);
            label4.Name = "label4";
            label4.Size = new Size(70, 28);
            label4.TabIndex = 3;
            label4.Text = "Price: ";
            // 
            // JoinBtn
            // 
            JoinBtn.BackColor = SystemColors.ControlDark;
            JoinBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            JoinBtn.Location = new Point(497, 350);
            JoinBtn.Name = "JoinBtn";
            JoinBtn.Size = new Size(94, 29);
            JoinBtn.TabIndex = 4;
            JoinBtn.Text = "Join";
            JoinBtn.UseVisualStyleBackColor = false;
            JoinBtn.Click += JoinBtn_Click;
            // 
            // CancleBtn
            // 
            CancleBtn.BackColor = SystemColors.ControlDark;
            CancleBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            CancleBtn.Location = new Point(12, 350);
            CancleBtn.Name = "CancleBtn";
            CancleBtn.Size = new Size(94, 29);
            CancleBtn.TabIndex = 5;
            CancleBtn.Text = "Cancel ";
            CancleBtn.UseVisualStyleBackColor = false;
            CancleBtn.Click += CancleBtn_Click;
            // 
            // BackBtn
            // 
            BackBtn.BackColor = Color.Transparent;
            BackBtn.BackgroundImage = Properties.Resources.backGlowBtn1;
            BackBtn.BackgroundImageLayout = ImageLayout.Stretch;
            BackBtn.Location = new Point(-5, -5);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(63, 60);
            BackBtn.TabIndex = 9;
            BackBtn.TabStop = false;
            BackBtn.Click += BackBtn_Click;
            // 
            // DateTimeIN
            // 
            DateTimeIN.BackColor = SystemColors.Window;
            DateTimeIN.BorderStyle = BorderStyle.FixedSingle;
            DateTimeIN.Location = new Point(352, 209);
            DateTimeIN.Name = "DateTimeIN";
            DateTimeIN.Padding = new Padding(0, 2, 0, 2);
            DateTimeIN.Size = new Size(165, 27);
            DateTimeIN.TabIndex = 11;
            DateTimeIN.Text = " ";
            // 
            // PriceIN
            // 
            PriceIN.BackColor = SystemColors.Window;
            PriceIN.BorderStyle = BorderStyle.FixedSingle;
            PriceIN.Location = new Point(352, 265);
            PriceIN.Name = "PriceIN";
            PriceIN.Padding = new Padding(0, 2, 0, 2);
            PriceIN.Size = new Size(165, 27);
            PriceIN.TabIndex = 12;
            PriceIN.Text = " ";
            // 
            // LocationIN
            // 
            LocationIN.BackColor = SystemColors.Window;
            LocationIN.BorderStyle = BorderStyle.FixedSingle;
            LocationIN.Location = new Point(352, 157);
            LocationIN.Name = "LocationIN";
            LocationIN.Padding = new Padding(0, 2, 0, 2);
            LocationIN.Size = new Size(165, 27);
            LocationIN.TabIndex = 13;
            LocationIN.Text = " ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(79, 104);
            label6.Name = "label6";
            label6.Size = new Size(73, 28);
            label6.TabIndex = 14;
            label6.Text = "Name:";
            // 
            // NameIN
            // 
            NameIN.BackColor = SystemColors.Window;
            NameIN.BorderStyle = BorderStyle.FixedSingle;
            NameIN.Location = new Point(352, 110);
            NameIN.Name = "NameIN";
            NameIN.Padding = new Padding(0, 2, 0, 2);
            NameIN.Size = new Size(165, 27);
            NameIN.TabIndex = 15;
            NameIN.Text = " ";
            // 
            // JoinEvent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.joinEventBg;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(603, 386);
            Controls.Add(NameIN);
            Controls.Add(label6);
            Controls.Add(LocationIN);
            Controls.Add(PriceIN);
            Controls.Add(DateTimeIN);
            Controls.Add(BackBtn);
            Controls.Add(CancleBtn);
            Controls.Add(JoinBtn);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "JoinEvent";
            Text = "JoinEvent";
            Load += JoinEvent_Load;
            ((System.ComponentModel.ISupportInitialize)BackBtn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button JoinBtn;
        private Button CancleBtn;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox2;
        private PictureBox BackBtn;
        private Label label5;
        private Label DateTimeIN;
        private Label PriceIN;
        private Label LocationIN;
        private Label label6;
        private Label NameIN;
    }
}