using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;

public class Control : MonoBehaviour
{
    public float spped = 5;
    public Rigidbody rb;

    float HorizontalInput;

    private void FixedUpdate()
    {
        Vector3 forwardMove=transform.forward*spped*Time.fixedDeltaTime;
        Vector3 horizontalmove=transform.right*HorizontalInput*spped*Time.fixedDeltaTime;
        rb.MovePosition(rb.position + forwardMove+horizontalmove);
    }
    // Update is called once per frame
    void Update()
    {
        HorizontalInput = Input.GetAxis("Horizontal");
    }
}
