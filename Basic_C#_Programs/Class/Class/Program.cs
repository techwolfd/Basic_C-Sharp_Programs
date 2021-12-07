using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            decimal y = 0;
            Class1 obj = new Class1();
            

            Console.WriteLine("enter a number; ");
            x = Convert.ToInt32(Console.ReadLine());

            //object method whit int
            obj.numop(x);

            //method static
            Class1.numop1(x);

            y = x;
            //object method whit decimal
            obj.numop(y);

            Console.Read();
        }
    }
}
