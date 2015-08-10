using Microsoft.Xna.Framework.Content;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GameLibrary.PlayerInput;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace GameLibrary.GameObjects
{
    public class DrawableGameObject : GameObject
    {
        public Texture2D Texture { get; set; }

        public Vector2 Position { get; set; }

        public DrawableGameObject(ContentManager content,GameObject parent, string textureName)
            :base(content,parent)
        {
            Texture = Content.Load<Texture2D>(textureName);
        }

        public override void Update(GameTime gameTime)
        {

        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(this.Texture, this.Position, Color.White);
        }
    }
}
