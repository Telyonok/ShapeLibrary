namespace ShapeLibrary
{
    public interface IShape
    {
        public double GetArea();
    }

    public class Circle : IShape
    {
        private double radius;

        public Circle(double radius)
        {
            if (radius <= 0)
                throw new ArgumentOutOfRangeException("Radius can not be less or equal to zero.");
            this.radius = radius;
        }

        public double GetArea()
        {
            return Math.PI * Math.Pow(radius, 2);
        }
    }

    public class Triangle : IShape
    {
        private double a;
        private double b;
        private double c;

        public Triangle(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
                throw new ArgumentOutOfRangeException("Sides can not be less or equal to zero.");
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public double GetArea()
        {
            double s = (a + b + c) / 2;
            return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        }

        public bool IsRightAngled()
        {
            return a * a + b * b == c * c 
                || b * b + c * c == a * a 
                || a * a + c * c == b * b;
        }
    }
}
