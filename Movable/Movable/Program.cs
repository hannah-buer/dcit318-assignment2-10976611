using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating an instances of Car and Bicycle
            Car car = new Car();
            Bicycle bicycle = new Bicycle();

            // Calling the Move() method on each instance
            car.Move();
            bicycle.Move();

            Console.ReadLine();
        }
    }
}
