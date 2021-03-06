using System;
using Xunit;
using Test_Calculator;

namespace Test_Calculator.Tests
{
    public class CalculationTests
    {
        [Fact]
        public void DivisionWithZero()
        {
            //Arrange
            double num1 = 1;
            double num2 = 0;
            double expected = 0;

            //Act
            double result = Operator.Divide(num1, num2);

            //Attempt 1
            /*ArgumentException result = Assert.Throws<ArgumentException>(
                () => Operator.Divide(num1,num2));*/

            //Assert
            Assert.Equal(expected, result);

            //Attempt 1
            //Assert.Equal("You cant divide by 0.", result.Message);
        }

        [Theory]
        [InlineData(9990, 10)]
        [InlineData(10, 44444)]
        [InlineData(1334, -10)]
        [InlineData(-1334, 10)]
        public void TestAdd(double num1,double num2)
        {           
            double result = Operator.Add(num1, num2);

            Assert.Equal(result, num1 + num2);
        }
               
        [Theory]
        [InlineData(9990, 10)]
        [InlineData(10, 44444)]
        [InlineData(1334, -10)]
        [InlineData(-1334, 10)]
        public void TestSubtract(double num1, double num2)
        {
            double result = Operator.Subtract(num1, num2);

            Assert.Equal(result, num1 - num2);
        }

        [Fact]
        public void TestMultiply()
        {
            //Arrange
            //Operator op = new Operator();
            double num1 = 10;
            double num2 = 12;

            //Act
            double result = Operator.Multiply(num1, num2);           

            //Assert
            Assert.Equal(result, num1 * num2);
        }

        [Fact]
        public void Divide()
        {
            //Arrange
            double num1 = 10;
            double num2 = 2;

            //Act
            double result = Operator.Divide(num1, num2);

            //Assert
            Assert.Equal(result, num1 / num2);
        }

        [Fact]
        public void AdditionOverloadArray()  //Test Addition Overload with one array
        {
            double[] testArray1 = { 1, 3, 5, 7, 9 };
            double correctResult = 25;                     

            double testResult = Operator.Add(testArray1);

            Assert.Equal(correctResult, testResult);
        }

        [Fact]
        public void SubractionOverloadWithOneArray() //Test Subtraction Overload with one array
        {
            double[] testArray1 = { 2, 4, 6, 8 };
            double correctResult = -16;            

            double testResult = Operator.Subtract(testArray1);

            Assert.Equal(correctResult, testResult);
        }

        [Fact]
        public void AdditionOverloadWithOneArray()  //Test Addition Overload with two arrays
        {
            double[] testArray1 = { 1, 3, 5, 7, 9 };
            double[] testArray2 = { 1, 3, 5, 7, 9 };
            double[] correctResult = { 2, 6, 10, 14, 18 };

            double[] testResult = new double[correctResult.Length];

            testResult = Operator.Add(testArray1, testArray2);

            Assert.Equal(correctResult, testResult);
        }

        [Fact]
        public void SubractionOverloadArray() //Test Subtraction Overload with two arrays
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
