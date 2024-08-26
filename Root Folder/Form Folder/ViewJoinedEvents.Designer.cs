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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            DisplayJoinedEvents = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DisplayJoinedEvents).BeginInit();
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
            // ViewJoinedEvents
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.viewJoinedEventsBg;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(548, 450);
            Controls.Add(DisplayJoinedEvents);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "ViewJoinedEvents";
            Text = "Joined Events";
            Load += ViewJoinedEvents_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)DisplayJoinedEvents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private DataGridView DisplayJoinedEvents;
    }
}