namespace Root_Folder
{
    public partial class HomePage : Form
    {
        private string role;

        public HomePage()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string role = "particepent";
            LoginPage l1 = new LoginPage(role);
            l1.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string role = "particepent";
            LoginPage l1 = new LoginPage(role);
            l1.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string role = "orgnizer";
            LoginPage l1 = new LoginPage(role);
            l1.Show();
            this.Hide();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string role = "orgnizer";
            LoginPage l1 = new LoginPage(role);
            l1.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            string role = "admin";
            LoginPage l1 = new LoginPage(role);
            l1.Show();
            this.Hide();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string role = "admin";
            LoginPage l1 = new LoginPage(role);
            l1.Show();
            this.Hide();
        }
    }
}
