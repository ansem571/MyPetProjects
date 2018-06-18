using MathLibrary.Contracts.Positions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLibrary.Contracts.Shapes
{
    public class Rectangle
    {
        public Vector2d Origin { get; set; }
        /// <summary>
        /// Width, Height
        /// </summary>
        public Vector2d Size { get; set; }
    }
}
