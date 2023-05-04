using Exercise.Davalebebi.Mesame;
using Exercise.Davalebebi.Meore_Davaleba;
using Exercise.Davalebebi.Pirveli_Davaleba;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {



            Calculate shapeCalculation = new Calculate(6);

            shapeCalculation.AreaCalculation();

            Shape shape = (Shape)shapeCalculation;
            shape.AreaCalculation();

            Console.WriteLine("--------------");

            Radio radio = new Radio();
            radio.ChangeStation();
            radio.VolumeUp();


            Console.WriteLine("--------------");
            Dog dog = new Dog();

            dog.SetName();

            Console.WriteLine("--------------");
            dog.GetName();
            dog.Eat();
        }
    }
}
