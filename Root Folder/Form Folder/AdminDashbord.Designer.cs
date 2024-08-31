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
            ((System.ComponentModel.ISupportInitialize)EventListTable).BeginInit();
            SuspendLayout();
            // 
            // LogOutBtn
            // 
            LogOutBtn.BackColor = SystemColors.ControlDark;
            LogOutBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            LogOutBtn.Location = new Point(694, 12);
            LogOutBtn.Name = "LogOutBtn";
            LogOutBtn.Size = new Size(94, 29);
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
            EventListTable.Location = new Point(72, 90);
            EventListTable.Name = "EventListTable";
            EventListTable.RowHeadersWidth = 51;
            EventListTable.Size = new Size(656, 509);
            EventListTable.TabIndex = 4;
            // 
            // RemoveEventBtn
            // 
            RemoveEventBtn.BackColor = SystemColors.ControlDark;
            RemoveEventBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            RemoveEventBtn.Location = new Point(336, 605);
            RemoveEventBtn.Name = "RemoveEventBtn";
            RemoveEventBtn.Size = new Size(127, 29);
            RemoveEventBtn.TabIndex = 5;
            RemoveEventBtn.Text = "Remove Event";
            RemoveEventBtn.UseVisualStyleBackColor = false;
            RemoveEventBtn.Click += RemoveEventBtn_Click;
            // 
            // ViewEventDetailsBtn
            // 
            ViewEventDetailsBtn.Location = new Point(142, 605);
            ViewEventDetailsBtn.Name = "ViewEventDetailsBtn";
            ViewEventDetailsBtn.Size = new Size(126, 29);
            ViewEventDetailsBtn.TabIndex = 6;
            ViewEventDetailsBtn.Text = "View Details";
            ViewEventDetailsBtn.UseVisualStyleBackColor = true;
            ViewEventDetailsBtn.Click += ViewEventDetailsBtn_Click;
            // 
            // AdminDashbord
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.adminBg;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 691);
            Controls.Add(ViewEventDetailsBtn);
            Controls.Add(RemoveEventBtn);
            Controls.Add(EventListTable);
            Controls.Add(label1);
            Controls.Add(LogOutBtn);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "AdminDashbord";
            Text = "Admin Dashbord";
            Load += AdminDashbord_Load;
            ((System.ComponentModel.ISupportInitialize)EventListTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button LogOutBtn;
        private Label label1;
        private DataGridView EventListTable;
        private Button RemoveEventBtn;
        private Button ViewEventDetailsBtn;
    }
}