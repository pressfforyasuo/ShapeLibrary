using ShapeLibrary.Shapes;

namespace TestShape
{
    [TestClass]
    public class ShapeTests
    {
        [TestMethod]
        public void Circle_AreaCalculation_ReturnsCorrectValue()
        { 
            double radius = 5;
            Circle circle = new Circle(radius);

            double area = circle.CalculateArea();

            Assert.AreEqual(Math.PI * radius * radius, area);
        }

        [TestMethod]
        public void Triangle_AreaCalculation_ReturnsCorrectValue()
        {
            double sideA = 3;
            double sideB = 4;
            double sideC = 5;
            Triangle triangle = new Triangle(sideA, sideB, sideC);

            double area = triangle.CalculateArea();

            Assert.AreEqual(6, area);
        }

        [TestMethod]
        public void Triangle_IsRightAngled_ReturnsTrueForRightAngledTriangle()
        {
            double sideA = 3;
            double sideB = 4;
            double sideC = 5;
            Triangle triangle = new Triangle(sideA, sideB, sideC);

            bool isRightAngled = triangle.IsRightAngled();

            Assert.IsTrue(isRightAngled);
        }

        [TestMethod]
        public void Triangle_IsRightAngled_ReturnsFalseForNonRightAngledTriangle()
        {
            double sideA = 2;
            double sideB = 3;
            double sideC = 4;
            Triangle triangle = new Triangle(sideA, sideB, sideC);

            bool isRightAngled = triangle.IsRightAngled();

            Assert.IsFalse(isRightAngled);
        }
    }
}
