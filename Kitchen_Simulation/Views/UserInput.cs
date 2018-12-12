using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitchen_Simulation.Views
{
    public class UserInput
    {
        //FIELDS
        private KeyboardState oldKeyBoard;
        private MouseState oldMouse;
        private KeyboardState keyboard;
        private MouseState mouse;


        //CONSTRUCTOR
        public UserInput(KeyboardState oldKeyBoard, MouseState oldMouse, KeyboardState keyboard, MouseState mouse)
        {
            this.oldMouse = oldMouse;
            this.oldKeyBoard = oldKeyBoard;
            this.keyboard = keyboard;
            this.mouse = mouse;
        }

        //GETTER & SETTER

        public Point GetMousePosition() // WHERE IS THE USER MOUSE ?
        {
            return new Point(this.mouse.X, this.mouse.Y);
        }

        public bool IsLetMousePressed() // DOES THE USER LEFT CLIC AND RELEASE ?
        {
            return this.oldMouse.LeftButton == ButtonState.Pressed && this.mouse.LeftButton == ButtonState.Released;
        }

        public bool IsKeyDown(Keys key) // IS THIS KEY DOWN ?
        {
            return this.keyboard.IsKeyDown(key);
        }
    }
}
