﻿using UnitTestXUnitAspNetCore.App;

namespace UnitTestXUnitAspNetCore.Test
{
    public class CalculatorTest
    {
        private Calculator calculator { get; set; }
        public CalculatorTest()
        {
            calculator = new Calculator();
        }


        [Fact]
        public void SumTestWithoutParameter()
        {
            //Arrange
            int a = 5;
            int b = 20;

            //Act
            var total = calculator.Sum(a, b);

            //Assert
            Assert.Equal<int>(25, total);
        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(5, 7, 12)]
        [InlineData(10, 19, 29)]
        public void SumTestWithParameter(int firstParam, int secondParam, int expectedParam)
        {
            int actualData = calculator.Sum(firstParam, secondParam);

            Assert.Equal(expectedParam, actualData);
        }

        [Theory]
        [InlineData(6, 3, 2)]
        [InlineData(55, 5, 11)]
        public void Divide_SimpleValues_ReturnQuotient(int firstParam, int secondParam, int expectedParam)
        {
            int actualData = calculator.Divide(firstParam, secondParam);

            Assert.Equal(expectedParam, actualData);
        }

        [Theory]
        [InlineData(5, 0)]
        public void Divide_SecondValueIsZero_ReturnDivideByZeroException(int firstParam, int secondParam)
        {
            Assert.Throws<DivideByZeroException>(() => calculator.Divide(firstParam, secondParam));
        }
    }
}
