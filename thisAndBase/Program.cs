using System;
using System.Collections.Generic;
namespace thisAndBase
{
 
    class Program 
    { 
      
        private static List<IObject> AddedObjects()    // Creating a fun that returns a list whose type is Iobject
                                                       // to accept Creatures from Person & Animal classes together 
        {
            List <IObject> Ilist= new List<IObject>();
            Ilist.Add(new Person { name="Sara" , age= 12 , graduationYear=2030 } );
            Ilist.Add(new Animal { name = "Dog", age = 2 , sound="hwhwhwhw" });

            return Ilist;
        }
        static void Main(string[] args)
        {
           Person man = Person.AddedSimpleData();  // className.Method
              
            Console.WriteLine(man); // print the data that in man object
                                    // which took from AddedSimpeData method
                                    // !! there is ToString fun in each class to print the obj


            Console.WriteLine();
            Console.WriteLine();

            List<IObject> Creatures = AddedObjects();

            foreach (IObject item in Creatures)
            {
                //Console.WriteLine(item);
                if (item is Person p )  // p is the Animal object that in Creatures list  
                {
                    Console.WriteLine(p+$" and my Graduation Year is {p.graduationYear} ");
                }
                if (item is Animal a) // p is the Animal object that in Creatures list
                {
                    Console.WriteLine(a + $" and My sound is like {a.sound} ");
                }
            }


            Console.WriteLine();
            Console.WriteLine();



            // hint : The difference between "this" and "Base" 
            Boys boy = new Boys();
            boy.print();


        }

     
    }
}
