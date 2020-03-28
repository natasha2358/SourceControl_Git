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
             Console.WriteLine("Hello from "+ this.Name + "I am "+ this.Age + "years old!");
        }
    }

}
