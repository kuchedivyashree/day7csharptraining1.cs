using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    public delegate void mydele(int x, int y);
    internal class A
    {
        public void add(int x, int y)
        {
            Console.WriteLine("the sum is" + (x + y));
        }
        public void sub(int x, int y)
        {
            Console.WriteLine("the difference is" + (x - y));
            Console.ReadKey();
        }
    }
    class Proram
    {
        static void Main(string[] args)
        {
            A obj = new A();
            mydele m = new mydele(obj.add);
            m(10, 20);
            mydele m1 = new mydele(obj.sub);
            m1(10, 20);
        }
    }

    
}
