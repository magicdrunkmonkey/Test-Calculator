using System;
using Xunit;
using Test_Calculator;

namespace Test_Calculator.Tests
{
    public class CalculationTests
    {
        [Fact]
        public void TestDivisionWithZero()
        {
            double num1 = 1;
            double num2 = 0;

            ArgumentException result = Assert.Throws<ArgumentException>(
                () => Operator.Divide(num1,num2));

            Assert.Equal("You cant divide by 0.", result.Message);
        }

        [Fact]
        public void AdditionOverloadArray()
        {
            double[] testArray1 = { 1, 3, 5, 7, 9 };
            double[] testArray2 = { 1, 3, 5, 7, 9 };
            double[] correctResult = { 2, 6, 10, 14, 18 };

            double[] testResult = new double[correctResult.Length];

            testResult = Operator.Add(testArray1, testArray2);

            Assert.Equal(correctResult, testResult);
        }

        [Fact]
        public void SubractionOverloadArray()
        {
            double[] testArray1 = { 2, 4, 6, 8 };
            double[] testArray2 = { 1, 1, 2, 10 };
            double[] correctResult = { 1, 3, 4, -2 };

            double[] testResult = new double[correctResult.Length];

            testResult = Operator.Subtract(testArray1, testArray2);

            Assert.Equal(correctResult, testResult);
        }
    }
}
