using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AD
{
    public class Purchase
    {
        private int bID;
        private string date;
        private string paymenttype;
        private int productID;
        private int purchaseID;
        private int quantityofpurch;
        private int totalprice;
        private int uID;
        private int unitpriceofpurch;

        public Purchase()
        {
            
        }
    
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

        public string Date
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

        public string PaymentType
        {
            get
            {
                return this.paymenttype;
            }
            set
            {
                this.paymenttype = value;
            }
        }

        public int ProductID
        {
            get
            {
                return this.productID;
            }
            set
            {
                this.productID = value;
            }
        }

        public int PurchaseID
        {
            get
            {
                return this.purchaseID;
            }
            set
            {
                this.purchaseID = value;
            }
        }

        public int Quantityofpurch
        {
            get
            {
                return this.quantityofpurch;
            }
            set
            {
                this.quantityofpurch = value;
            }
        }

        public int TotalPrice
        {
            get
            {
                return this.totalprice;
            }
            set
            {
                this.totalprice = value;
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

        public int UnitPriceofpurch
        {
            get
            {
                return this.unitpriceofpurch;
            }
            set
            {
                this.unitpriceofpurch = value;
            }
        }

        public Products Products
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
