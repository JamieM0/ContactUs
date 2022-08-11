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
using System.Diagnostics;

namespace ContactUs
{
    public partial class ContactView : Form
    {
        bool IsNewContact = true;
        bool IsSaved = true;
        
        public ContactView()
        {
            InitializeComponent();
            CenterToScreen();
            LoadContact();
            titleUpdater();
            IsSaved = true;
        }

        private void lbFName_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pbSendMail_Click(object sender, EventArgs e)
        {
            string email = rtxtEmailAddresses.Text.Split('\r')[0];
            System.Diagnostics.Process.Start($"mailto:{email}");
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
                    connect.clocal.selected_id = 0;
                    Hide();
                    new ContactList().Show();
                }
                else if (dialogResult == DialogResult.No)
                {
                    //Hide();
                }
            }
            else
            {
                Hide();
                new ContactList().Show();
            }
            
        }

        private void ContactView_Load(object sender, EventArgs e)
        {

        }

        string imgIconName = "";
        
        private void btnChangeContactImage_Click(object sender, EventArgs e)
        {
            
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
            IsSaved = false;
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
            IsSaved = false;
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
            IsSaved = false;
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
            ContactView cv = new ContactView();
            cv.arrLine[line_to_edit] = newText;
            File.WriteAllLines(fileName, cv.arrLine);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSaveOnly_Click(object sender, EventArgs e)
        {
            SaveFull();
            IsSaved = true;
        }

        private void btnSaveAndReturn_Click(object sender, EventArgs e)
        {
            connect.clocal.selected_id = 0;
            SaveFull();
            IsSaved = true;
            Hide();
            new ContactList().Show();
        }

        private void SaveFull()
        {
            string userlinenumber = connect.clocal.userlinenumber.ToString();
            var inDir = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            string locationPath = ($@"{inDir}\ContactUsProgram");
            string filePath = /*@*/$@"{locationPath}\contacts_{userlinenumber}.conf";/*\\*/
            string fileName = filePath;
            // Kill contacts.conf
            Process[] workers = Process.GetProcessesByName(filePath);
            foreach (Process worker in workers)
            {
                worker.Kill();
                worker.WaitForExit();
                worker.Dispose();
            }

            string contactimage = imgIconName;
            string fName = txtFName.Text;
            string lName = txtLName.Text;
            string/*[]*/ emails = rtxtEmailAddresses.Text/*.Split(new string[] { Environment.NewLine }, StringSplitOptions.None*//*Environment.NewLine*//*, StringSplitOptions.RemoveEmptyEntries*//*)*/;
            string/*[]*/ phoneNumbers = rtxtPhoneNumbers.Text/*.Split(new string[] { Environment.NewLine }, StringSplitOptions.None*//*Environment.NewLine*//*, StringSplitOptions.RemoveEmptyEntries*//*)*/;
            DateTime birthdate = dtpBirthdate.Value;
            DateTime otherdate = dtpOtherDate.Value;
            string otherdatelabel = txtOtherDate.Text;
            string notes = rtxtNotes.Text;
            string address = rtxtAddress.Text;
            if (contactimage == "" && !editingPreviousContact)
            {
                contactimage = "example.png";
            }

            int relativeID = File.ReadLines(fileName).Count();

            FileStream aFile;
            StreamWriter sw;
            try
            {
                //Check if the file exists, if not (it does't) then it creates it.
                if (!File.Exists(fileName))
                {
                    aFile = new FileStream(fileName, FileMode.Create, FileAccess.Write);
                    relativeID = 0;
                }
                else if (!editingPreviousContact)
                {
                    //If the file already exists, then open it in append mode.
                    aFile = new FileStream(fileName, FileMode.Append, FileAccess.Write);
                    
                    //Create a new connection to the file writer
                    sw = new StreamWriter(aFile);

                    //Write the contact details to the file with each piece of data separated with the '~' symbol.
                    sw.WriteLine($"{relativeID}~{contactimage}~{fName}~{lName}~{emails}~{phoneNumbers}" +
                        $"~{birthdate}~{otherdate}~{otherdatelabel}~{notes}~{address}");

                    //Close the connection to the file
                    sw.Close();
                    aFile.Close();
                    aFile.Dispose();
                    sw.Dispose();
                    //aFile.Flush();
                    //sw.Flush();
                    //aFile.

                }
                else
                {
                    //Change the line of sid-1 to the new data.
                    lineChanger($"{absoluteRelativeID}~{absoluteImageIcon}~{fName}~{lName}~{emails}~{phoneNumbers}" +
                        $"~{birthdate}~{otherdate}~{otherdatelabel}~{notes}~{address}", fileName, sid-1);
                }
                MessageBox.Show("Contact information has been saved successfully!", "Successful");
            }

            catch (Exception ex)
            {
                //If the file cannot be found give the user a suitable message
                MessageBox.Show(ex.Message, "Could not save Contact Information! \r\n\r\nError code: CV-IS \r\n\r\nPlease see the Github page and make an issue if there isn't one \r\nalready made with this problem, and mark it with the 'Bug / Problem' tag.");
            }

            //sw.Close();
            //aFile.Close();
        }

        private void btnReturnToMainMenu_Click(object sender, EventArgs e)
        {
            
        }

        bool editingPreviousContact = false;
        int sid;
        string[] arrLine = new string [100];
        string absoluteRelativeID;
        string absoluteImageIcon;
        string fullCurrentContact;

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
                arrLine = File.ReadAllLines(fileName);

                //Check if contacts exist in the conf file
                if (allContacts.Length > 0)
                {
                    sid = connect.clocal.selected_id;

                    if (sid != 0)
                    {
                        editingPreviousContact = true;
                        
                        //Loop over each player details
                        foreach (var contact in allContacts)
                        {
                            if (sid - 1 == Convert.ToInt32(contact.Split('~')[0]))
                            {
                                //Get the contact info
                                var splitDetails = contact.Split('~');
                                //var unsplitDetails = new string[splitDetails.Length];
                                absoluteRelativeID = splitDetails[0];
                                pbContactPicture.ImageLocation = splitDetails[1];
                                absoluteImageIcon = splitDetails[1];
                                txtFName.Text = splitDetails[2];
                                txtLName.Text = splitDetails[3];
                                rtxtEmailAddresses.Text = splitDetails[4];
                                rtxtPhoneNumbers.Text = splitDetails[5];
                                dtpBirthdate.Value = Convert.ToDateTime(splitDetails[6]);
                                dtpOtherDate.Value = Convert.ToDateTime(splitDetails[7]);
                                txtOtherDate.Text = splitDetails[8];
                                rtxtNotes.Text = splitDetails[9];
                                rtxtAddress.Text = splitDetails[10];
                                fullCurrentContact = splitDetails[0] + "~" + splitDetails[1] + "~" + splitDetails[2] + "~" + splitDetails[3] + "~" + splitDetails[4] + "~" + splitDetails[5] + "~" + splitDetails[6] + "~" + splitDetails[7] + "~" + splitDetails[8] + "~" + splitDetails[9] + "~" + splitDetails[10];
                            }

                        }
                    }

                    //Dispose();
                }
                else
                {
                    
                    //MessageBox.Show("No contacts have been found. Error code: CV-NF", "No contacts found.",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                //fileName.Close();
            }
            else
            {
                MessageBox.Show("Contacts file cannot be found. Error code: CV-FG", "No contacts found.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Hide();
                new ContactList().Show();
            }
        }

        private void dtpBirthdate_Leave(object sender, EventArgs e)
        {
            IsSaved = false;
        }

        private void txtOtherDate_Leave(object sender, EventArgs e)
        {
            
        }

        private void dtpOtherDate_Leave(object sender, EventArgs e)
        {
            IsSaved = false;
        }

        private void rtxtNotes_Leave(object sender, EventArgs e)
        {

        }

        private void rtxtAddress_Leave(object sender, EventArgs e)
        {

        }

        private void btnChangeContactImage_Leave(object sender, EventArgs e)
        {

        }

        private void btnNewForm_Click(object sender, EventArgs e)
        {
            Hide();
            new ContactView().Show();
        }

        private void pbContactPicture_Click(object sender, EventArgs e)
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

                    //Copy image to program location

                    //Try to copy the image
                    try
                    {
                        File.Copy(openFileDialog.FileName, openFileDialog.SafeFileName);
                    }
                    catch
                    {

                    }

                    imgIconName = openFileDialog.SafeFileName;
                    absoluteImageIcon = openFileDialog.SafeFileName;
                }
            }

            //MessageBox.Show(fileContent, "File Content at path: " + filePath, MessageBoxButtons.OK);
            //pbContactPicture.Image = fileContent;
        }

        private void rtxtNotes_TextChanged(object sender, EventArgs e)
        {
            IsSaved = false;
        }

        private void pbDeleteContact_Click(object sender, EventArgs e)
        {
            string userlinenumber = connect.clocal.userlinenumber.ToString();
            var inDir = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            string locationPath = ($@"{inDir}\ContactUsProgram");
            string filePath = /*@*/$@"{locationPath}\contacts_{userlinenumber}.conf";/*\\*/
            string fileName = filePath;
            
            if (MessageBox.Show("This will delete this contact from your list. This cannot be undone. Would you like to continue?", "WARNING!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var tempFile = Path.GetTempFileName();
                var linesToKeep = File.ReadLines(fileName).Where(l => l != fullCurrentContact);
                string[] lineKeeping = new string[linesToKeep.Count()+1];

                // Reassign the relative IDs of the other contacts
                //Loop over each contact details
                int ia = 0;
                foreach (var contact in linesToKeep)
                {
                    //Get the contact info
                    var splitDetails = contact.Split('~');
                    //var unsplitDetails = new string[splitDetails.Length];
                    splitDetails[0] = ia.ToString();
                    lineKeeping[ia] = splitDetails[0] + "~" + splitDetails[1] + "~" + splitDetails[2] + "~" + splitDetails[3] + "~" + splitDetails[4] + "~" + splitDetails[5] + "~" + splitDetails[6] + "~" + splitDetails[7] + "~" + splitDetails[8] + "~" + splitDetails[9] + "~" + splitDetails[10];
                    ia++;
                }

                File.WriteAllLines(tempFile, lineKeeping);

                File.Delete(fileName);
                File.Move(tempFile, fileName);

                var lines = File.ReadAllLines(fileName).Where(arg => !string.IsNullOrWhiteSpace(arg));
                File.WriteAllLines(fileName, lines);

                Hide();
                new ContactList().Show();
            }
        }

        private void rtxtEmailAddresses_TextChanged(object sender, EventArgs e)
        {
            IsSaved = false;
        }

        private void rtxtAddress_TextChanged(object sender, EventArgs e)
        {
            IsSaved = false;
        }

        private void dtpOtherDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtOtherDate_TextChanged(object sender, EventArgs e)
        {
            IsSaved = false;
        }
    }
}
