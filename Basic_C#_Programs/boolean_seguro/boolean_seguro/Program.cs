using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boolean_seguro
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            Console.WriteLine("\"Programa de aprobacion basico \n para el seguro de auto\" \n");

            Console.WriteLine("Cual es tu edad?:");
            string sedad = Console.ReadLine();// se guarda edad
            int edad = Convert.ToInt32(sedad);

            Console.WriteLine("alguna vez ha tenido un DUI (responder verdadero/falso) :");
            string dui = Console.ReadLine();//se guarda false o true
            bool tenerDUI = Convert.ToBoolean(dui);
            //// typebool

            Console.WriteLine("Cuantas multas por exceso de velocidad tiene?:");
            string mul = Console.ReadLine();// se guarda el numero de pagina
            int multas = Convert.ToInt16(mul);

            ////bool mayorA15 = edad > 15;
            //Console.Write(edad > 15);
            ////bool ningunDUI = tenerDUI == false;
            //Console.Write(tenerDUI == false);
            ////bool noMayorA3 = multas > 3;
            //Console.Write(multas < 3);

            Console.WriteLine("Calificado?:");//
            bool calificado = (edad > 15 && tenerDUI == false && multas < 3);// se eluje en booleano si es verdadero que tiene mas de 15  no tiene DUI
                                                                             // //y si tiene menos de una multa

            Console.Write(calificado); // se imprime el resultado 
            Console.ReadLine();
        }
    }
}
