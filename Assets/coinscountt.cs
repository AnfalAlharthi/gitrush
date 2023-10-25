using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class coinscountt : MonoBehaviour
{

    public TextMeshProUGUI coinstext;
    private float counter;


    // Start is called before the first frame update
    public void collect()
    {
        counter += 1f;
        coinstext.text = counter.ToString("coins : " + "0");
    }


}