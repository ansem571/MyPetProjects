namespace MathLibrary.Contracts.Positions
{
    public class Vector2d
    {
        public float X { get; set; }
        public float Y { get; set; }

        public Vector2d() { }

        public Vector2d(float x, float y)
        {
            X = x;
            Y = y;
        }

        public static Vector2d operator +(Vector2d vec1, Vector2d vec2)
        {
            Vector2d retVal = new Vector2d
            {
                X = vec2.X + vec1.X,
                Y = vec2.Y + vec1.Y
            };
            return retVal;
        }
        public static Vector2d operator -(Vector2d vec1, Vector2d vec2)
        {
            Vector2d retVal = new Vector2d
            {
                X = vec2.X - vec1.X,
                Y = vec2.Y - vec1.Y
            };
            return retVal;
        }
    }
}
