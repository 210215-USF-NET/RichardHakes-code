using System;   //import package

namespace HelloWorld    //package Helloworld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello {name}!");
        }
    }
}
