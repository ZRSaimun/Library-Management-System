using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Librarian
    {
        private byte[] image;

        public byte[] Image
        {
            get { return image; }
            set { image = value; }
        }

        private string id;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        private string lastName;

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        private string firstName;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        private string surname;

        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }
        private string userName;

        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }
        private string contact;

        public string Contact
        {
            get { return contact; }
            set { contact = value; }
        }
        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
      
        private string address;
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        private double salary;

        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }
        private string password;

        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        private string confirm;

        public string Confirm
        {
            get { return confirm; }
            set { confirm = value; }
        }

    }
}
