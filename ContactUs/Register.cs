using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ContactUs
{
    public partial class Register : Form
    {
        string passwordStrength = "";
        bool validPWStrength = false;
        bool IsPWEntered = false;

        public Register()
        {
            InitializeComponent();
            //progressPasswordStrengthBarTest.Maximum = 100;
            //progressPasswordStrengthBarTest.Minimum = 0;
            //progressPasswordStrengthBarTest.Value = 54;
            //progressPasswordStrengthBarTest.BackColor = Color.Red;
            progressPasswordStrengthBarTest.Visible = false;
            progressPasswordStrengthBarTest.Enabled = false;
            lbPWStrength.Visible = false;
            txtPassword.PasswordChar = '*';
            txtConfirmPassword.PasswordChar = '*';
            CenterToScreen();
        }

        public enum PasswordScore
        {
            Blank = 0,
            VeryWeak = 1,
            Weak = 2,
            Medium = 3,
            Strong = 4,
            VeryStrong = 5
        }

        public class PasswordAdvisor
        {
            public static PasswordScore CheckStrength(string password) //The actual logic for determinging the strength of the user's password.
            {
                int score = 0;
                //string[] specialCharacters[] = { "A", "A" };
                string[] specialCharacters = { "!", "@", "#", "$", "^", "&", "*", "?", "_", "~", "-", "£", "(", ")", "/", ".", ",", ";", ":", "=", "+", "<", ">", };
                string[] uppercaseCharacters = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", };
                //A
                string[] numbers = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", };
                if (password.Length < 1)
                    return PasswordScore.Blank;
                if (password.Length < 4)
                    return PasswordScore.VeryWeak;

                if (password.Length >= 8)
                    score++;
                if (password.Length >= 12)
                    score++;
                if (specialCharacters.Any(password.Contains))
                    score++;
                if (uppercaseCharacters.Any(password.Contains))
                    score++;
                if (numbers.Any(password.Contains))
                    score++;

                return (PasswordScore)score;
            }
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void btnRegisterInstead_Click(object sender, EventArgs e)
        {
            Hide();
            new Login().Show();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            lbPWStrength.Visible = true;
            PasswordScore passwordStrengthScore = PasswordAdvisor.CheckStrength(txtPassword.Text); // A //Checks the strength of the user's password.

            switch (passwordStrengthScore) //Calculates the strength of the password. //It then changes the colour of the password display screen (font) depending on the strength.
            {
                case PasswordScore.Blank:
                    lbPWStrength.ForeColor = Color.Black;
                    //lbPasswordStrengthHere.Text = "Blank";
                    //lbPasswordStrengthHere.Text = "Incredibly Weak! Why not try changing your password below, but I'm not going to make you.";
                    lbPWStrength.Text = "";
                    IsPWEntered = false;
                    break;
                case PasswordScore.VeryWeak:
                    lbPWStrength.ForeColor = Color.Red;
                    lbPWStrength.Text = "Very Weak";
                    validPWStrength = false;
                    IsPWEntered = true;
                    break;
                case PasswordScore.Weak:
                    // Show an error message to the user
                    lbPWStrength.ForeColor = Color.Orange;
                    lbPWStrength.Text = "Weak";
                    validPWStrength = false;
                    IsPWEntered = true;
                    break;
                //break;
                case PasswordScore.Medium:
                    lbPWStrength.ForeColor = Color.Yellow;
                    lbPWStrength.Text = "Medium";
                    validPWStrength = true;
                    IsPWEntered = true;
                    break;
                case PasswordScore.Strong:
                    lbPWStrength.ForeColor = Color.Green;
                    lbPWStrength.Text = "Strong";
                    validPWStrength = true;
                    IsPWEntered = true;
                    break;
                case PasswordScore.VeryStrong:
                    // Password deemed strong enough, allow user to be added to database etc
                    lbPWStrength.ForeColor = Color.LawnGreen;
                    lbPWStrength.Text = "Very Strong! Well Done.";
                    validPWStrength = true;
                    IsPWEntered = true;
                    break;
                    //break;
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (!IsPWEntered)
            {
                MessageBox.Show("You didn't enter a password! Go back and enter one now!", "No password entered", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else if (!validPWStrength)
            {
                DialogResult dialogResult = MessageBox.Show("You didn't enter a very strong password, would you like to continue?","Not a strong password entered", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    ProceedRegister();
                }
            }
            else
            {
                ProceedRegister();
            }
        }

        private void ProceedRegister()
        {
            if (txtPassword.Text == txtConfirmPassword.Text)
            {
                //Proceed with Registration
                //Create a path to the user details
                var inDir = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
                string locationPath = ($@"{inDir}\ContactUsProgram");
                string filePath = /*@*/$@"{locationPath}\users.txt";/*\\*/

                if (!Directory.Exists(locationPath))
                {
                    Directory.CreateDirectory(locationPath);
                }

                FileStream aFile;
                StreamWriter sw;

                try
                {
                    //If a user file doesn't exist, create one
                    if (!File.Exists(filePath))
                    {
                        aFile = new FileStream(filePath, FileMode.Create, FileAccess.Write);
                    }
                    else
                    {
                        aFile = new FileStream(filePath, FileMode.Append, FileAccess.Write);
                    }
                    sw = new StreamWriter(aFile);
                    string username = txtUsername.Text;
                    string password = txtPassword.Text;
                    string favcolouraccent = cmbColour.Text;
                    string active = ("No");
                    int numberofcharactersinpassword = txtPassword.Text.Length;

                    connect.clocal.numberofcharactersinpassword = numberofcharactersinpassword;
                    string encrypted_username = classMD5Operation.EncryptString(username);
                    string encrypted_password = classMD5Operation.EncryptString(password);
                    string encrypted_favcolouraccent = classMD5Operation.EncryptString(favcolouraccent);
                    string encrypted_activeAccount = classMD5Operation.EncryptString(active);

                    if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password) && !string.IsNullOrEmpty(cmbColour.Text)) //Ensures that all fields are filled
                    {
                        sw.WriteLine($"{encrypted_username}~{encrypted_password}~{encrypted_favcolouraccent}~{encrypted_activeAccount}");

                        sw.Close();
                        aFile.Close();

                        txtUsername.Text = "";
                        txtPassword.Text = "";

                        Hide();
                        new Login().Show();

                        MessageBox.Show("User has been added successfully.", "Successful");
                    }
                    else
                    {
                        MessageBox.Show("Username and Password must not be empty.\r\nPlease also make sure that you have chosen an accent colour.", "Username or Password empty.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("User failed to add.\r\nThis can sometimes happen after you leave the Username, password "/*and" inconvienience*/+ ", or accent colour fields empty.\r\nPlease ensure that they are no longer empty, then click Register in around 10 seconds.\r\nSorry for any inconvenience.", "Error occurred");
                }
            }
            else
            {
                MessageBox.Show("", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
