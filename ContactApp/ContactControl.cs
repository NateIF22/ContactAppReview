using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ContactApp
{
    public partial class ContactControl : UserControl
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Contact ContactDetails { get; set; }
        public ContactControl(Contact contactDetails)
        {
            InitializeComponent();
            ContactDetails = contactDetails;
            //Fill in all of the details on the control using the data.
            lblFullName.Text = $"{ContactDetails.FirstName} {ContactDetails.LastName}";
            lblAddress.Text = ContactDetails.Email;
            lblPhoneNumber.Text = ContactDetails.PhoneNumber;

            // how do I trigger code on the base form?
        }

        private void btnMarkContacted_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"You have marked {name} as contacted.");
        }
    }
}
