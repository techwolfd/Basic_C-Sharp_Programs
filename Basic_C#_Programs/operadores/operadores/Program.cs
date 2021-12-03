using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operadores
{
    class Program
    {
        static void Main(string[] args)
        {
            double a1 = 10;
            float b1 = 20;
            int c1 = 2;
            int resultado = (int)(7.5 * Math.Sqrt(a1) - b1 / c1);
            Console.WriteLine(resultado);
            Console.ReadKey();
            //primero, la operación de raíz cuadrada de 'a' (nótese que acabamos de hacer otro uso
            //de una nueva clase del framework del espacio de nombres 'System');

            ////segundo, el resultado obtenido (de tipo 'double') se multiplica por el número 7,5; 
            ///
            ///tercero, se realiza la división entre 'b' y 'c' convirtiendo previamente el tipo de 'c' al 
            ///tipo de 'b' y obteniendo un resultado de tipo 'float'; 
            ///
            ///cuarto, se hace la resta de los dos resultado anteriores conviertiendo previamente 
            ///el resultado de tipo 'float' a tipo 'double'; 
            ///
            ///quinto y último, se hace una conversión del resultado final tipo 'double' a tipo 'int', 
            ///despreciando los decimales y mostrando al final solamente su parte entera.
            ///
            int a = 4, b = 6, c = 2, d = 10, e = 1;
            double resultado1 = 0;

            resultado1 = a + c - e * d;
            //resultado = a + c - 10;
            //resultado = 6 - 10;
            //resultado = -4;
            Console.WriteLine(resultado1);

            resultado1 = (a + c - e) * d;
            //resultado = (6 - e) * d;
            //resultado = 5 * d;
            //resultado = 50;
            Console.WriteLine(resultado1);

            resultado1 = a * c / b + d * e - c % a;
            //resultado = 8 / b + d * e - c % a;
            //resultado = 8 / b + 10 - c % a;
            //resultado = 8 / b + 10 - 2;
            //resultado = 1 + 10 - 2;
            //resultado = 11 - 2;
            //resultado = 9;
            Console.WriteLine(resultado1);
            Console.ReadLine();
        }
    }
}
