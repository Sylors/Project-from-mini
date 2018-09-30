using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle t1 = new Triangle(15,20,25);
            bool ch = t1.Check();
            if (ch)
            {
                int p =t1.Perimeter();
                double s= t1.Area();
                t1.Output(p,s);
            }
            else
                Console.WriteLine("Треугольник с данными сторонами не существует");
            Console.ReadLine();
        }
    }
}
