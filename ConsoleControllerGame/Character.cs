using System;

namespace ConsoleControllerGame;

public class Character
{
    public int Hp { get; set; }
    public Vector2 Pos { get; set; }
    public int Speed { get; set; }
    public Image Sprite { get; set; }


    public virtual bool ShouldTakeDamage()
    {
        return false;
    }

    public int TakeDamage(int Damage)
    {
        Hp -= Damage;
        return Hp;
    }

    public virtual Vector2 Movement()
    {
        Vector2 tempVector2 = new(0,0);

        return tempVector2;
    }

    public virtual Vector2 SetSpawnPoint()
    {
        Vector2 tempVector2 = new(0,0);

        return tempVector2;
    }
}



