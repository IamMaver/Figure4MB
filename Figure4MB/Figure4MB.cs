namespace Figure4MB
{
    public abstract class Figure4MB
    {
        public abstract double GetArea();

        public static double CalculateArea(Figure4MB figure) // Функция для попучения площади любого потомка класса без знания конкретной фигуры в compile-time 
        {
            return figure.GetArea();
        }
    }
    public class Triangle4MB : Figure4MB
    {
        private double a, b, c;

        public Triangle4MB(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public override double GetArea()
        {
            double hP; //hP = Half of Perimeter
            if (a <= 0 || b <= 0 || c <= 0) throw new ArgumentException("All sides must be greater than zero");
            else if (a + b < c || b + c < a || a + c < b) throw new ArgumentException("It's not a triangle");
            hP = (a + b + c) / 2.0;

            return Math.Sqrt(hP * (hP - a) * (hP - b) * (hP - c)); // Heron's formula
        }

        public bool IsRightTriangle()
        {
            double[] side = new double[3];
            side[0] = a;
            side[1] = b;
            side[2] = c;
            Array.Sort(side);

            return Math.Abs(side[0] * side[0] + side[1] * side[1] - side[2] * side[2]) <= 1E-7;
        }
    }

    public class Circle4MB : Figure4MB
    {
        private double r;

        public Circle4MB(double r)
        {
            this.r = r;
        }

        public double R
        {
            get { return r; }
            set { r = value; }
        }

        public override double GetArea()
        {
            if (r < 0.0) throw new ArgumentException("Radius less than zero");
            return double.Pi * r * r;
        }
    }
}