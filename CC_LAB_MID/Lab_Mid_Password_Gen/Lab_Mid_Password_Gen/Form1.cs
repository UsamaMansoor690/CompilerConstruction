using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Mid_Password_Gen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void generate_Click(object sender, EventArgs e)
        {
            string password = GeneratePassword();
            output.Text = password;
            int count = 0;
            for (int i = 0; i<password.Length; i++)
            {
                count = count + 1;
            }
            length.Text = count.ToString();
        }

        private string GeneratePassword()
        {
            Random random = new Random();
            StringBuilder password = new StringBuilder();

            // Rule (d): Must contain initials of first and last name, which are U and M
            password.Append("UM");

            // Rule (a): At least one uppercase alphabet
            char uppercaseChar = (char)random.Next('A', 'Z' + 1);
            password.Append(uppercaseChar);

            // Rule (b): At least 4 numbers, two numbers must be 2 and 6
            int[] requiredNumbers = { 2, 6 };
            int[] otherNumbers = { 0, 1, 3, 4, 5, 7, 8, 9 };
            for (int i = 0; i < 2; i++)
            {
                int num = requiredNumbers[i];
                password.Append(num);
            }
            for (int i = 0; i < 3; i++)
            {
                int num = otherNumbers[random.Next(otherNumbers.Length)];
                password.Append(num);
            }

            // Rule (c): At least 2 special characters
            string specialChars = "!@#$%^&*()_+";
            int chrr = random.Next(2, 7);
            for (int i = 0; i < chrr; i++)
            {
                char specialChar = specialChars[random.Next(specialChars.Length)];
                password.Append(specialChar);
            }

            // Shuffle the characters in the password for better randomness
            string shuffledPassword = new string(password.ToString().ToCharArray().OrderBy(x => random.Next()).ToArray());

            // Ensure the password length does not exceed 16 characters
            return shuffledPassword.Length <= 16 ? shuffledPassword : shuffledPassword.Substring(0, 16);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
