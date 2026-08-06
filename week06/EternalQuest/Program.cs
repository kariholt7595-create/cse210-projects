using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        manager.Start();
    }
}

// Creativity:
// I added a level system to make the Eternal Quest feel more like a game.
// As the player earns more points, they level up from Beginner to 
// Intermediate, and Expert. The current level is displayed whenever
// the player's total points are shown.