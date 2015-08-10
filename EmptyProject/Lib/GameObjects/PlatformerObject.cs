using Microsoft.Xna.Framework.Content;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace GameLibrary.GameObjects
{
    public class PlatformerObject : DrawableGameObject
    {
        public float xSpeed;            // Horizontal movement speed
        public float ySpeed;            // Vertical movement speed
        public float gravity;           // Continual downwards force being applied to the object
        public float friction;          // Deceleration when the object is no longer accelerating in the horizontal direction
        public float jumpHeight;        // How high the object can jump
        public float secondsToJumpApex; // How many seconds it takes to reach the maximum jump height



        public PlatformerObject(ContentManager content,GameObject parent, string textureName)
            : base(content,parent, textureName)
        {
            
        }

        public override void Update(GameTime gameTime)
        {

        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            base.Draw(spriteBatch);
        }
    }
}
