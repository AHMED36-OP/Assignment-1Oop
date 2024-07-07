using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assignment_1Oop
{
    public struct PersonQ7
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public PersonQ7(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
