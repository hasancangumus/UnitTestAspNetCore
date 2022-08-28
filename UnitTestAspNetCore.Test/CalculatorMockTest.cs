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

        [Theory]
        [InlineData(1, 2, 0)]
        [InlineData(5, 7, 0)]
        [InlineData(10, 19, 0)]
        public void SumMockTestWithParameterVerifyTimesOnce(int firstParam, int secondParam, int expectedParam)
        {
            _mock.Setup(x => x.Sum(firstParam, secondParam)).Returns(0);
            int actualData = _calculator.Sum(firstParam, secondParam);

            _mock.Verify(x => x.Sum(firstParam, secondParam), Times.Once);  
        }

        [Theory]
        [InlineData(1, 2, 0)]
        [InlineData(5, 7, 0)]
        [InlineData(10, 19, 0)]
        public void SumMockTestWithParameterVerifyDivideTimesNever(int firstParam, int secondParam, int expectedParam)
        {
            _mock.Setup(x => x.Sum(firstParam, secondParam)).Returns(0);
            int actualData = _calculator.Sum(firstParam, secondParam);

            _mock.Verify(x => x.Divide(firstParam, secondParam), Times.Never);
        }

        [Theory]
        [InlineData(1, 2, 0)]
        [InlineData(5, 7, 0)]
        [InlineData(10, 19, 0)]
        public void SumMockTestWithParameterSetupIncludesCallback(int firstParam, int secondParam, int expectedParam)
        {
            int actualSum = 0;
            _mock.Setup(x => x.Sum(It.IsAny<int>(), It.IsAny<int>()))
                .Callback<int, int>((x, y) => actualSum = x + y);
            
            Assert.Equal(expectedParam, actualSum);
        }
    }
}
