using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Room_Simulation.Views.GameObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Room_Simulation.Views
{
    public class Simulation
    {
        //FIELDS
        private Map map;
        private Waiter waiter1;
        private bool justOne = true;
        //CONSTRUCTOR
        public Simulation()
        {
            map = new Map();
            waiter1 = new Waiter(1000, 500);
        }

        //METHODS
        //UPDATE
        public void Update(GameTime gameTime, UserInput userInput)
        {
            if (justOne)
            {
                justOne = false;
                waiter1.returnToExchange();
            }
            waiter1.Update(userInput, gameTime);
            map.Update(userInput, gameTime);
        }
        //DRAW
        public void Draw(SpriteBatch spritebatch)
        {

            map.Draw(spritebatch);
            waiter1.Draw(spritebatch);
        }
    }
}
