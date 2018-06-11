using MathLibrary.Contracts.Positions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLibrary.Contracts.Matrices
{
    public class Transform
    {
        public Vector3d Position { get; set; }
        //In degrees
        public Vector3d Rotation { get; set; }
        public Vector3d Scale { get; set; }
    }
}
