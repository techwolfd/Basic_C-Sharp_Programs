﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjects
{
    //class abstract
    public class Person
    {
        //list tipe employee
        //public List<Employee> employee { get; set; }
        //property firstname
        public string FirstName { get; set; }
        //property lastname
        public string LastName { get; set; }
        //propiedad telefono
        public long telefono { get; set; }
        //

        //constructor
        public Person (string FirstName, string LastName, int telefono)
        {
            FirstName = "name1";
            LastName = "lastn1";
            telefono = 123456789;
        }
        // constructor
        public Person(string FirstName)
             : this(FirstName, "", 00)
        {

        }

        public Person() : this("", "", 0)
        {

        }

        //metodo sayname and writeline name full
        public virtual void SayName()
        {
            Console.WriteLine($"last name is:[  {LastName}]");
        }

        //public static Employee operator ==(Employee employee1, Employee employee2)
        //{


        //    if (employee1.Identi == employee2.Identi) {

        //        employee1.similar = "es igual al otro empleado";
        //    }
        //    return employee1;
            
        //}
        //public static Employee operator !=(Employee employee1, Employee employee2)
        //{


        //    if (employee1.ID != employee2.ID)
        //    {

        //        employee1.similar = "es igual al otro empleado";
        //    }
        //    return employee1;
        //}
         

        

    }
}
