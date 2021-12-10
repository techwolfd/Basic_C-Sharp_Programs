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
            //Employee employee = new Employee();

            //cration of list of employees
            List<Employee> listaempleados = new List<Employee>();
            //fill list
                listaempleados.Add(new Employee());  listaempleados[0].ID = 01; listaempleados[0].FirstName = "juan"; listaempleados[0].LastName = "lopez";
                        listaempleados.Add(new Employee         { ID = 00, FirstName = "jose", LastName="martinez"  }) ;
                        listaempleados.Add(new Employee         { ID = 01, FirstName = "luis", LastName = "castro" });
                        listaempleados.Add(new Employee         { ID = 02, FirstName = "pether", LastName = "cruz" });
                        listaempleados.Add(new Employee         { ID = 03, FirstName = "jose", LastName = "moreno" });
                        listaempleados.Add(new Employee         { ID = 04, FirstName = "andrew", LastName = "valerio" });
                        listaempleados.Add(new Employee         { ID = 05, FirstName = "michael", LastName = "alonso" });
                        listaempleados.Add(new Employee { ID = 06, FirstName = "rin", LastName = "dicha" });
                        listaempleados.Add(new Employee { ID = 07, FirstName = "jose", LastName = "juarez" });
                        listaempleados.Add(new Employee { ID = 08, FirstName = "adriana", LastName = "robles" });
                        listaempleados.Add(new Employee { ID = 09, FirstName = "itze", LastName = "rodi" });
                        listaempleados.Add(new Employee { ID = 10, FirstName = "veronica", LastName = "arvizu" });


            //creation of list where they are stored employee with name jose
            List<Employee> listaEmpleado2 = new List<Employee>();
            foreach (Employee nameJoe in listaempleados)
            {
                if (nameJoe.FirstName == "jose")
                {
                    listaEmpleado2.Add(nameJoe);
                }
            }
            //print out whit for each
            foreach (Employee emp in listaEmpleado2)
            {
                Console.WriteLine("for each == jose: " + emp.ID + " " + emp.FirstName + " " + emp.LastName);
            }
            Console.WriteLine("\n");



            //expression lambda where they are stored employee with name jose
           List <Employee> listaEmpLambda = listaempleados.Where(lam => lam.FirstName == "jose").ToList();

            //print out whit lambda
            foreach (Employee emp in listaEmpLambda)
            {
                Console.WriteLine("exp lambda== jose: " + emp.ID + " " + emp.FirstName + " " + emp.LastName);
            }
            Console.WriteLine("\n");

            //expression lambda with employee greater than 5
            List<Employee> listaEmpLambdaMay5 = listaempleados.Where(lam => lam.ID >5).ToList();
            //print out whit lambda
            foreach (Employee emp in listaEmpLambdaMay5)
            {
                Console.WriteLine("exp lambda > 5: " + emp.ID + " " + emp.FirstName + " " + emp.LastName);
            }











            //// assign string to state

            //employee.FirstName = "Muestra";
            //employee.LastName = "Estudiante";
            ////method say name
            ////employee.SayName();

            ////creation of object 
            //IQuittable quittable = new Employee();

            //quittable.Equals(employee);
            ////object employye is same to quitatable object
            //quittable = employee;
            ////quittable.Quit();



            Console.Read();
        }
    }
}
