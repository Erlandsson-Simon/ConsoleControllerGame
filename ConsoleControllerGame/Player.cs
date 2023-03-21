public class Player : Character
{
    public string whereToStart { get; set; } = "south";

    public Player()
    {
        SetSpawnPoint();
        rect = new(StartingPos.X, StartingPos.Y, 50, 50);
        Speed = 10f;
    }

    public override void Update()
    {
        Movement();
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
        movement //math abs
    }

    // public override bool ShouldTakeDamage()
    // {
    //     return false;
    // }
}
