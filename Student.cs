using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7
{
    internal class Student : Person, IPerson
    {
        public Student() { }
        public Student(string fn, string ln)
        {
            this.Fname = fn;
            this.Lname = ln;
        }

        public void SayName(string value)
        {
            Console.WriteLine(value);
        }
    }
}
