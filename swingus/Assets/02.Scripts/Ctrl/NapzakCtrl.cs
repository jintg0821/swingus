using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NapzakCtrl : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        rb.velocity = new Vector3(0f, -speed, 0f);

        if (this.transform.position.y <= -2)
        {
            Destroy(this.gameObject);
        }

        transform.Rotate(new Vector3(0, 400, 0) * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("Napzak");
            Destroy(gameObject);
        }

        if (other.tag == "Ground")
        {
            Destroy(gameObject);
        }
    }
}