using Map2DLibrary.Contracts;
using System.Collections.Generic;

namespace EscapeTheDungeon.Contracts
{
    /// <summary>
    /// Each map is representative of a floor. Each floor is the same size. For now.
    /// </summary>
    public class DungeonMapDictionary : Dictionary<int, Map2d>
    {
        public new void Add(int floor, Map2d map)
        {
            base.Add(floor, map);
        }
        public new Map2d this[int floor]
        {
            get { return base[floor]; }
            set { base[floor] = value; }
        }
    }
}
