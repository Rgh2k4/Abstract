using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    public abstract class Animal
    {
        public string Name
        {
            get { return Name; }
            set { Name = value; }
        }
        public string Colour
        {
            get { return Colour;}
            set { Colour = value; }
        }
        public string Age
        {
            get { return Age; }
            set { Age = value; }
        }

        public Animal() { }

        public abstract void Eat();
    }
}
