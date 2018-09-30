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
            bool ch = t1.isTriangle();
            if (ch)
            {
                Console.WriteLine(t1);
            } else {
                Console.WriteLine("Треугольник с данными сторонами не существует");
            }
            Console.ReadLine();
        }
    }
}
