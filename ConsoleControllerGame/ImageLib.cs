//Contains most images and textures in the game

public static class ImageLib
{
    // public static Image = Raylib.LoadImage("HeroSprites/Hero.png");

    //The ones that get used a lot will be loaded directly in "final form" 
    public static Texture2D BossSprite = Raylib.LoadTexture("Textures/BossSprite.png");
    public static Texture2D PlayerSprite = Raylib.LoadTexture("HeroSprites/Hero.png");

}
