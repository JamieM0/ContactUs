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
    public partial class ContactList : Form
    {
        public ContactList()
        {
            InitializeComponent();
        }

        private void ContactList_Load(object sender, EventArgs e)
        {
            // Initialise a two dimensional array to hold the contact details
            string[,] contacts = new string[,]
            {
                {"John Smith", "0123456789", "", "", "", "" }
            };

            // Import contact list from contacts_0.conf file
            string userlinenumber = connect.clocal.userlinenumber.ToString();
            var inDir = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            string locationPath = ($@"{inDir}\ContactUsProgram");
            string filePath = /*@*/$@"{locationPath}\contacts_{userlinenumber}.conf";/*\\*/
            string fileName = filePath;
            string[] lines = System.IO.File.ReadAllLines($@"{fileName}");
            if (File.Exists(fileName))
            {
                //Read in contacts
                var allContacts = File.ReadAllLines(fileName);
                
                //Check that there's actually something there
                if (allContacts.Length > 0)
                {
                    int contactNumberList = 0;
                    //Loop through all the contacts
                    foreach (var contact in allContacts)
                    {
                        string[] words = contact.Split('~');
                        string relativeID = words[0];
                        int rIDNum = Convert.ToInt32(relativeID);
                        string image = words[1];
                        string firstName = words[2];
                        string lastName = words[3];
                        string emailAddress = words[4];
                        string phoneNumber = words[5];

                        contacts[rIDNum, 0] = relativeID;
                        contacts[rIDNum, 1] = image;
                        contacts[rIDNum, 2] = firstName;
                        contacts[rIDNum, 3] = lastName;
                        contacts[rIDNum, 4] = emailAddress;
                        contacts[rIDNum, 5] = phoneNumber;

                        //// Add the contact to the list
                        //contactList.Items.Add(contact_local);

                        //string test = contact_local.FirstName;
                        // Set pb[rIDNum] to contacts[rIDNum, 1]
                        //pb0.Image = Image.FromFile(contacts[rIDNum, 1]);
                        fName0.Text = contacts[rIDNum, 2];
                        lName0.Text = contacts[rIDNum, 3];
                        emailAddress0.Text = contacts[rIDNum, 4];
                        phoneNumber0.Text = contacts[rIDNum, 5];
                    }
                }
            }

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            Hide();
            new ContactView().Show();
        }

        private void pnlContact0_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlContact0_Click(object sender, EventArgs e)
        {
            Hide();
            new ContactView().Show();
        }

        private void newPanel(int count, string firstName, string lastName, string emailAddress, string phoneNumber, string image)
        {
            Panel panel = new Panel();
            if (count%2 == 0)
            {
                panel.Location = new System.Drawing.Point(3, 3 + (155 * (count / 2)));
            }
            else
            {
                panel.Location = new System.Drawing.Point(627, 3 + (155 * (count / 2)));
            }
            panel.Size = new System.Drawing.Size(580, 149);
            panel.Name = "pnlContact" + (count + 1);
            panel.Click += new EventHandler(panel_Click);
            pnlContactList.Controls.Add(panel);

            PictureBox pb = new PictureBox();
            pb.Location = new System.Drawing.Point(0, 3);
            pb.Name = "pb" + (count + 1);
            pb.Size = new System.Drawing.Size(142, 140);
            pb.SizeMode = PictureBoxSizeMode.Zoom;
            pb.Image = Image.FromFile(image);
            pnlContactList.Controls.Add(pb);

            Label labelFName = new Label();
            labelFName.Location = new System.Drawing.Point(148, 3);
            labelFName.Name = "fName" + (count + 1);
            labelFName.Size = new System.Drawing.Size(173, 45);
            labelFName.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            labelFName.Text = firstName;
            pnlContactList.Controls.Add(labelFName);

            Label labelLName = new Label();
            labelLName.Location = new System.Drawing.Point(316, 3);
            labelLName.Name = "lName" + (count + 1);
            labelLName.Size = new System.Drawing.Size(167, 45);
            labelLName.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            labelLName.Text = lastName;
            pnlContactList.Controls.Add(labelLName);

            Label labelEMail = new Label();
            labelEMail.Location = new System.Drawing.Point(151, 58);
            labelEMail.Name = "emailAddress" + (count + 1);
            labelEMail.Size = new System.Drawing.Size(295, 25);
            labelEMail.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular);
            labelEMail.Text = emailAddress;
            pnlContactList.Controls.Add(labelEMail);

            Label labelPhoneNumber = new Label();
            labelPhoneNumber.Location = new System.Drawing.Point(151, 97);
            labelPhoneNumber.Name = "phoneNumber" + (count + 1);
            labelPhoneNumber.Size = new System.Drawing.Size(122, 25);
            labelPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular);
            labelPhoneNumber.Text = phoneNumber;
            pnlContactList.Controls.Add(labelPhoneNumber);
        }

        private void panel_Click(object sender, EventArgs e)
        {
            Hide();
            new ContactView().Show();
        }
    }
}
