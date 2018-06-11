using MathLibrary.Contracts.Positions;

namespace MathLibrary.Contracts.Constants
{
    public static class TransformConstants
    {
        public static Vector3d TransformLeft = new Vector3d(-90f, 0f, 0f);
        public static Vector3d TransformRight = new Vector3d(90f, 0f, 0f);
        public static Vector3d TransformUp = new Vector3d(0f, 90f, 0f);
        public static Vector3d TransformDown = new Vector3d(0f, -90f, 0f);

        public static float MaxDegree = 360f;
    }
}
