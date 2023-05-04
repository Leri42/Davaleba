using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise.Davalebebi.Mesame
{
    public class Dog : Animal
    {
        public override void Eat()
        {
            Console.WriteLine($"Dog {name} is Eating");
        }
    }
}
