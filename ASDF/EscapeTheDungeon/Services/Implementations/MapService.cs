using EscapeTheDungeon.Contracts;
using EscapeTheDungeon.Contracts.TileTypes;
using Map2DLibrary.Contracts;
using System;
using System.Linq;

namespace EscapeTheDungeon.Services.Implementations
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

        public void DisplayFloorMap(int floor)
        {
            if (!_dungeonMap.TryGetValue(floor, out var mapFloor))
                return;

        }

        public void UpdateMap(ITileBase tile, int floor)
        {
            if (!_dungeonMap.TryGetValue(floor, out var mapFloor)) // floor does not exist in dungeon map
                return;
            if (!mapFloor.Map.TryGetValue(tile.GetTileLocation(), out var oldTile)) // tile does not exist in floor map
                return;
            if (oldTile.GetType() == tile.GetType())
            {
                switch (tile)
                {
                    case BasicTile b:
                        {
                            b.SetVisited(true);
                            var nearbyTiles = b.GetNearbyTiles().ToList();
                            foreach(DungeonBaseTile nearbyTile in nearbyTiles)
                            {
                                nearbyTile.SetVisible(true);
                            }
                            b.SetupNearbyTiles(nearbyTiles);
                            tile = b;
                        }
                        break;
                    case StairTile stair:
                        {
                            stair.SetVisited(true);
                            var nearbyTiles = stair.GetNearbyTiles().ToList();
                            foreach (DungeonBaseTile nearbyTile in nearbyTiles)
                            {
                                nearbyTile.SetVisible(true);
                            }
                            stair.SetupNearbyTiles(nearbyTiles);
                            tile = stair;
                        }
                        break;
                    case DungeonBaseTile d:
                    case ITileBase t:
                        {
                            throw new InvalidCastException($"Tile {nameof(tile)} was not set to an appropriate type. {tile.GetType()}");
                        }
                    default:
                        {
                            throw new ArgumentOutOfRangeException($"Tile {nameof(tile)} case was not defined for {tile.GetType()}");
                        }
                }
                oldTile = tile;
            }
        }
    }
}
