using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AD
{
    public class FinalProducts
    {
        private double fquantity;
        private double funitprice;

        public double FQuantity
        {
            get
            {
                return this.fquantity;
            }
            set
            {
                this.fquantity = value;
            }
        }

        public double FUnitPrice
        {
            get
            {
                return this.funitprice;
            }
            set
            {
                this.funitprice = value;
            }
        }
    }
}
