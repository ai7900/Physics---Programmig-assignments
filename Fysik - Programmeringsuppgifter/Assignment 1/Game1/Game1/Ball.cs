using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Game1
{
    class Ball
    {
        const float gravity = 0.1f;

        Vector2 initVelocity, velocity;
        Vector2 initPos, pos;
        float radius;

        Rectangle srcRec;
        Rectangle destrec;

        float time;

        public Ball(Vector2 initVelocity, Vector2 velocity, Vector2 initPos, Vector2 pos, float radius)
        {
            this.initPos        = initPos;
            this.pos            = pos;
            this.initVelocity   = initVelocity;
            this.velocity       = velocity;
            this.radius         = radius;

            srcRec = new Rectangle(0, 0, AssetManager.ballTex.Width, AssetManager.ballTex.Height);

            //srcRec = new Rectangle((Point)(initPos * Conversion.Scale), new Point((int)radius * 2, (int)radius * 2));
        }

        public void Update(GameTime gametime)
        {
            time = (float)gametime.ElapsedGameTime.TotalSeconds;
            // pos dtx = initPos.x + initVelocity.x * time
            // pos dty = initPos.y - time(((gravity * time) / 2) + initVelocity.y * time)
            //gametime.ElapsedGameTime.TotalSeconds;

            // Flip y-axis: y' = ymax - y;
            //pos.Y = pos.Y < Conversion.ScreenSize.Y - radius ? (Conversion.ScreenSize.Y - radius) - (float)(initPos.Y - gametime.ElapsedGameTime.TotalSeconds * ((-gravity * gametime.ElapsedGameTime.TotalSeconds) / 2) + initVelocity.Y) : Conversion.ScreenSize.Y - radius;
            //pos.X = pos.X < Conversion.ScreenSize.X - radius ? (float)(initPos.X + initVelocity.X * gametime.ElapsedGameTime.TotalSeconds) : Conversion.ScreenSize.X - radius;  //Kan också ändra riktning på velocity.

            pos.Y = pos.Y < Conversion.ScreenSize.Y - radius ? initPos.Y - ((gravity * (float)Math.Pow(time, 2) / 2)) + initVelocity.Y * time : Conversion.ScreenSize.Y - radius;
            pos.X = pos.X < Conversion.ScreenSize.X - radius ? initPos.X + initVelocity.X * time : Conversion.ScreenSize.X - radius;

            //destrec = new Rectangle((int)(pos.X * Conversion.Scale.X), (int)(pos.Y * Conversion.Scale.Y * -1), (int)(radius * Conversion.Scale.X), (int)(radius * Conversion.Scale.Y * -1));

        }

        public void Draw(SpriteBatch spriteBatch)
        {
            destrec = new Rectangle((int)(pos.X * Conversion.Scale.X), (int)(Conversion.ScreenSize.Y - pos.Y * 10), (int)radius * 10, (int)radius * -10);

            spriteBatch.Draw(AssetManager.ballTex, destrec, srcRec, Color.Blue);
            //spriteBatch.Draw(AssetManager.ballTex, Conversion.Scale * initPos, srcRec, Color.Blue);
            //spriteBatch.Draw(AssetManager.ballTex, pos, Color.Red);
            //spriteBatch.Draw(AssetManager.ballTex, , Color.Red);
            //Don't forget to use Conversion.scale when converting to meters
        }

    }

}
