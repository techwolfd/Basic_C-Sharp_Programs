using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cotizacionenvio_paquete
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            Console.WriteLine("\"Programa para obtener \n una cotizacion de envio para un paquete\n");

            Console.WriteLine("\nBienvenido a Package Express. Por favor, siga las siguientes instrucciones.");

            Console.WriteLine("\nIngrese el peso del paquete");
            int pesoPaquete = Convert.ToInt32(Console.ReadLine());//variable donde se guarda el peso del paquete

            if(pesoPaquete > 50)
            {  Console.WriteLine("\nerror : Paquete demasiado pesado para ser enviado a través de Package Express. \nQue tenga un buen día.");
                Console.ReadLine();
            }
           
            
            else {             Console.WriteLine("\nIngrese el ancho del paquete");
            int anchoPaquete = Convert.ToInt32(Console.ReadLine());//variable donde se guarda el ancho del paquete

            Console.WriteLine("\nIngrese la altura del paquete");
            int alturaPaquete = Convert.ToInt32(Console.ReadLine());//variable donde se guarda el ancho del paquete

            Console.WriteLine("\nIngrese el longitud del paquete");
            int longitudPaquete = Convert.ToInt32(Console.ReadLine());//variable donde se guarda el ancho del paquete

                if ((anchoPaquete +  alturaPaquete + longitudPaquete) > 50) // se condiciona si la suma de las dimensiones es mayor a 50
                    {
                Console.WriteLine("\nerror : Paquete demasiado grande para enviarse a través de Package Express. \nQue tenga un buen día.");
                    Console.ReadLine();
                }
                else { 
                 int dimensiones = ((anchoPaquete * alturaPaquete * longitudPaquete) * pesoPaquete)/100; //se realiza la operacion para obtener la cotizacion

                 Console.WriteLine("la cotizacion es: $" + dimensiones + " dolares. Gracias!"); // se imprime el resultado

                Console.ReadLine();
                }
            }
        }

    }
}
