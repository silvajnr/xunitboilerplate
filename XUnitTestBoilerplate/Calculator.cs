using System;
using System.Collections.Generic;
using System.Text;

namespace XUnitTestBoilerplate
{
    public class Calculator
    {        
        public decimal Value { get; private set; } = 0;

        public decimal Add(decimal value)
        {
            return Value += value;
        }

        public decimal Subtract(decimal value)
        {
            return Value -= value;
        }

        public decimal Multiply(decimal value)
        {
            if(Value == 0)
            {
                return Value = value;
            }
            
            return Value *= value;
        }

        public decimal Divide(decimal value)
        {
            if (Value == 0)
            {
                return Value = value;
            }

            return Value /= value;
        }

    }
}
