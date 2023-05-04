using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise.Davalebebi.Pirveli_Davaleba
{
    public class Shape
    {
        public int Width { get; set; }

        public Shape(int width)
        {
            Width = width;
        }
        public Shape()
        {

        }

        public virtual void AreaCalculation()
        {
            Console.WriteLine($"Area for this shape is - {Width*Width}");
        }
    }
}
