using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLibrary.Contracts.Positions
{
    public class Vector3d
    {
        public float X { get; set; }
        public float Y { get; set; }
        public float Z { get; set; }
        public Vector3d() { }

        public Vector3d(float x, float y, float z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public static Vector3d operator+ (Vector3d vec1, Vector3d vec2 )
        {
            Vector3d vec3 = new Vector3d
            {
                X = vec2.X + vec1.X,
                Y = vec2.Y + vec1.Y,
                Z = vec2.Z + vec1.Z
            };
            return vec3;
        }
    }
}
