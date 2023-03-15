public class Player : Character
{

    public Player()
    {
        rect = new(StartingPos.X, StartingPos.Y, 50, 50);
        Speed = 5f;
    }

    public override void Draw()
    {
        R.DrawRectangleRec(rect, Color.BLUE);
        R.DrawRectangleLinesEx(rect, 3, Color.BLACK);
    }

    public override void Update()
    {
        base.Update();
        Movement();
    }

    public override void Movement()
    {
        movement.X = Speed * Raylib.GetGamepadAxisMovement(0, GamepadAxis.GAMEPAD_AXIS_LEFT_X);
        movement.Y = Speed * Raylib.GetGamepadAxisMovement(0, GamepadAxis.GAMEPAD_AXIS_LEFT_Y);
    }

    // public override void SetSpawnPoint()
    // {

    // }

    // public override bool ShouldTakeDamage()
    // {
    //     return false;
    // }
}
