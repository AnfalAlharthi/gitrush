using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 5f; // ÓÑÚÉ ÇáÍÑßÉ
    public float flyForce = 5f; // ŞæÉ ÇáØíÑÇä
    public float gravityForce = 9.8f; // ŞæÉ ÇáÌÇĞÈíÉ
    public Animator anim;

    private Rigidbody rb;
    private bool isGrounded = true; // ÊÍŞŞ ããÇ ÅĞÇ ßÇä ÇááÇÚÈ Úáì ÇáÃÑÖ

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.useGravity = false; // ÊÚØíá ÇáÌÇĞÈíÉ ááÓãÇÍ ÈÇáØíÑÇä
    }

    private void Update()
    {  float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

          anim.SetFloat("horizontalWalking", moveHorizontal);
        anim.SetFloat("verticalMovement", moveVertical);
        Vector3 movement = new Vector3(moveHorizontal, 0f, moveVertical); // ÊÚÏíá ÇáãÍæÑ ÇáÃİŞí
        rb.AddForce(movement * speed);
        Vector3 direction = new Vector3(rb.velocity.x, 0f, rb.velocity.z); // ÑæÊíÔä
        rb.MoveRotation(Quaternion.LookRotation(direction));

        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * flyForce);
            isGrounded = false; // íÊã ÑİÚ ÇááÇÚÈ Úä ÇáÃÑÖ
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
            isGrounded = true; // íÊã ÊÚííä ÇááÇÚÈ Úáì ÇáÃÑÖ ÚäÏ ÇáÇÕØÏÇã ÈÇáÃÑÖ

        }
     
    }
}