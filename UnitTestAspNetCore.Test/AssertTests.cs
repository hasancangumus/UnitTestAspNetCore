namespace UnitTestXUnitAspNetCore.Test
{
    public class AssertTests
    {
        [Fact]
        public void StringContains()
        {
            Assert.Contains("Hasan", "Hasan Cangümüş");
        }

        [Fact]
        public void StringDoesNotContain()
        {
            Assert.DoesNotContain("Ahmet", "Hasan Cangümüş");
        }

        [Fact]
        public void ListContains()
        {
            var nameList = new List<string>() { "Hasan", "Mehmet", "Ümit" };
            Assert.Contains(nameList, x => x == "Hasan");
        }

        [Fact]
        public void ListDoesNotContain()
        {
            var nameList = new List<string>() { "Hasan", "Mehmet", "Ümit" };
            Assert.DoesNotContain(nameList, x => x == "Ali");
        }

        [Fact]
        public void BooleanTrue()
        {
            Assert.True(5 > 3);
        }

        [Fact]
        public void BooleanTrueTypeOf()
        {
            //string = string ----- Test success
            Assert.True("".GetType() == typeof(string));
        }

        [Fact]
        public void BooleanFalse()
        {
            Assert.False(3 > 5);
        }

        [Fact]
        public void BooleanFalseTypeOf()
        {
            //string != int ----- Test success
            Assert.False("".GetType() == typeof(int));
        }

        [Fact]
        public void RegexMatches()
        {
            var regEx = "^[0-9]*$"; //regex pattern just contains digit
            Assert.Matches(regEx, "1234");
        }

        [Fact]
        public void RegexDoesNotMatch()
        {
            var regEx = "^[0-9]*$"; //regex pattern just contains digit
            Assert.DoesNotMatch(regEx, "1234Abcd");
        }

        [Fact]
        public void StringStartsWith()
        {
            Assert.StartsWith("T", "Tuesday");
        }

        [Fact]
        public void StringEndsWith()
        {
            Assert.EndsWith("day", "Tuesday");
        }

        [Fact]
        public void Empty()
        {
            Assert.Empty(new List<string>());
        }

        [Fact]
        public void NotEmpty()
        {
            Assert.NotEmpty(new List<string>() { "Hasan" });
        }

        [Fact]
        public void InRange()
        {
            Assert.InRange(10, 2, 20);
        }

        [Fact]
        public void NotInRange()
        {
            Assert.NotInRange(30, 2, 20);
        }

        [Fact]
        public void Single()
        {
            Assert.Single(new List<string>() { "Hasan" });
            //Assert.Single(new List<string>() { "Hasan","Ahmet" });    //Test fail
            //Assert.Single(new List<int>() { 1, 2, 3 });               //Test fail     
        }

        [Fact]
        public void IsType()
        {
            Assert.IsType<string>("Hasan");
            //Assert.IsType<int>("Hasan");               //Test fail
        }

        [Fact]
        public void IsNotType()
        {
            //Assert.IsNotType<string>("Hasan");    //Test fail
            Assert.IsNotType<int>("Hasan");
        }

        [Fact]
        public void IsAssignableFrom()
        {
            //List type inherits IEnumerable interface
            Assert.IsAssignableFrom<IEnumerable<string>>(new List<string>());

            //Object is the greatest class. All types inherits Object
            Assert.IsAssignableFrom<Object>("Hasan");
            Assert.IsAssignableFrom<Object>(7);
        }

        [Fact]
        public void Null()
        {
            string? nullString = null;
            Assert.Null(nullString);
        }

        [Fact]
        public void NotNull()
        {
            string? notNullString = "abc";
            Assert.NotNull(notNullString);
        }

        [Fact]
        public void Equal()
        {
            Assert.Equal<int>(2, 2);
        }

        [Fact]
        public void NotEqual()
        {
            Assert.NotEqual<int>(2, 5);
        }
    }
}
