using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatePatternPlayer : MonoBehaviour
{
    public float jumpBoostAmount;
    public float jumpTimerLength;
    public float helicopterLength;
    public float helicopterSpeed;

    [HideInInspector] public IPowerupState currentState;
    [HideInInspector] public JumpBoost jumpBoost;
    [HideInInspector] public Helicopter helicopter;
    [HideInInspector] public NormalState normalState;

    private void Awake()
    {
        helicopter = new Helicopter(this);
        jumpBoost = new JumpBoost(this);
        normalState = new NormalState(this);
    }

    private void Start()
    {
        currentState = normalState;
    }

    private void Update()
    {
        currentState.PowerupEffect();
    }

    // Public function
    public void ChangeState(IPowerupState state)
    {
        if (state != currentState)
        {
            currentState = state;
            currentState.Enter();
        }
        else
        {
            Debug.Log("Can't transition to current state");
        }
    }
}
