namespace Root_Folder
{
    partial class CustemerDashbord
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
            EventDashBord = new DataGridView();
            button1 = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ViewJoined = new Button();
            ViewJoinPageBtn = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)EventDashBord).BeginInit();
            panel1.SuspendLayout();
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
            label1.TabIndex = 0;
            label1.Text = "Events";
            // 
            // EventDashBord
            // 
            EventDashBord.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            EventDashBord.Location = new Point(265, 76);
            EventDashBord.Name = "EventDashBord";
            EventDashBord.RowHeadersWidth = 51;
            EventDashBord.Size = new Size(656, 509);
            EventDashBord.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 0, 30);
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button1.ForeColor = SystemColors.Window;
            button1.Location = new Point(42, 535);
            button1.Name = "button1";
            button1.Size = new Size(144, 50);
            button1.TabIndex = 4;
            button1.Text = "LogOut";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // ViewJoined
            // 
            ViewJoined.BackColor = Color.FromArgb(0, 0, 30);
            ViewJoined.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ViewJoined.ForeColor = SystemColors.Window;
            ViewJoined.Location = new Point(50, 41);
            ViewJoined.Name = "ViewJoined";
            ViewJoined.Size = new Size(144, 50);
            ViewJoined.TabIndex = 5;
            ViewJoined.Text = "View Joined";
            ViewJoined.UseVisualStyleBackColor = false;
            ViewJoined.Click += ViewJoined_Click;
            // 
            // ViewJoinPageBtn
            // 
            ViewJoinPageBtn.BackColor = Color.FromArgb(0, 0, 10);
            ViewJoinPageBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ViewJoinPageBtn.ForeColor = SystemColors.Window;
            ViewJoinPageBtn.Location = new Point(798, 29);
            ViewJoinPageBtn.Name = "ViewJoinPageBtn";
            ViewJoinPageBtn.Size = new Size(113, 31);
            ViewJoinPageBtn.TabIndex = 6;
            ViewJoinPageBtn.Text = "Join Event";
            ViewJoinPageBtn.UseVisualStyleBackColor = false;
            ViewJoinPageBtn.Click += ViewJoinPageBtn_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 0, 30);
            panel1.Controls.Add(ViewJoined);
            panel1.Location = new Point(-8, -12);
            panel1.Name = "panel1";
            panel1.Size = new Size(237, 708);
            panel1.TabIndex = 7;
            // 
            // CustemerDashbord
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 10);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(962, 609);
            Controls.Add(ViewJoinPageBtn);
            Controls.Add(button1);
            Controls.Add(EventDashBord);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "CustemerDashbord";
            Text = "Custemer Dashbord";
            Load += CustemerDashbord_Load;
            ((System.ComponentModel.ISupportInitialize)EventDashBord).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView EventDashBord;
        private Button button1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button ViewJoined;
        private Button ViewJoinPageBtn;
        private Panel panel1;
    }
}