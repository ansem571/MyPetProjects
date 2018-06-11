using MathLibrary.Contracts.Positions;
using System;

namespace MathLibrary.BasicFormulas
{
    public class DistanceCalculator
    {
        /// <summary>
        /// Return unit distance from vec2 to vec1
        /// </summary>
        /// <param name="vec1"></param>
        /// <param name="vec2"></param>
        /// <returns></returns>
        public float Distance(Vector2d vec1, Vector2d vec2)
        {
            return (float)Math.Sqrt(Math.Pow(vec2.Y - vec1.Y, 2) + Math.Pow(vec2.X - vec1.X, 2));
        }

        /// <summary>
        /// Return unit distance from vec2 to vec1
        /// </summary>
        /// <param name="vec1"></param>
        /// <param name="vec2"></param>
        /// <returns></returns>
        public float Distance(Vector3d vec1, Vector3d vec2)
        {
            return (float)Math.Sqrt(Math.Pow(vec2.Z - vec1.Z, 2) + Math.Pow(vec2.Y - vec1.Y, 2) + Math.Pow(vec2.X - vec1.X, 2));
        }
    }
}
