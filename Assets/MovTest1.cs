using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovTest1 : MonoBehaviour
{
    public float movementSpeed = 5f;
    public float flyingSpeed = 10f;
    public float flyingForce = 5f;

    private Rigidbody rb;
    private bool isFlying = false;
    public Animator animator; // �� ������ ������� ���������� ���� �������


    private void Start()
    {
        rb = GetComponent<Rigidbody>();

    }

    private void Update()
    {
        // ����� ������ ��� ������ ������
        float horizontalMovement = Input.GetAxis("Horizontal");
        float verticalMovement = Input.GetAxis("Vertical");
        animator.SetBool("run", verticalMovement > 0);
        Vector3 movement = new Vector3(horizontalMovement, 0, verticalMovement) * movementSpeed * Time.deltaTime;
        transform.Translate(movement);
        transform.Rotate(movement);
        // Vector3 direction = new Vector3(rb.velocity.x, 0f, rb.velocity.z); // ������
        // rb.MoveRotation(Quaternion.LookRotation(direction));
        //rb.MoveRotation(Quaternion.LookRotation(rb.velocity));

        // ������ �� �������
        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetBool("IsFlying", true);
            if (!isFlying)
            {
                rb.useGravity = false;
                rb.AddForce(transform.up * flyingForce, ForceMode.Impulse);
                isFlying = true;


                // ����� ������� �������
                animator.SetBool("IsFlying", false);

            }
            else
            {
                rb.useGravity = true;
                isFlying = false;
            }
        }

        // ����� ������ ����� �������
        if (isFlying)
        {
            float flyingHorizontalMovement = Input.GetAxis("Horizontal");
            float flyingVerticalMovement = Input.GetAxis("Vertical");
            Vector3 flyingMovement = new Vector3(flyingHorizontalMovement, 0, flyingVerticalMovement) * flyingSpeed * Time.deltaTime;
            transform.Translate(flyingMovement);
        }
    }

}
