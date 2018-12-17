using Kitchen_Simulation.Views.GameObjects;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Room_Simulation.Views.GameObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitchen_Simulation.Views.GameObjects
{
    public class Table : GameObjectsBase
    {
        public int capacity;
        public List<Chair> chairsList = new List<Chair>();

        //CONSTRUCTOR
        public Table(int x, int y, int capacity)
            : base(x, y, new Sprite("table" + capacity.ToString(), 70, 64))
        {
            this.capacity = capacity;
            switch (capacity)
            {
                case 2:
                    chairsList.Add(new Chair(this.hitbox.X + 70, this.hitbox.Y + 10, 3));
                    chairsList.Add(new Chair(this.hitbox.X - 32, this.hitbox.Y + 10, 2));
                    break;
                case 4:
                    chairsList.Add(new Chair(this.hitbox.X + 101, this.hitbox.Y + 10, 3));
                    chairsList.Add(new Chair(this.hitbox.X + 38, this.hitbox.Y + 42, 0));
                    chairsList.Add(new Chair(this.hitbox.X + 38, this.hitbox.Y - 30, 1));
                    chairsList.Add(new Chair(this.hitbox.X - 32, this.hitbox.Y + 10, 2));
                    break;

                case 6:
                    chairsList.Add(new Chair(this.hitbox.X + 150, this.hitbox.Y + 10, 3));
                    chairsList.Add(new Chair(this.hitbox.X + 30, this.hitbox.Y + 42, 0));
                    chairsList.Add(new Chair(this.hitbox.X + 30, this.hitbox.Y - 30, 1));
                    chairsList.Add(new Chair(this.hitbox.X + 95, this.hitbox.Y + 42, 0));
                    chairsList.Add(new Chair(this.hitbox.X + 95, this.hitbox.Y - 30, 1));
                    chairsList.Add(new Chair(this.hitbox.X - 32, this.hitbox.Y + 10, 2));
                    break;
                case 8:
                    chairsList.Add(new Chair(this.hitbox.X + 188, this.hitbox.Y + 10, 3));
                    chairsList.Add(new Chair(this.hitbox.X + 54 - 28, this.hitbox.Y + 42, 0));
                    chairsList.Add(new Chair(this.hitbox.X + 54 - 28, this.hitbox.Y - 30, 1));
                    chairsList.Add(new Chair(this.hitbox.X + 108 - 28, this.hitbox.Y + 42, 0));
                    chairsList.Add(new Chair(this.hitbox.X + 108 - 28, this.hitbox.Y - 30, 1));
                    chairsList.Add(new Chair(this.hitbox.X + 162 - 28, this.hitbox.Y + 42, 0));
                    chairsList.Add(new Chair(this.hitbox.X + 162 - 28, this.hitbox.Y - 30, 1));
                    chairsList.Add(new Chair(this.hitbox.X - 32, this.hitbox.Y + 10, 2));
                    break;

                case 10:
                    chairsList.Add(new Chair(this.hitbox.X + 250, this.hitbox.Y + 10, 3));
                    chairsList.Add(new Chair(this.hitbox.X + 54 - 25, this.hitbox.Y + 42, 0));
                    chairsList.Add(new Chair(this.hitbox.X + 54 - 25, this.hitbox.Y - 30, 1));
                    chairsList.Add(new Chair(this.hitbox.X + 108 - 25, this.hitbox.Y + 42, 0));
                    chairsList.Add(new Chair(this.hitbox.X + 108 - 25, this.hitbox.Y - 30, 1));
                    chairsList.Add(new Chair(this.hitbox.X + 162 - 25, this.hitbox.Y + 42, 0));
                    chairsList.Add(new Chair(this.hitbox.X + 162 - 25, this.hitbox.Y - 30, 1));
                    chairsList.Add(new Chair(this.hitbox.X + 162 - 25 + 54, this.hitbox.Y + 42, 0));
                    chairsList.Add(new Chair(this.hitbox.X + 162 - 25 + 54, this.hitbox.Y - 30, 1));
                    chairsList.Add(new Chair(this.hitbox.X - 32, this.hitbox.Y + 10, 2));
                    break;
                default:
                    break;
            }
        }

        public void setColor(Color color)
        {
            sprite.SetColor(color);
        }

        public Rectangle GetRectangle()
        {
            return sprite.GetRectangle();
        }

        public bool checkCollision(Rectangle rectangle)
        {
            return sprite.GetRectangle().Intersects(rectangle);
        }
        //UPDATE & DRAW

        public override void Update(UserInput userInput, GameTime gameTime)
        {
            foreach (var item in chairsList)
            {
                item.Update(userInput, gameTime);
            }
            base.Update(userInput, gameTime);
        }
        public override void Draw(SpriteBatch spriteBatch)
        {
            base.Draw(spriteBatch);
            foreach (var item in chairsList)
            {
                item.Draw(spriteBatch);
            }

        }
    }
}