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
                }

            Console.WriteLine("\nIngrese el ancho del paquete");
            int anchoPaquete = Convert.ToInt32(Console.ReadLine());//variable donde se guarda el ancho del paquete

            Console.WriteLine("\nIngrese la altura del paquete");
            int alturaPaquete = Convert.ToInt32(Console.ReadLine());//variable donde se guarda el ancho del paquete

            Console.WriteLine("\nIngrese el longitud del paquete");
            int longitudPaquete = Convert.ToInt32(Console.ReadLine());//variable donde se guarda el ancho del paquete

            if ((anchoPaquete +  alturaPaquete + longitudPaquete) > 50) // se condiciona si la suma de las dimensiones es mayor a 50
            {
                Console.WriteLine("\nerror : Paquete demasiado grande para enviarse a través de Package Express. \nQue tenga un buen día.");
            }

            int dimensiones = ((anchoPaquete * alturaPaquete * longitudPaquete) * pesoPaquete)/100; //se realiza la operacion para obtener la cotizacion

            Console.WriteLine("la cotizacion es: $" + dimensiones + " dolares. Gracias!"); // se imprime el resultado

            Console.ReadLine();
            //string dui = Console.ReadLine();//se guarda false o true
            //bool tenerDUI = Convert.ToBoolean(dui);
            ////// typebool

            //Console.WriteLine("Cuantas multas por exceso de velocidad tiene?:");
            //string mul = Console.ReadLine();// se guarda el numero de pagina
            //int multas = Convert.ToInt16(mul);

            ////bool mayorA15 = edad > 15;
            //Console.Write(edad > 15);
            ////bool ningunDUI = tenerDUI == false;
            //Console.Write(tenerDUI == false);
            ////bool noMayorA3 = multas > 3;
            //Console.Write(multas < 3);

            //Console.WriteLine("Calificado?:");//
            //bool calificado = (edad > 15 && tenerDUI == false && multas < 3);// se eluje en booleano si es verdadero que tiene mas de 15  no tiene DUI
            //                                                                 // //y si tiene menos de una multa

            //Console.Write(calificado); // se imprime el resultado 
            //Console.ReadLine();
        }
    }
}
