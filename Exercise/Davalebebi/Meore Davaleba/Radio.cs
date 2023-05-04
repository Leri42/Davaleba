using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise.Davalebebi.Meore_Davaleba
{
    public class Radio : IVolume, IChangeStation
    {
        [Range(0, 40)]

        public byte Volume { get; set; } = 0;

        [Range(88.0f, 106.0f)]
        public float Station { get; set; } = 88.0f;



        public void ChangeStation()
        {
            Console.WriteLine($"you have change Radio station - {Station+=0.1f}");
        }

        public void VolumeDown()
        {
            Console.WriteLine($"you have Decreased Radio Volume - {Volume -= 1}");
        }

        public void VolumeUp()
        {
            Console.WriteLine($"you have increased Radio Volume - {Volume += 1}");
        }
    }
}
