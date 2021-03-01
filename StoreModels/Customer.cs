using System;

namespace StoreModels
{
    // <Summary>
    // Adds information for properties of adding fields for customer information
    // <Summary>

    public class Customer
    {
        private string firstName;
        private string lastName;
        private string phoneNumber;
        private int customerID;

        public string FirstName 
        { 
            get { return firstName; } 
            set
            {
                if (value == null || value.Equals(""))
                {
                    throw new ArgumentNullException("Enter a valid first name");
                }
                firstName = value;
                
            } 
        }

        public string LastName 
        { 
            get{ return lastName; } 
            set
            {
                if (value == null || value.Equals(""))
                {
                    throw new ArgumentNullException("Enter a valide last name");
                }
                lastName = value;
            }
        }
        public string PhoneNumber
        {
            get { return phoneNumber; }
            set{
                
                if (value == null || value.Equals(""))
                {
                    throw new ArgumentNullException("Enter a valid phone number");
                }
                phoneNumber = value;
            }
        }

        public int CustomerID { get; set; }
        public override string ToString() => $"Customer Details:\n\tName: {this.FirstName} {this.LastName} \n\tPhone: {this.PhoneNumber}";



    }
}

