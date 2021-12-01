/**/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {


            //creacion de los arrays de string y entero
            string[] strArray1 = new string[] { "cero", "uno", "dos", "tres", "cuatro", "cinco" };
            int[] intArray1 = new int[] { 000, 100, 200, 300, 400, 500 };

            //array de string
            Console.WriteLine("ingresa un numero de indice del 0- 5 para mostra el numero en cadea");
            int selecIndice = Convert.ToInt32(Console.ReadLine());
            //seleccion de condicion para ingresar al intervalo ingreado correcto
            if (selecIndice >= 0 && selecIndice <= 5)
                Console.WriteLine("seleccionaste: " + strArray1[selecIndice] + "\n\n");

            else
                Console.WriteLine("ingresaste otro indice que no existe en esta matriz\n\n");


            //array de numeros enteros
            Console.WriteLine("ingresa un numero de indice del 0- 5 para mostrar lo que tiene la matriz en esa posicion");
            int selecIndiceInt = Convert.ToInt32(Console.ReadLine());
            //seleccion de condicion para ingresar al intervalo ingreado correcto 
            if (selecIndiceInt >= 0 && selecIndiceInt <= 5) { 
            Console.WriteLine("seleccionaste: " + intArray1[selecIndiceInt] + "\n\n"); 
        }

            else
                Console.WriteLine("ingresaste otro indice que no existe en esta matriz\n\n");

            // lista de cadenas
            //creacion y llenado de la lista
            List<int> intList = new List<int>();
            intList.Add(000); intList.Add(100); intList.Add(200); intList.Add(300); intList.Add(400);
            intList.Add(500);
            Console.WriteLine("ingresa un numero de indice del 0- 5 para mostrar lo que tiene la Lista en esa posicion");
            int selecIndicelist= Convert.ToInt32(Console.ReadLine());

            //seleccion de condicion para ingresar al intervalo ingreado correcto
            if (selecIndicelist >= 0 && selecIndicelist <= 5)
                Console.WriteLine("seleccionaste: "+ intList[selecIndicelist]);

            else
                Console.WriteLine("ingresaste otro indice que no existe en esta lista \n\n");

            //intList.Add(10);
            //Console.WriteLine(intList[1]);
            //intList.Remove(10);


            // int[] numArray1 = new int[] { 5, 2, 10, 200, 5000, 600, 2300 };

            // int[] numArray2 =  { 5, 2, 10, 200, 5000, 600, 2300 };

            // numArray2[5] = 650;



            // Console.WriteLine(numArray2[5]);
            // //arrays


            // List<int> intList = new List<int>();
            // intList.Add(4);
            // Console.WriteLine(intList[0]);
            // intList.Add(10);
            // Console.WriteLine(intList[1]);
            // intList.Remove(10);

            // Console.WriteLine(intList[0]);


            // //list


            // List<string> slist = new List<string>();;
            // slist.Add("Hello");
            // Console.WriteLine(intList[0]);
            // slist.Add("wolf");
            // Console.WriteLine(intList[1]);
            //slist.Remove("wolf");

            // Console.WriteLine(intList[0]);


            // byte[] byteArray = 


            Console.ReadLine();
        }
    }
}
