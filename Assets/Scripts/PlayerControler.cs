using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler
{
    IPlayerBehaviour view;
    IPlayerData data;

    public PlayerControler(IPlayerBehaviour view, IPlayerData data)
    {
        this.view = view;
        this.data = data;
    }

    internal void DoDamage()
    {
        // logic
        data.HP -= 10;

        view.ShowPlayerHit(data.HP);
        view.UpdateGUI();
    }
}

public class CtrlTest
{
    public void TestDoDamage()
    {
        // AAA = Arrange - Act - Assert
        MockData data = new MockData();
        PlayerControler cut = new PlayerControler(new MockView(), data);

        cut.DoDamage(20);

        if (data.HP != 0)
            throw new Exception();
    }

    class MockView : IPlayerBehaviour
    {
        public void PlayDamageSound()
        {
        }

        public void ShowPlayerHit(int newScore)
        {
        }

        public void UpdateGUI()
        {
        }
    }

    class MockData : IPlayerData
    {
        public int HP
        {
            get;

            set;
        }
    }
}

