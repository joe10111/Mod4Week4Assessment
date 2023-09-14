using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Mod4Week4Assessment
{
    abstract public class Person
    {
        public string Name { get; private set; }
        public DateTime Birthday { get; private set; }

        public Person(string name, DateTime birthday)
        {
            Name = name;
            Birthday = birthday;
        }

        abstract public string GetGreeting();

        public string GetBirthday()
        {
            return $"{Name}'s birthday is on {Birthday:MMMM d, yyyy}";
        }
    }
}
