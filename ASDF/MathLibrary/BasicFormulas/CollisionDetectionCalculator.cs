using MathLibrary.Contracts.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLibrary.BasicFormulas
{
    public class CollisionDetectionCalculator
    {
        public bool CollisionDetected(Rectangle rect1, Rectangle rect2)
        {
            if (rect1.Origin.X < rect2.Origin.X + rect2.Size.X &&
                rect1.Origin.X + rect1.Size.X > rect2.Origin.X &&
                rect1.Origin.Y < rect2.Origin.Y + rect2.Size.Y &&
                rect1.Origin.Y + rect1.Size.Y > rect2.Origin.Y)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
