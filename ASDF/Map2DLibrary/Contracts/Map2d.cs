using MathLibrary.Contracts.Positions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
