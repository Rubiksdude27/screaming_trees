using RaftModLoader;
﻿using UnityEngine;
using HMLLibrary;

public class screaming_trees : Mod
{
    public void Start()
    {
        Debug.Log("Mod screaming_trees has been loaded!");
    }

    public void OnModUnload()
    {
        Debug.Log("Mod screaming_trees has been unloaded!");
    }
    void WorldEvent_WorldLoaded()
    {
        Debug.Log("Fuck You in a nice way");
    }
}