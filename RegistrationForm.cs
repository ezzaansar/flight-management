using SE3.Models;
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
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string firstName = FirstNameBox.Text.Trim();
            string lastName = LastNameBox.Text.Trim();
            string gender = MaleRadioButton.Checked ? "Male" : "Female";
            DateOnly dateOfBirth = DateOnly.FromDateTime(dateTimePicker2.Value.Date);
            string cnic = CNICTextBox.Text.Trim();
            string email = EmailTextBox.Text.Trim();
            string phoneNumber = PhoneNumberTextBox.Text.Trim();
            string address = AddressTextBox.Text.Trim();
            string password = PasswordTextBox.Text.Trim();
            string country = CountryTextBox.Text.Trim();
            string city = CityTextBox.Text.Trim();
            string state = StateTextBox.Text.Trim();
            string confirmPassword = ConfirmPasswordTextBox.Text.Trim();

            if (
                firstName == string.Empty || lastName == string.Empty ||
                cnic == string.Empty || email == string.Empty ||
                phoneNumber == string.Empty || address == string.Empty ||
                password == string.Empty || country == string.Empty ||
                city == string.Empty || state == string.Empty
            ) return;

            if (confirmPassword != password) return;

            var service = DatabaseService.Instance;
            var user = service.GetUser(email, password);

            if (user != null) {
                MessageBox.Show("User already exists!");
            } else {
                var newUser = new User(
                    UserId: -1,
                    FirstName: firstName,
                    LastName: lastName,
                    Gender: gender,
                    DateOfBirth: dateOfBirth,
                    CNIC: cnic,
                    Email: email,
                    PhoneNumber: phoneNumber,
                    Address: address,
                    Password: password,
                    Country: country,
                    City: city,
                    State: state
                );
                var savedUser = service.SaveUser(newUser);
                if (savedUser != null) {
                    UserService.Instance.SetCurrentUser(savedUser);
                    HomePage home = new HomePage();
                    home.Show();
                } else {
                    MessageBox.Show("Failed to register user!");
                }
            }
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

        private void button3_Click(object sender, EventArgs e)
        {
            LoginForm form1 = new LoginForm();
            form1.Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void CountryTextBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void CityTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
