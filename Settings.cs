using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameY
{
    class Settings
    {
        public bool IsFullScreen;
        public int Width;
        public int Height;

        public Settings(bool isFullScreen, int width, int height)
        {
            IsFullScreen = isFullScreen;
            Width = width;
            Height = height;
        }
        internal void Initialize(GraphicsDeviceManager _graphics)
        {
            _graphics.IsFullScreen = IsFullScreen;
            _graphics.PreferredBackBufferWidth = Width;
            _graphics.PreferredBackBufferHeight = Height;
            _graphics.ApplyChanges();
        }
    }
}
