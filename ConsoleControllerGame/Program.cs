global using System;
global using System.Numerics;
global using Raylib_cs;
global using R = Raylib_cs.Raylib;

R.InitWindow(1600, 800, "JumpMaster");
R.SetTargetFPS(60);



while (!R.WindowShouldClose())
{
    R.BeginDrawing();

    R.ClearBackground(Color.WHITE);

    R.EndMode2D();
    R.EndDrawing();
}

// Console.WriteLine(Raylib.GetGamepadAxisMovement(0, GamepadAxis.GAMEPAD_AXIS_LEFT_X))
