namespace UnitTestXUnitAspNetCore.App
{
    public class CalculatorService : ICalculatorService
    {
        public int Sum(int firstItem, int secondItem)
        {
            return firstItem + secondItem;
        }

        public int Divide(int firstItem, int secondItem)
        {
            if (firstItem == 0 || secondItem == 0)
                throw new DivideByZeroException();


            return firstItem / secondItem;
        }
    }
}
