namespace Root_Folder
{
    partial class OganizerDashbord
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
            EventTable = new DataGridView();
            LogOutBtn = new Button();
            EventRemoveBtn = new Button();
            UpdateEvent = new Button();
            AddEventBtn = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ViewDetailsBtn = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)EventTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Cooper Black", 20F, FontStyle.Bold);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(266, 22);
            label1.Name = "label1";
            label1.Size = new Size(140, 39);
            label1.TabIndex = 4;
            label1.Text = "Events";
            // 
            // EventTable
            // 
            EventTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            EventTable.Location = new Point(265, 76);
            EventTable.Name = "EventTable";
            EventTable.RowHeadersWidth = 51;
            EventTable.Size = new Size(656, 509);
            EventTable.TabIndex = 20;
            // 
            // LogOutBtn
            // 
            LogOutBtn.BackColor = Color.FromArgb(0, 0, 30);
            LogOutBtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            LogOutBtn.ForeColor = SystemColors.Window;
            LogOutBtn.Location = new Point(42, 535);
            LogOutBtn.Name = "LogOutBtn";
            LogOutBtn.Size = new Size(144, 50);
            LogOutBtn.TabIndex = 5;
            LogOutBtn.Text = "LogOut";
            LogOutBtn.UseVisualStyleBackColor = false;
            LogOutBtn.Click += LogOutBtn_Click;
            // 
            // EventRemoveBtn
            // 
            EventRemoveBtn.BackColor = Color.FromArgb(0, 0, 30);
            EventRemoveBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            EventRemoveBtn.ForeColor = SystemColors.Window;
            EventRemoveBtn.Location = new Point(42, 173);
            EventRemoveBtn.Name = "EventRemoveBtn";
            EventRemoveBtn.Size = new Size(144, 50);
            EventRemoveBtn.TabIndex = 3;
            EventRemoveBtn.Text = "Remove";
            EventRemoveBtn.UseVisualStyleBackColor = false;
            EventRemoveBtn.Click += EventRemoveBtn_Click;
            // 
            // UpdateEvent
            // 
            UpdateEvent.BackColor = Color.FromArgb(0, 0, 30);
            UpdateEvent.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            UpdateEvent.ForeColor = SystemColors.Window;
            UpdateEvent.Location = new Point(42, 29);
            UpdateEvent.Name = "UpdateEvent";
            UpdateEvent.Size = new Size(144, 50);
            UpdateEvent.TabIndex = 1;
            UpdateEvent.Text = "Update";
            UpdateEvent.UseVisualStyleBackColor = false;
            UpdateEvent.Click += UpdateEvent_Click;
            // 
            // AddEventBtn
            // 
            AddEventBtn.BackColor = Color.FromArgb(0, 0, 10);
            AddEventBtn.FlatAppearance.BorderColor = Color.Navy;
            AddEventBtn.FlatAppearance.MouseDownBackColor = Color.Navy;
            AddEventBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 128, 255);
            AddEventBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            AddEventBtn.ForeColor = SystemColors.Window;
            AddEventBtn.Location = new Point(798, 29);
            AddEventBtn.Name = "AddEventBtn";
            AddEventBtn.Size = new Size(113, 31);
            AddEventBtn.TabIndex = 4;
            AddEventBtn.Text = "Add Event";
            AddEventBtn.UseVisualStyleBackColor = false;
            AddEventBtn.Click += AddEventBtn_Click;
            // 
            // ViewDetailsBtn
            // 
            ViewDetailsBtn.BackColor = Color.FromArgb(0, 0, 30);
            ViewDetailsBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ViewDetailsBtn.ForeColor = SystemColors.Window;
            ViewDetailsBtn.Location = new Point(42, 100);
            ViewDetailsBtn.Name = "ViewDetailsBtn";
            ViewDetailsBtn.Size = new Size(144, 50);
            ViewDetailsBtn.TabIndex = 2;
            ViewDetailsBtn.Text = "View Details";
            ViewDetailsBtn.UseVisualStyleBackColor = false;
            ViewDetailsBtn.Click += ViewDetailsBtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(0, 0, 30);
            pictureBox1.Location = new Point(-8, -12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(237, 708);
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // OganizerDashbord
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 10);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(962, 609);
            Controls.Add(ViewDetailsBtn);
            Controls.Add(AddEventBtn);
            Controls.Add(UpdateEvent);
            Controls.Add(EventRemoveBtn);
            Controls.Add(LogOutBtn);
            Controls.Add(EventTable);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "OganizerDashbord";
            Text = "OganizerDashbord";
            Load += OganizerDashbord_Load;
            ((System.ComponentModel.ISupportInitialize)EventTable).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private DataGridView EventTable;
        private Button LogOutBtn;
        private Button EventRemoveBtn;
        private Button UpdateEvent;
        private Button AddEventBtn;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button ViewDetailsBtn;
        private PictureBox pictureBox1;
    }
}