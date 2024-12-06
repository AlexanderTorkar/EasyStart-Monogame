using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyMonoGame;
using Microsoft.Xna.Framework;

namespace EasyStart
{
    internal class Boss1 : Actor
    {
        private Random random = new Random();
        private float time = 0;
        private float xSpeed = 250;
        private float ySpeed = 250;
        public override void Update(GameTime gameTime)
        {
            X += xSpeed * (float)gameTime.ElapsedGameTime.TotalSeconds;
            Y += ySpeed * (float)gameTime.ElapsedGameTime.TotalSeconds;
            time += (float)gameTime.ElapsedGameTime.TotalSeconds;
            if (time > 1)
            {
                // timer byt riktning
                float deltaRight = 1920 - X;
                float deltaLeft = 1920 - deltaRight;
                int tal = random.Next(-(int)deltaLeft, (int)deltaRight);
                if (tal <0)
                {
                    // walk left
                    xSpeed = -250;
                    IsFlippedHorizontally = false;
                }
                else
                {
                    xSpeed = 250;   
                    IsFlippedHorizontally = true;

                }
                float xPos = X;
                tal = random.Next(-1, 2);
                ySpeed = 300 * tal;
                time = 0;
                float deltaUp = 1080 - Y;
                float deltaDown = 1080 - deltaUp;
                int yTal = random.Next(-(int)deltaDown, (int)deltaUp);
                if (yTal < 0)
                {
                    // walk up
                    ySpeed = -300;
                }
                else
                {
                    ySpeed = 300;

                }
            }
        }
    }
}
