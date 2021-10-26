using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thisAndBase
{
   public class Person : IObject
    {

        public string name { get; set; }
        public int age { get; set; }

        public Person(string name= "Abdo",int age=16)
        {
            this.age = age;
            this.name = name;

        }
        public int graduationYear { get; set; }

        public static Person AddedSimpleData()
        {
            return new Person
            {
                name = "Aya",
                age = 10
            };
        }
      
        public override string ToString()
        {
            return $"my name is {this.name} , age : {this.age}";
        }

    }


}
