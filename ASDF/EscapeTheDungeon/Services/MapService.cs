using EscapeTheDungeon.Contracts;
using Map2DLibrary.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscapeTheDungeon.Services
{
    public class MapService
    {
        private DungeonMapDictionary _dungeonMap;
        private int _floor;
        
        public MapService(DungeonMapDictionary dungeonMap, int floor = 1)
        {
            _dungeonMap = dungeonMap ?? throw new ArgumentNullException(nameof(dungeonMap));
            _floor = floor;
        }

        public void UpdateMap(ITileBase tile, int floor)
        {
            var mapFloor = _dungeonMap[floor];
            var oldTile = mapFloor.Map[tile.GetTileLocation()];
            if (oldTile.GetType() == tile.GetType())
            {
                var basicTile = typeof(BasicTile).ToString();
                switch (tile)
                {
                    case BasicTile b:
                        {
                            b.SetVisited(true);
                        }
                        break;
                    default:
                        break;
                }
                oldTile = tile;
            }
        }
    }
}
