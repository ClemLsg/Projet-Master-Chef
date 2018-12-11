using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Room_Simulation.Views.GameObjects
{
    public abstract class GameObjectsBase
    {
        //FIELDS
        protected Rectangle hitbox;
        protected Sprite sprite;
        public bool moving = false;
        private int goToX;
        private int goToY;
        public int speed = 10;

        //CONSTRUTOR
        protected GameObjectsBase(int x, int y, Sprite sprite)
        {
            Point textureSize = sprite.GetTextureSize();
            this.hitbox = new Rectangle(x, y, textureSize.X, textureSize.Y);
            this.sprite = sprite;
        }
        //METHODS
        public virtual void GoTo(int x, int y)
        {
            this.goToX = x;
            this.goToY = y;
            this.moving = true;
        }

        //UPDATE & DRAW
        public virtual void Update(UserInput userInput, GameTime gameTime)
        {
            if (moving)
            {
                int Xway = goToX - hitbox.X;
                int Yway = goToY - hitbox.Y;

                if(Xway > 0)
                {
                    hitbox.X = hitbox.X + 1 * speed;
                }
                else if(Xway < 0)
                {
                    hitbox.X = hitbox.X - 1 * speed;
                }
                else if(Yway > 0)
                {
                    hitbox.Y = hitbox.Y + 1 * speed;
                }
                else if(Yway < 0)
                {
                    hitbox.Y = hitbox.Y - 1 * speed;
                }
                else
                {
                    moving = false;
                }

             //   hitbox.X = hitbox.X + ((goToX - hitbox.X) / speed);
              //  hitbox.Y = hitbox.Y + ((goToY - hitbox.Y) / speed);
             //   speed = speed - 1;
            //    if (hitbox.X == goToX && hitbox.Y == goToY)
            //    {
            //        moving = false;
              //      speed = 50;
            //    }
            }
            this.sprite.Update(this.hitbox.X, this.hitbox.Y);
        }
        public virtual void Draw(SpriteBatch spriteBatch)
        {
            this.sprite.Draw(spriteBatch);
        }
    }
}
