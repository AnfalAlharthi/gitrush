using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorTest : MonoBehaviour
{
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
    if (Input.GetKeyDown(KeyCode.Space))
        {
            //  ‘€Ì· √‰Ì„Ì‘‰ «·ÿÌ—«‰
            animator.SetBool("IsFlying", true);
        }

       if (Input.GetKeyUp(KeyCode.Space))
        {
            // ≈Ìﬁ«› √‰Ì„Ì‘‰ «·ÿÌ—«‰
            animator.SetBool("IsFlying", false);
       }
   
    }
}
