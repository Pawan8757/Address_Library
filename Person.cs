using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookLamdaDemo
{
    public class Person
    {
        public string PhoneNo;
        public string Name;
        public string Address;

        public int Age;

        public Person(string phoneno, string name, string address, int age)
        {
            PhoneNo = phoneno;
            Name = name;
            Address = address;
            Age = age;
        }
    }
}