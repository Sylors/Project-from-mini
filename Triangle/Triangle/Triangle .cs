using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    class Triangle
    {
        private int a;
        private int b;
        private int c;

        private double p;
        private double s;

        public Triangle(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;

            p = this.CalcPerimeter();
            s = this.CalcArea();
        }

        public bool isTriangle()
        {
            return ((a + b > c) && (a + c > b) && (b + c > a));
        }

        private int CalcPerimeter()
        {
            int p = a + b + c;
            return p;
        }

        public double getPerimeter() 
        {
            return p;
        }

        private double CalcArea()
        {
            int half = (a + b + c) / 2;
            double s = Math.Sqrt(half * (half - a) * (half - b) * (half-c));
            return s;
        }

        public double getArea() {
            return s;
        }

        public override string ToString() 
        {
            return "Треугольник со сторонами " + a + ", " + b + ", " + c + " имеет периметр " + p + " и площадь " + s;
        }
    }
}
