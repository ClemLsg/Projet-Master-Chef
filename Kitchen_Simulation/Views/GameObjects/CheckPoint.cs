using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitchen_Simulation.Views.GameObjects
{
    public class Checkpoint : GameObjectsBase
    {

        //CONSTRUCTOR
        public Checkpoint(int x, int y)
            : base(x, y, new Sprite("candle", 70, 64))
        {
           
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
