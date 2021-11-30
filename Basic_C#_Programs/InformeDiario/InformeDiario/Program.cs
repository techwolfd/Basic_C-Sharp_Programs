using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformeDiario
{
    class Program
    {
        static void Main(string[] args)
       {
            ////saludo de introduccion
            //Console.WriteLine("The Tech Academy \n");
            //Console.WriteLine("Informe diario (DR) del estudiante \n");

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

            bool tof = 12 < 5;
            Console.Write(tof);

            Console.WriteLine(tof.ToString());
            Console.ReadLine();


        }
    }
}


//using System;

//namespace myConsoleProject.cs
//{
//    class Program
//    {
//        static void Main()
//        {
//            Console.WriteLine("Cual es tu nombre?");
//            string name = Console.ReadLine();

//            Console.WriteLine("Hola, " + name + "! y ejemplo de uso de dobles \" comillas \" ");

//            Console.WriteLine("bienvenido a acme accounting systems");
//            Console.WriteLine("recuerda, nosotros \"contamos\" con usted");

//            Console.WriteLine("cual es tu numero favorito?");
//            string favoriteNumber = Console.ReadLine();
//            int favNum = Convert.ToInt32(favoriteNumber);
//            int total = favNum + 10;
//            Console.WriteLine("tu numero favorito mas 10 es :" + total);

//            bool isStuding = false;
//            Console.WriteLine(isStuding);
//            byte hoursworked = 42;
//            Console.WriteLine(hoursworked);
//            sbyte currentTemperature = -13;
//            Console.WriteLine(currentTemperature);
//            char questionMar = '\u2103';
//            Console.WriteLine(questionMar);

//            decimal moneyInBank = 100.5m;
//            Console.WriteLine(moneyInBank);
//            double heightCentimeters = 211.30202092;
//            Console.WriteLine(heightCentimeters);

//            float secondsleft = 2.62f;
//            Console.WriteLine(secondsleft);
//            short temperatureOnMar = -341;
//            Console.WriteLine(temperatureOnMar);
//            string myname = "wolf";
//            Console.WriteLine(myname);

//            int currentAge = 30;
//            string yearsOld = currentAge.ToString();
//            Console.WriteLine(currentAge);

//            bool isRaining = true;
//            Console.WriteLine(isRaining);
//            string rainingStatus = Convert.ToString(isRaining);

//            Console.WriteLine(rainingStatus);

//            Console.ReadLine();
//        }
//    }
//}
