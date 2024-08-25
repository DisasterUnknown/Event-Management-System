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
            button2 = new Button();
            ViewJoinPageBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)EventDashBord).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Cooper Black", 20F, FontStyle.Bold);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(330, 29);
            label1.Name = "label1";
            label1.Size = new Size(140, 39);
            label1.TabIndex = 0;
            label1.Text = "Events";
            // 
            // EventDashBord
            // 
            EventDashBord.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            EventDashBord.Location = new Point(72, 90);
            EventDashBord.Name = "EventDashBord";
            EventDashBord.RowHeadersWidth = 51;
            EventDashBord.Size = new Size(656, 509);
            EventDashBord.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.AppWorkspace;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button1.Location = new Point(694, 12);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 4;
            button1.Text = "LogOut";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ControlDark;
            button2.Font = new Font("Rockwell Extra Bold", 9F, FontStyle.Bold);
            button2.Location = new Point(649, 650);
            button2.Name = "button2";
            button2.Size = new Size(139, 29);
            button2.TabIndex = 5;
            button2.Text = "View Joined";
            button2.UseVisualStyleBackColor = false;
            // 
            // ViewJoinPageBtn
            // 
            ViewJoinPageBtn.BackColor = SystemColors.ControlDark;
            ViewJoinPageBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ViewJoinPageBtn.Location = new Point(356, 605);
            ViewJoinPageBtn.Name = "ViewJoinPageBtn";
            ViewJoinPageBtn.Size = new Size(94, 29);
            ViewJoinPageBtn.TabIndex = 6;
            ViewJoinPageBtn.Text = "Join Event";
            ViewJoinPageBtn.UseVisualStyleBackColor = false;
            ViewJoinPageBtn.Click += ViewJoinPageBtn_Click;
            // 
            // CustemerDashbord
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.customerBg;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 691);
            Controls.Add(ViewJoinPageBtn);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(EventDashBord);
            Controls.Add(label1);
            Name = "CustemerDashbord";
            Text = "Custemer Dashbord";
            Load += CustemerDashbord_Load;
            ((System.ComponentModel.ISupportInitialize)EventDashBord).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView EventDashBord;
        private Button button1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button button2;
        private Button ViewJoinPageBtn;
    }
}