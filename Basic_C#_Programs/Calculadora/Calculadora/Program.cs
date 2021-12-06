/*
Este programa muestra un programa donde se crean 3 funciones
Autor: David Cortes
Fecha de creacion: 6 de diciembre de 2021
Feha de ultima modificacion: 6 de diciembre de 2021
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingresa un numero entero");

            
            int x = Convert.ToInt32( Console.ReadLine());
            
            //called function funsum
            int nsum = funsum (x);
            Console.WriteLine("sum of the same number: " + nsum);

            //called function funsum
            int nmul = funmul(x);
            Console.WriteLine("multiplication of the same number: " + nmul);

            //called function funsum3
            int nsum3 = funsum3(x);
            Console.WriteLine("number plus 3: " + nsum3);


            Console.ReadLine();
        }




        //function sum of the same number
        public static int funsum (int numero)
        {
            int numsum = numero;
            numero = numsum + numsum;
            return numero;
        }
        //function multiplication of the same number
        public static int funmul(int numero)
        {
            int numsum = numero;
            numsum = numsum * numsum;
            return numsum;
        }

        //function number plus 3
        public static int funsum3(int numero)
        {
            int numsum = numero;
            numsum += 3 ;
            return numsum;
        }

    }
}
