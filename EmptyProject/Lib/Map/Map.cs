using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GameLibrary.Data.Map;
using GameLibrary.GameObjects;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace GameLibrary.Map
{
    public class Map : GameObject
    {
        private MapData Data { get; set; }

        private Tileset Tileset { get; set; }

        private TileData[,] Tiles
        {
            get { return Data.Tiles; }
            set { Data.Tiles = value; }
        }

        public TileData this [int x, int y]
        {
            get { return Data.Tiles[x, y]; }
            set { Data.Tiles[x, y] = value; }
        }

        public int ID 
        {
            get { return Data.ID; }
        }

        public Map(ContentManager content,GameObject parent,int id)
            :base(content,parent)
        {
            Data = new MapData(id);
            Tileset = new Tileset(content,this, id);
        }

        public override void Update(GameTime gameTime)
        {
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
        }
    }
}
