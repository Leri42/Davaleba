using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise.Davalebebi.Pirveli_Davaleba
{
    public class Calculate :Area
    {
      public Calculate(int width):base(width)
        {

        }

        public  void AreaCalculation()
        {
            base.AreaCalculation();
            Console.WriteLine($"Perimeter for this shape is {Width*4}");
        }
    }
}
