namespace FiguresAreaLibTests
{
    public class FiguresAreaCalculatorTest
    {
        private readonly FiguresAreaCalculator _calculator;

        public FiguresAreaCalculatorTest()
        {
            _calculator = new FiguresAreaCalculator();
        }

        [Fact]
        public void CircleCalcArea_True()
        {
            var circle = new Circle(20);
            var trueArea = Circle.CalculateArea(20);
            var calcArea = _calculator.Calc(circle);

            Assert.Equal(trueArea, calcArea);
        }

        [Fact]
        public void TriangleCalcArea_True()
        {
            var triangle1 = new Triangle(8, 9, 10);
            var trueArea1 = Triangle.CalculateArea(8, 9, 10);
            var calcArea1 = _calculator.Calc(triangle1);

            Assert.Equal(trueArea1, calcArea1);
        }

        [Fact]
        public void TriangleIsRight_True()
        {
            var triangle1 = new Triangle(8, 9, 10);
            Assert.False(triangle1.IsRight());
            Assert.False(Triangle.IsRight(8, 9, 10));

            var triangle2 = new Triangle(3, 4, 5);
            Assert.True(triangle2.IsRight());
            Assert.True(Triangle.IsRight(3, 4, 5));
        }
    }
}