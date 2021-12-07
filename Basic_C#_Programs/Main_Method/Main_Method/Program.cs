using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            //int x = 0;
            decimal xdec= 0;
            int xint = 0;
            string xstring ;


            Console.WriteLine("ingresa un numero entero");
            xint = Convert.ToInt32(Console.ReadLine());
            //call to funnum
            Sumnum numero = new Sumnum();

            //Sumnum.funnum(xint);

            Console.WriteLine("\ningresa un numero decimal");
            xdec = Convert.ToDecimal( Console.ReadLine());
            //call to funnum

            Sumnum.funnum(xdec);

            Console.WriteLine("\ningresa un numero decimal");
            xstring = Convert.ToString (Console.ReadLine());
            //call to funnum

            Sumnum.funnum(xstring);

            Console.Read ();

        }





       
    }
    
}
