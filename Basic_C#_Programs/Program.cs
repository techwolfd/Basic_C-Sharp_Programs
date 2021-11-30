using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aprovacion_basico_boolean
{
    class Program
    {
        static void Main(string[] args)
        {
            //saludo de introduccion
            Console.WriteLine("\"Programa de aprobacion basico \n para el seguro de auto\" \n");

            Console.WriteLine("Cual es tu edad?:");
            string sedad = Console.ReadLine();// se guarda edad
            int edad = Convert.ToInt32(sedad);

            Console.WriteLine("alguna vez ha tenido un DUI (responder verdadero/falso) :");
            string dui = Console.ReadLine();//se guarda false o true
            bool tenerDUI = Convert.ToBoolean(dui);
            //// typebool

            Console.WriteLine("Cuantas multas por exceso de velocidad tiene?:");
            string mul= Console.ReadLine();// se guarda el numero de pagina
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

            //Console.WriteLine("\nPersona 2 \n");
            //Console.WriteLine("ingrese tarifa por hora:");
            //string tafhora2 = Console.ReadLine();// se guarda el numero de pagina
            //int tarifaHora2 = Convert.ToInt32(tafhora2);
            //Console.WriteLine("ingrese horas trabajadas por semana:");
            //string htr2 = Console.ReadLine();// se guarda el numero de pagina
            //int horaTrabajada2 = Convert.ToInt32(htr2);

            //int salarioanual1 = tarifaHora1 * horaTrabajada1 * 52;
            //Console.WriteLine("El salario anual de persona 1 es :" + salarioanual1);

            //int salarioanual2 = tarifaHora2 * horaTrabajada2 * 52;
            //Console.WriteLine("El salario anual de persona 2 es :" + salarioanual2);

            //Console.WriteLine("¿La Persona 1 gana más dinero que la Persona 2 ?\n");

            //bool boolsalario = salarioanual1 > salarioanual2;
            //Console.Write(boolsalario);


            //Console.ReadLine();


            //Console.WriteLine("a. Como te llamas:");//peticion y almacenado del nombre en un tipo string
            //string nombre = Console.ReadLine();

            //Console.WriteLine("b. En que curso estas:");
            //string nombreCurso = Console.ReadLine();

            //Console.WriteLine("c. que numero de pagina :");
            //string numeroPagina = Console.ReadLine();// se guarda el numero de pagina
            //int numPagina = Convert.ToInt32(numeroPagina);

            //Console.WriteLine("d. necesita ayuda (responder verdadero/falso) :");
            //string wantayuda = Console.ReadLine();//tipo tipo booleano 
            //bool ayuda = Convert.ToBoolean(wantayuda);
            //// typebool

            //Console.WriteLine("e. hubo alnua experiencia positiva que le gustaria compartir?");
            //string experiencia = Console.ReadLine();

            //Console.WriteLine("f. hay otro comentario:");
            //string comentario = Console.ReadLine();

            //Console.WriteLine("g. cuantas horas estudiaste hoy");
            //string horasEstudio = Console.ReadLine();//se guarda las horas estudiadad
            //int horaEst = Convert.ToInt32(horasEstudio);
            //// typebyte

            //Console.WriteLine("Gracias por sus respuestas. \" \n \"Un instructor responderá a esto en breve. \"\n Qué tengas un lindo día!\"\n \" Este es el final del programa.");

            ////suma de dos numeros
            //int s1 = 3;
            //int s2 = 3;
            //int sums = s1 + s2;
            //Console.WriteLine(sums);
            //Console.ReadLine();
        }
    }
}
