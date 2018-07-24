using Map2DLibrary.Contracts;
using MathLibrary.Contracts.Positions;

namespace EscapeTheDungeon.Contracts.TileTypes
{
    public class StairTile : DungeonBaseTile
    {
        private readonly int _nextFloorValue;
        private readonly ITileBase _nextFloorTile;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="tileLocation">x,y location</param>
        /// <param name="floor">Floor you go to when moved onto</param>
        /// <param name="nextFloorTile"></param>
        public StairTile(Vector2d tileLocation, int floor, ITileBase nextFloorTile) : base(tileLocation)
        {
            _nextFloorValue = floor;
            _nextFloorTile = nextFloorTile;
        }

        public int GetNextFloorValue()
        {
            return _nextFloorValue;
        }

        public ITileBase GetNextFloorTile()
        {
            return _nextFloorTile;
        }
    }
}
