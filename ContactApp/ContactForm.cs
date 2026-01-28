using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

#pragma warning disable WFO1000

namespace ContactApp
{
    public partial class ContactForm : Form
    {
        public List<Contact> Contacts { get; set; }

        public ContactForm()
        {

            InitializeComponent();
            Contacts = new List<Contact>();

        }

        public void UpdateContactListBox()
        {
            lbContacts.Items.Clear();
            foreach (Contact contact in Contacts)
            {
                lbContacts.Items.Add(contact);
            }
        }

        private void ContactForm_Load(object sender, EventArgs e)
        {
            foreach (var contact in Contacts)
            {
                Debug.WriteLine(contact);
            }
        }

        public void AddContact(
            string first,
            string last,
            string? phone,
            string? email
            )
        {
            //Fix later
            Contacts.Add(new Contact
            {
                FirstName = first,
                LastName = last,
                PhoneNumber = phone,
                Email = email,
            });
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Capture data
            //crate a nre contact
            Contact newContact = new Contact
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                PhoneNumber = txtPhone.Text,
                Email = txtEmail.Text,
            };

            //add to list
            Contacts.Add(newContact);

            //pull the lever to update
            UpdateContactListBox();
        }
    }
}
