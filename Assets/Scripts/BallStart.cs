using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallStart : MonoBehaviour
{
    [SerializeField]
    private float speed;
    [SerializeField]
    private float speedChange;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(Random.insideUnitCircle * speed, ForceMode.VelocityChange);
    }

    private void Update()
    {
        rb.AddForce(rb.velocity.normalized * speedChange * Time.deltaTime, ForceMode.VelocityChange);
    }
}
