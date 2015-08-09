using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System.IO;
using System.Xml.Serialization;
namespace GameLibrary
{
    [Serializable]
    public class ControlScheme
    {
        #region Controls
        public Keys Left { get; set; }

        public Keys Right { get; set; }

        public Keys Jump { get; set; }

        public Keys Attack1 { get; set; }

        public Keys Attack2 { get; set; }

        public Keys Attack3 { get; set; }

        public Keys Run { get; set; }

        public Keys Back { get; set; }

        public Keys Confirm { get; set; }

        public Keys Debug { get; set; }

        #endregion
        
        public ControlScheme()
        {
            DefaultConfiguration();
        }

        public void DefaultConfiguration()
        {
            //Movement
            Left = Keys.Left;
            Right = Keys.Right;
            Jump = Keys.Space;

            //Player Commands
            Attack1 = Keys.Z;
            Attack2 = Keys.X;
            Attack3 = Keys.C;
            Run = Keys.LeftShift;

            //Interaction
            Confirm = Keys.Enter;
            Back = Keys.Escape;
            Debug = Keys.F1;

        }
    }
}
