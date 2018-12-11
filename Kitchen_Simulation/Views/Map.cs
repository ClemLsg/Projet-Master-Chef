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
    public class Map
    {
        //FIELD
        private List<Cooker> cookers;
        private WorkTable workTable;

        //CONSTRUCTOR
        public Map()
        {
            cookers = new List<Cooker>();
            cookers.Add(new Cooker(0, 0));
            cookers.Add(new Cooker(128, 0));
            cookers.Add(new Cooker(256, 0));
            cookers.Add(new Cooker(384, 0));
            cookers.Add(new Cooker(512, 0));
            workTable = new WorkTable(640, 0);

        }
        //METHODS
        //UPDATE & DRAW
        public void Update(UserInput userInput, GameTime gameTime)
        {
            foreach (var item in cookers)
            {
                item.Update(userInput, gameTime);
            }
            workTable.Update(userInput, gameTime);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            foreach (var item in cookers)
            {
                item.Draw(spriteBatch);
            }
            workTable.Draw(spriteBatch);
        }
    }
}
