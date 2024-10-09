using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented_Programming
{
    internal class Ball
    {
        public int Size {  get; set; }
        public Color Color { get; set; }
        public int TimesOfThrown { get; set; }

        public Ball(int size, Color color)
        {
            Size = size;
            Color = color;
        }

        public Ball(int size, Color color, int timesOfThrown)
        {
            Size = size;
            Color = color;
            TimesOfThrown = timesOfThrown;
        }

        public void Pop()
        {
            Size = 0;
        }

        public void Throw()
        {
            if ( Size != 0) 
                TimesOfThrown++;
        }

        public int GetTheTimesOfThrow()
        {
            return TimesOfThrown;
        }
    }
}
