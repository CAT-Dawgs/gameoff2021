using System;
using UnityEngine;

[Serializable]
public class SaveData
{
    public string SaveScene
    {
        get;
        set;
    }

    public Vector3 PlayerPos
    {
        get;
        set;
    }

    public string PlayerInventory
    {
        get;
        set;
    }
}