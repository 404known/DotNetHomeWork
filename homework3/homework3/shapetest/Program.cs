using System;

namespace shapeTest
{
    public class ShapeTest
    {
        public static void Main()
        {
            Shape[] shapes = GenerateTenShapes();
            int sum = 0;
            for(int i = 0; i < 10; i++)
            {
                sum += shapes[i].Area;
            }
            Console.WriteLine(Sum(shapes));
        }
        public static Shape[] GenerateTenShapes()
        {
            Shape[] shapes = new Shape[10];
            shapes[0] = ShapeFactory.getShape("Square", 2);
            shapes[1] = ShapeFactory.getShape("Square", 1);
            shapes[2] = ShapeFactory.getShape("Triangle", 2, 3, 4);
            shapes[3] = ShapeFactory.getShape("Rectangle", 1, 3);
            shapes[4] = ShapeFactory.getShape("Rectangle", -4, 2);
            shapes[5] = ShapeFactory.getShape("Triangle", 2, 100, 2);
            shapes[6] = ShapeFactory.getShape("Square", 2);
            shapes[7] = ShapeFactory.getShape("Square", 1);
            shapes[8] = ShapeFactory.getShape("Square", 2);
            shapes[9] = ShapeFactory.getShape("Square", 1);
            return shapes;
        }
        public static int Sum(Shape[] shapes)
        {
            int sum = 0;
            foreach (Shape shape in shapes)
            {
                sum += shape.Area;
            }
            return sum;
        }
    }

    public interface Shape
    {
        int Area { get; }
        bool IsLegal();
    }
    public class Rectangle : Shape
    {
        protected int width;
        protected int height;
        public int Area { get => width * height; }

        public Rectangle(int w, int h)
        {
            width = w;
            height = h;
        }

        public bool IsLegal()
        {
            return (width > 0 && height > 0);
        }
    }
    public class Square : Rectangle
    {
        public Square(int x) : base(x, x)
        {
        }
    }
    public class Triangle : Shape
    {
        private int side1;
        private int side2;
        private int side3;
        public Triangle(int x, int y, int z)
        {
            side1 = x;
            side2 = y;
            side3 = z;
        }
        private int p()
        {
            return (side1 + side2 + side3) / 2;
        }
        int Shape.Area { get => (int)Math.Sqrt(p() * (p()-side1) * (p()-side2) * (p()-side3)); }

        public bool IsLegal()
        {
            if (side1 <= 0 && side2 <= 0 && side3 <= 0) return false;
            if (side1 + side2 <= side3) return false;
            if (side2 + side3 <= side1) return false;
            if (side1 + side3 <= side2) return false;
            return true;
        }
    }
    public class ShapeFactory
    {
        public static Shape getShape(String dis, params int[] par)
        {
            if(dis == "Square")
            {
                if (par.Length != 1) return new Square(0);
                Square s = new Square(par[0]);
                if(!s.IsLegal()) return new Square(0);
                return s;
            }
            else if(dis == "Rectangle")
            {
                if(par.Length != 2) return new Rectangle(0, 0);
                Rectangle s = new Rectangle(par[0], par[1]);
                if(!s.IsLegal()) return new Rectangle(0, 0);
                return s;
            }
            else
            {
                if (par.Length != 3) return new Triangle(0, 0, 0);
                Triangle s = new Triangle(par[0], par[1], par[2]);
                if(!s.IsLegal()) return new Triangle(0, 0, 0);
                return new Triangle(par[0], par[1], par[2]);
            }
        }
    }
}