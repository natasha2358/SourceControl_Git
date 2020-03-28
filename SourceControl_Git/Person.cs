using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceControl_Git
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void PrintPerson()
        {
            if(this.Age < 30)
            {
                Console.WriteLine("Hi, " + this.Name + " you are young.");
            }
            else
            {
                Console.WriteLine("Hi, " + this.Name+ " you old :(" );
            }
    
        }
    }

}
