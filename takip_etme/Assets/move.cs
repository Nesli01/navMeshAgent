using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    float xInput,zInput;
    public float speed;
    public Rigidbody rb;
    void Update()
    {
        xInput = Input.GetAxis("Horizontal");
        zInput = Input.GetAxis("Vertical");
        rb.AddForce(new Vector3(xInput,0,zInput*speed*Time.deltaTime));

        
    }
}
