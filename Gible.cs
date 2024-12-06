using EasyMonoGame;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyStart
{
    public class Gible : Actor
    {
        private float speed = 500f;

        private int points = 0;

        public override void Update(GameTime gameTime)
        {
            Vector2 movement = Vector2.Zero; 

            KeyboardState keyboard = Keyboard.GetState();

            if (keyboard.IsKeyDown(Keys.Up)) movement.Y -= 1; 
            if (keyboard.IsKeyDown(Keys.Down)) movement.Y += 1;

            if (keyboard.IsKeyDown(Keys.Left))
            {
                movement.X -= 1;
                IsFlippedHorizontally = false; 
            }

            if (keyboard.IsKeyDown(Keys.Right))
            {
                movement.X += 1;
                IsFlippedHorizontally = true; 
            }

            if (movement != Vector2.Zero)
            {
                movement.Normalize();
                Position += movement * speed * (float)gameTime.ElapsedGameTime.TotalSeconds;
            }
            if (IsTouching(typeof(Pinapberry)))
            {
                RemoveTouching(typeof(Pinapberry));
                points += 1;
                World.ShowText("Points: " + points, 1750, 100);
            }
        }
    }
}
