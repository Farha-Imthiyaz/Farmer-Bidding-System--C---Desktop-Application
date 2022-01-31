using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AD
{
    public class Admin : User
    {
        private string adminID;

        public string AdminID
        {
            get
            {
                return this.adminID;
            }
            set
            {
                this.adminID = value;
            }
        }
    }
}
