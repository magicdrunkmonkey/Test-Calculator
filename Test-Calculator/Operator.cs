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

        //Overload Add with one array
        public static double Add(double[] arrayOfInputs1) 
        {
            double sumArray = arrayOfInputs1[0]; //Initialize with arrays first value           

            for (int i = 1; i < arrayOfInputs1.Length; i++)
            {
                sumArray = sumArray + arrayOfInputs1[i];
            }

            return sumArray;
        }

        //Overload Add with two arrays
        public static double[] Add(double[] arrayOfInputs1, double[] arrayOfInputs2) 
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

        //Overload Subtract with one array
        public static double Subtract(double[] arrayOfInputs1)
        {
            double sumArray = arrayOfInputs1[0];  // Initialize with arrays first value

            for (int i = 1; i < arrayOfInputs1.Length; i++)
            {
                sumArray = sumArray - arrayOfInputs1[i];
            }

            return sumArray;
        }
        //Overload Subtration with two arrays
        public static double[] Subtract(double[] arrayOfInputs1, double[] arrayOfInputs2) 
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
            double subResult = 0;
            try
            {
                if(subNum2 == 0)
                {
                    throw new ArgumentException("You can't divide by 0.");
                }
                subResult = subNum1 / subNum2;
                
            }
            catch(ArgumentException error)
            {
                Console.WriteLine(error.Message);
            }
            return subResult;

            /*
            if (subNum2 == 0)
            {
                throw new ArgumentException("You cant divide by 0.");
            }
            else
            {
                double subResult = subNum1 / subNum2;
                return subResult;
            }  */
        }
    }
}