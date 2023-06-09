using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour
{
    public float speed = 10f;
    public float jump = 10f;
    bool isJumping = false;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, -speed *10* Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, speed *10* Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, 0, speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, 0, -speed * Time.deltaTime);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (isJumping == false)
            {
                isJumping = true;
                GetComponent<Rigidbody>().AddForce(Vector3.up * jump, ForceMode.Impulse);
            }
        }
    }
    void OnCollisionEnter(Collision col)
    {
        if (col.transform.name == "Ground")
        {
            isJumping = false;
        }
    } 
}
