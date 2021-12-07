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
            Employee employee = new Employee();

            employee.FirstName = "Muestra";
            employee.LastName = "Estudiante";
            employee.SayName();

            Console.Read();
        }
    }
}
