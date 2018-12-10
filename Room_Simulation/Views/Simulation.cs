using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
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
        private List<Client> clients = new List<Client>();
        private List<int> spriteSizeX = new List<int>() {0, 52, 51, 33, 36, 29, 36, 50, 30, 43, 51, 52, 51, 51};
        private List<int> spriteSizeY = new List<int>() {0, 58, 59, 57, 61, 62, 63, 55, 57, 59, 60, 63, 61, 52};
        private Waiter waiter1;
        private bool justOne = true;
        //CONSTRUCTOR
        public Simulation()
        {
            map = new Map();
            waiter1 = new Waiter(1000, 500);
            clients.Add(new Client(0, 0, 1, spriteSizeX, spriteSizeY));
            clients.Add(new Client(0, 0, 2, spriteSizeX, spriteSizeY));
            clients.Add(new Client(0, 0, 3, spriteSizeX, spriteSizeY));

        }

        //METHODS
        //UPDATE
        public void Update(GameTime gameTime, UserInput userInput)
        {
            foreach (var item in clients)
            {
                item.Update(userInput, gameTime);
            }

            if (userInput.IsKeyDown(Keys.C))
            {
                this.clients[0].goToTable(5);
                this.clients[1].goToTable(5);
                this.clients[2].goToTable(5);
            }
            if (userInput.IsKeyDown(Keys.V))
            {
                this.clients[0].Sit(map.tables[clients[0].Table-1]);
                this.clients[1].Sit(map.tables[clients[1].Table - 1]);
                this.clients[2].Sit(map.tables[clients[2].Table - 1]);
            }

            waiter1.Update(userInput, gameTime);
            map.Update(userInput, gameTime);
        }
        //DRAW
        public void Draw(SpriteBatch spritebatch)
        {
            map.Draw(spritebatch);
            foreach (var item in clients)
            {
                item.Draw(spritebatch);
            }


            waiter1.Draw(spritebatch);
        }
    }
}
