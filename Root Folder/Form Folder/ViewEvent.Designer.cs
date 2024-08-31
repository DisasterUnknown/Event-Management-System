namespace Root_Folder
{
    partial class ViewEvent
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
            BackBtn = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            ParticipentGrid = new DataGridView();
            NameIN = new Label();
            PlaceIN = new Label();
            DateTimeIN = new Label();
            PriceIN = new Label();
            SeatsCountIN = new Label();
            DetailsBtn = new Button();
            label7 = new Label();
            OrgIN = new Label();
            ((System.ComponentModel.ISupportInitialize)BackBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ParticipentGrid).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Rockwell Extra Bold", 20F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(168, 26);
            label1.Name = "label1";
            label1.Size = new Size(287, 40);
            label1.TabIndex = 0;
            label1.Text = "Event Details";
            // 
            // BackBtn
            // 
            BackBtn.BackColor = Color.Transparent;
            BackBtn.BackgroundImage = Properties.Resources.backGlowBtn1;
            BackBtn.BackgroundImageLayout = ImageLayout.Stretch;
            BackBtn.Location = new Point(-5, -5);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(63, 60);
            BackBtn.TabIndex = 1;
            BackBtn.TabStop = false;
            BackBtn.Click += BackBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(103, 99);
            label2.Name = "label2";
            label2.Size = new Size(79, 28);
            label2.TabIndex = 2;
            label2.Text = "Name: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(103, 148);
            label3.Name = "label3";
            label3.Size = new Size(67, 28);
            label3.TabIndex = 3;
            label3.Text = "Place:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(103, 197);
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
            label5.ForeColor = Color.White;
            label5.Location = new Point(103, 244);
            label5.Name = "label5";
            label5.Size = new Size(64, 28);
            label5.TabIndex = 5;
            label5.Text = "Price:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(103, 292);
            label6.Name = "label6";
            label6.Size = new Size(201, 28);
            label6.TabIndex = 6;
            label6.Text = "Participant amount:";
            // 
            // ParticipentGrid
            // 
            ParticipentGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ParticipentGrid.Location = new Point(50, 384);
            ParticipentGrid.Name = "ParticipentGrid";
            ParticipentGrid.RowHeadersWidth = 51;
            ParticipentGrid.Size = new Size(504, 226);
            ParticipentGrid.TabIndex = 12;
            // 
            // NameIN
            // 
            NameIN.BackColor = SystemColors.Window;
            NameIN.BorderStyle = BorderStyle.FixedSingle;
            NameIN.Location = new Point(335, 101);
            NameIN.Name = "NameIN";
            NameIN.Padding = new Padding(0, 2, 0, 2);
            NameIN.Size = new Size(165, 27);
            NameIN.TabIndex = 13;
            NameIN.Text = " ";
            // 
            // PlaceIN
            // 
            PlaceIN.BackColor = SystemColors.Window;
            PlaceIN.BorderStyle = BorderStyle.FixedSingle;
            PlaceIN.Location = new Point(335, 149);
            PlaceIN.Name = "PlaceIN";
            PlaceIN.Padding = new Padding(0, 2, 0, 2);
            PlaceIN.Size = new Size(165, 27);
            PlaceIN.TabIndex = 14;
            PlaceIN.Text = " ";
            // 
            // DateTimeIN
            // 
            DateTimeIN.BackColor = SystemColors.Window;
            DateTimeIN.BorderStyle = BorderStyle.FixedSingle;
            DateTimeIN.Location = new Point(335, 197);
            DateTimeIN.Name = "DateTimeIN";
            DateTimeIN.Padding = new Padding(0, 2, 0, 2);
            DateTimeIN.Size = new Size(165, 27);
            DateTimeIN.TabIndex = 15;
            DateTimeIN.Text = " ";
            // 
            // PriceIN
            // 
            PriceIN.BackColor = SystemColors.Window;
            PriceIN.BorderStyle = BorderStyle.FixedSingle;
            PriceIN.Location = new Point(335, 245);
            PriceIN.Name = "PriceIN";
            PriceIN.Padding = new Padding(0, 2, 0, 2);
            PriceIN.Size = new Size(165, 27);
            PriceIN.TabIndex = 16;
            PriceIN.Text = " ";
            // 
            // SeatsCountIN
            // 
            SeatsCountIN.BackColor = SystemColors.Window;
            SeatsCountIN.BorderStyle = BorderStyle.FixedSingle;
            SeatsCountIN.Location = new Point(335, 293);
            SeatsCountIN.Name = "SeatsCountIN";
            SeatsCountIN.Padding = new Padding(0, 2, 0, 2);
            SeatsCountIN.Size = new Size(165, 27);
            SeatsCountIN.TabIndex = 17;
            SeatsCountIN.Text = " ";
            // 
            // DetailsBtn
            // 
            DetailsBtn.BackColor = SystemColors.ControlDark;
            DetailsBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DetailsBtn.Location = new Point(228, 629);
            DetailsBtn.Name = "DetailsBtn";
            DetailsBtn.Size = new Size(156, 29);
            DetailsBtn.TabIndex = 18;
            DetailsBtn.Text = "Participant Details";
            DetailsBtn.UseVisualStyleBackColor = false;
            DetailsBtn.Click += DetailsBtn_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.Control;
            label7.Location = new Point(103, 338);
            label7.Name = "label7";
            label7.Size = new Size(105, 28);
            label7.TabIndex = 19;
            label7.Text = "Organizer";
            // 
            // OrgIN
            // 
            OrgIN.BackColor = SystemColors.Window;
            OrgIN.Location = new Point(335, 340);
            OrgIN.Name = "OrgIN";
            OrgIN.Padding = new Padding(0, 2, 0, 2);
            OrgIN.Size = new Size(165, 27);
            OrgIN.TabIndex = 20;
            OrgIN.Text = " ";
            // 
            // ViewEvent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.viewEventBg;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(612, 675);
            Controls.Add(OrgIN);
            Controls.Add(label7);
            Controls.Add(DetailsBtn);
            Controls.Add(SeatsCountIN);
            Controls.Add(PriceIN);
            Controls.Add(DateTimeIN);
            Controls.Add(PlaceIN);
            Controls.Add(NameIN);
            Controls.Add(ParticipentGrid);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(BackBtn);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ViewEvent";
            Text = "View Event";
            Load += ViewEvent_Load;
            ((System.ComponentModel.ISupportInitialize)BackBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)ParticipentGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox BackBtn;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private DataGridView ParticipentGrid;
        private Label NameIN;
        private Label PlaceIN;
        private Label DateTimeIN;
        private Label PriceIN;
        private Label SeatsCountIN;
        private Button DetailsBtn;
        private Label label7;
        private Label OrgIN;
    }
}