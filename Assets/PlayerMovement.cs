using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
	public float forwardSpeed = 10f;
	public float horzSpeed = 3f;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
		var vel = Vector3.forward * forwardSpeed;
		vel.y = rb.velocity.y;
        if (Input.GetKey(KeyCode.A))
        {
			vel += Vector3.left * horzSpeed;
        }
        if (Input.GetKey(KeyCode.D))
        {
			vel += Vector3.right * horzSpeed;
        }
		rb.velocity = vel;
    }
}
