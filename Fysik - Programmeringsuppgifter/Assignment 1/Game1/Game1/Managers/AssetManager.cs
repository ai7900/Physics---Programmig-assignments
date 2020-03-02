using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace Game1
{
    //Allt som laddas in via Contet.load hämtas härifrån
    public static class AssetManager
    {
        public static Texture2D ballTex;

        public static void LoadContent(ContentManager Content)
        {
            ballTex = Content.Load<Texture2D>("ball");
        }
    }


}
