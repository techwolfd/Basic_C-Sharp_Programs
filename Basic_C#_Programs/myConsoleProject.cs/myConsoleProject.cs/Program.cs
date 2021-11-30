using System;

namespace myConsoleProject.cs
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Cual es tu nombre?");
            string name = Console.ReadLine();

            Console.WriteLine("Hola, " + name + "! usando \" comillas \" ");

            Console.WriteLine("bienvenido a acme accounting systems");
            Console.WriteLine("recuerda, nosotros \"contamos\" con usted");
            Console.Read();
        }
    }
}
