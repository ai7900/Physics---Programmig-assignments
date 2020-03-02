using Microsoft.Xna.Framework;

namespace Game1
{
    class Conversion
    {
        static public Vector2 ScreenSize { get; } = new Vector2(800, 480);
        static public Vector2 Scale { get; } = new Vector2(10, -10);
        //pixels per meter
        static public Vector2 BottomLeft { get; } = new Vector2(0, 0);
        //position av nedre vänstra hörnet i meter
        static public Vector2 TopRight { get; } = new Vector2(ScreenSize.X / Scale.X, ScreenSize.Y / Scale.Y);
        //position av övre högra hörnet i meter
        static public Vector2 PosToPixel(Vector2 posInMeter)
        {
            Vector2 temp = new Vector2(posInMeter.X * Scale.X, posInMeter.Y * Scale.Y + ScreenSize.Y);
            return temp;


        }
    }
}
