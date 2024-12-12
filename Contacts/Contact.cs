using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP
{
    public class Contact
    {
        string firstname;
        string lastname;
        string email;

        public string Firstname 
        {
            get { return firstname; }
            set { firstname = value; }
        }
        public string Lastname
        {
            get { return lastname; }
            set { lastname = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
    }
}
