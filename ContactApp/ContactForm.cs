using System.Diagnostics;

namespace ContactApp
{
    public partial class ContactForm : Form
    {
        public List<Contact> Contacts { get; set; }

        public ContactForm()
        {

            InitializeComponent();
            Contacts = new List<Contact>();
            AddContact(new Contact
            {
                FirstName = "John",
                LastName = "Doe",
                Email = "john@email.com"
            });
        }

        private void ContactForm_Load(object sender, EventArgs e)
        {
            foreach (var contact in Contacts)
            {
                Debug.WriteLine(contact);
            }
        }

        //public void AddContact(
        //    string first,
        //    string last,
        //    string? phone = null,
        //    string? email = null
        //    )
        //{
        //    Contacts.Add(new Contact
        //    {
        //        FirstName = first,
        //        LastName = last,
        //        PhoneNumber = phone,
        //        Email = email
        //    });
        //}

        public void AddContact(Contact contact)
        {
            Contacts.Add(contact);
        }
    }
}
