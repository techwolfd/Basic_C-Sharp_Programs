using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnums
{
    class Program
    {
        public enum Day
        {
            monday,
            tuesday,
            wednesday,
            thursday,
            friday,
            saturday,
            sunday
        }
        static void Main(string[] args)
        {

            try
            {

                Day day = Day.sunday;
            string Daycompare ;
             Console.WriteLine("enter the current day of the week.");
                Daycompare = Console.ReadLine();
                
                    Console.WriteLine(" enter you: "+ Daycompare);
                    Day dia = (Day)Enum.Parse(typeof(Day), Daycompare);
                if (day == Day.sunday)
                {
                    Console.WriteLine("Equals day.");
                }

                Console.Read();
            }

            catch (ArgumentException)
            {
                 
                Console.WriteLine("Please enter an actual day of the week.");

            }
            Console.Read();
        }
       
    }

}
