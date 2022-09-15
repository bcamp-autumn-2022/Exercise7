using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7
{
    internal class Student : Person, IPerson
    {
        public void SayName(string value)
        {
            Console.WriteLine(value);
        }
    }
}
