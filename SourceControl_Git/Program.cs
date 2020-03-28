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
            Person b = new Person("Daniela", 49);
            Second c = new Second();
            int data = c.FirstMethodFromSecondClass(3, 7);
            Console.WriteLine(data);
            c.SecondMethodFromSecondClass(5, 1, 2);
            b.PrintPerson();
            p.MethodForThirdBranch();
            a.PrintPerson();
           int x=  c.FirstMethodFromThirdClass(6,3);
            Console.WriteLine(x);

            Console.ReadKey();
        }
    }
}
