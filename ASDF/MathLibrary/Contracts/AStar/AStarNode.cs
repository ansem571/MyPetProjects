using MathLibrary.Contracts.Positions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLibrary.Contracts.AStar
{
    public class AStarNode
    {
        public string Name { get; set; }
        public Vector2d Location { get; set; }
        /// <summary>
        /// Cost from current pos to next
        /// </summary>
        public float G { get; set; }
        /// <summary>
        /// Cost from current to end
        /// </summary>
        public float H { get; set; }

        public float F => G + H;
        public AStarNode ParentNode { get; set; }
        public List<AStarNode> Neighbors = new List<AStarNode>();

        public AStarNode(string name, Vector2d pos = null)
        {
            Name = name;
            Location = pos ?? new Vector2d();
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
