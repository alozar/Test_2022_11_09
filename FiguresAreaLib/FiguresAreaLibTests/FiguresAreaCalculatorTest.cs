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
        public void Calc_circle_trueArea()
        {
            var circle = new Circle(20);
            var trueArea = Circle.ÑalculateAreaFunc(20);
            var calcArea = _calculator.Calc(circle);

            Assert.Equal(trueArea, calcArea);
        }

        [Fact]
        public void Calc_triangle_trueArea()
        {
            var triangle1 = new Triangle(8, 9, 10);
            var trueArea1 = Triangle.ÑalculateAreaFunc(8, 9, 10);
            var calcArea1 = _calculator.Calc(triangle1);

            Assert.Equal(trueArea1, calcArea1);

            var triangle2 = new Triangle(3, 4, 5);
            var trueArea2 = Triangle.ÑalculateAreaFunc(3, 4, 5);
            var calcArea2 = _calculator.Calc(triangle2);

            Assert.Equal(trueArea2, calcArea2);
        }
    }
}