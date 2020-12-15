using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
   public class Admin
    {
        

        private string id;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        private string name;

        public string Name
        {
         get { return name; }
         set { name = value; }
        }

        private string contact;

        public string Contact
        {
            get { return contact; }
            set { contact = value; }
        }
        private string password;

        public string Password
        {
            get { return password; }
            set { password = value; }
        }
       
    }
}
