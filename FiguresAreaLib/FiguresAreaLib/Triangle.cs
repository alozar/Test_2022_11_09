namespace FiguresAreaLib
{
    public class Triangle : Figure
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }

        public Triangle(double sideA, double sideB, double sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        /// <summary>
        /// Вычислить площадь треугольника
        /// </summary>
        public override double СalculateArea()
        {
            if (SideA == default(double) || SideB == default(double) || SideC == default(double))
            {
                throw new ArgumentNullException("Одна из сторон не задана");
            }
            return СalculateArea(SideA, SideB, SideC);
        }

        /// <summary>
        /// Вычислить площадь треугольника
        /// </summary>
        public static double СalculateArea(double sideA, double sideB, double sideC)
        {
            var halfPerimeter = СalculatePerimeter(sideA, sideB, sideC) / 2;
            return Math.Sqrt(halfPerimeter * (halfPerimeter - sideA) * (halfPerimeter - sideB) * (halfPerimeter - sideC));
        }

        /// <summary>
        /// Вычислить периметр треугольника
        /// </summary>
        public static double СalculatePerimeter(double sideA, double sideB, double sideC)
        {
            return sideA + sideB + sideC;
        }
    }
}