using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalState : IPowerupState
{
    private readonly StatePatternPlayer player;

    public NormalState(StatePatternPlayer p)
    {
        player = p;
    }

    public void Enter()
    {
    }

    public void Exit()
    {
    }

    public void PowerupEffect()
    {
    }
}
