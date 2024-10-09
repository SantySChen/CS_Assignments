using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented_Programming
{
    internal class Color
    {
        public int Red {  get; set; }
        public int Green { get; set; }
        public int Blue { get; set; }

        public Color(int red = 255, int green = 255, int blue = 255)
        {
            Red = red;
            Green = green;
            Blue = blue;
        }

        public float GetGrayscale()
        {
            return (Red + Green + Blue) / 3f;
        }
    }
}
