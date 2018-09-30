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

        public Triangle(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public bool Check()
        {
            if (a + b > c && a + c > b && b + c > a)
                return true;
            else
                return false;
        }

        public int Perimeter()
        {
            int p= a + b + c;
            return p;
        }

        public double Area()
        {
            int half = (a + b + c) / 2;
            double s = Math.Sqrt(half * (half - a) * (half - b) * (half-c));
            return s;
        }

        public void Output(int p, double s)
        {
            Console.WriteLine("Треугольник со сторонами {0}, {1}, {2} имеет периметр {3} и площадь {4} ", a, b, c, p, s);
        }
    }
}
