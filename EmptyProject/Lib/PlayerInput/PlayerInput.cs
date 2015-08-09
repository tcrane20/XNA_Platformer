using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System.IO;

namespace GameLibrary.PLayerInput
{
    public class PlayerInput 
    {
        public ControlScheme Controls { get; set; }

        public KeyboardState CurrentKeyboardState { get; set; }

        public KeyboardState OldKeyboardState { get; set; }

        public MouseState CurrentMouseState { get; set; }

        public MouseState OldMouseState { get; set; }

        #region Controls

        public bool Left
        {
            get { return CurrentKeyboardState.IsKeyDown(Controls.Left); }
        }

        public bool LeftPressed
        {
            get { return CurrentKeyboardState.IsKeyDown(Controls.Left) && !OldKeyboardState.IsKeyDown(Controls.Left); }
        }

        public bool LeftReleased
        {
            get { return !CurrentKeyboardState.IsKeyDown(Controls.Left) && OldKeyboardState.IsKeyDown(Controls.Left); }
        }

        public bool Right
        {
            get { return CurrentKeyboardState.IsKeyDown(Controls.Right); }
        }

        public bool RightPressed
        {
            get { return CurrentKeyboardState.IsKeyDown(Controls.Right) && !OldKeyboardState.IsKeyDown(Controls.Right); }
        }

        public bool RightReleased
        {
            get { return !CurrentKeyboardState.IsKeyDown(Controls.Right) && OldKeyboardState.IsKeyDown(Controls.Right); }
        }

        public bool Attack1
        {
            get { return CurrentKeyboardState.IsKeyDown(Controls.Attack1); }
        }

        public bool Attack1Pressed
        {
            get { return CurrentKeyboardState.IsKeyDown(Controls.Attack1) && !OldKeyboardState.IsKeyDown(Controls.Attack1); }
        }

        public bool Attack1Released
        {
            get { return !CurrentKeyboardState.IsKeyDown(Controls.Attack1) && OldKeyboardState.IsKeyDown(Controls.Attack1); }
        }

        public bool Attack2
        {
            get { return CurrentKeyboardState.IsKeyDown(Controls.Attack2); }
        }

        public bool Attack2Pressed
        {
            get { return CurrentKeyboardState.IsKeyDown(Controls.Attack2) && !OldKeyboardState.IsKeyDown(Controls.Attack2); }
        }

        public bool Attack2Released
        {
            get { return !CurrentKeyboardState.IsKeyDown(Controls.Attack2) && OldKeyboardState.IsKeyDown(Controls.Attack2); }
        }
        public bool Run
        {
            get { return CurrentKeyboardState.IsKeyDown(Controls.Run); }
        }

        public bool RunPressed
        {
            get { return CurrentKeyboardState.IsKeyDown(Controls.Run) && !OldKeyboardState.IsKeyDown(Controls.Run); }
        }

        public bool RunReleased
        {
            get { return !CurrentKeyboardState.IsKeyDown(Controls.Run) && OldKeyboardState.IsKeyDown(Controls.Run); }
        }

        public bool Confirm
        {
            get { return CurrentKeyboardState.IsKeyDown(Controls.Confirm); }
        }

        public bool ConfirmPressed
        {
            get { return CurrentKeyboardState.IsKeyDown(Controls.Confirm) && !OldKeyboardState.IsKeyDown(Controls.Confirm); }
        }

        public bool ConfirmReleased
        {
            get { return !CurrentKeyboardState.IsKeyDown(Controls.Confirm) && OldKeyboardState.IsKeyDown(Controls.Confirm); }
        }

        public bool Back
        {
            get { return CurrentKeyboardState.IsKeyDown(Controls.Back); }
        }

        public bool BackPressed
        {
            get { return CurrentKeyboardState.IsKeyDown(Controls.Back) && !OldKeyboardState.IsKeyDown(Controls.Back); }
        }

        public bool BackReleased
        {
            get { return !CurrentKeyboardState.IsKeyDown(Controls.Back) && OldKeyboardState.IsKeyDown(Controls.Back); }
        }

        public bool Debug
        {
            get { return CurrentKeyboardState.IsKeyDown(Controls.Debug); }
        }

        public bool DebugPressed
        {
            get { return CurrentKeyboardState.IsKeyDown(Controls.Debug) && !OldKeyboardState.IsKeyDown(Controls.Debug); }
        }

        public bool DebugReleased
        {
            get { return !CurrentKeyboardState.IsKeyDown(Controls.Debug) && OldKeyboardState.IsKeyDown(Controls.Debug); }
        }

        public bool MouseLeft
        {
            get { return CurrentMouseState.LeftButton == ButtonState.Pressed; }
        }

        public bool MouseLeftClicked
        {
            get { return CurrentMouseState.LeftButton == ButtonState.Pressed && OldMouseState.LeftButton == ButtonState.Released; }
        }

        public bool MouseLeftReleased
        {
            get { return CurrentMouseState.LeftButton == ButtonState.Released && OldMouseState.LeftButton == ButtonState.Pressed; }
        }

        #endregion

        public PlayerInput()
        {
            Controls = new ControlScheme();

            CurrentKeyboardState = Keyboard.GetState();
            OldKeyboardState = CurrentKeyboardState;

            CurrentMouseState = Mouse.GetState();
            OldMouseState = CurrentMouseState;

        }

        public void Update(GameTime gameTime)
        {
            OldKeyboardState = CurrentKeyboardState;
            CurrentKeyboardState = Keyboard.GetState();

            OldMouseState = CurrentMouseState;
            CurrentMouseState = Mouse.GetState();

        }
    }
}
