public class Player : Character
{
    public string whereToStart { get; set; } = "south";

    public Player()
    {
        SetSpawnPoint();
        rect = new(StartingPos.X, StartingPos.Y, 80, 80);
        Speed = 10f;
        spriteSize = new(80,80);
        spriteSheet = ;
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

    public override void Sprites()
    {
        switch (Facing)
        {
            case "south":
                Sprite = "";
                break;

            case "west":
                Sprite = "";
                break;

            case "east":
                Sprite = "";
                break;

            case "north":
                Sprite = "";
                break;
        }
    }

    // public override bool ShouldTakeDamage()
    // {
    //     return false;
    // }
}
