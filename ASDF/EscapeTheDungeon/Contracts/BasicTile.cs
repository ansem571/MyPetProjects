using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Map2DLibrary.Contracts;
using MathLibrary.Contracts.Positions;

namespace EscapeTheDungeon.Contracts
{
    public class BasicTile : ITileBase
    {
        private readonly Vector2d _tileLocation;
        private IEnumerable<ITileBase> _nearbyTiles;
        private bool _visited;

        public BasicTile(Vector2d tileLocation)
        {
            _tileLocation = tileLocation;
        }

        public bool GetVisited()
        {
            return _visited;
        }
        public void SetVisited(bool value)
        {
            _visited = value;
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
            throw new NotImplementedException();
        }
    }
}
