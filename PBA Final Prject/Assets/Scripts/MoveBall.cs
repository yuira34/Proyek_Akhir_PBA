using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBall : MonoBehaviour
{
    public Vector3 zAccel, xAccel, yAccel;
    public float speedLimit;
    public bool buttonpressed;
    Rigidbody rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (rigidbody.velocity.magnitude < speedLimit)
        {
            if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
            {
                rigidbody.velocity += Input.GetAxis("Vertical") * zAccel * Time.deltaTime + Input.GetAxis("Horizontal") * xAccel * Time.deltaTime;
            }
        }
        rigidbody.velocity += new Vector3(0, Input.GetAxis("Jump") * 5, 0);
    }
}
