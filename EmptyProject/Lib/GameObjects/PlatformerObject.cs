using Microsoft.Xna.Framework.Content;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GameLibrary.PLayerInput;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace GameLibrary.GameObjects
{
    public class PlatformerObject : DrawableGameObject
    {

        public PlatformerObject(ContentManager content, string textureName, PlayerInput playerInput)
            : base(content, textureName, playerInput)
        {
            Texture = Content.Load<Texture2D>(textureName);
        }

        public override void Update(GameTime gameTime)
        {
            if (PlayerInput.Right)
            {
                this.Position += 4 * Vector2.UnitX;
            }
            if (PlayerInput.Left)
            {
                this.Position += -4 * Vector2.UnitX;
            }
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(this.Texture, this.Position, Color.White);
        }
    }
}
