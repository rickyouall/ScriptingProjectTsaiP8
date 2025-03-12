using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseClick : MonoBehaviour
{
    private Rigidbody rb;
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void OnMouseDown()
    {
        rb.AddForce(-transform.forward * 1000f);

        rb.useGravity = true;
    }
}
