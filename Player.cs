using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace GameY
{
    class Player : Game
    {
        public int Health { get; set; }
        public int Damage { get; set; }
        public double MagicalResistance { get; set; }
        public double PhysicalResistance { get; set; }
        public bool AttackType { get; set; }

        public Vector2 Position;
        public Texture2D Texture;
        
        public Player(Texture2D texture, Vector2 position)
        {
            Position = position;
            Texture = texture;
        }
        public void Draw(SpriteBatch _spriteBatch)
        {
            _spriteBatch.Draw(Texture, Position, Color.White);
        }
    }
}
