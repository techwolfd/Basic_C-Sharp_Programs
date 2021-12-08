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
    }
    
}
