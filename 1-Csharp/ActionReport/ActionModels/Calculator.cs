using System;
namespace ActionModels
{
    public class Calculator
    {
        public void DoMath(int a, int b, Action<int, int> doOperation) {
            doOperation(a, b);
        } 
    }
}