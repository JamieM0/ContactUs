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
        int numbertotal = 0;
        
        public ContactList()
        {
            InitializeComponent();
            CenterToScreen();
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
            string oldFiles = $@"{locationPath}\oldFiles.conf";

            if (!File.Exists(oldFiles))
            {
                using (StreamWriter sw = File.CreateText(oldFiles))
                {
                    sw.WriteLine("0");
                }
            }

            if (File.Exists(fileName))
            {
                string[] lines = System.IO.File.ReadAllLines($@"{fileName}");
                //Read in contacts
                var allContacts = File.ReadAllLines(fileName);

                //Check that there's actually something there
                if (allContacts.Length > 0)
                {
                    int contactNumberList = 0;
                    int[] ids = new int[allContacts.Length + 1];
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

                        if (contactNumberList == 0)
                        {
                            pb_0.Image = Image.FromFile($@"{image}");
                            fName_0.Text = $"{firstName} {lastName}";
                            lName0.Text = "";
                            emailAddress_0.Text = emailAddress;
                            phoneNumber_0.Text = phoneNumber;
                            ids[contactNumberList] = rIDNum;
                        }
                        else
                        {
                            int count = pnlContactList.Controls.OfType<Panel>().ToList().Count;
                            newPanel(count, firstName, lastName, emailAddress, phoneNumber, image);
                            ids[contactNumberList] = rIDNum;
                        }
                        contactNumberList++;
                        numbertotal = contactNumberList;
                    }
                }
            }
            else
            {
                //Create a new file
                File.Create(fileName).Dispose();
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
            name = ((Panel)sender).Name;

            name_split = name.Split('_');

            moveOn();
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
            panel.Name = "pnlContact_" + (count);
            panel.Click += new EventHandler(panel_Click);
            pnlContactList.Controls.Add(panel);

            PictureBox pb = new PictureBox();
            pb.Location = new System.Drawing.Point(0, 3);
            pb.Name = "pb_" + (count);
            pb.Size = new System.Drawing.Size(142, 140);
            pb.SizeMode = PictureBoxSizeMode.Zoom;
            pb.Image = Image.FromFile($@"{image}");
            pb.Click += new EventHandler(pb_Click);
            panel.Controls.Add(pb);

            Label labelFName = new Label();
            labelFName.Location = new System.Drawing.Point(148, 3);
            labelFName.Name = "fName_" + (count);
            labelFName.Size = new System.Drawing.Size(500, 45);
            labelFName.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            labelFName.Text = $"{firstName} {lastName}";
            labelFName.Click += new EventHandler(label_Click);
            panel.Controls.Add(labelFName);

            Label labelEMail = new Label();
            labelEMail.Location = new System.Drawing.Point(151, 58);
            labelEMail.Name = "emailAddress_" + (count);
            labelEMail.Size = new System.Drawing.Size(295, 25);
            labelEMail.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular);
            labelEMail.Text = emailAddress;
            labelEMail.Click += new EventHandler(label_Click);
            panel.Controls.Add(labelEMail);

            Label labelPhoneNumber = new Label();
            labelPhoneNumber.Location = new System.Drawing.Point(151, 97);
            labelPhoneNumber.Name = "phoneNumber_" + (count);
            labelPhoneNumber.Size = new System.Drawing.Size(122, 25);
            labelPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular);
            labelPhoneNumber.Text = phoneNumber;
            labelPhoneNumber.Click += new EventHandler(label_Click);
            panel.Controls.Add(labelPhoneNumber);
        }

        string name = "";
        string[] name_split;
        int selected_id = 0;

        private void panel_Click(object sender, EventArgs e)
        {
            name = ((Panel)sender).Name;

            name_split = name.Split('_');

            moveOn();
        }

        private void pb_Click(object sender, EventArgs e)
        {
            name = ((PictureBox)sender).Name;

            name_split = name.Split('_');

            moveOn();
        }

        private void label_Click(object sender, EventArgs e)
        {
            name = ((Label)sender).Name;

            name_split = name.Split('_');

            moveOn();
        }

        private void btnAddContact_Click(object sender, EventArgs e)
        {
            numbertotal++;
            connect.clocal.ID = numbertotal;

            Hide();
            new ContactView().Show();
        }

        private void fName0_Click(object sender, EventArgs e)
        {
            name = ((Label)sender).Name;

            name_split = name.Split('_');

            moveOn();
        }

        private void pb0_Click(object sender, EventArgs e)
        {
            name = ((PictureBox)sender).Name;

            name_split = name.Split('_');

            moveOn();
        }

        private void emailAddress0_Click(object sender, EventArgs e)
        {
            name = ((Label)sender).Name;

            name_split = name.Split('_');

            moveOn();
        }

        private void phoneNumber0_Click(object sender, EventArgs e)
        {
            name = ((Label)sender).Name;

            name_split = name.Split('_');

            moveOn();
        }

        private void zeroClicked()
        {
            //panel_Click();
        }

        private void moveOn()
        {
            selected_id = Convert.ToInt32(name_split[1]) + 1;

            connect.clocal.selected_id = selected_id;

            Hide();
            new ContactView().Show();
        }

        private void pnlContactList_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDeleteAllContacts_Click(object sender, EventArgs e)
        {
            // Import contact list from contacts_0.conf file
            string userlinenumber = connect.clocal.userlinenumber.ToString();
            var inDir = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            string locationPath = ($@"{inDir}\ContactUsProgram");
            string filePath = /*@*/$@"{locationPath}\contacts_{userlinenumber}.conf";/*\\*/
            string fileName = filePath;

            if (MessageBox.Show("This will delete all your contacts, there is no way to undo this. Would you like to continue?", "WARNING!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (File.Exists(fileName))
                {
                    File.Delete(fileName);
                }
                else
                {
                    MessageBox.Show("No contacts to delete!", "Error Code: CL-NC");
                }
            }
            else
            {
                MessageBox.Show("No contacts were deleted!");
            }

            this.Hide();
            new ContactList().Show();
        }

        private void btnRemoveContacts_Click(object sender, EventArgs e)
        {
            // Import contact list from contacts_0.conf file
            string userlinenumber = connect.clocal.userlinenumber.ToString();
            var inDir = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            string locationPath = ($@"{inDir}\ContactUsProgram");
            string filePath = /*@*/$@"{locationPath}\contacts_{userlinenumber}.conf";/*\\*/
            string fileName = filePath;
            string oldFiles = $@"{locationPath}\oldFiles.conf";
            if (MessageBox.Show("This will move all your contacts, but won't permanently delete them. Would you like to continue?", "INFORMATION!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string curve = File.ReadAllText(oldFiles).Split('\r')[0];
                File.Move(filePath, $@"{locationPath}\unusednow\contacts_{userlinenumber}{curve}.conf");
                int curveint = Convert.ToInt32(curve);
                curveint++;
                File.WriteAllText(oldFiles, curveint.ToString());
            }
            else
            {
                MessageBox.Show("No contacts were moved!");
            }

            this.Hide();
            new ContactList().Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Hide();
            new Login().Show();
        }
    }
}
