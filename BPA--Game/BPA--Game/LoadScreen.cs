﻿using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPA__Game
{
    public class LoadScreen:Screen
    {
        
        mButton btnLoad1;
        mButton btnLoad2;
        mButton btnBack;
        Texture2D background;
       // GraphicsDeviceManager graphics;
        //SpriteBatch spriteBatch;
        //ScreenName nextScreen;
        int screenWidth;
        int screenHeight;
        private bool loadGame;


       
        public LoadScreen()
        {
            screenWidth = 800;
            screenHeight = 700;
            loadGame = false;
           // LoadContent();
            //Initialize();
        }
        public override void LoadContent(ContentManager ContentMgr, GraphicsDeviceManager graphics)
        {
            //spriteBatch = new SpriteBatch(GraphicsDevice);
            graphics.PreferredBackBufferWidth = screenWidth;
            graphics.PreferredBackBufferHeight = screenHeight;
            btnLoad2 = new mButton(ContentMgr.Load<Texture2D>("BtnLoad"), graphics.GraphicsDevice);
            btnLoad1 = new mButton(ContentMgr.Load<Texture2D>("BtnLoad"), graphics.GraphicsDevice);
            btnBack = new mButton(ContentMgr.Load<Texture2D>("BtnBack"), graphics.GraphicsDevice);
            btnLoad2.ButtonClicked += HandleButtonClicked;
            btnLoad1.ButtonClicked += HandleButtonClicked;
            btnBack.ButtonClicked += HandleButtonClicked;
            btnLoad2.setPosition(new Vector2(350, 300));
            btnLoad1.setPosition(new Vector2(350, 300 + btnLoad1.size.Y * 2));
            btnBack.setPosition(new Vector2(350, 300 + btnBack.size.Y * 9));
            //this.IsMouseVisible = true;


        }
        public override void UnloadContent()
        {
            btnLoad2.ButtonClicked -= HandleButtonClicked;
            btnLoad1.ButtonClicked -= HandleButtonClicked;
            btnBack.ButtonClicked -= HandleButtonClicked;

            base.UnloadContent();
        }
        public  override void Update(GameTime gameTime)
        {
            btnLoad2.Update();
            btnLoad1.Update();
            btnBack.Update();

        }
        public override void Draw(SpriteBatch spriteBatch)
        {
            //GraphicsDevice.Clear(Color.CornflowerBlue);
            btnLoad2.Draw(spriteBatch);
            btnLoad1.Draw(spriteBatch);
            btnBack.Draw(spriteBatch);

        }
        public bool GetLoadGame() { return loadGame; }

        public void HandleButtonClicked(object sender, EventArgs eventArgs)
        {
            if (sender == btnLoad1)
            {
                nextScreen = "GameScreen"; //ScreenName.GameScreen;
                loadGame = true;
            }
            else if (sender == btnLoad2)
            {
                nextScreen = "GameScreen"; //ScreenName.GameScreen;
                loadGame = true;
            }
            else if (sender == btnBack)
            {
                nextScreen = "TitleScreen"; //ScreenName.OptionsScreen;
                loadGame = false;
            }
            OnButtonClicked();
        }
        public event EventHandler ButtonClicked;
        public void OnButtonClicked()
        {   
            if (ButtonClicked != null)
            {
                ButtonClicked(this, EventArgs.Empty);
            }
        }
        
    }
}
