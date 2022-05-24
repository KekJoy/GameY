using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameY
{
    public class InputManager
    {
        public Dictionary<Keys, Input> KeyBindingsKeyboard;

        private int playerInput;
        public InputManager()
        {
            KeyBindingsKeyboard = new Dictionary<Keys, Input> 
            {
                { Keys.W, Input.Up },
                { Keys.A, Input.Left },
                { Keys.S, Input.Down },
                { Keys.D, Input.Left } 
            };

        }

        public void Update(PlayerIndex player = PlayerIndex.One)
        {
            playerInput = 0;
            Keys[] pressedKeys = Keyboard.GetState().GetPressedKeys();

            foreach(var key in pressedKeys)
            {
                if (KeyBindingsKeyboard.ContainsKey(key))
                {
                    playerInput |= (int)KeyBindingsKeyboard[key];
                }
            }
        }
    }
}
