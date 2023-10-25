using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animator : MonoBehaviour
{
    [SerializeField] private Animator playeranimator;
    // Start is called before the first frame update
    void Start()
    {
        playeranimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space)) {
         playeranimator.SetBool("IsFlying", true);
       }  
    
    }
}

