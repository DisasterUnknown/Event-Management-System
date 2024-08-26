namespace Root_Folder
{
    partial class CreateEvent
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
            label5 = new Label();
            label6 = new Label();
            EventNameIN = new TextBox();
            PlaceIN = new TextBox();
            DateTimeIN = new DateTimePicker();
            EventCreation = new Button();
            PriceIN = new TextBox();
            PamountIN = new MaskedTextBox();
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
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(165, 39);
            label1.Name = "label1";
            label1.Size = new Size(222, 40);
            label1.TabIndex = 1;
            label1.Text = "Add Event";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(92, 129);
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
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(92, 182);
            label3.Name = "label3";
            label3.Size = new Size(73, 28);
            label3.TabIndex = 3;
            label3.Text = "Place: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(92, 230);
            label4.Name = "label4";
            label4.Size = new Size(64, 28);
            label4.TabIndex = 4;
            label4.Text = "Time:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(92, 277);
            label5.Name = "label5";
            label5.Size = new Size(137, 28);
            label5.TabIndex = 5;
            label5.Text = "Ticket Count:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label6.ForeColor = SystemColors.ButtonFace;
            label6.Location = new Point(92, 323);
            label6.Name = "label6";
            label6.Size = new Size(64, 28);
            label6.TabIndex = 6;
            label6.Text = "Price:";
            // 
            // EventNameIN
            // 
            EventNameIN.Location = new Point(280, 133);
            EventNameIN.Name = "EventNameIN";
            EventNameIN.Size = new Size(187, 27);
            EventNameIN.TabIndex = 1;
            // 
            // PlaceIN
            // 
            PlaceIN.Location = new Point(280, 186);
            PlaceIN.Name = "PlaceIN";
            PlaceIN.Size = new Size(187, 27);
            PlaceIN.TabIndex = 2;
            // 
            // DateTimeIN
            // 
            DateTimeIN.CustomFormat = "dd/MM/yyyy hh:mm tt";
            DateTimeIN.Format = DateTimePickerFormat.Custom;
            DateTimeIN.Location = new Point(280, 232);
            DateTimeIN.Name = "DateTimeIN";
            DateTimeIN.Size = new Size(187, 27);
            DateTimeIN.TabIndex = 3;
            // 
            // EventCreation
            // 
            EventCreation.BackColor = SystemColors.ControlDark;
            EventCreation.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            EventCreation.Location = new Point(230, 409);
            EventCreation.Name = "EventCreation";
            EventCreation.Size = new Size(94, 29);
            EventCreation.TabIndex = 6;
            EventCreation.Text = "Conform";
            EventCreation.UseVisualStyleBackColor = false;
            EventCreation.Click += EventCreation_Click;
            // 
            // PriceIN
            // 
            PriceIN.Location = new Point(280, 327);
            PriceIN.Name = "PriceIN";
            PriceIN.Size = new Size(187, 27);
            PriceIN.TabIndex = 5;
            PriceIN.TextChanged += PriceIN_TextChanged;
            // 
            // PamountIN
            // 
            PamountIN.Location = new Point(280, 281);
            PamountIN.Mask = "00000";
            PamountIN.Name = "PamountIN";
            PamountIN.PromptChar = ' ';
            PamountIN.Size = new Size(187, 27);
            PamountIN.TabIndex = 4;
            // 
            // CreateEvent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.addEventBg;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(535, 450);
            Controls.Add(PamountIN);
            Controls.Add(PriceIN);
            Controls.Add(EventCreation);
            Controls.Add(DateTimeIN);
            Controls.Add(PlaceIN);
            Controls.Add(EventNameIN);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BackBtn);
            Name = "CreateEvent";
            Text = "CreateEvent";
            Load += CreateEvent_Load;
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
        private Label label5;
        private Label label6;
        private TextBox EventNameIN;
        private TextBox PlaceIN;
        private DateTimePicker DateTimeIN;
        private Button EventCreation;
        private TextBox PriceIN;
        private MaskedTextBox PamountIN;
    }
}