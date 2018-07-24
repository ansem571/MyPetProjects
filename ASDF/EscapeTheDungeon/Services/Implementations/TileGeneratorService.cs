using EscapeTheDungeon.Contracts;
using EscapeTheDungeon.Services.Interfaces;
using Map2DLibrary.Contracts;
using System;
using System.Collections.Generic;

namespace EscapeTheDungeon.Services.Implementations
{
    public class TileGeneratorService : ITileGeneratorService
    {
        public IEnumerable<ITileBase> GenerateTiles()
        {
            var tiles = new List<ITileBase>();
            tiles.AddRange(GenerateBasicTiles());
            tiles.AddRange(GenerateStairTiles());
            tiles.AddRange(GenerateSaveTiles());

            return tiles;
        }

        public IEnumerable<ITileBase> GenerateTilesFromFile(string fileName)
        {
            throw new NotImplementedException();
        }

        private IEnumerable<BasicTile> GenerateBasicTiles()
        {
            throw new NotImplementedException();
        }

        private IEnumerable<StairTile> GenerateStairTiles()
        {
            throw new NotImplementedException();
        }

        private IEnumerable<BasicTile> GenerateSaveTiles()
        {
            throw new NotImplementedException();
        }
    }
}
