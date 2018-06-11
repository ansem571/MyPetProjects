using MathLibrary.Contracts.Positions;

namespace MathLibrary.Contracts.Matrices
{
    public class Transform
    {
        public Vector3d Position { get; set; }
        /// <summary>
        /// Rotation starts at 0,0,0. Values are in degrees up to 360
        /// </summary>
        public Vector3d Rotation { get; set; }
        /// <summary>
        /// Scale starts at a 1:1 scale
        /// </summary>
        public Vector3d Scale { get; set; } = new Vector3d(1, 1, 1);
    }
}
