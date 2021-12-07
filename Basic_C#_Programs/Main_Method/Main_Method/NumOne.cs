using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Method
{
    public class Sumnum
    {
        public Sumnum()
        {
            //Console.WriteLine("ingresa un numero entero d");


            //int x =Convert.ToInt32(Console.ReadLine());
                        
            //int nsum = funsum(x);
            //Console.WriteLine("sum of the same number: " + nsum);


            //decimal xdec = 0;
            ////called function funsum

            //decimal nmul = funmul(xdec);
            
        }

        //public int num {get; set;}
        //function funsum whit int
        public static int funnum(int numero)
        {
            int numsum = numero;
            //operation sum
            numero = numsum + numsum;
            // print of operation
            Console.WriteLine("sum of the same number: " + numero);
            return numero;
        }

        //function funsum whit decimal
        public static decimal funnum(decimal numero)
        {
            decimal numsum = numero;
            //operation multiplication
            numero = numsum * numsum;
            // print of operation
            Console.WriteLine("multiplication of the same number: " + numero);
            return numero;
        }

        //function funsum whit string
        public static string funnum(string numero)
        {
            //convert to int
            int numsum = Convert.ToInt32( numero);
            //operation sum
            numero += numsum;
            // print of operation
            Console.WriteLine("sum of the same number: " + numero);
            return numero;
        }

        public static int funnummethod(int numero,int numero2 = 2)
        {
            
            numero2 = Convert.ToInt32(numero2);
            //operation sum
            numero = numero + numero2;
            // print of operation
            Console.WriteLine("method, sum two number: " + numero);
            return numero;
        }

    }
}
