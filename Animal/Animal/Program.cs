using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating instances
            Animal genericAnimal = new Animal();
            Dog dog = new Dog();
            Cat cat = new Cat();

            // Calling MakeSound method on each instance
            genericAnimal.MakeSound(); 
            dog.MakeSound();           
            cat.MakeSound();

            Console.ReadLine(); 
        }
    }
}
