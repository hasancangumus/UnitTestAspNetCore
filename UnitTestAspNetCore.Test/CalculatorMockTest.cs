using Moq;
using UnitTestXUnitAspNetCore.App;

namespace UnitTestXUnitAspNetCore.Test
{
    public class CalculatorMockTest
    {
        private Calculator _calculator { get; set; }
        private Mock<ICalculatorService> _mock { get; set; }
        public CalculatorMockTest()
        {
            _mock = new Mock<ICalculatorService>();
            _calculator = new Calculator(_mock.Object);
        }

        [Theory]
        [InlineData(1, 2, 0)]
        [InlineData(5, 7, 0)]
        [InlineData(10, 19, 0)]
        public void SumMockTestWithParameter(int firstParam, int secondParam, int expectedParam)
        {
            _mock.Setup(x => x.Sum(firstParam, secondParam)).Returns(0);

            //Normally, actual data is sum of firstParam and secondParam.
            //But I create mock function above. It always returns 0
            int actualData = _calculator.Sum(firstParam, secondParam);

            Assert.Equal(expectedParam, actualData);
        }


    }
}
