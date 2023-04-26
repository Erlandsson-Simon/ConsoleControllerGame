public class Player : Character
{
    public Weapon ChosenWeapon { get; set; }

    public string whereToStart { get; set; } = "south";

    public Player()
    {
        SetSpawnPoint();
        rect = new(StartingPos.X, StartingPos.Y, 50, 50);
        Speed = 10f;

        spriteSize = new(50,50);
        spriteSheet = ImageLib.PlayerSprite;
    }

    public override void Update()
    {
        Movement();
        Turning();
        Console.WriteLine(Facing);
        base.Update();
    }

    public override void Draw()
    {
        R.DrawRectangleRec(rect, Color.BLUE);
        R.DrawRectangleLinesEx(rect, 3, Color.BLACK);

        spriteRect = new(spritePos.X, spritePos.Y, spriteSize.X, spriteSize.Y);
        R.DrawTexturePro(spriteSheet, spriteRect, rect, Vector2.Zero, 0, Color.BLACK);
    }

    public override void SetSpawnPoint()
    {
        switch (whereToStart)
        {
            //bottom of the screen
            case "south":
                StartingPos = new(500, 500);
                break;
            //right side of the screen
            case "west":
                StartingPos = new();
                break;
            case "east":
                StartingPos = new();
                break;
            //right side of the screen
            case "north":
                StartingPos = new();
                break;
        }
    }

    public override void Movement()
    {
        movement.X = Speed * Raylib.GetGamepadAxisMovement(0, GamepadAxis.GAMEPAD_AXIS_LEFT_X);
        movement.Y = Speed * Raylib.GetGamepadAxisMovement(0, GamepadAxis.GAMEPAD_AXIS_LEFT_Y);
    }

    public override void Turning()
    {
        base.Turning();
    }

    public override void Sprites()
    {
        switch (Facing)
        {
            case "south":
                spritePos = new(0, 0);
                break;

            case "west":
                spritePos = new(0, 0);
                break;

            case "east":
                spritePos = new(0, 0);
                break;

            case "north":
                spritePos = new(0, 0);
                break;

            case "idle":
                spritePos = new(0, 0);
                break;
        }
    }

    // public override bool ShouldTakeDamage()
    // {
    //     return false;
    // }
}
