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
        bool IsSaved = false;
        
        public ContactView()
        {
            InitializeComponent();
            CenterToScreen();
            DialogResult dialogResult = MessageBox.Show("Load contact 1?", "Load contact 1?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                LoadContact();
            }
            
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
            if (!IsSaved)
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

            IsSaved = false;
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
            
            IsSaved = false;
        }

        private void rtxtEmailAddresses_Leave(object sender, EventArgs e)
        {
            if (!rtxtEmailAddresses.Text.Contains("@"))
            {
                MessageBox.Show("The email you have entered is invalid, you can still continue if you like.", "Warning: Invalid Email");
            }

            IsSaved = false;
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
            IsSaved = false;
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
            IsSaved = false;
        }

        private void btnSaveAndReturn_Click(object sender, EventArgs e)
        {
            SaveFull();
            IsSaved = false;
            new ContactList().Show();
        }

        private void SaveFull()
        {
            string userlinenumber = connect.clocal.userlinenumber.ToString();
            var inDir = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            string locationPath = ($@"{inDir}\ContactUsProgram");
            string filePath = /*@*/$@"{locationPath}\contacts_{userlinenumber}.conf";/*\\*/
            string fileName = filePath;

            string contactimage = /*pbContactPicture.ImageLocation*/"example.jpg";
            string fName = txtFName.Text;
            string lName = txtLName.Text;
            string/*[]*/ emails = rtxtEmailAddresses.Text/*.Split(new string[] { Environment.NewLine }, StringSplitOptions.None*//*Environment.NewLine*//*, StringSplitOptions.RemoveEmptyEntries*//*)*/;
            string/*[]*/ phoneNumbers = rtxtPhoneNumbers.Text/*.Split(new string[] { Environment.NewLine }, StringSplitOptions.None*//*Environment.NewLine*//*, StringSplitOptions.RemoveEmptyEntries*//*)*/;
            DateTime birthdate = dtpBirthdate.Value;
            DateTime otherdate = dtpOtherDate.Value;
            string otherdatelabel = txtOtherDate.Text;
            string notes = rtxtNotes.Text;
            string address = rtxtAddress.Text;
            int relativeID = 0;

            FileStream aFile;
            StreamWriter sw;
            try
            {
                //Check if the file exists, if not (it does't) then it creates it.
                if (!File.Exists(fileName))
                {
                    aFile = new FileStream(fileName, FileMode.Create, FileAccess.Write);
                    //relativeID = 0;
                }
                else
                {
                    //If the file already exists, then open it in append mode.
                    aFile = new FileStream(fileName, FileMode.Append, FileAccess.Write);
                    //relativeID = File.ReadLines(fileName).Count();
                }

                //Create a new connection to the file writer
                sw = new StreamWriter(aFile);

                //Write the contacr details to the file with each piece of data separated with the '~' symbol.
                sw.WriteLine($"{relativeID}~{contactimage}~{fName}~{lName}~{emails}~{phoneNumbers}" +
                    $"~{birthdate}~{otherdate}~{otherdatelabel}~{notes}~{address}");

                //Close the connection to the file
                sw.Close();
                aFile.Close();
                aFile.Dispose();
                sw.Dispose();
                aFile.Flush();
                sw.Flush();
                //aFile.

                MessageBox.Show("Contact information has been saved successfully!", "Successful");
            }

            catch (Exception ex)
            {
                //If the file cannot be found give the user a suitable message
                MessageBox.Show(ex.Message, "Could not save Contact Information! \r\n\r\nError code: Invalid Contact Save \r\n\r\nPlease see the Github page and make an issue if there isn't one \r\nalready made with this problem, and mark it with the 'Bug / Problem' tag.");
            }

            //sw.Close();
            //aFile.Close();
        }

        private void btnReturnToMainMenu_Click(object sender, EventArgs e)
        {
            Hide();
            new ContactList().Show();
        }

        private void LoadContact()
        {
            string userlinenumber = connect.clocal.userlinenumber.ToString();
            var inDir = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            string locationPath = ($@"{inDir}\ContactUsProgram");
            string filePath = /*@*/$@"{locationPath}\contacts_{userlinenumber}.conf";/*\\*/
            string fileName = filePath;
            if (File.Exists($@"{locationPath}\contacts_{userlinenumber}.conf"))
            {
                //Read in all the details of the conf file
                var allContacts = File.ReadAllLines($@"{locationPath}\contacts_{userlinenumber}.conf");

                //Check if contacts exist in the conf file
                if (allContacts.Length > 0)
                {
                    //Loop over each player details
                    foreach (var contact in allContacts)
                    {
                        //Get the contact info
                        var splitDetails = contact.Split('~');
                        var unsplitDetails = new string[splitDetails.Length];
                        pbContactPicture.ImageLocation = splitDetails[1];
                        txtFName.Text = splitDetails[2];
                        txtLName.Text = splitDetails[3];
                        rtxtEmailAddresses.Text = splitDetails[4];
                        rtxtPhoneNumbers.Text = splitDetails[5];
                        dtpBirthdate.Value = Convert.ToDateTime(splitDetails[6]);
                        dtpOtherDate.Value = Convert.ToDateTime(splitDetails[7]);
                        txtOtherDate.Text = splitDetails[8];
                        rtxtNotes.Text = splitDetails[9];
                        rtxtAddress.Text = splitDetails[10];
                        //string unsplitDetails = classAesOperation.DecryptString(key, splitDetails[0]);
                        //dgPupils.Rows.Add(unsplitDetails[0], unsplitDetails[1], Convert.ToString(unsplitDetails[3]), Convert.ToString(unsplitDetails[2]), Convert.ToInt32(unsplitDetails[4]),
                        //    Convert.ToInt32(unsplitDetails[5]), Convert.ToInt32(unsplitDetails[6]), unsplitDetails[7]);

                    }

                    //Dispose();
                }
                else
                {
                    MessageBox.Show("No pupils have been found.");
                }

                //fileName.Close();
            }
            else
            {
                MessageBox.Show("File cannot be found. Remember that the Overview data (Data on the pupils) is stored on a per user basis. If you've already saved a pupil on this system, you aren't on the correct account. All data is encrypted so if this is the case, there's nothing that can be done unless you know the details of the other account. When you click 'OK', the Overview screen will be shown empty.");
            }
        }

        private void dtpBirthdate_Leave(object sender, EventArgs e)
        {
            IsSaved = false;
        }

        private void txtOtherDate_Leave(object sender, EventArgs e)
        {
            IsSaved = false;
        }

        private void dtpOtherDate_Leave(object sender, EventArgs e)
        {
            IsSaved = false;
        }

        private void rtxtNotes_Leave(object sender, EventArgs e)
        {
            IsSaved = false;
        }

        private void rtxtAddress_Leave(object sender, EventArgs e)
        {
            IsSaved = false;
        }

        private void btnChangeContactImage_Leave(object sender, EventArgs e)
        {
            IsSaved = false;
        }

        private void btnNewForm_Click(object sender, EventArgs e)
        {
            Hide();
            new ContactView().Show();
        }
    }
}
