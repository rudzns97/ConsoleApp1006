using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1006
{
    class Calc<T>
    {
        public T Add(T x, T y)
        {
            dynamic dx = x;
            dynamic dy = y;
            return dx + dy;
        }
        public double Add(double x, double y)
        {
            return x + y;
        }
        public int Minus(int x, int y)
        {
            return x - y;
        }
    }
    class Generic1
    {
        static void Main()
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            Calc<int> c1 = new Calc<int>();
            Console.WriteLine(c1.Add(3,5));
            //Console.WriteLine(c1.Minus(3.5, 5.7));
            Calc<double> c2 = new Calc<double>();
            c2.Add(3.5, 6.7);
        }
    }
}
