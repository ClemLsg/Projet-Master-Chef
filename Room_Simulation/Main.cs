using System.Threading;
using Kitchen_Simulation;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Room_Simulation.Views;

namespace Room_Simulation
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Main : Game
    {
        //FIELDS
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        Simulation simulation;
        KeyboardState oldKeyBoard; // Old keyboard state, used by the UserInput to detect state modification
        MouseState oldMouse; // Old mouse state, used by the UserInput to detect state modification
        Sleeper sleeper;

        public Main()
        {
            graphics = new GraphicsDeviceManager(this);

            //CONFIGURATION : Of the Monogame window
            graphics.PreferredBackBufferWidth = 1600;
            graphics.PreferredBackBufferHeight = 800;
            this.IsMouseVisible = true;
            graphics.IsFullScreen = false; // C'est degeux en fullscreen mdr, touchez pas a ca XD

            //POINTING Content to ressources folder
            Content.RootDirectory = "Content";
            
            sleeper = new Sleeper();
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
            simulation = new Simulation(); // Initialising the simulation
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            // Loading the ressources
            RessourcesManager ressources = new RessourcesManager();
            ressources.LoadGraphics(Content);
            ressources.LoadSounds(Content);
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            if(!this.IsActive)
                Thread.Sleep(100);
            else
            {
                if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                    Exit();

                // TODO: Add your update logic here
                this.simulation.Update(gameTime, new UserInput(this.oldKeyBoard, this.oldMouse, this.oldKeyBoard = Keyboard.GetState(), this.oldMouse = Mouse.GetState()));
                base.Update(gameTime);

                if (Keyboard.GetState().IsKeyDown(Keys.I))
                {
                    this.sleeper.IsPaused = true;
                }
            
                Thread.Sleep(this.sleeper.Period);              
            }
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.DarkGray);
            spriteBatch.Begin();
            // TODO: Add your drawing code here
            this.simulation.Draw(this.spriteBatch);
            base.Draw(gameTime);
            spriteBatch.End();
        }
    }
}
