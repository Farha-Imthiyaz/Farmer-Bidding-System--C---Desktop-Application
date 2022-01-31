using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AD
{
    public class User
    {
        private int uID;
        private string username;
        private string usertype;
        private string email;
        private string address;
        private string age;
        private string fullname;
        private string gender;
        private string nic;
        private string phonenumber;
        private string dob;
        private string password;
    
        public int UID
        {
            get
            {
                return this.uID;
            }
            set
            {
                this.uID = value;
            }
        }

        public string Username
        {
            get
            {
                return this.username;
            }
            set
            {
                this.username = value;
            }
        }

        public string Phonenumber
        {
            get
            {
                return this.phonenumber;
            }
            set
            {
                this.phonenumber = value;
            }
        }

        public string Fullname
        {
            get
            {
                return this.fullname;
            }
            set
            {
                this.fullname = value;
            }
        }

        public string NIC
        {
            get
            {
                return this.nic;
            }
            set
            {
                this.nic = value;
            }
        }

        public string Gender
        {
            get
            {
                return this.gender;
            }
            set
            {
                this.gender = value;
            }
        }

        public string Email
        {
            get
            {
                return this.email;
            }
            set
            {
                this.email = value;
            }
        }

        public string Age
        {
            get
            {
                return this.age;
            }
            set
            {
                this.age = value;
            }
        }

        public string Address
        {
            get
            {
                return this.address;
            }
            set
            {
                this.address = value;
            }
        }

        public string DOB
        {
            get
            {
                return this.dob;
            }
            set
            {
                this.dob = value;
            }
        }

        public string Usertype
        {
            get
            {
                return this.usertype;
            }
            set
            {
                this.usertype = value;
            }
        }

        public string Password
        {
            get
            {
                return this.password;
            }
            set
            {
                this.password = value;
            }
        }

        public Bidding Bidding
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        
    }
}
