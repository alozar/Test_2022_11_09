namespace FiguresAreaLib
{
    public class Circle : Figure
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        /// <summary>
        /// Функция вычисления площади круга
        /// </summary>
        public static readonly Func<double, double> СalculateAreaFunc = (radius) => Math.PI * radius * radius;

        /// <summary>
        /// Вычислить площадь круга
        /// </summary>
        public override double СalculateArea()
        {
            if (Radius == default(double))
            {
                throw new ArgumentNullException("Радиус круга не задан");
            }
            return СalculateAreaFunc(Radius);
        }

        /// <summary>
        /// Вычислить площадь круга
        /// </summary>
        public static double СalculateArea(double radius)
        {
            return СalculateAreaFunc(radius);
        }
    }
}