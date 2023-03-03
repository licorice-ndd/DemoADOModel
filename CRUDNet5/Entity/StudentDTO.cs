using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDNet5.Entity
{
    class StudentDTO
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

        private string address;
        public string Address
        {
            get { return address; }
            set { string address = value; }
        }
        private string gender;
        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }
        private DateTime dateofbirth;
        public DateTime Dateofbirth
        {
            get { return dateofbirth; }
            set { dateofbirth = value; }
        }
        private string country;
        public string Country
        {
            get { return country; }
            set
            {
                country = value;
            }
        }
        private string role;
        public string Role
        {
            get { return role; }
            set
            {
                role = value;
            }
        }
    }
}
