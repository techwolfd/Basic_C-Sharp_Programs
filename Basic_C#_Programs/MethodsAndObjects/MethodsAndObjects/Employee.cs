using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjects
{
    // inherit of class person
    public class Employee : Person
    {
        public int ID { get; set; }

        //override void sayname
        public override void SayName()
        {
            Console.WriteLine($"Name is:[ {FirstName } {LastName}]");

            base.SayName();
        }
    }
    
}
