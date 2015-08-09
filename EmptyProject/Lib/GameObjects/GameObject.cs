using GameLibrary.PLayerInput;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameLibrary.GameObjects
{
    /// <summary>
    /// Base class for GameObjects
    /// </summary>
    public class GameObject
    {
        public GameObject Parent { get; set; }

        protected ContentManager Content { get; set; }

        public PlayerInput PlayerInput { get; set; }

        public GameObject(ContentManager content,PlayerInput playerInput)
        {
            Content = content;
            PlayerInput = playerInput;
        }

        public virtual void Draw(SpriteBatch spriteBatch)
        {
        }

        public virtual void Update(GameTime gameTime)
        {
        }

        public virtual void Dispose()
        {
        }
    }
}
