using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HardLanding : MonoBehaviour
{
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            // ����� ������� ������
            animator.SetBool("HardLanding", true);
        }

        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            // ����� ������� ������
            animator.SetBool("HardLanding", false);
        }

    }
}
