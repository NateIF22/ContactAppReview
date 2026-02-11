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
        }

        private void btnMarkContacted_Click(object sender, EventArgs e)
        {
            //// code to toggle the background of the control to green
            //ContactDetails.isContacted = !ContactDetails.isContacted;
            //if (ContactDetails.isContacted)
            //{
            //    this.BackColor = Color.LawnGreen;
            //}
            //else
            //{
            //    this.BackColor = SystemColors.Control;
            //}
            var fp = this.Parent;
            var frm = fp?.Parent as ContactForm;

            if (frm != null)
            {
                // delete myself from the list of contacts on the base for.
                frm.Contacts.Remove(ContactDetails);
                frm.UpdateContactList();
            }
        }
    }
}
