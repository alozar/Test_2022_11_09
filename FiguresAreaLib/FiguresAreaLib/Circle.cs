namespace FiguresAreaLib
{
    public class Circle : Figure
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            _check(radius);
            Radius = radius;
        }

        /// <summary>
        /// Проверка на заполненность радиуса
        /// </summary>
        private static void _check(double radius)
        {
            if (radius == default(double))
            {
                throw new ArgumentNullException("Радиус не указан");
            }
        }

        /// <summary>
        /// Вычислить площадь круга
        /// </summary>
        public static double СalculateArea(double radius)
        {
            _check(radius);
            return Math.PI * radius * radius;
        }



        /// <summary>
        /// Вычислить площадь круга
        /// </summary>
        public override double СalculateArea()
        {
            _check(Radius);
            return СalculateArea(Radius);
        }
    }
}