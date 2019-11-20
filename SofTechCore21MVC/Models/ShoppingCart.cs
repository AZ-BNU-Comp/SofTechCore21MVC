using System;

namespace SofTechCore21MVC.Models
{
    public class ShoppingCart
    {
        private int shoppingCartID;
        public int ShoppingCartID
        {
            get
            {
                return shoppingCartID;
            }
            set
            {
                shoppingCartID = value;
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
        private string status;
        public string Status
        {
            get
            {
                return status;
            }
            set
            {
                status = value;
            }
        }

        private OrderItem[] part_of;
        private Customer[] may_add_Garments_to;

    }
}
