using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AD
{
    public class Bidding
    {
        private int bID;
        private DateTime date;
        private string unitrate;
        private int uID;
        private string prodName;
        private string quantity;
        private string prodPrice;
    
        public int BID
        {
            get
            {
                return this.bID;
            }
            set
            {
                this.bID = value;
            }
        }

        public DateTime Date
        {
            get
            {
                return this.date;
            }
            set
            {
                this.date = value;
            }
        }

        public string Unitrate
        {
            get
            {
                return this.unitrate;
            }
            set
            {
                this.unitrate = value;
            }
        }

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

        public string ProdName
        {
            get
            {
                return this.prodName;
            }
            set
            {
                this.prodName = value;
            }
        }

        public string Quantity
        {
            get
            {
                return this.quantity;
            }
            set
            {
                this.quantity = value;
            }
        }

        public string ProdPrice
        {
            get
            {
                return this.prodPrice;
            }
            set
            {
                this.prodPrice = value;
            }
        }

        public Purchase Purchase
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
