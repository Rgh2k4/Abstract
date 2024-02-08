using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AbInterface
{
    class Progr
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.Name = Console.ReadLine();
            dog.Colour = Console.ReadLine();
            dog.Height = Console.ReadLine();
            dog.Age = Console.ReadLine();

            List<string> animals = new List<string>();
            animals.Add("Cow");
            animals.Add("Mouse");
            animals.Add("Rat");
            animals.Add("Horse");

            Console.WriteLine(animals.ToArray());
        }
    }
}
