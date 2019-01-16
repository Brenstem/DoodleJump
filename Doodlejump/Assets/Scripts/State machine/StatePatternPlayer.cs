using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatePatternPlayer : MonoBehaviour
{
    public float jumpBoostAmount;
    public float jumpTimerLength;
    public float helicopterLength;
    public float helicopterSpeed;
    public float shootLength;

    [HideInInspector] public IPowerupState currentState;
    [HideInInspector] public JumpBoost jumpBoost;
    [HideInInspector] public Helicopter helicopter;
    [HideInInspector] public NormalState normalState;
    [HideInInspector] public Shoot shootState;

    private void Awake()
    {
        helicopter = new Helicopter(this);
        jumpBoost = new JumpBoost(this);
        normalState = new NormalState(this);
        shootState = new Shoot(this);
    }

    private void Start()
    {
        currentState = normalState;
    }

    private void Update()
    {
        currentState.PowerupEffect();
    }

    public void ChangeState(IPowerupState state)
    {
        if (state != currentState)
        {
            currentState.Exit();
            currentState = state;
            currentState.Enter();
        }
        else
        {
            Debug.Log("Can't transition to current state");
        }
    }
}
