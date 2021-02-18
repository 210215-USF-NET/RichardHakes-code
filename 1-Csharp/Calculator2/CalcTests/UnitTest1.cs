using System;
using Xunit;
using CalcModels;

namespace CalcTests
{
    public class UnitTest1
    {
         Calculator testCalculator = new Calculator();
        [Fact]
        public void TestAddFunc()
        {
            int x = 43;
            int y = 34;
            int z = x + y;

            Assert.Equal(z, testCalculator.Add(x, y));
        }
        [Fact]
        public void TestSubtractFunc()
        {
            int x = 43;
            int y = 34;
            int z = x - y;
            Assert.Equal(z, testCalculator.Subtract(x,y));
        }
        [Fact]
        public void TestMultiplyFunc()
        {
            int x = 43;
            int y = 34;
            int z = x * y;
            Assert.Equal(z, testCalculator.Multiply(x,y));
        }
        [Fact]
        public void TestDivideFunc()
        {
            int x = 27;
            int y = 3;
            int z = x / y;
            Assert.Equal(z, testCalculator.Divide(x,y));
        }

        [Theory]
        [InlineData(0)]

        public void TestDivideByZero(int y)
        {
            Assert.Throws<DivideByZeroException>(() => testCalculator.Divide(5,y));
        }

        [Fact]
        public void TestFibonacciZero()
        {
            // 0 1 1 2 3 4 8 13 21
            int n = 0;
            Assert.Equal(n, testCalculator.Fibonacci(0));

        }
    }
}
