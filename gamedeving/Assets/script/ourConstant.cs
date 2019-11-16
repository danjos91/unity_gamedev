using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ourConstant : MonoBehaviour
{
    public float force = 10f;
    public float jumpForce = 300f;

    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
       //Debug.Log("Start"); 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(Vector3.forward * force); 
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(Vector3.left * force); 
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(Vector3.back * force); 
        } 
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(Vector3.right * force); 
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * jumpForce); 
        }
    }
}
