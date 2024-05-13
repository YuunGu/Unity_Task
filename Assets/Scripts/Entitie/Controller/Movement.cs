using System;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Controller controller;
    private Rigidbody2D movementRigidbody;

    private Vector2 movementDirection = Vector2.zero;

    private void Awake()
    {
        controller = GetComponent<Controller>();
        movementRigidbody = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        controller.OnMoveEvent +=  Move;
    }

    private void FixedUpdate()
    {
        ApplyMovement(movementDirection);
    }


    private void Move(Vector2 direction)
    {
        movementDirection = direction * 5;
    }
    private void ApplyMovement(Vector2 direction)
    {
        direction = direction * 5;
        movementRigidbody.velocity = direction;
    }
}
