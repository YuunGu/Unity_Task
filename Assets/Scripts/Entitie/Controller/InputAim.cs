using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.XInput;
using UnityEngine.InputSystem.XR;

public class InputAim : MonoBehaviour
{
    private InputController inputController;
    [SerializeField] private SpriteRenderer characterRenderer;
    [SerializeField] private SpriteRenderer characterRenderer2;

    private void Awake()
    {
        inputController = GetComponent<InputController>();
    }

    private void Start()
    {
        inputController.OnLookEvent += OnAim;
    }

    private void OnAim(Vector2 vector)
    {
        characterDirection(vector);
    }

    private void characterDirection(Vector2 vector)
    {
        float rotZ = Mathf.Atan2(vector.y, vector.x) * Mathf.Rad2Deg;
        characterRenderer.flipX = MathF.Abs(rotZ) > 90f;
        characterRenderer2.flipX = MathF.Abs(rotZ) > 90f;
    }
}
