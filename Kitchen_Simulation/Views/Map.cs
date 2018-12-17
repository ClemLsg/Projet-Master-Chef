using Kitchen_Simulation.Views.GameObjects;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitchen_Simulation.Views.GameObjects
{
    public class Map
    {
        //FIELD
        private List<Cooker> cookers;
        private List<WorkTable> workTables;
        private Fridge fridge;
        private DishWasher dishWasher;
        private WashMachine washMachine;
        private List<Sink> sinks;
        //CONSTRUCTOR
        public Map()
        {
            cookers = new List<Cooker>();
            cookers.Add(new Cooker(0, 0));
            cookers.Add(new Cooker(128, 0));
            cookers.Add(new Cooker(256, 0));
            cookers.Add(new Cooker(384, 0));
            cookers.Add(new Cooker(512, 0));
            workTables = new List<WorkTable>();
            workTables.Add(new WorkTable(640, 0));
            workTables.Add(new WorkTable(512, 192));
            workTables.Add(new WorkTable(258, 192));
            dishWasher = new DishWasher(258, 250);
            washMachine = new WashMachine(320, 250);
            fridge = new Fridge(766, 192);
            sinks = new List<Sink>();
            sinks.Add(new Sink(384, 250));
            sinks.Add(new Sink(384 + 192, 250));

        }
        //METHODS
        //UPDATE & DRAW
        public void Update(UserInput userInput, GameTime gameTime)
        {
            foreach (var item in cookers)
            {
                item.Update(userInput, gameTime);
            }
            foreach (var item in workTables)
            {
                item.Update(userInput, gameTime);
            }
            foreach (var item in sinks)
            {
                item.Update(userInput, gameTime);
            }
            fridge.Update(userInput, gameTime);
            dishWasher.Update(userInput, gameTime);
            washMachine.Update(userInput, gameTime);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            foreach (var item in cookers)
            {
                item.Draw(spriteBatch);
            }
            foreach (var item in workTables)
            {
                item.Draw(spriteBatch);
            }
            foreach (var item in sinks)
            {
                item.Draw(spriteBatch);
            }
            fridge.Draw(spriteBatch);
            dishWasher.Draw(spriteBatch);
            washMachine.Draw(spriteBatch);
        }
    }
}
