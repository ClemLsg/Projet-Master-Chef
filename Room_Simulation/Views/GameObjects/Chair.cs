using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Room_Simulation.Views.Display;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Room_Simulation.Views.GameObjects
{
    public class Chair : GameObjectsBase
    {
        public Chair(int x, int y, int index)
            : base(x, y, new AnimatedSprite("chairs", 32, 32, index, SheetOrientation.HORIZONTAL))
        {

        }
        // FIELDS

        // CONSTRUCTOR
        public Rectangle rectangle()
        {
            return sprite.GetRectangle();
        }

        // METHODS

        // UPDATE & DRAW
        public override void Update(UserInput userInput)
        {
            base.Update(userInput);
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            base.Draw(spriteBatch);
        }
    }
}
