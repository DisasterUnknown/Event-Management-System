namespace Root_Folder.Form_Folder
{
    partial class ViewUserAccounts
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
            UserAccountGrid = new DataGridView();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            ViewDetailsBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)UserAccountGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // UserAccountGrid
            // 
            UserAccountGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            UserAccountGrid.Location = new Point(49, 89);
            UserAccountGrid.Name = "UserAccountGrid";
            UserAccountGrid.RowHeadersWidth = 51;
            UserAccountGrid.Size = new Size(701, 355);
            UserAccountGrid.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.backGlowBtn1;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(-5, -5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(63, 60);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(80, 34);
            label1.Name = "label1";
            label1.Size = new Size(231, 42);
            label1.TabIndex = 2;
            label1.Text = "User Accounts";
            // 
            // ViewDetailsBtn
            // 
            ViewDetailsBtn.BackColor = Color.FromArgb(0, 0, 10);
            ViewDetailsBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ViewDetailsBtn.ForeColor = SystemColors.Window;
            ViewDetailsBtn.Location = new Point(593, 39);
            ViewDetailsBtn.Name = "ViewDetailsBtn";
            ViewDetailsBtn.Size = new Size(126, 40);
            ViewDetailsBtn.TabIndex = 3;
            ViewDetailsBtn.Text = "View Details";
            ViewDetailsBtn.UseVisualStyleBackColor = false;
            ViewDetailsBtn.Click += ViewDetailsBtn_Click;
            // 
            // ViewUserAccounts
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 10);
            ClientSize = new Size(800, 484);
            Controls.Add(ViewDetailsBtn);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(UserAccountGrid);
            Name = "ViewUserAccounts";
            Text = "ViewUserAccounts";
            Load += ViewUserAccounts_Load;
            ((System.ComponentModel.ISupportInitialize)UserAccountGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView UserAccountGrid;
        private PictureBox pictureBox1;
        private Label label1;
        private Button ViewDetailsBtn;
    }
}