using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Game1
{
    class Ball
    {
        const float gravity = 9.82f;

        Vector2 initVelocity, velocity;
        Vector2 initPos, pos;
        float radius;

        Rectangle srcRec = new Rectangle(0,0,10,10);
        Rectangle destrec;



        public Ball(Vector2 initVelocity, Vector2 velocity, Vector2 initPos, Vector2 pos, float radius)
        {
            this.initPos        = initPos;
            this.pos            = pos;
            this.initVelocity   = initVelocity;
            this.velocity       = velocity;
            this.radius         = radius;

            //srcRec = new Rectangle((Point)(initPos * Conversion.Scale), new Point((int)radius * 2, (int)radius * 2));
        }

        public void Update(GameTime gametime)
        {
            destrec = new Rectangle((int)(initPos.X * Conversion.Scale.X), (int)(initPos.Y * Conversion.Scale.Y), (int)(radius * Conversion.Scale.X), (int)(radius * Conversion.Scale.Y));
            // pos dtx = initPos.x + initVelocity.x * time
            // pos dty = initPos.y - time(((gravity * time) / 2) + initVelocity.y)
            //gametime.ElapsedGameTime.TotalSeconds;

            //Use Conversion.TopRight and BottomLeft for wall-collision.
        }

        public void Draw(SpriteBatch spriteBatch)
        {

            spriteBatch.Draw(AssetManager.ballTex, destrec, srcRec, Color.Blue);
            
            //spriteBatch.Draw(AssetManager.ballTex, Conversion.Scale * initPos, srcRec, Color.Blue);
            //spriteBatch.Draw(AssetManager.ballTex, Conversion.Scale * initPos, Color.Red);
            //spriteBatch.Draw(AssetManager.ballTex, , Color.Red);
            //Don't forget to use Conversion.scale when converting to meters
        }

    }

}
