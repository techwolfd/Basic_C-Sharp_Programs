﻿using System;
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
            int x1 = 3;
            int x2 = 9;

            Method metodo = new Method();

            //call method opnumber pass 2 number
            metodo.opnumber(2, 5);
            
            //call method opnumber pass parameters
            metodo.opnumber(x1 , x2);

            
            Console.Read();

        }
        
    }
}
