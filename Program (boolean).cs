using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slide12
{
    class Program
    {
        static void Main(string[] args)
        {
            // Section 1
            Console.WriteLine(!true);
            Console.WriteLine(!false);
            Console.WriteLine(true && false);
            Console.WriteLine(true || false);
            Console.WriteLine(true && true);
            // Section 2
            Console.WriteLine((true && true) && true);
            Console.WriteLine((false || false) || false);
            // Section 3
            Console.WriteLine((12 > 10) && (14 > 7));
            Console.WriteLine((9 > 10) || (99 > 100));
        }
    }
}
