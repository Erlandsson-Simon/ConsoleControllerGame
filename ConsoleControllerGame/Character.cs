public class Character
{
    public Vector2 StartingPos { get; set; }
    public Rectangle rect;

    public int Hp { get; set; }
    public float Speed { get; set; }
    public Vector2 movement;

    public Image Sprite { get; set; }

    private static List<Character> allCharacters = new();

    public Character()
    {
        allCharacters.Add(this);
    }

    public virtual void Update()
    {
        rect.x += movement.X;
        rect.y += movement.Y;
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

    public virtual void SetSpawnPoint()
    {

    }

    public virtual void Movement()
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



