using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onColaaission : MonoBehaviour
{
    public Material theMaterial;
    public GameObject coineffect;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {

            Destroy(this.gameObject);
            Instantiate(coineffect, transform.position, transform.rotation);
            FindObjectOfType<coinscountt>().collect();
        }
    }

}


