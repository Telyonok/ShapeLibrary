using NUnit.Framework;
using ShapeLibrary;

namespace ShapeLibraryTests
{
    [TestFixture]
    public class TriangleTests
    {

        [TestCase(1, 1, 1, 0.4330)]
        [TestCase(3, 4, 5, 6)]
        [TestCase(5, 5, 5, 10.8253)]
        public void GetArea_ReturnsCorrectValue(double a, double b, double c, double expectedArea)
        {
            var triangle = new Triangle(a, b, c);

            var area = triangle.GetArea();

            Assert.That(area, Is.EqualTo(expectedArea).Within(0.0001));
        }

        [Test]
        public void GetArea_AllZeroes_ThrowsArgumentOutOfRangeException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(0, 0, 0));
        }

        [Test]
        public void GetArea_OneZero_ThrowsArgumentOutOfRangeException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(0, 1, 1));
        }

        [Test]
        public void GetArea_NegativeValue_ThrowsArgumentOutOfRangeException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(-1, 1, 1));
        }

        [Test]
        public void IsRightAngled_3_4_5_ReturnsTrue()
        {
            var triangle = new Triangle(3, 4, 5);

            Assert.True(triangle.IsRightAngled());
        }

        [Test]
        public void IsRightAngled_4_4_4_ReturnsFalse()
        {
            var triangle = new Triangle(4, 4, 4);

            Assert.False(triangle.IsRightAngled());
        }
    }

    [TestFixture]
    public class CircleTests
    {
        [TestCase(1, Math.PI)]
        [TestCase(2, 4 * Math.PI)]
        [TestCase(3, 9 * Math.PI)]
        public void GetArea_ValidValues_ReturnsCorrectValue(double radius, double expectedArea)
        {
            var circle = new Circle(radius);

            var area = circle.GetArea();

            Assert.That(area, Is.EqualTo(expectedArea).Within(0.0001));
        }

        [Test]
        public void GetArea_Zero_ThrowsArgumentOutOfRangeException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Circle(0));
        }

        [Test]
        public void GetArea_NegativeValue_ThrowsArgumentOutOfRangeException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Circle(-3));
        }
    }
}