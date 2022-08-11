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
    public partial class Login : Form
    {
        string[] users;
        string[] usernameandpassword;
        bool userFound;

        public Login()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*';
            CenterToScreen();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnRegisterInstead_Click(object sender, EventArgs e)
        {
            Hide();
            new Register().Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            connect.clocal.user_pw = txtPassword.Text;

            if (txtPassword.Text == "" || txtUsername.Text == "")
            {
                MessageBox.Show("Please enter a username and password to continue!", "No username or password entered", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                connect.clocal.user/*_clear*/ = txtUsername.Text;

                string username_input_clear = txtUsername.Text;
                string password_input_clear = txtPassword.Text;
                string favcolouraccent_input_clear = "default";
                //string old_input_clear = "default";
                string old_input_clear = "No";

                string username_input_encrypted = classMD5Operation.EncryptString(username_input_clear);
                string password_input_encrypted = classMD5Operation.EncryptString(password_input_clear);
                string favcolouraccent_input_encrypted = classMD5Operation.EncryptString(favcolouraccent_input_clear);
                string old_input_encrypted = classMD5Operation.EncryptString(old_input_clear);

                if (txtUsername.Text == "" && txtPassword.Text == "")
                {
                    MessageBox.Show("Please enter your username and password.");
                }
                else
                {
                    //Hide();
                    //new frmDashboard().Show();
                    var inDir = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
                    string locationPath = ($@"{inDir}\ContactUsProgram");
                    string filePath = /*@*/$@"{locationPath}\users.txt";/*\\*/
                    if (File.Exists($@"{filePath}"))
                    {
                        users = File.ReadLines($@"{filePath}").ToArray();
                        userFound = false;
                        for (int i = 0; i < users.Length; i++) //Searches through the users file to find the correct user.
                        {

                            usernameandpassword = users[i].Split('~');
                            favcolouraccent_input_clear = usernameandpassword[2];
                            //old = usernameandpassword[3];
                            //frmPupilPersonalDetails.skiPupil.oldStatus = old;
                            if (username_input_encrypted == usernameandpassword[0] && password_input_encrypted == usernameandpassword[1]/* && favcolouraccent == usernameandpassword[2]*//* && usernameandpassword[3] == "No"*//* && usernameandpassword[3] == old_input_encrypted*/ && usernameandpassword[3] == old_input_encrypted)
                            {
                                userFound = true;
                                connect.clocal.password/*_clear*/ = password_input_clear;
                                connect.clocal.userlinenumber = i;
                                connect.clocal.password_encrypted = password_input_encrypted;
                                connect.clocal.user_encrypted = username_input_encrypted;
                                connect.clocal.favcolouraccent_encrypted = favcolouraccent_input_clear/*.ToString()*/;
                                connect.clocal.activeAccountStatus_encrypted = old_input_encrypted/*.ToString()*/;
                                break;
                            }
                        }
                        if (userFound)
                        {
                            Hide();
                            new ContactList().Show();

                        }
                        else
                        {
                            MessageBox.Show("Incorrect username or password!\r\n\r\nError code: Invalid Login \r\n\r\nPlease try again.", "User not found", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No users have been registered", "No users have been found");
                    }

                }

                switch (favcolouraccent_input_clear)
                {
                    case "1EB780457550C252423946EA865BCD81":
                        favcolouraccent_input_clear = "Red";
                        break;
                    case "08C296FA4E816FCDA59E7A27C839B257":
                        favcolouraccent_input_clear = "Yellow";
                        break;
                    case "603E92E7CEA35CE23E597FD06750D60D":
                        favcolouraccent_input_clear = "Chartreuse"; //Green
                        break;
                    case "C5A30888F6C35AE2064712BE42806FF3":
                        favcolouraccent_input_clear = "Cyan"; //Blue
                        break;
                    case "A3159F79ACC18F984E46BD356F784D65":
                        favcolouraccent_input_clear = "Purple";
                        break;
                    case "75B3CE0CABB751A8B1FC33C8A9A74A9D":
                        favcolouraccent_input_clear = "Pink";
                        break;
                }
                connect.clocal.userColour = favcolouraccent_input_clear;
                //frmPupilPersonalDetails.skiPupil.password = password;
                //if (connect.clocal.textColour_encrypted == "D7679B5056E8231802C4D09661B76BB7")
                //{
                //    connect.clocal.textColour = ("White");
                //}
            }
        }
    }
}
