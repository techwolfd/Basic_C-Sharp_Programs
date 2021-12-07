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
        public int funnum(int numero)
        {
            int numsum = numero;
            //operation sum
            numero = numsum + numsum;
            // print of operation
            Console.WriteLine("sum of the same number: " + numero);
            return numero;
        }

        //function funsum whit decimal
        public int funnum(decimal numero)
        {
            decimal numsum = numero;
            //operation multiplication
            numero = numsum * numsum;
            // print of operation
            int x = Convert.ToInt32(numero);
            Console.WriteLine("multiplication of the same number: " + x);
            return x;
        }

        //function funsum whit string
        public int funnum(string numero)
        {
            //convert to int
            int numsum = Convert.ToInt32( numero);
            //operation sum
            numsum = numsum+ numsum;
            // print of operation
            int x = numsum;
            Console.WriteLine("sum of the same number: " + x);
            return x;
        }

        public  int funnummethod(int numero,string numero2 = "2" )
        {
            
            int n  = Convert.ToInt32(numero2);
            //operation sum
            numero = numero + n;
            // print of operation
            Console.WriteLine("method,  number add 2: " + numero);
            return numero;
        }

    }
}
