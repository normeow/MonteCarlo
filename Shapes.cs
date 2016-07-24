using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MonteCarlo
{

    public interface IArea

    {
        Shape getShape();
    }

    public interface Shape
    {
        double getSquare();
        bool isWithin(double x, double y);
    }

    public class Rect : Shape
    {
        public int x1, y1, x2, y2;
        public Rect(int x1, int y1, int x2, int y2)
        {

            if (x1 < 0 || y1 < 0 || x2 < 0 || y2 < 0)
                throw new ArgumentOutOfRangeException("Координаты должны распологаться в первой четверти");
            if (x2 <= x1 || y2 <= y1)
                throw new ArgumentOutOfRangeException("Неверно заданы координаты");
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
        }


        public double getSquare()
        {
            return (x2 - x1) * (y2 - y1);
        }

        public bool isWithin(double x, double y)
        {
            return x >= x1 && x <= x2 && y <= y2 && y >= y1;
        }

        public int width() { return x2 - x1; }
        public int height() { return y2 - y1; }
    }

    public class Circle : Shape
    {
        public int x, y, r;
        public Circle(int x, int y, int r)
        {
            if (x < 0 || y < 0 || r <= 0)
                throw new ArgumentOutOfRangeException("Некорректные параметры окружности");
            this.x = x;
            this.y = y;
            this.r = r;
        }
        

        public double getSquare()
        {
            return Math.PI * r * r;
        }

        public bool isWithin(double x, double y)
        {
            return Math.Pow(x - this.x, 2) + Math.Pow(y - this.y, 2) <= r; ;
        }
    }

    public class Ellipse : Shape
    {
        public int x, y, a, b;

        public Ellipse(int x, int y, int a, int b)
        {
            if (x < 0 || y < 0 || a <= 0 || b <= 0)
                throw new ArgumentOutOfRangeException("Некорректные параметры эллипса");
            this.x = x;
            this.y = y;
            this.a = a;
            this.b = b;
        }
        

        public double getSquare()
        {
            return Math.PI * a * b;
        }

        public bool isWithin(double x, double y)
        {
            return Math.Pow(x - this.x, 2) / (a * a) + Math.Pow(y - this.y, 2) / (b * b) <= 1;
        }
    }
}
