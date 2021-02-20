using System;
using ActionModels;
namespace ActionUI
{
    class Program
    {
        static Cart cart = new Cart();
        static Customer customer = new Customer();
        static Calculator calculate = new Calculator();
        static void Main(string[] args)
        {
            Console.Clear();
            Product newProduct = new Product();
            newProduct.ProductName = "Test Product";
            newProduct.Price = 54.32;
            cart.Items.Add(newProduct);
            newProduct = new Product();
            newProduct.ProductName = "Another Product";
            newProduct.Price = 23.45;
            cart.Items.Add(newProduct);

            cart.DiscountMessage(PrintMessage);
            Console.WriteLine();
            cart.PrintCart(PrintMessage);
            Console.WriteLine();
            customer.PrintCustomerName(PrintMessage);
            Console.WriteLine();
            
            int a = 9;
            int b = 3;
            calculate.DoMath(a, b, Add);
            calculate.DoMath(a, b, Subtract);
            calculate.DoMath(a, b, Multiply);

            Console.ReadLine();
        }

        private static void PrintMessage(string message) { Console.WriteLine(message); }

        private static void Add(int a, int b) { Console.WriteLine(a+b); }
        private static void Subtract(int a, int b) { Console.WriteLine(a-b); }
        private static void Multiply(int a, int b) { Console.WriteLine(a*b); }
    }
}
