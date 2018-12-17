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
        public List<Table> tables = new List<Table>();
        private Sprite exchange;
        private Sprite allWalls;
        public List<Checkpoint> checkpoints = new List<Checkpoint>();

        //CONSTRUCTOR
        public Map()
        {
            allWalls = new Sprite("allwalls", 0, 0);
            this.checkpoints.Add(new Checkpoint(1370 + 20, 30));
            this.checkpoints.Add(new Checkpoint(1145 + 20, 30));
            this.checkpoints.Add(new Checkpoint(885 + 20, 30));
            this.checkpoints.Add(new Checkpoint(620 + 20, 30));
            this.checkpoints.Add(new Checkpoint(315 + 20, 30));
            this.checkpoints.Add(new Checkpoint(5, 30));

            this.tables.Add(new Table(25 + 25, 300, 8));
            this.tables.Add(new Table(25 + 25, 300 + 130 * 1, 8));
            this.tables.Add(new Table(25 + 25, 300 + 130 * 2, 10));
            this.tables.Add(new Table(25 + 25, 300 + 130 * 3, 10));

            this.tables.Add(new Table(375 + 40, 95, 6));
            this.tables.Add(new Table(375 + 40, +95 + 130 * 1, 6));

            this.tables.Add(new Table(375 + 40, +95 + 130 * 2, 8));
            this.tables.Add(new Table(375 + 40, 95 + 130 * 3, 8));
            this.tables.Add(new Table(375 + 40, 95 + 130 * 4, 8));

            this.tables.Add(new Table(275 + 450, 95, 4));
            this.tables.Add(new Table(275 + 450, 95 + 130 * 1, 4));

            this.tables.Add(new Table(275 + 450, 95 + 130 * 2, 6));
            this.tables.Add(new Table(275 + 450, 95 + 130 * 3, 6));
            this.tables.Add(new Table(275 + 450, 95 + 130 * 4, 6));

            this.tables.Add(new Table(550 + 450, 95, 4));
            this.tables.Add(new Table(550 + 450, 95 + 130 * 1, 4));
            this.tables.Add(new Table(550 + 450, 95 + 130 * 2, 4));
            this.tables.Add(new Table(550 + 450, 95 + 130 * 3, 4));
            this.tables.Add(new Table(550 + 450, 95 + 130 * 4, 4));

            this.tables.Add(new Table(825 + 425, 25 + 70, 2));
            this.tables.Add(new Table(825 + 425, 125 + 70, 2));
            this.tables.Add(new Table(825 + 425, 225 + 70, 2));

            this.tables.Add(new Table(825 + 425, 350 + 70, 4));
            this.tables.Add(new Table(825 + 425, 475 + 70, 4));
            this.tables.Add(new Table(825 + 425, 600 + 70, 4));

            this.tables.Add(new Table(1075 + 400, 625 + 70, 2));
            this.tables.Add(new Table(1075 + 400, 525 + 70, 2));
            this.tables.Add(new Table(1075 + 400, 425 + 70, 2));
            this.tables.Add(new Table(1075 + 400, 325 + 70, 2));
            this.tables.Add(new Table(1075 + 400, 225 + 70, 2));
            this.tables.Add(new Table(1075 + 400, 125 + 70, 2));
            this.tables.Add(new Table(1075 + 400, 25 + 70, 2));










            this.exchange = new Sprite("exchange", 0, 0);
        }
        //METHODS
        //UPDATE & DRAW
        public void Update(UserInput userInput, GameTime gameTime)
        {
            foreach (var item in tables)
            {
                item.Update(userInput, gameTime);
            }
            foreach (var item in checkpoints)
            {
                item.Update(userInput, gameTime);
            }
            this.allWalls.Update(0, 0);
            this.exchange.Update(100, -15);
            //base.Update(gametime, input, game);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            this.allWalls.Draw(spriteBatch);
            foreach (var item in checkpoints)
            {
                item.Draw(spriteBatch);
            }
            foreach (var item in tables)
            {
                item.Draw(spriteBatch);
            }
            this.exchange.Draw(spriteBatch);
        }
    }
}
