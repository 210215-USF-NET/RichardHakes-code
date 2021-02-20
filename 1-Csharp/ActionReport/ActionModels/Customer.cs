using System;

namespace ActionModels
{
    public class Customer
    {
        private string Name = "FName LName";

        public void PrintCustomerName(Action<string> printName) {
            printName(Name);
        }
    }
}