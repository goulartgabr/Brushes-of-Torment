using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;



public class registerLevel2 : MonoBehaviour
{

public static bool levelA1;
public static bool levelA2;
public static bool levelB1;
public static bool levelB2;
    // Start is called before the first frame update
    void Start()
    {
        levelA1 = false;
        levelA2 = false;
        levelB1 = false;
        levelB2 = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (artChoice2.pickedA && artChoice2.picked1 == true){
            levelA1 = true;
            Debug.Log("foi A1");

        } else if (artChoice2.pickedA && artChoice2.picked2 == true){
            levelA2 = true;
            Debug.Log("foi A2");

        } else if (artChoice2.pickedB && artChoice2.picked1 == true){
             levelB1 = true;   
             Debug.Log("foi B1");

    } else if (artChoice2.pickedB && artChoice2.picked2 == true){
             levelB2 = true;   
             Debug.Log("foi B2");
}
    }
}
