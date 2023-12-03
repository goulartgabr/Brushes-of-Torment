using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class brushScript : MonoBehaviour
{

public GameObject inticon, brush, lockedtext; 
public AudioSource interact;
public bool unlocked, locked;
public static bool letterfound;



void OnTriggerStay(Collider other){
    if (other.CompareTag("MainCamera"))
    {
        if (unlocked == false){
            if(locked == false){
            inticon.SetActive(true);

         if (Input.GetMouseButtonDown(0)){
            brush.SetActive(false);
            easelPaint.brushfound = true;
            inticon.SetActive(false);
            interact.Play();
        }
            
        }
        if (locked == true){
            lockedtext.SetActive(true);
        }
        
    }
    }
}

void Update()
    {
        if (easelPaint.letterfound)
        {
            locked = false;
        }
    }

void OnTriggerExit(Collider other){
    if (other.CompareTag("MainCamera")){
        inticon.SetActive(false);
        lockedtext.SetActive(false);
}
}
}



    