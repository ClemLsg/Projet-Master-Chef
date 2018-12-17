using Kitchen_Simulation.Views.Display;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitchen_Simulation.Views.GameObjects
{
    public class Clerk : GameObjectsBase
    {
        // FIELDS
        private Random random;
        private int timer = 0;
        private int actualPosition = 17;
        private bool isGoingToWS = false;
        //private bool isGoingToCheckPoint = false;
        private int targetWS = -1;
        //public List<int> spriteSizeX = new List<int>() {52,3 };
        //public List<int> spriteSizeY = new List<int>() {58, 3 };

        // CONSTRUCTOR
        public Clerk(int x, int y)
            : base(x, y, new AnimatedSprite("client13",51,52, 0, SheetOrientation.HORIZONTAL))
        {
            random = new Random();
        }



        public Rectangle rectangle()
        {
            return sprite.GetRectangle();
        }


        // METHODS

        public void goToWS(int tableNumb)
        {
            if (!this.moving)
            {
                this.speed = 10;

                this.targetWS = tableNumb;

                this.isGoingToWS = true;

                if(targetWS > 0 && targetWS < 10)
                {
                    if(actualPosition > 0 && actualPosition < 10 || actualPosition == 17)
                    {
                        if(targetWS == 1)
                        {
                            GoTo(740,40);
                            isGoingToWS = false;
                            actualPosition = 1;
                            targetWS = -1;
                        }
                        if (targetWS == 2)
                        {
                            GoTo(550,50);
                            isGoingToWS = false;
                            actualPosition = 2;
                            targetWS = -1;
                        }
                        if (targetWS == 3)
                        {
                            GoTo(420,50);
                            isGoingToWS = false;
                            actualPosition = 3;
                            targetWS = -1;
                        }
                        if (targetWS == 4)
                        {
                            GoTo(290,50);
                            isGoingToWS = false;
                            actualPosition = 4;
                            targetWS = -1;
                        }
                        if (targetWS == 5)
                        {
                            GoTo(160,50);
                            isGoingToWS = false;
                            actualPosition = 5;
                            targetWS = -1;
                        }
                        if (targetWS == 6)
                        {
                            GoTo(30,50);
                            isGoingToWS = false;
                            actualPosition = 6;
                            targetWS = -1;
                        }
                        if (targetWS == 7)
                        {
                            GoTo(800,140);
                            isGoingToWS = false;
                            actualPosition = 7;
                            targetWS = -1;
                        }
                        if (targetWS == 8)
                        {
                            GoTo(610,140);
                            isGoingToWS = false;
                            actualPosition = 8;
                            targetWS = -1;
                        }
                        if (targetWS == 9)
                        {
                            GoTo(420,140);
                            isGoingToWS = false;
                            actualPosition = 9;
                            targetWS = -1;
                        }

                    }
                    else if(actualPosition == 18)
                    {
                        GoTo(100, 110);
                        actualPosition = 17;
                    }
                    else if(actualPosition < 17 && actualPosition > 9)
                    {
                        GoTo(100,350);
                        actualPosition = 18;
                    }

                }
                if (targetWS > 9 && targetWS < 17)
                {
                    if (actualPosition > 10 && actualPosition < 17 || actualPosition == 18)
                    {
                        if (targetWS == 10)
                        {
                            GoTo(650,290);
                            isGoingToWS = false;
                            actualPosition = 10;
                            targetWS = -1;
                        }
                        if (targetWS == 11)
                        {
                            GoTo(450,290);
                            isGoingToWS = false;
                            actualPosition = 11;
                            targetWS = -1;
                        }
                        if (targetWS == 12)
                        {
                            GoTo(330,320);
                            isGoingToWS = false;
                            actualPosition = 12;
                            targetWS = -1;
                        }
                        if (targetWS == 13)
                        {
                            GoTo(260,300);
                            isGoingToWS = false;
                            actualPosition = 13;
                            targetWS = -1;
                        }
                        if (targetWS == 14)
                        {
                            GoTo(700,470);
                            isGoingToWS = false;
                            actualPosition = 14;
                            targetWS = -1;
                        }
                        if (targetWS == 15)
                        {
                            GoTo(400,470);
                            isGoingToWS = false;
                            actualPosition = 15;
                            targetWS = -1;
                        }
                        if (targetWS == 16)
                        {
                            GoTo(140, 470);
                            isGoingToWS = false;
                            actualPosition = 16;
                            targetWS = -1;
                        }
                    }
                    else if (actualPosition == 17)
                    {
                        GoTo(100,350);
                        actualPosition = 18;
                    }
                    else if (actualPosition > 0 && actualPosition < 10)
                    {
                        GoTo(100, 110);
                        actualPosition = 17;
                    }


                }
            }
        }

        // UPDATE & DRAW
        public override void Update(UserInput userInput, GameTime gametime)
        {
            this.timer += gametime.ElapsedGameTime.Milliseconds;
            //Debug.WriteLine("OldPosition :" + this.oldPosition);
            //Debug.WriteLine("Position :" + this.actualPosition);
            //Debug.WriteLine("X:" + this.hitbox.X + "  Y:" + this.hitbox.Y);
            //if (timer > 5000) {
            //    timer = 0;
            //    int tab = random.Next(1, 32);
            //    goToTable(tab);
            //}
            if (userInput.IsKeyDown(Keys.Q))
            {
                this.hitbox.X--;
            }
            if (userInput.IsKeyDown(Keys.S))
            {
                this.hitbox.Y++;
            }
            if (userInput.IsKeyDown(Keys.D))
            {
                this.hitbox.X++;
            }
            if (userInput.IsKeyDown(Keys.Z))
            {
                this.hitbox.Y--;
            }
            if (userInput.IsKeyDown(Keys.P))
            {
                int tab = random.Next(1, 16);
                goToWS(tab);
            }

            if (isGoingToWS) // Way to exchange area
            {
                goToWS(this.targetWS);
            }


            base.Update(userInput, gametime);
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            base.Draw(spriteBatch);
        }
    }
}
