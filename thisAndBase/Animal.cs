using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thisAndBase
{
    class Animal : IObject
    {

        public string name { get; set; }
        public int age { get; set; }

        public string sound;

        public override string ToString()
        {
            return $"my name is {this.name} , age : {this.age}";
        }

    }
}
