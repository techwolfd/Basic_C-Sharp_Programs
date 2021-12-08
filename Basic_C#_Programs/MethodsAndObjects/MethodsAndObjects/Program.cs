using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            //instance of employee
            Employee employee = new Employee();

            // assign string to state
            employee.FirstName = "Muestra";
            employee.LastName = "Estudiante";
            //method say name
            employee.SayName();

            Console.Read();
        }
    }
}
