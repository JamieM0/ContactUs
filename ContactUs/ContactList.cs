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
            // Initialise an array of Contact objects
            //Contact[] contacts = new Contact[3];
            string[] contacts = new[5];

            // Import contact list from contacts_0.conf file
            string[] lines = System.IO.File.ReadAllLines(@"contacts_0.conf");
            foreach (string line in lines)
            {
                string[] words = line.Split(' ');
                string relativeID = words[0];
                int rIDNum = Convert.ToInt32(relativeID);
                string image = words[1];
                string firstName = words[2];
                string lastName = words[3];
                string emailAddress = words[4];
                string phoneNumber = words[5];
                // Create a new object for each contact in the contacts array
                contacts[Convert.ToInt32(relativeID)] = new
                {
                    Image = image,
                    FirstName = firstName,
                    LastName = lastName,
                    EmailAddress = emailAddress,
                    PhoneNumber = phoneNumber
                };


                //// Add the contact to the list
                //contactList.Items.Add(contact_local);

                //string test = contact_local.FirstName;
            }

        }
    }
}
