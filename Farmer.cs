﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AD
{
    public class Farmer : User
    {
        private string farmerID;

        public string FarmerID
        {
            get
            {
                return this.farmerID;
            }
            set
            {
                this.farmerID = value;
            }
        }
    }
}
