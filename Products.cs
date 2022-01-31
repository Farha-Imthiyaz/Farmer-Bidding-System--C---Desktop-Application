using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AD
{
    public class Products
    {
        private int prodID;
        private string category;
        private string name;
        private string type;
        private int quantityofprod;
        private int unitpriceofprod;
        private string bidDuration;
        private DateTime bidDate;

        public Products()
        {
            
        }

        public int ProdID
        {
            get
            {
                return this.prodID;
            }
            set
            {
                this.prodID = value;
            }
        }

        public string Category
        {
            get
            {
                return this.category;
            }
            set
            {
                this.category = value;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public string Type
        {
            get
            {
                return this.type;
            }
            set
            {
                this.type = value;
            }
        }

        public int Quantityofprod
        {
            get
            {
                return this.quantityofprod;
            }
            set
            {
                this.quantityofprod = value;
            }
        }

        public int UnitPriceofprod
        {
            get
            {
                return this.unitpriceofprod;
            }
            set
            {
                this.unitpriceofprod = value;
            }
        }

        public string BidDuration
        {
            get
            {
                return this.bidDuration;
            }
            set
            {
                this.bidDuration = value;
            }
        }

        public System.DateTime BidDate
        {
            get
            {
                return this.bidDate;
            }
            set
            {
                this.bidDate = value;
            }
        }
    }
}
