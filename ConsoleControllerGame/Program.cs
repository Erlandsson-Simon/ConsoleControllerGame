global using System;
global using System.Numerics;
global using Raylib_cs;
global using R = Raylib_cs.Raylib;

R.InitWindow(1600, 800, "LegendOfOctane");
R.SetTargetFPS(60);

new Player();

while (!R.WindowShouldClose())
{
    R.BeginDrawing();

    Character.Drawall();

    R.ClearBackground(Color.WHITE);

    R.EndMode2D();
    R.EndDrawing();

    Character.UpdateAll();
    
}