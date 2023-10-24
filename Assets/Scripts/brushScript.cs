using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class brushScript : MonoBehaviour
{

public GameObject inticon, brush; 
public AudioSource interact;

void OnTriggerStay(Collider other){
    if (other.CompareTag("MainCamera")){
        inticon.SetActive(true);
         if (Input.GetMouseButtonDown(0)){
            brush.SetActive(false);
            easelPaint.brushfound = true;
            inticon.SetActive(false);
            interact.Play();
        }
    }
}

void OnTriggerExit(Collider other){
    if (other.CompareTag("MainCamera")){
        inticon.SetActive(false);
}
}
}

    