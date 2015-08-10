using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameLibrary.Data.Map
{
    public class TilesetData
    {
        public int TilesetID { get; set; }

        public string FileName { get; set; }

        public TilesetData(int id)
        {
            TilesetID = id;
            FileName = GameData.Tilesets[id].FileName;
        }

        public TilesetData()
        {
        }
    }
}
