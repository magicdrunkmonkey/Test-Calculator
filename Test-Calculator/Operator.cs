using System;
using System.Collections.Generic;
using System.Text;

namespace Test_Calculator
{
    public class Operator
    {
        public static double Add(double addNum1, double addNum2)
        {
            double addResult = addNum1 + addNum2;
            return addResult;
        }

        public static double[] Add(double[] arrayOfInputs1, double[] arrayOfInputs2) //Overload Add with an array
        {
            double[] addArrayResults = new double[arrayOfInputs1.Length];

            for(int i=0; i < arrayOfInputs1.Length; i++)
            {
                addArrayResults[i] = arrayOfInputs1[i] + arrayOfInputs2[i];
            }
            
            return addArrayResults;
        }

        public static double Subtract(double subNum1, double subNum2)
        {
            double subResult = subNum1 - subNum2;
            return subResult;
        }

        public static double[] Subtract(double[] arrayOfInputs1, double[] arrayOfInputs2) //Overload subtration with an array
        {
            double[] subArrayResults = new double[arrayOfInputs1.Length];

            for (int i = 0; i < arrayOfInputs1.Length; i++)
            {
                subArrayResults[i] = arrayOfInputs1[i] - arrayOfInputs2[i];
            }
            return subArrayResults;
        }

        public static double Multiply(double subNum1, double subNum2)
        {
            double subResult = subNum1 * subNum2;
            return subResult;
        }

        public static double Divide(double subNum1, double subNum2)
        {
            if (subNum2 == 0)
            {
                throw new ArgumentException("You cant divide by 0.");
            }
            else
            {
                double subResult = subNum1 / subNum2;
                return subResult;
            }   
            
            //return subResult;
        }
    }
}