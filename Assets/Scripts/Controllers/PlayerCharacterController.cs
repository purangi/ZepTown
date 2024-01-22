using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacterController : MonoBehaviour
{
    //event 외부에서는 호출하지 못하게 막는다.
    public event Action<Vector2> OnMoveEvent;
    public event Action<Vector2> OnLookEvent;
    public event Action OnAttackEvent;

    protected virtual void Awake()
    {

    }
    protected virtual void Update()
    {

    }
    public void CallAttackEvent()
    {
        OnAttackEvent?.Invoke();
    }

    public void CallMoveEvent(Vector2 direction)
    {
        OnMoveEvent?.Invoke(direction);
    }

    public void CallLookEvent(Vector2 direction)
    {
        OnLookEvent?.Invoke(direction);
    }
}
