using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixPart
{
    class Program
    {
        static void Main(string[] args)
        {
            //creacion de los arrays de string y entero
            Console.WriteLine("\n\n PARTE 1------------------- ");

            string[] strArray = new string[5];
            strArray[0] = "uno";
            strArray[1] = "dos";
            strArray[2] = "tres";
            strArray[3] = "cuatro";
            strArray[4] = "cinco";
            //array de string
            Console.WriteLine("ingrese texto que se mostrara al final cada string");
            string texto = Console.ReadLine();

            for (int i = 0; i < strArray.Length; i++)
            {
                strArray[i] += texto;

            }

            //Console.WriteLine(strArray.Length+"leng" + "\n");
            for (int j = 0; j < strArray.Length; j++)
            {

                Console.WriteLine("index " + j + ": " + strArray[j]);

            }

            // part 2 and 3---
            Console.WriteLine("\n\n PRTE  2 DE LOOP INF---------------------- ");

            Console.WriteLine("\n elija si quiere ver un loop infinity (true/false)");
            bool loopw = Convert.ToBoolean(Console.ReadLine());
            int l1 = 0;

            while (loopw == true)//uso de while
            {
                Console.WriteLine(l1);//imprime numero i
                l1++;

            }
            Console.WriteLine("\n loop  do while de secuancia de numeros del 0 al 5 con <=");
            // parte 3 
            Console.WriteLine("\n\n PRTE  3 DE LOOP INF---------------------- ");

            Console.WriteLine("\n loop  con <");
            int l = 0;
            while (l < 6)//uso de while
            {
                Console.WriteLine(l);//imprime numero i
                l++;

            }
            Console.WriteLine("\n loop  do while de secuancia de numeros del 0 al 5 con <=");

            int m = 0;
            do  // inicio de do while
            {
                Console.WriteLine(m);// imprecion de j
                m++;// incremento de j

            }
            while (m <= 6); // hacer hasta que se cumpla la condicion


            //part cuatro-------------------------------

            //creacion de los arrays de string y entero

            List<string> listcad = new List<string>() { "cero", "uno", "dos", "tres", "cuatro", "cinco" };
            //array de string
            Console.WriteLine("\n\n PARTE 4-------------------------");
            Console.WriteLine("ingrese texto para buscar en la lista (numeros del cero al cinco 0-5)");
            string textod = Console.ReadLine();
            int jp = 0;


            for (int n = 0; n < listcad.Count; n++)
            {
                // Console.WriteLine("valor i" + i +": "+ strArray[i]);

                if (textod == listcad[n])
                {
                    jp = 1;
                    Console.WriteLine("el index que contiene  el texto coincidente es el: " + n);

                }
            }
            if (jp == 0)
            {
                Console.WriteLine("lo que ingresaste no esta en la lista");
            }

            // parte 5
            Console.WriteLine("\n\n PARTE 5-------------------------");

            List<string> listcadd = new List<string>() { "cero", "dos", "dos", "tres", "cuatro", "cinco" };
            Console.WriteLine("ingrese texto para buscar en la lista: cero , uno ... cinco");
            string textot = Console.ReadLine();

            jp = 0;

            for (int o = 0; o < listcadd.Count; o++)
            {

                // Console.WriteLine("valor i" + i +": "+ strArray[i]);
                if (listcadd[o] == textot)
                {
                    jp = 1;
                    Console.WriteLine("index del elemento coincidente: " + o);

                }
            }

            if (jp == 0)
            {
                Console.WriteLine("lo que ingresaste no esta en la lista");


            }

            // parte 6
            Console.WriteLine("\n\n PARTE 6-------------------------");
            List<string> listcadl = new List<string>() { "cero", "one", "one", "two", "three", "one", "two", "five", "six", "cero" };
            List<string> listcad6par = new List<string> { "", "", "", "", "", "", "", "", "", "" };
            //int ind ,i = 0;
                           
            foreach (string arrays in listcadl)
            {

                if (listcad6par.Contains(arrays))
                {
                    Console.WriteLine(arrays + " \thave already appeared: ");
                }

                else if (!listcad6par.Contains(arrays))
                {
                    listcad6par.Add(arrays);
                    Console.WriteLine(arrays + "\tNo have already appeared: ");
                }

            }






            Console.Read();

        }
    }
}
