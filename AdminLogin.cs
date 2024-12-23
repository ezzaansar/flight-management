using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SE3
{
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
            panel1.Paint += panel1_Paint; // Attach the Paint event
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // Define the gradient colors
            Color startColor = ColorTranslator.FromHtml("#633974");
            Color endColor = ColorTranslator.FromHtml("#148f77");

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

        private void button2_Click(object sender, EventArgs e)
        {
            LoginForm form1 = new LoginForm();
            form1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var email = EmailTextBox.Text.Trim();
            var password = PasswordTextBox.Text.Trim();

            if (email == string.Empty || password == string.Empty) return;

            var databaseService = DatabaseService.Instance;
            var userService = UserService.Instance;

            var user = databaseService.GetUser(email, password);
            if (user == null)
            {
                MessageBox.Show("User not found!");
                return;
            }
            
            if (user.Role == "User")
            {
                MessageBox.Show("User is not admin!");
                return;
            }

            userService.SetCurrentUser(user);
            AdminHomePage adminHomePage = new AdminHomePage();
            adminHomePage.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
