﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApps
{
    class Product
    {
        private decimal price;
        private int quantity;
        private decimal totalPayment;
        private decimal deliveryCharge;
        private decimal wrapCharge;
        private decimal gstCharge;
        private decimal delivery;
        private decimal wrapping;
        private decimal gst;

        private decimal Price
        {
            get { return price; }
            set { price = value; }
        }

        private int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public decimal TotalPayment
        {
            get { return totalPayment; }
            set { totalPayment = value; }
        }

        public decimal DeliveryCharge
        {
            get { return deliveryCharge; }
            set { deliveryCharge = value; }
        }

        public decimal WrapCharge
        {
            get { return wrapCharge; }
            set { wrapCharge = value; }
        }

        public decimal GSTCharge
        {
            get { return gstCharge; }
            set { gstCharge = value; }
        }


        private decimal Delivery
        {
            get { return delivery; }
            set { delivery = value; }
        }


        private decimal Wrapping
        {
            get { return wrapping; }
            set { wrapping = value; }
        }

        private decimal GST
        {
            get { return gst; }
            set { gst = value; }
        }

        //Constructor for Product
        public Product(decimal price, int quantity)
        {
            Price = price;
            Quantity = quantity;
        }

        //Calculate the total payment
        public void calTotalPayment()
        {
            TotalPayment = Price * Quantity;
        }

        public void calDeliveryCharge()
        {
            DeliveryCharge = TotalPayment + 25.0m;
        }

        public void calWrapCharge()
        {
            WrapCharge = DeliveryCharge + 5.0m;
        }

        public void calGSTCharge()
        {
            GSTCharge = WrapCharge * 1.1m;
        }
    }
}
