using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Room_Simulation.Views.Display
{
    public enum SheetOrientation
    {
        VERTICAL,
        HORIZONTAL
    }
    public class AnimatedSprite : Sprite
    {
        //FIELD
        private Rectangle sourceRestangle;
        private int spriteWidth;
        private int spriteHeight;
        private int currentIndex;
        private SheetOrientation orientation;
        private SpriteEffects sens;
        //SETTER

        public void SetIndex(int index)
        {
            this.currentIndex = index;
        }
        //CONSTRUCTOR

        public AnimatedSprite(string imgKey, int spriteWidth, int spriteHeight, int index, SheetOrientation orientation)
            : base(imgKey)
        {
            this.spriteHeight = spriteHeight;
            this.spriteWidth = spriteWidth;
            this.currentIndex = index;
            this.orientation = orientation;

            this.destinationRectangle = new Rectangle(0, 0, this.spriteWidth, this.spriteHeight);

            if (this.orientation == SheetOrientation.HORIZONTAL)
            {
                this.sourceRestangle = new Rectangle(this.currentIndex * this.spriteWidth, 0, this.spriteWidth, this.spriteHeight);
            }
            else
            {
                this.sourceRestangle = new Rectangle(0, this.currentIndex * this.spriteHeight, this.spriteWidth, this.spriteHeight);
            }
        }

        //METHODS

        public override void setOrientation(SpriteEffects orientation)
        {
            this.sens = orientation;
        }

        //UPDATE & DRAW

        public override void Update(int x, int y)
        {
            this.destinationRectangle = new Rectangle(x, y, this.spriteWidth, this.spriteHeight);

            if (this.orientation == SheetOrientation.HORIZONTAL)
            {
                this.sourceRestangle = new Rectangle(this.currentIndex * this.spriteWidth, 0, this.spriteWidth, this.spriteHeight);
            }
            else
            {
                this.sourceRestangle = new Rectangle(0, this.currentIndex * this.spriteHeight, this.spriteWidth, this.spriteHeight);
            }
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(this.texture, this.destinationRectangle, this.sourceRestangle, color, 0f, Vector2.Zero, this.sens, 0f);

        }
    }
}
