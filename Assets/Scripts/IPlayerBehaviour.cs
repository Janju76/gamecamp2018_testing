using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IPlayerBehaviour
{
    void ShowPlayerHit(int newScore);
    void PlayDamageSound();
    void UpdateGUI();	
}
