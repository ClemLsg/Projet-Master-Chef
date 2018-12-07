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
        private List<Table> tables = new List<Table>();
        private Sprite exchange;
        private Sprite allWalls;

        //CONSTRUCTOR
        public Map()
        {
            allWalls = new Sprite("allwalls", 0, 0);
            this.tables.Add(new Table(235, 325, 2));
            this.tables.Add(new Table(1050 + 400, 625 + 50, 2));
            this.tables.Add(new Table(1050 + 400, 525 + 50, 2));
            this.tables.Add(new Table(1050 + 400, 425 + 50, 2));
            this.tables.Add(new Table(1050 + 400, 325 + 50, 2));
            this.tables.Add(new Table(1050 + 400, 225 + 50, 2));
            this.tables.Add(new Table(1050 + 400, 125 + 50, 2));
            this.tables.Add(new Table(1050 + 400, 25 + 50, 2));
            this.tables.Add(new Table(850 + 400, 25 + 50, 2));
            this.tables.Add(new Table(850 + 400, 125 + 50, 2));
            this.tables.Add(new Table(830 + 400, 250 + 50, 4));
            this.tables.Add(new Table(830 + 400, 375 + 50, 4));
            this.tables.Add(new Table(830 + 400, 500 + 50, 4));
            this.tables.Add(new Table(830 + 400, 625 + 50, 4));
            this.tables.Add(new Table(610 + 400, 700, 4));
            this.tables.Add(new Table(610 + 400, 75, 4));
            this.tables.Add(new Table(610 + 400, 200, 4));
            this.tables.Add(new Table(610 + 400, 325, 4));
            this.tables.Add(new Table(610 + 400, 450, 4));
            this.tables.Add(new Table(610 + 400, 575, 4));
            this.tables.Add(new Table(330 + 400, 75, 6));
            this.tables.Add(new Table(330 + 400, 200, 6));
            this.tables.Add(new Table(330 + 400, 325, 6));
            this.tables.Add(new Table(330 + 400, 450, 6));
            this.tables.Add(new Table(330 + 400, 575, 6));
            this.tables.Add(new Table(315 + 400, 700, 8));
            this.tables.Add(new Table(420, 75, 8));
            this.tables.Add(new Table(420, 200, 8));
            this.tables.Add(new Table(420, 325, 8));
            this.tables.Add(new Table(420, 450, 8));
            this.tables.Add(new Table(360, 575, 10));
            this.tables.Add(new Table(360, 700, 10));
            this.exchange = new Sprite("exchange", 0, 0);
        }
        //METHODS
        //UPDATE & DRAW
        public void Update(UserInput userInput)
        {
            foreach (var item in tables)
            {
                item.Update(userInput);
            }
            this.allWalls.Update(0, 0);
            this.exchange.Update(100, -15);
            //base.Update(gametime, input, game);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            this.allWalls.Draw(spriteBatch);
            foreach (var item in tables)
            {
                item.Draw(spriteBatch);
            }
            this.exchange.Draw(spriteBatch);
        }
    }
}
