namespace Figure4MB.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void TestTriangleArea()
        {

            //Arrange

            Triangle4MB tr = new Triangle4MB(5.0, 4.0, 3.0);

            //Act

            double actual = tr.GetArea();

            //Assert

            Assert.Equal(6.0, actual);
        }

        [Theory]
        [InlineData(5.0, 4.0, 3.0, true)]
        [InlineData(5.0, 4.0, 2.0, false)]

        public void TestIsRightTriangle(double a, double b, double c, bool expected)
        {

            //Arrange

            Triangle4MB tr = new Triangle4MB(a, b, c);

            //Act

            bool actual = tr.IsRightTriangle();

            //Assert

            Assert.Equal(expected, actual);
        }

        [Fact]

        public void TestCircleArea()
        {

            //Arrange

            Circle4MB circle = new(1.0);

            //Act

            double actual = circle.GetArea();

            //Assert

            Assert.Equal(Math.PI, actual);
        }
    }
}