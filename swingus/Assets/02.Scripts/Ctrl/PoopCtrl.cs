using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoopCtrl : MonoBehaviour
{
    public float speed = 5f;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector3(0f, -speed, 0f);

        if (this.transform.position.y<= -2)
        {
            Destroy(this.gameObject);
        }

        transform.Rotate(new Vector3(0, 400, 0) * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("hit");
            HPManager.hp -= 1;  
            Destroy(gameObject);
        }

        if (other.tag == "Ground")
        {  
            Destroy(gameObject);
        }
    }
}
