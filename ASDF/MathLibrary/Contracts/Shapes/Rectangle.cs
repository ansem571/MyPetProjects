using MathLibrary.Contracts.Positions;

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
