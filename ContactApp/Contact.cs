using System;
using System.Collections.Generic;
using System.Text;

namespace ContactApp
{
    public class Contact
    {
        // What describes a contact (name, email, phone number, etc.)
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName
        {
            get
            {
                 return $"{FirstName} {LastName}";
            }
        }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public bool isContacted { get; set; } = false;

        // Construct a new contact
        public Contact()
        {
            
        }


        // What a contact can do (print to string, 
        public override string? ToString()
        {
            return $"Name: {FirstName} {LastName} Phone: {PhoneNumber} Email: {Email} - Contacted: {isContacted}";
        }


    }
}
