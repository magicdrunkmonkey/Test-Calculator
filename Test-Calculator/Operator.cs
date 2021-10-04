using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    class Operator
    {
        public static double Add(double addNum1, double addNum2)
        {
            double addResult = addNum1 + addNum2;
            return addResult;
        }

        public static double Subtract(double subNum1, double subNum2)
        {
            double subResult = subNum1 - subNum2;
            return subResult;
        }

        public static double Multiply(double subNum1, double subNum2)
        {
            double subResult = subNum1 * subNum2;
            return subResult;
        }

        public static double Divide(double subNum1, double subNum2)
        {
            double subResult = subNum1 / subNum2;
            return subResult;
        }
    }
}