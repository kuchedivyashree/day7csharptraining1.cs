using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    internal class rectangle
    {
        public delegate void rectDelegate(double height, double width);
        public void area(double height,double width)
        {
            Console.WriteLine("area is:{0}", (width * height));
        }
        public void perimeter(double height,double width)
        {
            Console.WriteLine("perimeter is:{0}", 2 * (width + height));
        }
        public static void Main(string[] args)
        {
            rectangle rect = new rectangle();
            rectDelegate rectdele = new rectDelegate(rect.area);
            rectdele.Invoke(6.3, 4.2);
            Console.WriteLine();
            rectdele.Invoke(16.3, 10.3);
            Console.ReadKey();
        }
    }
}
