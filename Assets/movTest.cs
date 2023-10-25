using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movTest : MonoBehaviour
{
    public float movementSpeed = 5f;
    public float flyingSpeed = 10f;
    public float flyingForce = 5f;
    private Rigidbody rb;
    private bool isFlying = false;
    public Animator animator; // ﬁ„ » ⁄ÌÌ‰ «·„ Õﬂ„ »«·√‰Ì„Ì‘‰ ·Â–« «·„ €Ì—
    //private bool isGrounded = true; //  Õﬁﬁ „„« ≈–« ﬂ«‰ «··«⁄» ⁄·Ï «·√—÷

    private void Start()
    {
        rb = GetComponent<Rigidbody>();

    }

    private void Update()
    {
        //  Õ—Ìﬂ «··«⁄» ≈·Ï «·√„«„ Ê«·Œ·›
        float horzontalmovement = Input.GetAxis("Horizontal");
        float verticalmovement = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(horzontalmovement, 0, verticalmovement) * movementSpeed * Time.deltaTime;
        transform.Translate(movement);


        animator.SetFloat("horizontalWalking", horzontalmovement);
        animator.SetFloat("verticalMovement", verticalmovement);

        // «· Õﬂ„ ›Ì «·ÿÌ—«‰
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //  ‘€Ì· √‰Ì„Ì‘‰ «·ÿÌ—«‰
            animator.SetBool("IsFlying", true);
               // ≈Ìﬁ«› √‰Ì„Ì‘‰ «·ÿÌ—«‰
               // animator.SetBool("IsFlying", false);
            if (!isFlying)
            {
 

                // isGrounded = true; // Ì „  ⁄ÌÌ‰ «··«⁄» ⁄·Ï «·√—÷ ⁄‰œ «·«’ÿœ«„ »«·√—÷

                rb.useGravity = false;
                rb.AddForce(transform.up * flyingForce, ForceMode.Impulse);
                isFlying = true;
            }
            else 
            {
                rb.useGravity = true;
                isFlying = false;
            }
        }

        //  Õ—Ìﬂ «··«⁄» √À‰«¡ «·ÿÌ—«‰
        if (isFlying)
        {
            float flyingHorizontalMovement = Input.GetAxis("Horizontal");
            float flyingVerticalMovement = Input.GetAxis("Vertical");
            Vector3 flyingMovement = new Vector3(flyingHorizontalMovement, 0, flyingVerticalMovement) * flyingSpeed * Time.deltaTime;
            transform.Translate(flyingMovement);
            //
            // isGrounded = false; // Ì „ —›⁄ «··«⁄» ⁄‰ «·√—÷
           
        }
    }
}

