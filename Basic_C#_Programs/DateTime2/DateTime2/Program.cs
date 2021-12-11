/*
Este programa muestra el time and add int number
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
            //create objetct timenow sort datetime
            DateTime timenow = DateTime.Now;
            
              Console.WriteLine("the time is: " + timenow+"\n enter a number enteger");
            //read of number to plus
            int hour = Convert.ToInt32( Console.ReadLine());
            //print of hte number entered
            Console.WriteLine("the time : " + hour);
            //add hour to timenow
            timenow = DateTime.Now.AddHours(hour);
            //print
            Console.WriteLine("the time add the number entered: " + timenow);
            Console.Read();
        }
    }
}
