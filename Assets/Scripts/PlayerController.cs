using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float speed;
    [SerializeField]
    private float xBorder;

    private Rigidbody rb;
    private Vector2 playerInput;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void Move(InputAction.CallbackContext context)
    {
        playerInput = context.ReadValue<Vector2>();
    }

    private void Update()
    {
        Vector3 position = rb.position;
        position += new Vector3(playerInput.x, 0, 0) * speed * Time.deltaTime;
        if(position.x > xBorder)
        {
            position.x = xBorder;
        }
        else if(position.x < -xBorder)
        {
            position.x = -xBorder;
        }
        rb.MovePosition(position);
    }
}
