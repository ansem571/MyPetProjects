using Map2DLibrary.Contracts;
using MathLibrary.Contracts.Positions;
using System.Collections.Generic;

namespace EscapeTheDungeon.Contracts.TileTypes
{
    public class DungeonBaseTile : ITileBase
    {
        private readonly Vector2d _tileLocation;
        private IEnumerable<ITileBase> _nearbyTiles;
        private bool _visited;
        private bool _isVisible;

        public DungeonBaseTile(Vector2d tileLocation)
        {
            _tileLocation = tileLocation;
            _nearbyTiles = new List<ITileBase>();
        }

        public bool GetVisited()
        {
            return _visited;
        }

        public void SetVisited(bool value)
        {
            _visited = value;
        }

        public bool GetVisible()
        {
            return _isVisible;
        }

        public void SetVisible(bool value)
        {
            _isVisible = value;
        }

        public Vector2d GetTileLocation()
        {
            return _tileLocation;
        }

        public IEnumerable<ITileBase> GetNearbyTiles()
        {
            return _nearbyTiles;
        }

        public void SetupNearbyTiles(IEnumerable<ITileBase> nearbyTiles)
        {
            _nearbyTiles = nearbyTiles;
        }
    }
}
