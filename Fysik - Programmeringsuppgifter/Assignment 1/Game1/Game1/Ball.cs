using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Game1
{
    class Ball
    {
        const float gravity = 9.82f;

        Vector2 initVelocity, dtVelocity;
        Point initPos, dtPos;
        float radius;

        Rectangle srcRec;
        
        public Ball(Vector2 initVelocity, Point initPos, float radius)
        {
            this.initPos        = initPos;
            this.initVelocity   = initVelocity;
            this.radius         = radius;

            srcRec = new Rectangle(initPos, new Point((int)radius * 2, (int)radius * 2));
        }

        public void Update(GameTime gametime)
        {
            // pos dtx = initPos.x + initVelocity.x * time
            // pos dty = initPos.y - time(((gravity * time) / 2) + initVelocity.y)
            gametime.ElapsedGameTime.TotalSeconds;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(AssetManager.ballTex, Conversion.Scale, Color.Red);
            //Don't forget to use Conversion.scale when converting to meters
        }

    }

}
