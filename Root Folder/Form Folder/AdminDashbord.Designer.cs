namespace Root_Folder
{
    partial class AdminDashbord
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
            LogOutBtn = new Button();
            label1 = new Label();
            EventListTable = new DataGridView();
            RemoveEventBtn = new Button();
            ViewEventDetailsBtn = new Button();
            panel1 = new Panel();
            ViewUsersBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)EventListTable).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // LogOutBtn
            // 
            LogOutBtn.BackColor = Color.FromArgb(0, 0, 30);
            LogOutBtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            LogOutBtn.ForeColor = SystemColors.Window;
            LogOutBtn.Location = new Point(42, 535);
            LogOutBtn.Name = "LogOutBtn";
            LogOutBtn.Size = new Size(144, 50);
            LogOutBtn.TabIndex = 2;
            LogOutBtn.Text = "LogOut";
            LogOutBtn.UseVisualStyleBackColor = false;
            LogOutBtn.Click += LogOutBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Cooper Black", 20F, FontStyle.Bold);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(268, 29);
            label1.Name = "label1";
            label1.Size = new Size(277, 39);
            label1.TabIndex = 3;
            label1.Text = "Events Details";
            // 
            // EventListTable
            // 
            EventListTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            EventListTable.Location = new Point(265, 76);
            EventListTable.Name = "EventListTable";
            EventListTable.RowHeadersWidth = 51;
            EventListTable.Size = new Size(656, 509);
            EventListTable.TabIndex = 4;
            // 
            // RemoveEventBtn
            // 
            RemoveEventBtn.BackColor = Color.FromArgb(0, 0, 30);
            RemoveEventBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            RemoveEventBtn.ForeColor = SystemColors.Window;
            RemoveEventBtn.Location = new Point(50, 41);
            RemoveEventBtn.Name = "RemoveEventBtn";
            RemoveEventBtn.Size = new Size(144, 50);
            RemoveEventBtn.TabIndex = 5;
            RemoveEventBtn.Text = "Remove Event";
            RemoveEventBtn.UseVisualStyleBackColor = false;
            RemoveEventBtn.Click += RemoveEventBtn_Click;
            // 
            // ViewEventDetailsBtn
            // 
            ViewEventDetailsBtn.BackColor = Color.FromArgb(0, 0, 10);
            ViewEventDetailsBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ViewEventDetailsBtn.ForeColor = SystemColors.Window;
            ViewEventDetailsBtn.Location = new Point(798, 29);
            ViewEventDetailsBtn.Name = "ViewEventDetailsBtn";
            ViewEventDetailsBtn.Size = new Size(113, 31);
            ViewEventDetailsBtn.TabIndex = 6;
            ViewEventDetailsBtn.Text = "View Details";
            ViewEventDetailsBtn.UseVisualStyleBackColor = false;
            ViewEventDetailsBtn.Click += ViewEventDetailsBtn_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 0, 30);
            panel1.Controls.Add(ViewUsersBtn);
            panel1.Controls.Add(RemoveEventBtn);
            panel1.Location = new Point(-8, -12);
            panel1.Name = "panel1";
            panel1.Size = new Size(237, 708);
            panel1.TabIndex = 7;
            // 
            // ViewUsersBtn
            // 
            ViewUsersBtn.BackColor = Color.FromArgb(0, 0, 30);
            ViewUsersBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ViewUsersBtn.ForeColor = SystemColors.Window;
            ViewUsersBtn.Location = new Point(50, 119);
            ViewUsersBtn.Name = "ViewUsersBtn";
            ViewUsersBtn.Size = new Size(144, 50);
            ViewUsersBtn.TabIndex = 6;
            ViewUsersBtn.Text = "View Acc";
            ViewUsersBtn.UseVisualStyleBackColor = false;
            ViewUsersBtn.Click += ViewUsersBtn_Click;
            // 
            // AdminDashbord
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 10);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(962, 609);
            Controls.Add(ViewEventDetailsBtn);
            Controls.Add(EventListTable);
            Controls.Add(label1);
            Controls.Add(LogOutBtn);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "AdminDashbord";
            Text = "Admin Dashbord";
            Load += AdminDashbord_Load;
            ((System.ComponentModel.ISupportInitialize)EventListTable).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button LogOutBtn;
        private Label label1;
        private DataGridView EventListTable;
        private Button RemoveEventBtn;
        private Button ViewEventDetailsBtn;
        private Panel panel1;
        private Button ViewUsersBtn;
    }
}