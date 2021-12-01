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
            bool whileloop = i ==1;//condicional para que whileloop sea true

            while (!whileloop)//uso de while
            {
                Console.WriteLine(i);//imprime numero i
                i++;
                if (i == 6) //condicion 
                    break;
            }
            Console.WriteLine("\n loop  do while de secuancia de numeros del 0 al 5");

            int j = 0;
            do  // inicio de do while
            {
                Console.WriteLine(j);// imprecion de j
                j++;// incremento de j
                if (j == 6)// condicion para j terminar
                    break;
            }
            while (!whileloop); // hacer hasta que se cumpla la condicion

            Console.ReadLine();


            //if (pesoPaquete > 50)
            //{
            //    Console.WriteLine("\nerror : Paquete demasiado pesado para ser enviado a través de Package Express. \nQue tenga un buen día.");
            //}

            //Console.WriteLine("\nIngrese el ancho del paquete");
            //int anchoPaquete = Convert.ToInt32(Console.ReadLine());//variable donde se guarda el ancho del paquete

            //Console.WriteLine("\nIngrese la altura del paquete");
            //int alturaPaquete = Convert.ToInt32(Console.ReadLine());//variable donde se guarda el ancho del paquete

            //Console.WriteLine("\nIngrese el longitud del paquete");
            //int longitudPaquete = Convert.ToInt32(Console.ReadLine());//variable donde se guarda el ancho del paquete

            //if ((anchoPaquete + alturaPaquete + longitudPaquete) > 50) // se condiciona si la suma de las dimensiones es mayor a 50
            //{
            //    Console.WriteLine("\nerror : Paquete demasiado grande para enviarse a través de Package Express. \nQue tenga un buen día.");
            //}

            //int dimensiones = ((anchoPaquete * alturaPaquete * longitudPaquete) * pesoPaquete) / 100; //se realiza la operacion para obtener la cotizacion

            //Console.WriteLine("la cotizacion es: $" + dimensiones + " dolares. Gracias!"); // se imprime el resultado

            //Console.ReadLine();
        }
    }
}
