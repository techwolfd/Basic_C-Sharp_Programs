/*
Este programa muestra una app console of string and integer 
Autor: David Cortes
Fecha de creacion: 2 de diciembre de 2021
Feha de ultima modificacion: 2 de diciembre de 2021
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleApp_intString
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            
            try
            {
                List<int> listint = new List<int>() { 1, 2, 3, 10, 20, 30, 45, 55, 65, 88, 99, 44 };
                Console.WriteLine("a number to divide each number in the list");
                int divisor = Convert.ToInt32(Console.ReadLine());
                int i = 0;
                Console.WriteLine(i);
                while (i < listint.Count())//uso de while
                {
                    Console.WriteLine(listint[i] / divisor);//imprime numero i

                    i++;
                }
                Console.ReadLine();
            }
            catch (FormatException ex)
            {
                Console.WriteLine("please onli number integer");
                return;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("please not divide with zero");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                
                Console.WriteLine("program has exited the try/catch block successfully");

                    
                Console.ReadLine();
            }

           

        }
    }
}
