namespace Root_Folder
{
    partial class ViewJoinedEvents
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
            DisplayJoinedEvents = new DataGridView();
            LeaveBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)BackBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DisplayJoinedEvents).BeginInit();
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
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(122, 36);
            label1.Name = "label1";
            label1.Size = new Size(296, 40);
            label1.TabIndex = 1;
            label1.Text = "Joined Events";
            // 
            // DisplayJoinedEvents
            // 
            DisplayJoinedEvents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DisplayJoinedEvents.Location = new Point(29, 109);
            DisplayJoinedEvents.Name = "DisplayJoinedEvents";
            DisplayJoinedEvents.RowHeadersWidth = 51;
            DisplayJoinedEvents.Size = new Size(484, 312);
            DisplayJoinedEvents.TabIndex = 2;
            // 
            // LeaveBtn
            // 
            LeaveBtn.BackColor = SystemColors.ControlDark;
            LeaveBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LeaveBtn.Location = new Point(219, 434);
            LeaveBtn.Name = "LeaveBtn";
            LeaveBtn.Size = new Size(114, 29);
            LeaveBtn.TabIndex = 3;
            LeaveBtn.Text = "Leave Event";
            LeaveBtn.UseVisualStyleBackColor = false;
            LeaveBtn.Click += LeaveBtn_Click;
            // 
            // ViewJoinedEvents
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.viewJoinedEventsBg;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(548, 475);
            Controls.Add(LeaveBtn);
            Controls.Add(DisplayJoinedEvents);
            Controls.Add(label1);
            Controls.Add(BackBtn);
            Name = "ViewJoinedEvents";
            Text = "Joined Events";
            Load += ViewJoinedEvents_Load;
            ((System.ComponentModel.ISupportInitialize)BackBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)DisplayJoinedEvents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox BackBtn;
        private Label label1;
        private DataGridView DisplayJoinedEvents;
        private Button LeaveBtn;
    }
}