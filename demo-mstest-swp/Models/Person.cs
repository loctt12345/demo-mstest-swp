using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace demo_mstest_swp.Models
{
    class Person : IPerson
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }

        public Person(string name, int age, string address)
        {
            Name = name;
            Age = age;
            Address = address;
        }

        public void Show()
        {
            Console.WriteLine($"Name: {Name} - Age: {Age} - Address: {Address}");
        }
    }
}
