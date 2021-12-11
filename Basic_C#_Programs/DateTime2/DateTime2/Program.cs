/*
Este programa muestra el juego de 21
Autor: David Cortes
Fecha de creacion: 10 de diciembre de 2021
Feha de ultima modificacion: 10 de diciembre de 2021
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTime2
{
    class Program
    {
        static void Main(string[] args)
        {

            DateTime timenow = DateTime.Now;
            
              Console.WriteLine("the time is: " + timenow+"\n enter a number enteger");
            int hour = Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("the time : " + hour);
            timenow = DateTime.Now.AddHours(hour);
            Console.WriteLine("the time add the number entered: " + timenow);
            Console.Read();
        }
    }
}
