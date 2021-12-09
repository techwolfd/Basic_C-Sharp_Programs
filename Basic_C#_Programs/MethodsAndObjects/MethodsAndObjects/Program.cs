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
            ////instance of employee
            //Employee employee = new Employee();

            //// assign string to state
            //employee.FirstName = "Muestra";
            //employee.LastName = "Estudiante";
            ////method say name
            //employee.SayName();

            ////creation of object 
            //IQuittable quittable = new Employee();
            //quittable.Equals(employee);
            ////object employye is same to quitatable object
            //quittable = employee;
            //quittable.Quit();

            //instance of employee
            Employee employee1 = new Employee();
            Employee employee2 = new Employee();

            employee1.ID = 01;
            employee2.ID = 02;

            //employee1.employee = new List<Employee>();

            
            employee1 = employee1 == employee2;

            Console.WriteLine("esto "+employee1.similar);

            Console.Read();
        }
    }
}
