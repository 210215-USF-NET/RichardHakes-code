using System;
using System.Collections.Generic;
namespace ActionModels
{
    public class Cart
    {
        public List<Product> Items {get; set;} = new List<Product>();

        public void DiscountMessage(Action<string> alertDiscount) {
            alertDiscount("We have a discount for this item");
        }

        public void PrintCart(Action<string> printList) {
            foreach(var item in Items) {
                printList(item.ProductName);
            }
        }
    }
}
