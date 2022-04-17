using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            foreach (string line in lines)
            {
                string[] words = line.Split('~');
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
    }
}
