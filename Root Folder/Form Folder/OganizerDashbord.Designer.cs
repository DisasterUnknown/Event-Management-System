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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            EventTable = new DataGridView();
            LogOutBtn = new Button();
            EventRemoveBtn = new Button();
            UpdateEvent = new Button();
            AddEventBtn = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ViewDetailsBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)EventTable).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(72, 90);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(48, 48);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Cooper Black", 20F, FontStyle.Bold);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(275, 33);
            label1.Name = "label1";
            label1.Size = new Size(254, 39);
            label1.TabIndex = 4;
            label1.Text = "Organization";
            // 
            // EventTable
            // 
            EventTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            EventTable.Location = new Point(72, 90);
            EventTable.Name = "EventTable";
            EventTable.RowHeadersWidth = 51;
            EventTable.Size = new Size(656, 509);
            EventTable.TabIndex = 5;
            // 
            // LogOutBtn
            // 
            LogOutBtn.BackColor = SystemColors.ControlDark;
            LogOutBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            LogOutBtn.Location = new Point(694, 12);
            LogOutBtn.Name = "LogOutBtn";
            LogOutBtn.Size = new Size(94, 29);
            LogOutBtn.TabIndex = 6;
            LogOutBtn.Text = "LogOut";
            LogOutBtn.UseVisualStyleBackColor = false;
            LogOutBtn.Click += LogOutBtn_Click;
            // 
            // EventRemoveBtn
            // 
            EventRemoveBtn.BackColor = SystemColors.ControlDark;
            EventRemoveBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            EventRemoveBtn.Location = new Point(125, 605);
            EventRemoveBtn.Name = "EventRemoveBtn";
            EventRemoveBtn.Size = new Size(94, 29);
            EventRemoveBtn.TabIndex = 8;
            EventRemoveBtn.Text = "Remove";
            EventRemoveBtn.UseVisualStyleBackColor = false;
            EventRemoveBtn.Click += EventRemoveBtn_Click;
            // 
            // UpdateEvent
            // 
            UpdateEvent.BackColor = SystemColors.ControlDark;
            UpdateEvent.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            UpdateEvent.Location = new Point(296, 605);
            UpdateEvent.Name = "UpdateEvent";
            UpdateEvent.Size = new Size(94, 29);
            UpdateEvent.TabIndex = 9;
            UpdateEvent.Text = "Update";
            UpdateEvent.UseVisualStyleBackColor = false;
            UpdateEvent.Click += UpdateEvent_Click;
            // 
            // AddEventBtn
            // 
            AddEventBtn.BackColor = SystemColors.ControlDark;
            AddEventBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            AddEventBtn.Location = new Point(583, 605);
            AddEventBtn.Name = "AddEventBtn";
            AddEventBtn.Size = new Size(94, 29);
            AddEventBtn.TabIndex = 10;
            AddEventBtn.Text = "Add";
            AddEventBtn.UseVisualStyleBackColor = false;
            AddEventBtn.Click += AddEventBtn_Click;
            // 
            // ViewDetailsBtn
            // 
            ViewDetailsBtn.BackColor = SystemColors.ControlDark;
            ViewDetailsBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ViewDetailsBtn.Location = new Point(431, 605);
            ViewDetailsBtn.Name = "ViewDetailsBtn";
            ViewDetailsBtn.Size = new Size(109, 29);
            ViewDetailsBtn.TabIndex = 11;
            ViewDetailsBtn.Text = "View Details";
            ViewDetailsBtn.UseVisualStyleBackColor = false;
            ViewDetailsBtn.Click += ViewDetailsBtn_Click;
            // 
            // OganizerDashbord
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.oganizerBg;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 691);
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)EventTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private DataGridView EventTable;
        private Button LogOutBtn;
        private Button EventRemoveBtn;
        private Button UpdateEvent;
        private Button AddEventBtn;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button ViewDetailsBtn;
    }
}