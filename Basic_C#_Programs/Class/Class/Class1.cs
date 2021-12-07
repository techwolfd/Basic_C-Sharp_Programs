using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    public class Class1
    {

        public Class1()
        {

        }
        //method numop void whitout return
        public void numop(int numero)
        {
            
            int number = numero;
            int number2 = 2;
            //operation
            number = number / number2;
            Console.WriteLine("number divide by 2: "+number);
           
        }
        //Method numop1  static
        public static int numop1(int numero)
        {

            int number = numero;
            int number2 = 2;
            //operation sum
            number = number +number2;
            Console.WriteLine("number plus 2: "+number);
            //return of number
            return number;

        }
        public decimal numop(out decimal numero, decimal number2)
        {
            decimal x = number2; 
             numero = 2;
            //operation
            numero = numero * number2;
            //return of number
            return numero;

        }

    }
}
