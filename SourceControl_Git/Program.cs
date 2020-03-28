using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceControl_Git
{
    class Program
    {
        static void Main(string[] args)
        {

            Person p = new Person("Natasha", 21);
            Person a = new Person("Sara", 19);
            p.PrintPerson();
            a.PrintPerson();
        }
    }
}
