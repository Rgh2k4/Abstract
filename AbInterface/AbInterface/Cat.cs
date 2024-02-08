using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbInterface
{
    public class Cat : IAnimal
    {
        public string Name { get; set; }
        public string Colour { get; set; }
        public string Height { get; set; }
        public string Age { get; set; }

        public Cat()
        {
            Console.WriteLine("The cats name is" + Name);
            Console.WriteLine("The cat is" + Colour);
            Console.WriteLine("The cat is " + Age + "years old");
            Console.WriteLine("The cats height is " + Height);
        }
        public void Eat()
        {
            Console.WriteLine("Cats eat mice");
        }

        public string Cry()
        {
            return "Meow!";
        }
    }
}
