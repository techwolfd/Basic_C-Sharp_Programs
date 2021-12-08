using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjects
{
    //class abstract
    public abstract class Person
    {
         
        //property firstname
        public string FirstName { get; set; }
        //property lastname
        public string LastName { get; set; }

        //metodo sayname and writeline name full
        public virtual void SayName()
        {
            
        }
    }
}
