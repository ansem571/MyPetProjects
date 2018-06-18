using MathLibrary.Contracts.Positions;
using System.Collections.Generic;

namespace Map2DLibrary.Contracts
{
    public interface ITileBase
    {       
        Vector2d GetTileLocation();
        IEnumerable<ITileBase> GetNearbyTiles();
        void SetupNearbyTiles(IEnumerable<ITileBase> nearbyTiles);
    }
}
