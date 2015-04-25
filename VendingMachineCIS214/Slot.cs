using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VendingMachineCIS214
{
    class Slot
    {
        private int quantity;
        private string productName;

        public Slot(int newQuantity, string newProductName) 
        {
            quantity = newQuantity;
            productName = newProductName;
        }
        
        public int getQuantity() 
        {
            return quantity;
        }

        public string getProductName() 
        {
            return productName;
        }

        public void decrementQuantity() 
        {
            quantity--;
        }
    }
}
