using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Room_Simulation.Views.Display;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Room_Simulation.Views.GameObjects
{
    public class Waiter : GameObjectsBase
    {
        // FIELDS
        private int timer = 0;
        private int actualPosition = 21;
        private bool isTakingPlate = false;

        // CONSTRUCTOR
        public Waiter(int x, int y)
            : base(x, y, new AnimatedSprite("serveur", 28, 60, 0, SheetOrientation.HORIZONTAL))
        {

        }



        public Rectangle rectangle()
        {
            return sprite.GetRectangle();
        }


        // METHODS
        public void serve(int tableNum)
        {
           // this.GoTo(x, y);
        }

        public void takePlate()
        {
            isTakingPlate = true;
            if(actualPosition < 33 && actualPosition > 25)
            {
                GoTo(1370 + 20, 30);
                actualPosition = 33;
            }
            else if (actualPosition < 26 && actualPosition > 19)
            {
                GoTo(1145 + 20, 30);
                actualPosition = 34;
            }
            else if (actualPosition < 20 && actualPosition > 14)
            {
                GoTo(885 + 20, 30);
                actualPosition = 35;
            }
            else if (actualPosition < 15 && actualPosition > 9)
            {
                GoTo(620 + 20, 30);
                actualPosition = 36;
            }
            else if (actualPosition < 10 && actualPosition > 4)
            {
                GoTo(315 + 20, 30);
                actualPosition = 37;
            }
            else if (actualPosition < 5 && actualPosition > 0)
            {
                GoTo(5, 30);
                actualPosition = 38;
            }
            else if (actualPosition < 39 && actualPosition > 32)
            {
                GoTo(0,0);
                actualPosition = 0;
                isTakingPlate = false;
            }
            else
            {
                GoTo(0, 0);
                actualPosition = 0;
                isTakingPlate = false;
            }
        }

        // UPDATE & DRAW
        public override void Update(UserInput userInput, GameTime gametime)
        {
            this.timer += gametime.ElapsedGameTime.Milliseconds;
            if(timer > 2000)
            {
                timer = 0;
                if (isTakingPlate)
                {
                    takePlate();
                }
            }

            base.Update(userInput, gametime);
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            base.Draw(spriteBatch);
        }
    }
}