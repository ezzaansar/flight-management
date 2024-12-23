using System.Drawing.Drawing2D;
using MySqlConnector;

namespace SE3
{
    public partial class LoginForm : Form
    {

        public LoginForm()
        {
            InitializeComponent();
            panel1.Paint += panel1_Paint; // Attach the Paint event
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // Define the gradient colors

            Color startColor = ColorTranslator.FromHtml("#148f77");
            Color endColor = ColorTranslator.FromHtml("#633974");

            // Create a LinearGradientBrush
            using (LinearGradientBrush brush = new LinearGradientBrush(
                panel1.ClientRectangle, // Area for the gradient
                startColor,             // Start color
                endColor,               // End color
                LinearGradientMode.Vertical)) // Vertical gradient
            {
                // Fill the panel background with the gradient
                e.Graphics.FillRectangle(brush, panel1.ClientRectangle);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to exit?",
                                       "Exit Application",
                                       MessageBoxButtons.YesNo,
                                       MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AdminLogin form2 = new AdminLogin();
            form2.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegistrationForm form3 = new RegistrationForm();
            form3.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = EmailTextBox.Text;
            string password = PasswordTextBox.Text;

            if (email == string.Empty || password.Length < 8) return;

            var service = DatabaseService.Instance;

            var user = service.GetUser(email, password);

            if (user != null)
            {
                UserService.Instance.SetCurrentUser(user);
                HomePage home = new HomePage();
                home.Show();
            }
            else
            {
                MessageBox.Show("Login failed. User doesn't exist.");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
