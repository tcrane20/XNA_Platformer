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
    public class PlatformerPlayer : PlatformerObject
    {

        public PlatformerPlayer(ContentManager content, string textureName)
            : base(content, textureName)
        {
            
        }

        public override void Update(GameTime gameTime)
        {
            if (Input.Right)
            {
                this.Position += 4 * Vector2.UnitX;
            }
            if (Input.Left)
            {
                this.Position += -4 * Vector2.UnitX;
            }
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            base.Draw(spriteBatch);
        }
    }
}
