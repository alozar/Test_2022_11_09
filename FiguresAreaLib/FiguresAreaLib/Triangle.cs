namespace FiguresAreaLib
{
    public class Triangle : Figure
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }

        public Triangle(double sideA, double sideB, double sideC)
        {
            _check(sideA, sideB, sideC);
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }
        
        /// <summary>
        /// Проверка на заполненность сторон
        /// </summary>
        private static void _check(double sideA, double sideB, double sideC)
        {
            if (sideA == default(double) || sideB == default(double) || sideC == default(double))
            {
                throw new ArgumentNullException("Одна из сторон не задана");
            }
        }

        /// <summary>
        /// Вычислить площадь треугольника
        /// </summary>
        public static double СalculateArea(double sideA, double sideB, double sideC)
        {
            _check(sideA, sideB, sideC);
            var halfPerimeter = СalculatePerimeter(sideA, sideB, sideC) / 2;
            return Math.Sqrt(halfPerimeter * (halfPerimeter - sideA) * (halfPerimeter - sideB) * (halfPerimeter - sideC));
        }

        /// <summary>
        /// Вычислить периметр треугольника
        /// </summary>
        public static double СalculatePerimeter(double sideA, double sideB, double sideC)
        {
            _check(sideA, sideB, sideC);
            return sideA + sideB + sideC;
        }

        /// <summary>
        /// Является ли треугольник прямоугольным
        /// </summary>
        public static bool IsRight(double sideA, double sideB, double sideC)
        {
            _check(sideA, sideB, sideC);
            return sideA * sideA == sideB * sideB + sideC * sideC
                || sideB * sideB == sideA * sideA + sideC * sideC
                || sideC * sideC == sideA * sideA + sideB * sideB;
        }



        /// <summary>
        /// Вычислить площадь треугольника
        /// </summary>
        public override double СalculateArea()
        {
            _check(SideA, SideB, SideC);
            return СalculateArea(SideA, SideB, SideC);
        }

        /// <summary>
        /// Является ли треугольник прямоугольным
        /// </summary>
        public bool IsRight()
        {
            _check(SideA, SideB, SideC);
            return IsRight(SideA, SideB, SideC);
        }
    }
}