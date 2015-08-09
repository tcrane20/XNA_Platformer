using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GameLibrary.PLayerInput;

namespace GameLibrary.GameObjects
{
    public class SceneBase : GameObject
    {
        protected List<GameObject> Elements { get; set; }

        public SceneBase(ContentManager content, PlayerInput playerInput)
            : base(content,playerInput)
        {
            Elements = new List<GameObject>();
            AddElement(new DrawableGameObject(Content,"blank",PlayerInput));
        }

        public void AddElement(GameObject obj)
        {
           Elements.Add(obj);
           obj.Parent = this;
        }

        public override void Update(GameTime gameTime) 
        {
            foreach(GameObject obj in Elements)
            {
                obj.Update(gameTime);
            }
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            foreach (GameObject obj in Elements)
            {
                obj.Draw(spriteBatch);
            }
        }
    }
}
