using GameLibrary.Data.Map;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameLibrary.GameObjects
{
    public class Tileset : GameObject
    {
        public Texture2D Texture { get; set; }

        public TilesetData Data { get; set; }
        
        public Tileset(ContentManager content,GameObject parent,int id)
            :base(content,parent)
        {
            Data = new TilesetData(id);
            Texture = content.Load<Texture2D>(Data.FileName);
        }
    }
}
