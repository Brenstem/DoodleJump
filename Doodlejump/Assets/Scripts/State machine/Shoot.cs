using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : IPowerupState
{
    private readonly StatePatternPlayer player;
    private float timer;

    public Shoot(StatePatternPlayer p)
    {
        player = p;
    }

    public void Enter()
    {
        player.GetComponent<Weapon>().canFire = true;
    }

    public void Exit()
    {
        player.GetComponent<Weapon>().canFire = false;
        timer = 0;
    }

    public void PowerupEffect()
    {
        timer += Time.deltaTime;

        Debug.Log(player.GetComponent<Weapon>().canFire);

        if (timer > player.shootLength)
        {
            player.ChangeState(player.normalState);
        }
    }
}
