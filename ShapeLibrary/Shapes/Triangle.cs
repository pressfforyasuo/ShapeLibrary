namespace ShapeLibrary.Shapes
{
    public class Triangle : IShape
    {
        private double sideA;
        private double sideB;
        private double sideC;

        public Triangle(double sideA, double sideB, double sideC)
        {
            this.sideA = sideA;
            this.sideB = sideB;
            this.sideC = sideC;
        }

        public double CalculateArea()
        {
            double semiPerimeter = (sideA + sideB + sideC) / 2;
            return Math.Sqrt(semiPerimeter * (semiPerimeter - sideA) * (semiPerimeter - sideB) * (semiPerimeter - sideC));
        }

        public bool IsRightAngled()
        {
            double maxSide = Math.Max(sideA, Math.Max(sideB, sideC));
            if (maxSide == sideA)
                return IsRightAngledHelper(sideA, sideB, sideC);
            else if (maxSide == sideB)
                return IsRightAngledHelper(sideB, sideA, sideC);
            else
                return IsRightAngledHelper(sideC, sideA, sideB);
        }

        private bool IsRightAngledHelper(double maxSide, double side1, double side2)
        {
            return maxSide * maxSide == side1 * side1 + side2 * side2;
        }
    }
}
