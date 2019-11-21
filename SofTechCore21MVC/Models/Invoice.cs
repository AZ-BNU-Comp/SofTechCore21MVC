using System;

namespace SofTechCore21MVC.Models

    /// <summary>
    /// Abdol Hadi
    /// </summary>  The Invoice allows the customers to see what they have purchased.
{
    public class Invoice
    {
        private int invoiceID;
        public int InvoiceID
        {
            get
            {
                return invoiceID;
            }
            set
            {
                invoiceID = value;
            }
        }
        private int customerID;
        public int CustomerID
        {
            get
            {
                return customerID;
            }
            set
            {
                customerID = value;
            }
        }
        private string garmentsList;
        public string GarmentsList
        {
            get
            {
                return garmentsList;
            }
            set
            {
                garmentsList = value;
            }
        }
        private int orderDate;
        public int OrderDate
        {
            get
            {
                return orderDate;
            }
            set
            {
                orderDate = value;
            }
        }
        private int dispatchDate;
        public int DispatchDate
        {
            get
            {
                return dispatchDate;
            }
            set
            {
                dispatchDate = value;
            }
        }
        private int deliveryDate;
        public int DeliveryDate
        {
            get
            {
                return deliveryDate;
            }
            set
            {
                deliveryDate = value;
            }
        }
        private string deliveryAddress;
        public string DeliveryAddress
        {
            get
            {
                return deliveryAddress;
            }
            set
            {
                deliveryAddress = value;
            }
        }
        private decimal totalCost;
        public decimal TotalCost
        {
            get
            {
                return totalCost;
            }
            set
            {
                totalCost = value;
            }
        }

        private Customer may_receive;

    }
}
