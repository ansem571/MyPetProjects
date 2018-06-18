using Map2DLibrary.Contracts;
using MathLibrary.Contracts.Positions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscapeTheDungeon.Contracts
{
    public class StairTile : DungeonBaseTile
    {
        public StairTile(Vector2d tileLocation) : base(tileLocation) { }
    }
}
