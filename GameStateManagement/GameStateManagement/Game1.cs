using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;

namespace GameStateManagement
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager _graphics;

        ScreenManager screenManager;

        public static String GameName = "Honeycomb Rush";

        public Game1()
        {
            // Initialize sound system
            AudioManager.Initialize(this);

            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";

            screenManager = new ScreenManager(this, Vector2.One);
            screenManager.AddScreen(new BackgroundScreen("titleScreen"), null);
            screenManager.AddScreen(new MainMenuScreen(), PlayerIndex.One);
            Components.Add(screenManager);
        }
    }
}
