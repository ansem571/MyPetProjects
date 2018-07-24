using Map2DLibrary.Contracts;
using System.Collections.Generic;

namespace EscapeTheDungeon.Services.Interfaces
{
    public interface ITileGeneratorService
    {
        IEnumerable<ITileBase> GenerateTiles();
        IEnumerable<ITileBase> GenerateTilesFromFile(string fileName);
    }
}
