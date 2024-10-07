using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Interface_SOLID
{
    // Liskov Substitution Principle (LSP)
    public abstract class Bird
    {
        public abstract void Fly();
    }

    public class Eagle : Bird
    {
        public override void Fly()
        {
            Console.WriteLine("Eagle is flying high");
        }
    }

    public class Sparrow : Bird
    {
        public override void Fly()
        {
            Console.WriteLine("Sparrow is flying low");
        }
    }

    public class BirdFlightSimulator
    {
        public void SimulateFlight(Bird bird)
        {
            bird.Fly();
        }
    }
}
