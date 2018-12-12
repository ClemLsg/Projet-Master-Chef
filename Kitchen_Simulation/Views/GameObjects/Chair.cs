using Kitchen_Simulation.Views;
using Kitchen_Simulation.Views.Display;
using Kitchen_Simulation.Views.GameObjects;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Room_Simulation.Views.GameObjects
{
    public class Chair : GameObjectsBase
    {
        public bool Available = true;
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
        public override void Update(UserInput userInput, GameTime gametime)
        {
            base.Update(userInput, gametime);
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            base.Draw(spriteBatch);
        }
    }
}
