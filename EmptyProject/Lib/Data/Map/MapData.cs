using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameLibrary.Data.Map
{
    [Serializable]
    public class MapData
    {
        public int ID { get; set; }

        public TileData[,] Tiles { get; set; }

        public string TilesetID { get; set; }

        public void LoadMap(int id)
        {
            //Hardcoded for now
            Tiles = new TileData[50, 20];
        }

        public MapData(int id = 0)
        {
            ID = id;
            LoadMap(id);
        }

        //Empty constructor for serialization
        public MapData()
        {
        }
    }
}
