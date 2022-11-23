using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpnentController : MonoBehaviour
{
    [SerializeField]
    private float maxSpeed;
    [SerializeField]
    private float xBorder;
    [SerializeField]
    private Transform ball;

    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        Vector3 position = rb.position;
        position.x = Mathf.MoveTowards(rb.position.x, ball.position.x, maxSpeed * Time.deltaTime);
        if (position.x > xBorder)
        {
            position.x = xBorder;
        }
        else if (position.x < -xBorder)
        {
            position.x = -xBorder;
        }
        rb.MovePosition(position);
    }
}
