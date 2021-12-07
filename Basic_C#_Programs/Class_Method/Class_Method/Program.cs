using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Method metodo = new Method();

            //call method opnumber pass 2 number
            metodo.opnumber(2, 5);
            
            //call method opnumber pass parameters
            metodo.opnumber(num2: 300 , num1 :9);

            
            Console.Read();

        }
        
    }
}
