using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceControl_Git
{
    public class Second
    {
        public int FirstMethodFromSecondClass(int x, int y)
        {
            return x + y + 25;
        }
        public void SecondMethodFromSecondClass(int x, int y, int z)
        {
            int r = x - y - z;
            Console.WriteLine(r);
        }
        public int FirstMethodFromThirdClass(int x, int y)
        {
            return x / y;
        }
    }
}
