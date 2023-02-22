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
        public string DateOfBirth { get; set; }
        public string Address { get; set; }

        public Person(string name, string dateOfBirth, string address)
        {
            Name = name;
            DateOfBirth = dateOfBirth;
            Address = address;
        }

        public void Show()
        {
            Console.WriteLine($"Name: {Name} - DateOfBirth: {DateOfBirth} - Address: {Address}");
        }
    }
}
