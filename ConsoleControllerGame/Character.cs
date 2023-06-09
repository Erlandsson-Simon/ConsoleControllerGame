public class Character
{
    public Vector2 StartingPos { get; set; }
    public Rectangle rect;

    public int Hp { get; set; }
    public float Speed { get; set; }
    public Vector2 movement;

    public int Sprite { get; set; }
    public static Texture2D spriteSheet;
    public Rectangle spriteRect;
    public Vector2 spritePos;
    public Vector2 spriteSize;
    private static List<Character> allCharacters = new();

    public string Facing { get; set; } = "idle";

    public Character()
    {
        allCharacters.Add(this);
    }

    public virtual void Update()
    {
        rect.x += movement.X;
        rect.y += movement.Y;
        Sprites();
    }

    public virtual void Draw()
    {

    }

    public static void UpdateAll()
    {
        foreach (Character c in allCharacters)
        {
            c.Update();
            Console.WriteLine(c.movement);
        }
    }

    public static void Drawall()
    {
        foreach (Character c in allCharacters)
        {
            c.Draw();
        }
    }

    public virtual void Turning()
    {
        float tempX = movement.X;
        float tempY = movement.Y;

        if (Math.Abs(tempX) > Math.Abs(tempY))
        {
            if (tempX > 0)
            {
                Facing = "east";
            }
            else
            {
                Facing = "west";
            }
        }

        else if (Math.Abs(tempX) < Math.Abs(tempY))

        {
            if (tempY > 0)
            {
                Facing = "south";
            }
            else
            {
                Facing = "north";
            }
        }
    }

    public virtual void SetSpawnPoint()
    {

    }

    public virtual void Movement()
    {

    }

    public virtual void Sprites()
    {

    }



    // public virtual bool ShouldTakeDamage()
    // {
    //     return false;
    // }

    // public int TakeDamage(int Damage)
    // {
    //     Hp -= Damage;
    //     return Hp;
    // }
}



