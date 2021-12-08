/*
Este programa muestra operadores
Autor: David Cortes
Fecha de creacion: 6 de diciembre de 2021
Feha de ultima modificacion: 6 de diciembre de 2021
 */
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
            //double a1 = 10;
            //float b1 = 20;
            //int c1 = 2;
            //int resultado = (int)(7.5 * Math.Sqrt(a1) - b1 / c1);
            //Console.WriteLine(resultado);
            //Console.ReadKey();
            ////primero, la operación de raíz cuadrada de 'a' (nótese que acabamos de hacer otro uso
            ////de una nueva clase del framework del espacio de nombres 'System');

            //////segundo, el resultado obtenido (de tipo 'double') se multiplica por el número 7,5; 
            /////
            /////tercero, se realiza la división entre 'b' y 'c' convirtiendo previamente el tipo de 'c' al 
            /////tipo de 'b' y obteniendo un resultado de tipo 'float'; 
            /////
            /////cuarto, se hace la resta de los dos resultado anteriores conviertiendo previamente 
            /////el resultado de tipo 'float' a tipo 'double'; 
            /////
            /////quinto y último, se hace una conversión del resultado final tipo 'double' a tipo 'int', 
            /////despreciando los decimales y mostrando al final solamente su parte entera.
            /////
            //int a = 4, b = 6, c = 2, d = 10, e = 1;
            //double resultado1 = 0;

            //resultado1 = a + c - e * d;
            ////resultado = a + c - 10;
            ////resultado = 6 - 10;
            ////resultado = -4;
            //Console.WriteLine("\n"+resultado1);

            //resultado1 = (a + c - e) * d;
            ////resultado = (6 - e) * d;
            ////resultado = 5 * d;
            ////resultado = 50;
            //Console.WriteLine("\n" + resultado1);

            //resultado1 = a * c / b + d * e - c % a;
            ////resultado = 8 / b + d * e - c % a;
            ////resultado = 8 / b + 10 - c % a;
            ////resultado = 8 / b + 10 - 2;
            ////resultado = 1 + 10 - 2;
            ////resultado = 11 - 2;
            ////resultado = 9;
            //Console.WriteLine("\n" + resultado1);


            //casting force to convert--------------------------
            object obj_s = "12345";
            string str_i = (string)obj_s; // "12345" as string, explicit
            Console.WriteLine("  casting \t" + str_i);


            int small = 12345;
            long big = 0;
            big = small; // 12345 as long, implicit
            Console.WriteLine(" casting \t" + big);
            
            int five = 5;
            var doubleFive = (double)five;
            Console.WriteLine(" casting \t" + doubleFive);

            char aa = 'a';
            var valueA = (int)aa;
            Console.WriteLine("casting \t" + valueA);// en ascci a es el 97

            float myFloat = 4.56F;
            decimal myMoney = (decimal)myFloat;
            Console.WriteLine(" casting \t" + myMoney);

            decimal myMoney1 = 5.87M;
            int intMoney = (int)myMoney1; //Value is now 5; the .87 was lost
            Console.WriteLine(" casting \t" + intMoney);

            //parsing--------------------------
            string int_s = "12345";
            int i = int.Parse(int_s); // 12345 as int
            Console.WriteLine("\n parsing \t" + i);

            string decString = "5.632";
            decimal decValue = decimal.Parse(decString); //Value is 5.632M
            Console.WriteLine(" parsing \t" + decValue);

            string testString = "10.22.2000";
            //double decValue = double.Parse(testString); //Exception thrown here!






            //Convert--------------------------
            double dub = 123.45;
            int ii = Convert.ToInt32(dub); // 123 as int
            Console.WriteLine(" \n convert \t" + ii);


            string fivea = "5.0";
            decimal decFive = Convert.ToDecimal(fivea); //Value is 5.0
            Console.WriteLine("  convert \t" + decFive);

            double myValue = 5.33;
            string stringValue = Convert.ToString(myValue); //Value is "5.33"
            Console.WriteLine("  convert \t" + stringValue);

            int intTrue = 1;
            bool isTrue = Convert.ToBoolean(intTrue); //Value is true because number is not 0
            Console.WriteLine("  convert \t" + isTrue);

            Console.ReadLine();
        }
    }
}
