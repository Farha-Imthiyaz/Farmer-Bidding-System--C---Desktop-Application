using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AD
{
    public class RawProducts
    {
        private double rquantity;
        private double runitprice;

        public double RQuantity
        {
            get
            {
                return this.rquantity;
            }
            set
            {
                this.rquantity = value;
            }
        }

        public double RUnitPrice
        {
            get
            {
                return this.runitprice;
            }
            set
            {
                this.runitprice = value;
            }
        }
    }
}
