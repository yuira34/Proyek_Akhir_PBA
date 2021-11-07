using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCam : MonoBehaviour
{
    public Vector3 dist, rotation, circPos;
    public GameObject ball;
    // Start is called before the first frame update
    void Start()
    {
        transform.LookAt(ball.transform);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = ball.transform.position + dist;
        transform.LookAt(ball.transform);
    }
}
