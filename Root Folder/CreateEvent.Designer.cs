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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            textBox3 = new TextBox();
            button1 = new Button();
            PriceIN = new TextBox();
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
            label5.Size = new Size(93, 28);
            label5.TabIndex = 5;
            label5.Text = "Amount:";
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
            // textBox1
            // 
            textBox1.Location = new Point(280, 133);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(187, 27);
            textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(280, 186);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(187, 27);
            textBox2.TabIndex = 8;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "dd/MM/yyyy h:mm tt";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(280, 232);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(187, 27);
            dateTimePicker1.TabIndex = 9;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(280, 281);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(187, 27);
            textBox3.TabIndex = 10;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlDark;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button1.Location = new Point(230, 409);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 12;
            button1.Text = "Conform";
            button1.UseVisualStyleBackColor = false;
            // 
            // PriceIN
            // 
            PriceIN.Location = new Point(280, 327);
            PriceIN.Name = "PriceIN";
            PriceIN.Size = new Size(187, 27);
            PriceIN.TabIndex = 13;
            PriceIN.TextChanged += PriceIN_TextChanged;
            // 
            // CreateEvent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.addEventBg;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(535, 450);
            Controls.Add(PriceIN);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "CreateEvent";
            Text = "CreateEvent";
            Load += CreateEvent_Load;
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
        private TextBox textBox1;
        private TextBox textBox2;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox3;
        private Button button1;
        private TextBox PriceIN;
    }
}