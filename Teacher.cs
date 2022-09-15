using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7
{
    internal class Teacher : IPerson
    {
        public void SayName(string value)
        {
            Console.WriteLine("I am a Teacher and my name is "+value);
        }
    }
}
