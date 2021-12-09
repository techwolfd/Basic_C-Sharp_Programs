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
            //employee.SayName();

            Person per = new  Employee();
            per.FirstName = "name";
            per.LastName = "last";
            per.SayName();
            //per.Quit();

            //creation of object 
            IQuittable quittable = new Employee();

            quittable.Equals(employee);
            //object employye is same to quitatable object
            quittable = employee;
            //quittable.Quit();

            //instance of 2 employees
            Employee employee1 = new Employee();
            Employee employee2 = new Employee();

            //ids= number
            employee1.ID = 01;
            employee2.ID = 01;

            //employee1.employee = new List<Employee>();

            //comparacion de los dos objetos sobre carga
            employee1 = employee1 == employee2;

            //print of object employee.similar
            Console.WriteLine("esto "+employee1.similar);

            Console.Read();
        }
    }
}
