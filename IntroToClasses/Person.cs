using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToClasses
{
    public class Person
    {
        // fileds
        private string name;
        private int _age;

        // constructor
        public Person()
        {
            name = "John";
            _age = 21;
        }

        public Person(string name, int age)
        {
            this.name = name;
            _age = age;
        }

        // properties

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public string Name
        {
            get { return name; }
        }

        // auto-implemented property
        public long Phone {get; set;}
    }
}
