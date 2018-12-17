using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Room_Simulation.Views.Display;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Room_Simulation.Views.GameObjects
{
    public class Client : GameObjectsBase
    {
        // FIELDS
        private Random random;
        private int timer = 0;
        private int oldPosition = -1;
        private int actualPosition = 32;
        private bool isTakingPlate = false;
        private bool isGoingToTable = false;
        public int Table = -1;
        //private bool isGoingToCheckPoint = false;
        private int targetTable = -1;
        //public List<int> spriteSizeX = new List<int>() {52,3 };
        //public List<int> spriteSizeY = new List<int>() {58, 3 };

        // CONSTRUCTOR
        public Client(int x, int y, int clientSkin, List<int> spriteSizeX, List<int> spriteSizeY)
            : base(x, y, new AnimatedSprite("client" + clientSkin, spriteSizeX[clientSkin], spriteSizeY[clientSkin], 0, SheetOrientation.HORIZONTAL))
        {

            random = new Random(clientSkin);
        }



        public Rectangle rectangle()
        {
            return sprite.GetRectangle();
        }


        // METHODS

        public void goToTable(int tableNumb)
        {
            if (!this.moving)
            {
                this.speed = 10;

                this.targetTable = tableNumb;
                this.Table = tableNumb;
                this.isGoingToTable = true;
                if (this.targetTable < 33 && this.targetTable > 25)
                {
                    if (actualPosition < 34 && actualPosition > 25)
                    {
                        if (this.targetTable == 26)
                        {
                            GoTo(1410, 80);
                            actualPosition = 26;
                            this.isGoingToTable = false;
                            this.targetTable = -1;
                        }
                        else if (this.targetTable == 27)
                        {
                            GoTo(1410, 180);
                            actualPosition = 27;
                            this.isGoingToTable = false;
                            this.targetTable = -1;
                        }
                        else if (this.targetTable == 28)
                        {
                            GoTo(1410, 280);
                            actualPosition = 28;
                            this.isGoingToTable = false;
                            this.targetTable = -1;
                        }
                        else if (this.targetTable == 29)
                        {
                            GoTo(1410, 380);
                            actualPosition = 29;
                            this.isGoingToTable = false;
                            this.targetTable = -1;
                        }
                        else if (this.targetTable == 30)
                        {
                            GoTo(1410, 480);
                            actualPosition = 30;
                            this.isGoingToTable = false;
                            this.targetTable = -1;
                        }
                        else if (this.targetTable == 31)
                        {
                            GoTo(1410, 580);
                            actualPosition = 31;
                            this.isGoingToTable = false;
                            this.targetTable = -1;
                        }
                        else if (this.targetTable == 32)
                        {
                            GoTo(1410, 680);
                            actualPosition = 32;
                            this.isGoingToTable = false;
                            this.targetTable = -1;
                        }
                    }
                    else if (actualPosition < 39 && actualPosition > 33 || actualPosition == 0)
                    {
                        GoTo(1410, 30);
                        actualPosition = 33;
                    }
                    else if (actualPosition < 26 && actualPosition > 19)
                    {
                        GoTo(1180, 30);
                        actualPosition = 34;
                    }
                    else if (actualPosition < 20 && actualPosition > 14)
                    {
                        GoTo(930, 30);
                        actualPosition = 35;
                    }
                    else if (actualPosition < 15 && actualPosition > 9)
                    {
                        GoTo(640, 30);
                        actualPosition = 36;
                    }
                    else if (actualPosition < 10 && actualPosition > 4)
                    {
                        GoTo(340, 30);
                        actualPosition = 37;
                    }
                    else if (actualPosition < 5 && actualPosition > 0)
                    {
                        GoTo(10, 30);
                        actualPosition = 38;
                    }
                }
                if (this.targetTable < 26 && this.targetTable > 19)
                {
                    if (actualPosition < 26 && actualPosition > 19 || actualPosition == 34)
                    {
                        if (this.targetTable == 20)
                        {
                            GoTo(1180, 80);
                            actualPosition = 20;
                            this.isGoingToTable = false;
                            this.targetTable = -1;
                        }
                        else if (this.targetTable == 21)
                        {
                            GoTo(1180, 180);
                            actualPosition = 21;
                            this.isGoingToTable = false;
                            this.targetTable = -1;
                        }
                        else if (this.targetTable == 22)
                        {
                            GoTo(1180, 280);
                            actualPosition = 22;
                            this.isGoingToTable = false;
                            this.targetTable = -1;
                        }
                        else if (this.targetTable == 23)
                        {
                            GoTo(1180, 430);
                            actualPosition = 23;
                            this.isGoingToTable = false;
                            this.targetTable = -1;
                        }
                        else if (this.targetTable == 24)
                        {
                            GoTo(1180, 560);
                            actualPosition = 24;
                            this.isGoingToTable = false;
                            this.targetTable = -1;
                        }
                        else if (this.targetTable == 25)
                        {
                            GoTo(1180, 680);
                            actualPosition = 25;
                            this.isGoingToTable = false;
                            this.targetTable = -1;
                        }
                    }
                    else if (actualPosition < 39 && actualPosition > 34 || actualPosition == 33 || actualPosition == 0)
                    {
                        GoTo(1180, 30);
                        actualPosition = 34;
                    }
                    else if (actualPosition < 33 && actualPosition > 25)
                    {
                        GoTo(1410, 30);
                        actualPosition = 33;
                    }
                    else if (actualPosition < 20 && actualPosition > 14)
                    {
                        GoTo(930, 30);
                        actualPosition = 35;
                    }
                    else if (actualPosition < 15 && actualPosition > 9)
                    {
                        GoTo(640, 30);
                        actualPosition = 36;
                    }
                    else if (actualPosition < 10 && actualPosition > 4)
                    {
                        GoTo(340, 30);
                        actualPosition = 37;
                    }
                    else if (actualPosition < 5 && actualPosition > 0)
                    {
                        GoTo(10, 30);
                        actualPosition = 38;
                    }
                }
                if (this.targetTable < 20 && this.targetTable > 14)
                {
                    if (actualPosition < 20 && actualPosition > 14 || actualPosition == 35)
                    {
                        if (this.targetTable == 15)
                        {
                            GoTo(930, 100);
                            actualPosition = 15;
                            this.isGoingToTable = false;
                            this.targetTable = -1;
                        }
                        else if (this.targetTable == 16)
                        {
                            GoTo(930, 230);
                            actualPosition = 16;
                            this.isGoingToTable = false;
                            this.targetTable = -1;
                        }
                        else if (this.targetTable == 17)
                        {
                            GoTo(930, 360);
                            actualPosition = 17;
                            this.isGoingToTable = false;
                            this.targetTable = -1;
                        }
                        else if (this.targetTable == 18)
                        {
                            GoTo(930, 490);
                            actualPosition = 18;
                            this.isGoingToTable = false;
                            this.targetTable = -1;
                        }
                        else if (this.targetTable == 19)
                        {
                            GoTo(930, 620);
                            actualPosition = 19;
                            this.isGoingToTable = false;
                            this.targetTable = -1;
                        }
                    }
                    else if (actualPosition < 39 && actualPosition > 35 || actualPosition == 33 || actualPosition == 34 || actualPosition == 0)
                    {
                        GoTo(900, 30);
                        actualPosition = 35;
                    }
                    else if (actualPosition < 33 && actualPosition > 25)
                    {
                        GoTo(1410, 30);
                        actualPosition = 33;
                    }
                    else if (actualPosition < 26 && actualPosition > 19)
                    {
                        GoTo(1180, 30);
                        actualPosition = 34;
                    }
                    else if (actualPosition < 15 && actualPosition > 9)
                    {
                        GoTo(640, 30);
                        actualPosition = 36;
                    }
                    else if (actualPosition < 10 && actualPosition > 4)
                    {
                        GoTo(340, 30);
                        actualPosition = 37;
                    }
                    else if (actualPosition < 5 && actualPosition > 0)
                    {
                        GoTo(10, 30);
                        actualPosition = 38;
                    }
                }





                ////

                if (this.targetTable < 15 && this.targetTable > 9)
                {
                    if (actualPosition < 15 && actualPosition > 9 || actualPosition == 36)
                    {
                        if (this.targetTable == 10)
                        {
                            GoTo(640, 100);
                            actualPosition = 10;
                            this.isGoingToTable = false;
                            this.targetTable = -1;
                        }
                        else if (this.targetTable == 11)
                        {
                            GoTo(640, 230);
                            actualPosition = 11;
                            this.isGoingToTable = false;
                            this.targetTable = -1;
                        }
                        else if (this.targetTable == 12)
                        {
                            GoTo(640, 360);
                            actualPosition = 12;
                            this.isGoingToTable = false;
                            this.targetTable = -1;
                        }
                        else if (this.targetTable == 13)
                        {
                            GoTo(640, 490);
                            actualPosition = 13;
                            this.isGoingToTable = false;
                            this.targetTable = -1;
                        }
                        else if (this.targetTable == 14)
                        {
                            GoTo(640, 620);
                            actualPosition = 14;
                            this.isGoingToTable = false;
                            this.targetTable = -1;
                        }
                    }
                    else if (actualPosition < 39 && actualPosition > 36 || actualPosition > 32 && actualPosition < 36 || actualPosition == 0)
                    {
                        GoTo(640, 30);
                        actualPosition = 36;
                    }
                    else if (actualPosition < 33 && actualPosition > 25)
                    {
                        GoTo(1410, 30);
                        actualPosition = 33;
                    }
                    else if (actualPosition < 26 && actualPosition > 19)
                    {
                        GoTo(1180, 30);
                        actualPosition = 34;
                    }
                    else if (actualPosition < 20 && actualPosition > 14)
                    {
                        GoTo(930, 30);
                        actualPosition = 35;
                    }
                    else if (actualPosition < 15 && actualPosition > 9)
                    {
                        GoTo(640, 30);
                        actualPosition = 36;
                    }
                    else if (actualPosition < 10 && actualPosition > 4)
                    {
                        GoTo(340, 30);
                        actualPosition = 37;
                    }
                    else if (actualPosition < 5 && actualPosition > 0)
                    {
                        GoTo(10, 30);
                        actualPosition = 38;
                    }
                }

                //////////
                ///

                if (this.targetTable < 10 && this.targetTable > 4)
                {
                    if (actualPosition < 10 && actualPosition > 4 || actualPosition == 37)
                    {
                        if (this.targetTable == 5)
                        {
                            GoTo(340, 100);
                            actualPosition = 5;
                            this.isGoingToTable = false;
                            this.targetTable = -1;
                        }
                        else if (this.targetTable == 6)
                        {
                            GoTo(340, 230);
                            actualPosition = 6;
                            this.isGoingToTable = false;
                            this.targetTable = -1;
                        }
                        else if (this.targetTable == 7)
                        {
                            GoTo(340, 360);
                            actualPosition = 7;
                            this.isGoingToTable = false;
                            this.targetTable = -1;
                        }
                        else if (this.targetTable == 8)
                        {
                            GoTo(340, 490);
                            actualPosition = 8;
                            this.isGoingToTable = false;
                            this.targetTable = -1;
                        }
                        else if (this.targetTable == 9)
                        {
                            GoTo(340, 620);
                            actualPosition = 9;
                            this.isGoingToTable = false;
                            this.targetTable = -1;
                        }
                    }
                    else if (actualPosition == 38 || actualPosition < 37 && actualPosition > 32 || actualPosition == 0)
                    {
                        GoTo(340, 30);
                        actualPosition = 37;
                    }
                    else if (actualPosition < 33 && actualPosition > 25)
                    {
                        GoTo(1410, 30);
                        actualPosition = 33;
                    }
                    else if (actualPosition < 26 && actualPosition > 19)
                    {
                        GoTo(1180, 30);
                        actualPosition = 34;
                    }
                    else if (actualPosition < 20 && actualPosition > 14)
                    {
                        GoTo(930, 30);
                        actualPosition = 35;
                    }
                    else if (actualPosition < 15 && actualPosition > 9)
                    {
                        GoTo(640, 30);
                        actualPosition = 36;
                    }
                    else if (actualPosition < 5 && actualPosition > 0)
                    {
                        GoTo(10, 30);
                        actualPosition = 38;
                    }
                }

                /////////
                ///

                if (this.targetTable < 5 && this.targetTable > 0)
                {
                    if (actualPosition < 5 && actualPosition > 0 || actualPosition == 38)
                    {
                        if (this.targetTable == 1)
                        {
                            GoTo(10, 310);
                            actualPosition = 1;
                            this.isGoingToTable = false;
                            this.targetTable = -1;
                        }
                        else if (this.targetTable == 2)
                        {
                            GoTo(10, 430);
                            actualPosition = 2;
                            this.isGoingToTable = false;
                            this.targetTable = -1;
                        }
                        else if (this.targetTable == 3)
                        {
                            GoTo(10, 560);
                            actualPosition = 3;
                            this.isGoingToTable = false;
                            this.targetTable = -1;
                        }
                        else if (this.targetTable == 4)
                        {
                            GoTo(10, 690);
                            actualPosition = 4;
                            this.isGoingToTable = false;
                            this.targetTable = -1;
                        }
                    }
                    else if (actualPosition < 38 && actualPosition > 32 || actualPosition == 0)
                    {
                        GoTo(10, 30);
                        actualPosition = 38;
                    }
                    else if (actualPosition < 33 && actualPosition > 25)
                    {
                        GoTo(1410, 30);
                        actualPosition = 33;
                    }
                    else if (actualPosition < 26 && actualPosition > 19)
                    {
                        GoTo(1180, 30);
                        actualPosition = 34;
                    }
                    else if (actualPosition < 20 && actualPosition > 14)
                    {
                        GoTo(930, 30);
                        actualPosition = 35;
                    }
                    else if (actualPosition < 15 && actualPosition > 9)
                    {
                        GoTo(640, 30);
                        actualPosition = 36;
                    }
                }
            }
        }

        public void Sit(Table table)
        {
            if (!this.moving)
            {
                int counter = 0;
                while (!table.chairsList[counter].Available)
                {
                    counter++;
                }
                table.chairsList[counter].Available = false;
                this.speed = 1;
                this.GoTo(table.chairsList[counter].rectangle().X-10, table.chairsList[counter].rectangle().Y-25);

            }
        }

        public void returnToExchange()
        {
            if (!this.moving)
            {
                this.speed = 10;

                isTakingPlate = true;
                if (actualPosition < 33 && actualPosition > 25)
                {
                    GoTo(1410, 30);
                    actualPosition = 33;
                }
                else if (actualPosition < 26 && actualPosition > 19)
                {
                    GoTo(1180, 30);
                    actualPosition = 34;
                }
                else if (actualPosition < 20 && actualPosition > 14)
                {
                    GoTo(930, 30);
                    actualPosition = 35;
                }
                else if (actualPosition < 15 && actualPosition > 9)
                {
                    GoTo(640, 30);
                    actualPosition = 36;
                }
                else if (actualPosition < 10 && actualPosition > 4)
                {
                    GoTo(340, 30);
                    actualPosition = 37;
                }
                else if (actualPosition < 5 && actualPosition > 0)
                {
                    GoTo(10, 30);
                    actualPosition = 38;
                }
                else if (actualPosition < 39 && actualPosition > 32)
                {
                    GoTo(150, 0);
                    actualPosition = 0;
                    isTakingPlate = false;
                }
                else
                {
                    GoTo(150, 0);
                    actualPosition = 0;
                    isTakingPlate = false;
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
            if (userInput.IsKeyDown(Keys.W))
            {
                this.hitbox.Y--;
            }
            if (userInput.IsKeyDown(Keys.P))
            {
                int tab = random.Next(1, 32);
                goToTable(tab);
                oldPosition = targetTable;
            }
            if (userInput.IsKeyDown(Keys.L))
            {
                returnToExchange();
            }
            if (isTakingPlate) // Way to exchange area
            {
                returnToExchange();
            }
            else if (isGoingToTable) // Way to table
            {
                goToTable(this.targetTable);
            }

            if (actualPosition == this.oldPosition)
            {
                this.oldPosition = -1;
                RessourcesManager.Sounds["checked"].Play();
            }

            base.Update(userInput, gametime);
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            base.Draw(spriteBatch);
        }
    }
}
