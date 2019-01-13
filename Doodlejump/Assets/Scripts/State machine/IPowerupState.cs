using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IPowerupState
{
    void Enter();

    void PowerupEffect();

    void Exit();
}
