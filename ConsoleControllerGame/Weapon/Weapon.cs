public abstract class Weapon
{
    public int Damage { get; set; }
    public int SwitchCooldown { get; set; }
    public Image WeaponSprite { get; set; }

    public virtual void Draw()
    {

    }

    public virtual void UseAnimation()
    {

    }
}
