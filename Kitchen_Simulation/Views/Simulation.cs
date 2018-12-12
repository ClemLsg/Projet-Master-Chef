using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
//using Room_Simulation.Views;
//using Room_Simulation.Views.GameObjects;
using Kitchen_Simulation.Views;
using Kitchen_Simulation.Views.GameObjects;
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
        private Map map;
        private Clerk clerk;
        private Cook cook;
        private Cook cook1;
        private Cleaner cleaner;

        //CONSTRUCTOR
        public Simulation()
        {
            map = new Map();
            clerk = new Clerk(100, 100);
            cook = new Cook(100, 100);
            cook1 = new Cook(100, 100);
            cleaner = new Cleaner(100, 100);
            cook.goToWS(2);
            cook1.goToWS(3);
        }

        //METHODS
        public void Animation(string Anime)
        {
            switch (Anime)
            {
                case "GoStockCom":
                    clerk.goToWS(16);
                    break;
                case "GoCookCom":
                    clerk.goToWS(cook.actualPosition);
                    break;
                case "GoExCom":
                    clerk.goToWS(1);
                    break;
                case "GoToCookClean":
                    cleaner.goToWS(cook.actualPosition);
                    break;
                case "GoToSinkClean":
                    cleaner.goToWS(11);
                    break;
                case "GoToDishWasherClean":
                    cleaner.goToWS(13);
                    break;
                case "GoToWashingMachineClean":
                    cleaner.goToWS(12);
                    break;
                default:
                    break;
            }
            Debug.WriteLine("L\'animation :" + Anime + "à bien été géré par le simulateur KITCHEN");
        }
        //UPDATE
        public void Update(GameTime gameTime, UserInput userInput)
        {
            map.Update(userInput, gameTime);
            clerk.Update(userInput, gameTime);
            cook.Update(userInput, gameTime);
            cook1.Update(userInput, gameTime);
            cleaner.Update(userInput, gameTime);
        }
        //DRAW
        public void Draw(SpriteBatch spritebatch)
        {

            map.Draw(spritebatch);
            clerk.Draw(spritebatch);
            cook.Draw(spritebatch);
            cook1.Draw(spritebatch);
            cleaner.Draw(spritebatch);
        }
    }
}
