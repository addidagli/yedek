using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBookStore
{
    class ShoppingCart
    {
        double CustomerId;
        List<ItemToPurchase> itemsToPurchase = new List<ItemToPurchase>();
        float paymentAmount;
        bool paymentType;

        private void printProducts()
        {

        }

        public double CustomerID
        {
            get
            {
                return CustomerId;
            }

            set
            {
                CustomerId = value;
            }
        }
        public float PaymentAmount
        {
            get
            {
                return paymentAmount;
            }

            set
            {
                paymentAmount = value;
            }
        }
        public bool PaymentType
        {
            get
            {
                return paymentType;
            }

            set
            {
                paymentType = value;
            }
        }

        private void addProduct(ItemToPurchase itemToAdd)
        {
            itemsToPurchase.Add(itemToAdd);
        }

        private void removeProduct(ItemToPurchase itemToRemove)
        {
            itemsToPurchase.Remove(itemToRemove);
        }

        private void placeOrder()
        {

        }

        private void cancelOrder()
        {

        }
    }
}
