using RaftModLoader;
﻿using UnityEngine;
using HMLLibrary;

public class screaming_trees : Mod
{
    public void Start()
    {
        Debug.Log("Mod screaming_trees has been loaded!");
        RAPI.GetLocalPlayer().Inventory.AddItem("Raw_Potato", 1);
    }

    public void OnModUnload()
    {
        Debug.Log("Mod screaming_trees has been unloaded!");
    }

}