using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System.IO;

namespace GameLibrary.PlayerInput
{
    public static class Input 
    {
        private static ControlScheme Controls = new ControlScheme();//{ get; set; }

        private static KeyboardState CurrentKeyboardState = Keyboard.GetState();// { get; set; }

        private static KeyboardState OldKeyboardState = CurrentKeyboardState;//{ get; set; }

        private static MouseState CurrentMouseState = Mouse.GetState();//{ get; set; }

        private static MouseState OldMouseState = CurrentMouseState;// { get; set; }

        #region Controls

        public static bool Left
        {
            get { return CurrentKeyboardState.IsKeyDown(Controls.Left); }
        }

        public static bool LeftPressed
        {
            get { return CurrentKeyboardState.IsKeyDown(Controls.Left) && !OldKeyboardState.IsKeyDown(Controls.Left); }
        }

        public static bool LeftReleased
        {
            get { return !CurrentKeyboardState.IsKeyDown(Controls.Left) && OldKeyboardState.IsKeyDown(Controls.Left); }
        }

        public static bool Right
        {
            get { return CurrentKeyboardState.IsKeyDown(Controls.Right); }
        }

        public static bool RightPressed
        {
            get { return CurrentKeyboardState.IsKeyDown(Controls.Right) && !OldKeyboardState.IsKeyDown(Controls.Right); }
        }

        public static bool RightReleased
        {
            get { return !CurrentKeyboardState.IsKeyDown(Controls.Right) && OldKeyboardState.IsKeyDown(Controls.Right); }
        }

        public static bool Attack1
        {
            get { return CurrentKeyboardState.IsKeyDown(Controls.Attack1); }
        }

        public static bool Attack1Pressed
        {
            get { return CurrentKeyboardState.IsKeyDown(Controls.Attack1) && !OldKeyboardState.IsKeyDown(Controls.Attack1); }
        }

        public static bool Attack1Released
        {
            get { return !CurrentKeyboardState.IsKeyDown(Controls.Attack1) && OldKeyboardState.IsKeyDown(Controls.Attack1); }
        }

        public static bool Attack2
        {
            get { return CurrentKeyboardState.IsKeyDown(Controls.Attack2); }
        }

        public static bool Attack2Pressed
        {
            get { return CurrentKeyboardState.IsKeyDown(Controls.Attack2) && !OldKeyboardState.IsKeyDown(Controls.Attack2); }
        }

        public static bool Attack2Released
        {
            get { return !CurrentKeyboardState.IsKeyDown(Controls.Attack2) && OldKeyboardState.IsKeyDown(Controls.Attack2); }
        }
        public static bool Run
        {
            get { return CurrentKeyboardState.IsKeyDown(Controls.Run); }
        }

        public static bool RunPressed
        {
            get { return CurrentKeyboardState.IsKeyDown(Controls.Run) && !OldKeyboardState.IsKeyDown(Controls.Run); }
        }

        public static bool RunReleased
        {
            get { return !CurrentKeyboardState.IsKeyDown(Controls.Run) && OldKeyboardState.IsKeyDown(Controls.Run); }
        }

        public static bool Confirm
        {
            get { return CurrentKeyboardState.IsKeyDown(Controls.Confirm); }
        }

        public static bool ConfirmPressed
        {
            get { return CurrentKeyboardState.IsKeyDown(Controls.Confirm) && !OldKeyboardState.IsKeyDown(Controls.Confirm); }
        }

        public static bool ConfirmReleased
        {
            get { return !CurrentKeyboardState.IsKeyDown(Controls.Confirm) && OldKeyboardState.IsKeyDown(Controls.Confirm); }
        }

        public static bool Back
        {
            get { return CurrentKeyboardState.IsKeyDown(Controls.Back); }
        }

        public static bool BackPressed
        {
            get { return CurrentKeyboardState.IsKeyDown(Controls.Back) && !OldKeyboardState.IsKeyDown(Controls.Back); }
        }

        public static bool BackReleased
        {
            get { return !CurrentKeyboardState.IsKeyDown(Controls.Back) && OldKeyboardState.IsKeyDown(Controls.Back); }
        }

        public static bool Debug
        {
            get { return CurrentKeyboardState.IsKeyDown(Controls.Debug); }
        }

        public static bool DebugPressed
        {
            get { return CurrentKeyboardState.IsKeyDown(Controls.Debug) && !OldKeyboardState.IsKeyDown(Controls.Debug); }
        }

        public static bool DebugReleased
        {
            get { return !CurrentKeyboardState.IsKeyDown(Controls.Debug) && OldKeyboardState.IsKeyDown(Controls.Debug); }
        }

        public static bool MouseLeft
        {
            get { return CurrentMouseState.LeftButton == ButtonState.Pressed; }
        }

        public static bool MouseLeftClicked
        {
            get { return CurrentMouseState.LeftButton == ButtonState.Pressed && OldMouseState.LeftButton == ButtonState.Released; }
        }

        public static bool MouseLeftReleased
        {
            get { return CurrentMouseState.LeftButton == ButtonState.Released && OldMouseState.LeftButton == ButtonState.Pressed; }
        }

        #endregion

        /*public Input()
        {
            //Controls = new ControlScheme();

            CurrentKeyboardState = Keyboard.GetState();
            OldKeyboardState = CurrentKeyboardState;

            CurrentMouseState = Mouse.GetState();
            OldMouseState = CurrentMouseState;

        }*/


        public static void Update(GameTime gameTime)
        {
            OldKeyboardState = CurrentKeyboardState;
            CurrentKeyboardState = Keyboard.GetState();

            OldMouseState = CurrentMouseState;
            CurrentMouseState = Mouse.GetState();

        }
    }
}
