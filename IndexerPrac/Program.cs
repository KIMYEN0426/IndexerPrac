using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerPrac
{
    class Products
    {
        public int this[int i]
        {
            get { return i; }
            set { Console.WriteLine(i + "번째 상품 설정"); }
        }
    }

    class SquareCalculator
    {
        public int this[int i]
        {
            get { return i * i; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Products p = new Products();
            Console.WriteLine(p[0]);
            Console.WriteLine(p[1]);
            Console.WriteLine(p[2]);
            p[4] = 1;

            SquareCalculator square = new SquareCalculator();
            Console.WriteLine(square[10]);
            Console.WriteLine(square[20]);
            Console.WriteLine(square[30]);

        }
    }
}
