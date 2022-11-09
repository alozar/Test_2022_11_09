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
        public static double CalculateArea(double radius)
        {
            _check(radius);
            return Math.PI * radius * radius;
        }



        /// <summary>
        /// Вычислить площадь круга
        /// </summary>
        public override double CalculateArea()
        {
            _check(Radius);
            return CalculateArea(Radius);
        }
    }
}