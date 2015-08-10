using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameLibrary.Data.Map
{
    [Serializable]
    public class TileData
    {
        public Vector2 TilesetPosition {get;set;}

        public TileData()
        {
        }
    }
}
