using MathLibrary.Contracts.Positions;
using System.Collections.Generic;

namespace Map2DLibrary.Contracts
{
    public class Map2d
    {
        /// <summary>
        /// The tile at the specified location. ITileBase is mostly implemented in other project.
        /// </summary>
        public Dictionary<Vector2d, ITileBase> Map { get; set; }
        /// <summary>
        /// Width x Height
        /// </summary>
        public Vector2d Dimensions { get; set; }
    }
}
