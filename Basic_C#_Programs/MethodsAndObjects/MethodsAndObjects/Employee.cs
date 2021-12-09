using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjects
{
    // inherit of class person and interface IQuittable
    public class Employee : Person , IQuittable
    {
        public int ID { get; set; }
        public string similar { get; set; }
        //override void sayname
        public override void SayName()
        {
            Console.WriteLine($"Name is:[ {FirstName } {LastName}]");

            base.SayName();
        }

        //method quit of interface IQuittable print name only
        public void Quit()
        {

            Console.WriteLine($"Name only:[ {FirstName }]");
          
        }

        public static Employee operator ==(Employee employee1, Employee employee2)
        {


            if (employee1.ID ==employee2.ID)
            {

                employee1.similar = " es igual al otro empleado";
            }
            return employee1;

        }
        public static Employee operator !=(Employee employee1, Employee employee2)
        {


            if (employee1.ID != employee2.ID)
            {

                employee1.similar = "no es igual al otro empleado";
            }
            return employee1;
        }

    }
    
}
