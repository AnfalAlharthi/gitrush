using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 5f; // ���� ������
    public float flyForce = 5f; // ��� �������
    public float gravityForce = 9.8f; // ��� ��������
    public Animator anim;

    private Rigidbody rb;
    private bool isGrounded = true; // ���� ��� ��� ��� ������ ��� �����

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.useGravity = false; // ����� �������� ������ ��������
    }

    private void Update()
    {  float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

          anim.SetFloat("horizontalWalking", moveHorizontal);
        anim.SetFloat("verticalMovement", moveVertical);
        Vector3 movement = new Vector3(moveHorizontal, 0f, moveVertical); // ����� ������ ������
        rb.AddForce(movement * speed);
        Vector3 direction = new Vector3(rb.velocity.x, 0f, rb.velocity.z); // ������
        rb.MoveRotation(Quaternion.LookRotation(direction));

        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * flyForce);
            isGrounded = false; // ��� ��� ������ �� �����
        }

        if (Input.GetKey(KeyCode.DownArrow) && !isGrounded)
        {
            rb.AddForce(Vector3.down * gravityForce);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true; // ��� ����� ������ ��� ����� ��� �������� ������

        }
     
    }
}