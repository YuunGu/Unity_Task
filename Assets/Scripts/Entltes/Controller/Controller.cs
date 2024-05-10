using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public event Action<Vector2> OnMoveEvent;
    public event Action<Vector2> OnLookEvent;

    public void CallMove(Vector2 direction)
    {
        OnMoveEvent?.Invoke(direction);
    }

    public void CallLook(Vector2 direction)
    {
        OnLookEvent?.Invoke(direction);
    }
}
