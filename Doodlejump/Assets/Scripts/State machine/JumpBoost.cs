using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpBoost : IPowerupState
{
    private readonly StatePatternPlayer player;
    private float powerupTimer;

    public JumpBoost(StatePatternPlayer p)
    {
        player = p;
    }

    public void Enter()
    {
        player.GetComponent<MoveController>().bounceForce += player.jumpBoostAmount;
        powerupTimer = 0;
    }

    public void Exit()
    {
        player.ChangeState(player.normalState);
        player.GetComponent<MoveController>().bounceForce -= player.jumpBoostAmount;
    }

    public void PowerupEffect()
    {
        powerupTimer += Time.deltaTime;

        if (powerupTimer > player.jumpTimerLength)
        {
            Exit();
        }
    }
}
