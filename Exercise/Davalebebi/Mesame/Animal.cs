using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise.Davalebebi.Mesame
{
    public abstract class Animal
    {
        public string name;

        public void SetName()
        {
            Console.WriteLine("Please Enter name for the animal");
            string value = Console.ReadLine();
            name = value;
        }

        public void GetName()
        {
            Console.WriteLine($"{name} is the animal's name");
        }
        public abstract void Eat();
    }
}
