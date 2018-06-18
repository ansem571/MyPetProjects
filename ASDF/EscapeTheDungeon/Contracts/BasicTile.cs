using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Map2DLibrary.Contracts;
using MathLibrary.Contracts.Positions;

namespace EscapeTheDungeon.Contracts
{
    public class BasicTile : DungeonBaseTile
    {
        public BasicTile(Vector2d tileLocation) : base(tileLocation) { }
    }
}
