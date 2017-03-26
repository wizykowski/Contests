﻿using Deadline;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows;

/// <summary>
/// Base for objects in game state (such as drones etc.).
/// </summary>
public abstract class GameStateObject
{
    public GameState Game;
    public int Id;

    public GameStateObject(GameState game, int id)
    {
        Game = game;
        Id = id;
    }
}

public class GameState
{
    public static readonly int LevelNumber = 1;
    public int CaseNumber = 1;

    public GameState()
    {
        //var data = Console.ReadLine().ParseList<int>();
    }
}
