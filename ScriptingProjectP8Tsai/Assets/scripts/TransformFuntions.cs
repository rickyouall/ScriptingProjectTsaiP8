using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformFuntions : MonoBehaviour
{
    public float moveSpeed = 30f;
    public float turnSpeed = 50f;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * moveSpeed*Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(-Vector3.forward * moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.up, -turnSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up , turnSpeed * Time.deltaTime);
        }
    }
}
