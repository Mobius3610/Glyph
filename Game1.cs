using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Glyph
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        Texture2D layerZero;
        Texture2D screenFrame;
        Texture2D blackMage;

        Vector2 blackMagePosition = new Vector2(300, 300);

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        protected override void LoadContent()
        {
            // TODO: use this.Content to load your game content here
            _spriteBatch = new SpriteBatch(GraphicsDevice); // Template code

            layerZero = Content.Load<Texture2D>("Layer_0");
            screenFrame = Content.Load<Texture2D>("Basic_Background_Frame");
            blackMage = Content.Load<Texture2D>("TestChar_Small");
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))// Template code
                Exit();
            else if (GamePad.GetState(PlayerIndex.One).Buttons.LeftStick == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Up))
                blackMagePosition = new Vector2(blackMagePosition.X, blackMagePosition.Y - 32);
            else if (GamePad.GetState(PlayerIndex.One).Buttons.LeftStick == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Down))
                blackMagePosition = new Vector2(blackMagePosition.X, blackMagePosition.Y + 32);
            else if (GamePad.GetState(PlayerIndex.One).Buttons.LeftStick == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Left))
                blackMagePosition = new Vector2(blackMagePosition.X - 32, blackMagePosition.Y);
            else if (GamePad.GetState(PlayerIndex.One).Buttons.LeftStick == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Right))
                blackMagePosition = new Vector2(blackMagePosition.X + 32, blackMagePosition.Y);
                
                // TODO: Add your update logic here

                base.Update(gameTime); 
        }

        protected override void Draw(GameTime gameTime)
        {
            // TODO: Add your drawing code here
            //GraphicsDevice.Clear(Color.CornflowerBlue);

            _spriteBatch.Begin();
            _spriteBatch.Draw(layerZero, new Vector2(0, 0), Color.White);
            _spriteBatch.Draw(screenFrame, new Vector2(0, 0), Color.White);
            _spriteBatch.Draw(blackMage, blackMagePosition, Color.White);
            _spriteBatch.End();


            base.Draw(gameTime);
        }
    }
}
