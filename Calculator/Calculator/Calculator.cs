using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Calculator
    {
        public double FirstNumber;
        public double SecondNumber;
        public double Add()
        {
            double Result = FirstNumber + SecondNumber;
            return Result;
        }
        public double Sub()
        {
            double Result = FirstNumber - SecondNumber;
            return Result;
        }
        public double Mul()
        {
            double Result = FirstNumber * SecondNumber;
            return Result;
        }
        public double Div()
        {
            double Result = FirstNumber / SecondNumber;
            return Result;
        }
    }

}
