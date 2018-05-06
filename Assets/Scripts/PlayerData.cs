using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IPlayerData
{
    int HP { get; set; }
}

public class PlayerData : IPlayerData{
    
    public int HP
    {
        get;

        set;
    }
}
