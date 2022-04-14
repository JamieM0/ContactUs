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
    public partial class ContactView : Form
    {
        bool IsNewContact = true;
        
        public ContactView()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void lbFName_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pbSendMail_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start($"mailto:{rtxtEmailAddresses.Text}");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //MessageBoxButtons.YesNo
            //MessageBox.Show();
            DialogResult dialogResult = MessageBox.Show("If you have unsaved progress, click No below to return & save it.\r\n Any unsaved data will be lost.\r\nDo you want to continue exiting?", "Are you sure you want to exit?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //this.Hide();
                System.Windows.Forms.Application.Exit();
            }
            else if (dialogResult == DialogResult.No)
            {
                //Hide();
            }
        }

        private void ContactView_Load(object sender, EventArgs e)
        {

        }

        private void btnChangeContactImage_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;
            var inDir = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = inDir + "\\Pictures";
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.tif;...";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    pbContactPicture.Image = new Bitmap(openFileDialog.FileName);

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    //using (StreamReader reader = new StreamReader(fileStream))
                    //{
                    //    fileContent = reader.ReadToEnd();
                    //}
                }
            }

            //MessageBox.Show(fileContent, "File Content at path: " + filePath, MessageBoxButtons.OK);
            //pbContactPicture.Image = fileContent;
        }

        private void txtFName_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtFName.Text))
            {
                txtFName.Text = txtFName.Text.Trim();
                txtFName.Text = (char.ToUpper(txtFName.Text[0]) + txtFName.Text.Substring(1));
            }

            titleUpdater();
            
        }

        private void txtLName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtLName_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtFName.Text))
            {
                txtLName.Text = txtLName.Text.Trim();
                txtLName.Text = (char.ToUpper(txtLName.Text[0]) + txtLName.Text.Substring(1));
            }

            titleUpdater();
            
        }

        private void rtxtEmailAddresses_Leave(object sender, EventArgs e)
        {
            if (!rtxtEmailAddresses.Text.Contains("@"))
            {
                MessageBox.Show("The email you have entered is invalid, you can still continue if you like.", "Warning: Invalid Email");
            }
        }

        private void rtxtPhoneNumbers_TextChanged(object sender, EventArgs e)
        {

        }

        private void rtxtPhoneNumbers_Leave(object sender, EventArgs e)
        {
            //if (!rtxtEmailAddresses.Text.Contains("@"))
            //{
            //    MessageBox.Show("The email you have entered is invalid, you can still continue if you like.", "Warning: Invalid Email");
            //}
        }

        private void txtFName_TextChanged(object sender, EventArgs e)
        {

        }

        private void titleUpdater()
        {
            lbTitle.Text = ($"{txtFName.Text} {txtLName.Text}");
        }

        private void Saver(int currentContactLineNumber)
        {
            if (IsNewContact == true)
            {
                //Add new line
            }
            else
            {
                //Edit current line
                lineChanger("", "", currentContactLineNumber);
            }
        }

        static void lineChanger(string newText, string fileName, int line_to_edit) //Changes a certain line of a certain text file (used for changing the user's password in txtUsers.txt).
        {
            string[] arrLine = File.ReadAllLines(fileName);
            //arrLine[line_to_edit - 1] = newText;
            arrLine[line_to_edit] = newText;
            File.WriteAllLines(fileName, arrLine);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Hide();
            new Login().Show();
        }

        private void btnSaveOnly_Click(object sender, EventArgs e)
        {
            SaveFull();
        }

        private void btnSaveAndReturn_Click(object sender, EventArgs e)
        {
            SaveFull();
        }

        private void SaveFull()
        {
            string userlinenumber = connect.clocal.userlinenumber.ToString();
            var inDir = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            string locationPath = ($@"{inDir}\ContactUsProgram");
            string filePath = /*@*/$@"{locationPath}\contacts_{userlinenumber}.txt";/*\\*/
            string fileName = filePath;

            string fName = txtFName.Text;
            string lName = txtLName.Text;
            string[] emails = rtxtEmailAddresses.Text.Split(new string[] { Environment.NewLine }, StringSplitOptions.None/*Environment.NewLine*//*, StringSplitOptions.RemoveEmptyEntries*/);
            string[] phoneNumbers = rtxtPhoneNumbers.Text.Split(new string[] { Environment.NewLine }, StringSplitOptions.None/*Environment.NewLine*//*, StringSplitOptions.RemoveEmptyEntries*/);
            DateTime birthdate = dtpBirthdate.Value;
            DateTime otherdate = dtpOtherDate.Value;
            string otherdatelabel = txtOtherDate.Text;
            string notes = rtxtNotes.Text;
            string address = rtxtAddress.Text;

            FileStream aFile;
            StreamWriter sw;
            try
            {
                //Check if the file exists, if not (it does't) then it creates it.
                if (!File.Exists(fileName))
                {
                    aFile = new FileStream(fileName, FileMode.Create, FileAccess.Write);
                }
                else
                {
                    //If the file already exists, then open it in append mode.
                    aFile = new FileStream(fileName, FileMode.Append, FileAccess.Write);
                }

                //Encrypt all the variables (Updated from last time, see commit)
                string pForename = connect.clocal.pForename;
                string pSurname = connect.clocal.pSurname;
                string DateOfBirth = connect.clocal.DateOfBirth.ToShortDateString();
                char pGender = connect.clocal.gender;
                string YearGroup = connect.clocal.YearGroup;
                double avgSkiTime = connect.clocal.avgSkiTime;
                int QuizScore = connect.clocal.QuizScore;
                string skiAbility = connect.clocal.skiAbility;

                string pGender_string = connect.clocal.gender.ToString();
                //string avgSkiTime_string = connect.clocal.avgSkiTime.ToString();
                //string QuizScore_string = connect.clocal.QuizScore.ToString();

                //string encodedStr = Convert.ToBase64String(Encoding.UTF8.GetBytes("inputStr"));

                //string pForename_base64 = Convert.ToBase64String(Encoding.UTF8.GetBytes(/*key, */pForename));
                //string pSurname_base64 = Convert.ToBase64String(Encoding.UTF8.GetBytes(/*key, */pSurname));
                //string DateOfBirth_base64 = Convert.ToBase64String(Encoding.UTF8.GetBytes(/*key, */DateOfBirth));
                //string pGender_base64 = Convert.ToBase64String(Encoding.UTF8.GetBytes(/*key, */pGender_string));
                //string YearGroup_base64 = Convert.ToBase64String(Encoding.UTF8.GetBytes(/*key, */YearGroup));
                //string avgSkiTime_base64 = Convert.ToBase64String(Encoding.UTF8.GetBytes(/*key, */avgSkiTime_string));
                //string QuizScore_base64 = Convert.ToBase64String(Encoding.UTF8.GetBytes(/*key, */QuizScore_string));
                //string skiAbility_base64 = Convert.ToBase64String(Encoding.UTF8.GetBytes(/*key, */skiAbility));

                //Create a new connection to the file writer
                sw = new StreamWriter(aFile);

                //Write the student details to the file with each piece of data separated with the '~' symbol.
                sw.WriteLine($"{pForename}~{pSurname}~{DateOfBirth}~{pGender}" +
                    $"~{YearGroup}~{avgSkiTime}~{QuizScore}~{skiAbility}");

                //Close the connection to the file
                sw.Close();
                aFile.Close();

                MessageBox.Show("Pupils details have been saved successfully..", "Successful");
                btnDashboardGoTo.Enabled = true;
                btnSavePupilDetails.Enabled = false;
                btnOverviewGoTo.Enabled = true;
            }

            catch (Exception ex)
            {
                //If the file cannot be found give the user a suitable message
                MessageBox.Show(ex.Message, "Pupils details have not been saved successfully, please try again. If this error persists, please file a bug report from the Dashboard.");
            }
        }
    }
}
