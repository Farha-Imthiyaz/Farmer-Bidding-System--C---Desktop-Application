using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AD
{
    public class SFCA : User
    {
        private string sfcaID;

        public string SFCAID
        {
            get
            {
                return this.sfcaID;
            }
            set
            {
                this.sfcaID = value;
            }
        }
    }
}
