using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    public class Cat : Animal
    {
        public string Name = Console.ReadLine();
        public string Colour = Console.ReadLine();
        public string Age = Console.ReadLine();
        public override void Eat()
        {
            Console.WriteLine("Cats eat mice");
        }
    }
}
