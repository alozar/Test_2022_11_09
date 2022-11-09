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
        /// Вычислить площадь круга
        /// </summary>
        public override double СalculateArea()
        {
            if (Radius == default(double))
            {
                throw new ArgumentNullException("Радиус круга не задан");
            }
            return СalculateArea(Radius);
        }

        /// <summary>
        /// Вычислить площадь круга
        /// </summary>
        public static double СalculateArea(double radius)
        {
            return Math.PI * radius * radius;
        }
    }
}