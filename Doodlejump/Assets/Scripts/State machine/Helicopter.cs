using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helicopter: IPowerupState
{
    private readonly StatePatternPlayer player;
    private float powerupTimer;
    private Rigidbody2D rb;

    public Helicopter(StatePatternPlayer p)
    {
        player = p;
    }

    public void Enter()
    {
        rb = player.GetComponent<Rigidbody2D>();
        powerupTimer = 0;
    }

    public void Exit()
    {
        player.ChangeState(player.normalState);
    }

    public void PowerupEffect()
    {
        powerupTimer += Time.deltaTime;

        rb.velocity = new Vector2(rb.velocity.x, player.helicopterSpeed);

        if (powerupTimer > player.helicopterLength)
        {
            Exit();
        }
    }
}
