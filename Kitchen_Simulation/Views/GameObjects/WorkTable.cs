using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Room_Simulation.Views;
using Room_Simulation.Views.GameObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitchen_Simulation.Views.GameObjects
{
    public class WorkTable : GameObjectsBase
    {

        //CONSTRUCTOR
        public WorkTable(int x, int y)
            : base(x, y, new Sprite("worktable", x, y))
        {

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

            base.Update(userInput, gameTime);
        }
        public override void Draw(SpriteBatch spriteBatch)
        {
            base.Draw(spriteBatch);

        }
    }
}
