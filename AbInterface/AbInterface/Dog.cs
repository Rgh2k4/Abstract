using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbInterface
{
    public class Dog : IAnimal
    {
        
        public string Name { get; set; }
        public string Colour { get; set; }
        public string Height { get; set; }
        public string Age { get; set; }

        public Dog()
        {
            Console.WriteLine("The dog's name is" + Name);
            Console.WriteLine("The dog is" + Colour);
            Console.WriteLine("The dog is " + Age + "years old");
            Console.WriteLine("The dogs height is " + Height);
        }

        
        public void Eat()
        {
            Console.WriteLine("Dogs eat meat");
        }

        public string Cry()
        {
            return "Woof!";
        }
    }
}
  