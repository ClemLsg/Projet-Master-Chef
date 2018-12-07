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
        private bool moving = false;
        private int goToX;
        private int goToY;
        private int speed = 1;

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
        public virtual void Update(UserInput userInput)
        {
            if (moving)
            {
                hitbox.X = hitbox.X + ((goToX - hitbox.X) / speed);
                hitbox.Y = hitbox.Y + ((goToY - hitbox.Y) / speed);
                speed = speed - 1;
                if (hitbox.X == goToX && hitbox.Y == goToY)
                {
                    moving = false;
                    speed = 1;
                }
            }
            this.sprite.Update(this.hitbox.X, this.hitbox.Y);
        }
        public virtual void Draw(SpriteBatch spriteBatch)
        {
            this.sprite.Draw(spriteBatch);
        }
    }
}
