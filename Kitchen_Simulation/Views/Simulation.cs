using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Room_Simulation.Views;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitchen_Simulation.Views
{
    public class Simulation
    {
        //FIELDS
        //CONSTRUCTOR
        public Simulation()
        {
        }

        //METHODS
        public void Animation(string Anime)
        {
            Debug.WriteLine("L\'animation :" + Anime + "à bien été géré par le simulateur KITCHEN");
        }
        //UPDATE
        public void Update(GameTime gameTime, UserInput userInput)
        {

        }
        //DRAW
        public void Draw(SpriteBatch spritebatch)
        {

        }
    }
}
