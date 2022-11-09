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
        /// Функция вычисления периметра треугольника
        /// </summary>
        public static readonly Func<double, double, double, double> СalculatePerimeterFunc =
            (sideA, sideB, sideC) => sideA + sideB + sideC;

        /// <summary>
        /// Функция вычисления площади треугольника (формула Герона)
        /// </summary>
        public static readonly Func<double, double, double, double> СalculateAreaFunc =
            (sideA, sideB, sideC) =>
            {
                var halfPerimeter = СalculatePerimeterFunc(sideA, sideB, sideC) / 2;
                return Math.Sqrt(halfPerimeter * (halfPerimeter - sideA) * (halfPerimeter - sideB) * (halfPerimeter - sideC));
            };

        public override double СalculateArea()
        {
            if (SideA == default(double) || SideB == default(double) || SideC == default(double))
            {
                throw new ArgumentNullException("Одна из сторон не задана");
            }
            return СalculateAreaFunc(SideA, SideB, SideC);
        }

        public static double СalculateArea(double sideA, double sideB, double sideC)
        {
            return СalculateAreaFunc(sideA, sideB, sideC);
        }
    }
}