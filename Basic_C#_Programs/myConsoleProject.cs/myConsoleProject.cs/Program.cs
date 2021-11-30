using System;

namespace myConsoleProject.cs
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Cual es tu nombre?");
            string name = Console.ReadLine();

            Console.WriteLine("Hola, " + name + "! y ejemplo de uso de dobles \" comillas \" ");

            Console.WriteLine("bienvenido a acme accounting systems");
            Console.WriteLine("recuerda, nosotros \"contamos\" con usted");
            
            Console.WriteLine("cual es tu numero favorito?");
            string favoriteNumber = Console.ReadLine();
            int favNum = Convert.ToInt32(favoriteNumber);
            int total = favNum + 10;
            Console.WriteLine("tu numero favorito mas 10 es :" + total);

            bool isStuding = false;
            Console.WriteLine(isStuding);
            byte hoursworked = 42;
            Console.WriteLine(hoursworked);
            sbyte currentTemperature = -13;
            Console.WriteLine(currentTemperature);
            char questionMar = '\u2103';
            Console.WriteLine(questionMar);

            decimal moneyInBank = 100.5m;
            Console.WriteLine(moneyInBank);
            double heightCentimeters = 211.30202092;
            Console.WriteLine(heightCentimeters);

            float secondsleft = 2.62f;
            Console.WriteLine(secondsleft);
            short temperatureOnMar = -341;
            Console.WriteLine(temperatureOnMar);
            string myname = "wolf";
            Console.WriteLine(myname);

            int currentAge = 30;
            string yearsOld = currentAge.ToString();
            Console.WriteLine(currentAge);

            bool isRaining = true;
            Console.WriteLine(isRaining);
            string rainingStatus = Convert.ToString(isRaining);

            Console.WriteLine(rainingStatus);

            Console.ReadLine();
        }
    }
}
