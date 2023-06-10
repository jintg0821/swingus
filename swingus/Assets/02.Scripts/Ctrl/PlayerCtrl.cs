using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour
{
    public float speed = 10.0f;
    public float rotateSpeed = 10.0f;
    public float jump = 10.0f;
    bool isJumping = false;

    float h, v;

    public AudioSource poopSfx;
    public AudioSource itemSfx;

    private Rigidbody rb;
    private new AudioSource audio;

    void Start()
    {
        audio = GetComponent<AudioSource>();
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");

        Vector3 dir = new Vector3(h, 0, v); // new Vector3(h, 0, v)�� ���� ���̰� �Ǿ����Ƿ� dir�̶�� ������ �ְ� ���� ���ϰ� ����� �� �ְ� ��

        // �ٶ󺸴� �������� ȸ�� �� �ٽ� ������ �ٶ󺸴� ������ ���� ���� ����
        if (!(h == 0 && v == 0))
        {
            // �̵��� ȸ���� �Բ� ó��
            transform.position += dir * speed * Time.deltaTime;
            // ȸ���ϴ� �κ�. Point 1.
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(dir), Time.deltaTime * rotateSpeed);
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Poop")
        {
            poopSfx.Play();
        }

        if (other.tag == "Item")
        {
            itemSfx.Play();
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
