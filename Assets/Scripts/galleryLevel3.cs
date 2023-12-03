using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;



public class galleryLevel3 : MonoBehaviour
{
public GameObject artA1, artA2, artB1, artB2;

    // Start is called before the first frame update
    void Update()
    {
        if (registerLevel3.levelA1 == true){
            artA1.SetActive(true);

        } else if (registerLevel3.levelA2 == true){
            artA2.SetActive(true);

        } else if (registerLevel3.levelB1 == true){
             artB1.SetActive(true);   

    } else if (registerLevel3.levelB2 == true){
             artB2.SetActive(true);  
}
    }
}
