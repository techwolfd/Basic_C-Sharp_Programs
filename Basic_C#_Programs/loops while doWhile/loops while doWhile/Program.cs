using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loops_while_doWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\"Programa que muestra loops while and do While \n ");

            //Console.WriteLine("\n");


            Console.WriteLine("\n loop while de secuancia de numeros del 0 al 5" );
            
            int i = 0;
            while (i < 6)//uso de while
            {
                Console.WriteLine(i);//imprime numero i
                i++;
               
            }
            Console.WriteLine("\n loop  do while de secuancia de numeros del 0 al 5");

            int j = 0;
            do  // inicio de do while
            {
                Console.WriteLine(j);// imprecion de j
                j++;// incremento de j
               
            }
            while (j < 6); // hacer hasta que se cumpla la condicion

            Console.ReadLine();


            //Console.ReadLine();
        }
    }
}
