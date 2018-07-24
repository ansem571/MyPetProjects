using MathLibrary.Contracts.Positions;

namespace EscapeTheDungeon.Contracts
{
    public class Player
    {
        /// <summary>
        /// x,y is tile location, z is floor
        /// </summary>
        public Vector3d CurrentLocation { get; set; }
        /// <summary>
        /// x,y is tile location, z is floor
        /// </summary>
        public Vector3d LastSaveLocation { get; set; }
        public DungeonMapDictionary DungeonMap { get; set; }
    }
}
