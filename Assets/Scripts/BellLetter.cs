using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BellLetter : MonoBehaviour
{   
    public GameObject inticon, letter; 

    void OnTriggerStay(Collider other){
        if (other.CompareTag("MainCamera")){
            if (Input.GetMouseButtonDown(0)){
                letter.SetActive(true);
            }
        }
    }
}
