using System;

namespace CalcModels
{
    public class Calculator
    {
        public int Add(int x, int y) { return x + y;}
        public int Subtract(int x, int y) { return x-y;}
        public int Multiply(int x, int y) {return x*y;}
        public int Divide(int x, int y) {
            if (y == 0) {
                throw new DivideByZeroException("Can't divide by 0");
            }
            return x/y;
            }


        public int Fibonacci(int n) { 

            if (n <= 1) {
                return n;
            }
            int prevFib = 0;
            int currFib = 1;
            for (int i = 0; i < n-1; i++) {
                int newFib = prevFib + currFib;
                prevFib = currFib;
                currFib = newFib;
            }
            return currFib;
            /*Recursive
            if (n <= 1) {
                return n;
            }
            return Fibonacci(n-1) + Fibonacci(n-2);
            */
        }    

        public bool IsPrime(int x) { return false;}
    }
}
