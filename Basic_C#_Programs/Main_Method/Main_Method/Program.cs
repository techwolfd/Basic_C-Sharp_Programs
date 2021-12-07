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
            int xint2 =0;
            string xstring ;



            Console.WriteLine("ingresa un numero entero");
            xint = Convert.ToInt32(Console.ReadLine());
            //call to funnum
            //Sumnum numero = new Sumnum();
            Sumnum.funnum(xint);

            Console.WriteLine("\ningresa un numero decimal");
            xdec = Convert.ToDecimal(Console.ReadLine());
            //call to funnum
            Sumnum.funnum(xdec);

            Console.WriteLine("\ningresa un string(number)");
            xstring = Convert.ToString(Console.ReadLine());
            //call to funnum
            Sumnum.funnum(xstring);

            Console.WriteLine("\ningresa two numbers");
            //read first number
            xint = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("no necesary int second number");
            //read secoin number
            xint2 = Convert.ToInt32(Console.ReadLine());


            //call to funnummethod , if the second commented number is uncommented it works
            Sumnum.funnummethod (xint/*,xint2*/);

            Console.Read ();

        }





       
    }
    
}
