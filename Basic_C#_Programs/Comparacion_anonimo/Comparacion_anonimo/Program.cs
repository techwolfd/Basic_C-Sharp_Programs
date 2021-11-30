using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comparacion_anonimo
{
    class Program
    {
        static void Main(string[] args)
        {

            //saludo de introduccion
            Console.WriteLine("\"Programa de comparación de ingresos anónimos\" \n");
            
            
            Console.WriteLine("Persona 1 \n");
            Console.WriteLine("ingrese tarifa por hora:");
            string tafhora1 = Console.ReadLine();// se guarda el numero de pagina
            int tarifaHora1 = Convert.ToInt32(tafhora1);
            Console.WriteLine("ingrese horas trabajadas por semana:");
            string htr1 = Console.ReadLine();// se guarda el numero de pagina
            int horaTrabajada1= Convert.ToInt32(htr1);

            
            Console.WriteLine("\nPersona 2 \n");
            Console.WriteLine("ingrese tarifa por hora:");
            string tafhora2 = Console.ReadLine();// se guarda el numero de pagina
            int tarifaHora2 = Convert.ToInt32(tafhora2);
            Console.WriteLine("ingrese horas trabajadas por semana:");
            string htr2 = Console.ReadLine();// se guarda el numero de pagina
            int horaTrabajada2 = Convert.ToInt32(htr2);

            int salarioanual1 = tarifaHora1 * horaTrabajada1 * 52;
            Console.WriteLine("El salario anual de persona 1 es :" + salarioanual1);

            int salarioanual2 = tarifaHora2 * horaTrabajada2 * 52;
            Console.WriteLine("El salario anual de persona 2 es :" + salarioanual2);

            Console.WriteLine("¿La Persona 1 gana más dinero que la Persona 2 ?\n");

            bool boolsalario= salarioanual1 > salarioanual2;
            Console.Write(boolsalario);


            Console.ReadLine();


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
