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
        //CONSTRUCTOR
        public Simulation()
        {
            map = new Map();
        }

        //METHODS
        //UPDATE
        public void Update(GameTime gametime, UserInput userInput)
        {
            map.Update(userInput);
        }
        //DRAW
        public void Draw(SpriteBatch spritebatch)
        {
            map.Draw(spritebatch);
        }
    }
}
