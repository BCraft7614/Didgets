﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Input;


namespace BPA__Game
{
    public class Entity
    {

        public Vector2 position;
        public Vector2 oldPosition;
        protected Texture2D image;
        protected Texture2D attackimage;
        protected ContentManager content;
        public int Width { get; set; }
        public int Height { get; set; }
        public virtual void UnloadContent()
        {
            
        }
        //For Enemies and players
        public Entity()
        {

        }
        public Entity(Texture2D image , Vector2 position )
        {

        }
        //for trigger rectangles
        public Entity(int X, int Y, int width, int height)
        {
            position = new Vector2(X,Y);
            Width = width;
            Height = height;
        }
        public virtual void Update(GameTime gameTime)
        {

        }

        public virtual void Draw(SpriteBatch spriteBatch)
        {
            
        }

        public virtual void Initialize()
        {

        }
        public virtual void LoadContent(ContentManager content)
        {
            this.content = new ContentManager(content.ServiceProvider, "Content");
        }

        /// <summary>
        /// Checks if an entity is colliding with a building 
        /// </summary>
        /// <param name="OtherEntity"></param>
        /// <returns></returns>
        public bool Collision(Entity OtherEntity)
        {
            Rectangle boundingBox = new Rectangle((int)position.X, (int)position.Y, Width, Height);
            Rectangle boundingBox2 = new Rectangle((int)OtherEntity.position.X, (int)OtherEntity.position.Y, OtherEntity.Width, OtherEntity.Height);
            return boundingBox.Intersects(boundingBox2);
        }
    }
}
