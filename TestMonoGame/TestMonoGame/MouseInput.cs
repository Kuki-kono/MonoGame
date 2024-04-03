using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace TestMonoGame
{
    public static class MouseInput
    {
        public static bool MouseDown { get; private set; }
        public static bool MouseUp { get; private set; }
        public static Vector2 MousePos => Mouse.GetState().Position.ToVector2();
        private static MouseState previousState;

        public static void Update()
        {
            MouseDown = (Mouse.GetState().LeftButton == ButtonState.Pressed && 
                        previousState.LeftButton == ButtonState.Released);
            MouseUp = (Mouse.GetState().LeftButton == ButtonState.Released && 
                        previousState.LeftButton == ButtonState.Pressed);

            previousState = Mouse.GetState();
        }
    }
}
