using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thisAndBase
{
    class Boys : Person
    {
        public string name { get; set; }
        public int age { get; set; }

        public Boys(string name="Mark", int age=34 )
        {

            this.name = name;
            this.age = age;
        }
        public void print()
        {
            Console.WriteLine("Printing the field of this class :");
            Console.WriteLine($"my name is {this.name} , age : {this.age}");
            Console.WriteLine("Printing the field of the base class");
            Console.WriteLine($"my name is {base.name} , age : {base.age}");

        }
    }
}
