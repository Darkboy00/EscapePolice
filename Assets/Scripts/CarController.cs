using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    public FixedJoystick Joystick;
    Rigidbody2D rb;
    Vector2 move;
    public float moveSpeed;
    public static bool PointerDown = false;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        move.x = Joystick.Horizontal;
        move.y = Joystick.Vertical;

        //rotation
        float hAxis = move.x;
        float vAxis = move.y;
        float zAxis = Mathf.Atan2(hAxis, vAxis) * Mathf.Rad2Deg;
        transform.eulerAngles = new Vector3(0f, 0f, -zAxis);
    }
    void FixedUpdate()
    {
        if(PointerDown)
        {
            rb.linearVelocity = Vector3.zero;
        }
        else
        {
            rb.MovePosition(rb.position + move *  moveSpeed * Time.deltaTime);
        }
    }
}