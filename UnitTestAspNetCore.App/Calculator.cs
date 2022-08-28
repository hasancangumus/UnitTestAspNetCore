namespace UnitTestXUnitAspNetCore.App
{
    public class Calculator
    {
        private ICalculatorService _calculatorService;
        public Calculator(ICalculatorService calculatorService)
        {
            _calculatorService = calculatorService;
        }
        public int Sum(int firstItem, int secondItem)
        {
            return _calculatorService.Sum(firstItem, secondItem);
        }

        public int Divide(int firstItem, int secondItem)
        {
            return _calculatorService.Divide(firstItem, secondItem);
        }
    }
}
