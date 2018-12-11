using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Room_Simulation.Views
{
    public class Sprite
    {
        //FIELDS
        protected Rectangle destinationRectangle;
        protected Vector2 position;
        protected Texture2D texture;
        protected Rectangle sourceRectangle;
        protected Color color;
        protected SpriteEffects orientation;

        //CONSTRUCTOR

        public Sprite(string imgKey)
        {
            this.Initialize(imgKey, 0, 0, SpriteEffects.None);
        }

        public Sprite(string imgKey, int x, int y)
        {
            this.Initialize(imgKey, x, y, SpriteEffects.None);
        }

        public Sprite(string imgKey, int x, int y, SpriteEffects orientation)
        {
            this.Initialize(imgKey, x, y, orientation);
        }

        private void Initialize(string imgKey, int x, int y, SpriteEffects orientation)
        {
            this.texture = RessourcesManager.Graphics[imgKey];
            this.color = Color.White;
            this.destinationRectangle = new Rectangle(x, y,this.texture.Width,this.texture.Height);
            this.orientation = orientation;
        }

        // SETTER & GETTER
        public Point GetTextureSize()
        {
            return new Point(this.destinationRectangle.Width, this.destinationRectangle.Height);
        }
        public void SetColor(Color color)
        {
            this.color = color;
        }
        public Rectangle GetRectangle()
        {
            return this.destinationRectangle;
        }
        public virtual void setOrientation(SpriteEffects orientation)
        {
            this.orientation = orientation;
        }

        // METHODS


        //UPDATE & DRAW
        public virtual void Update(int x, int y)
        {
            this.destinationRectangle = new Rectangle(x, y,this.texture.Width,this.texture.Height);
        }
        public virtual void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(this.texture, this.destinationRectangle, null, color, 0f, Vector2.Zero, this.orientation, 0f);
        }
    }
}
