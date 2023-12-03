using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class easelPaint : MonoBehaviour
{
    public GameObject easel,
        choiceA,
        choiceB,
        choice1,
        choice2,
        inttext,
        lockedtext;
    public bool unlocked,
        locked,
        painting;

    public AudioSource interact;
    public static bool brushfound;
    public static bool letterfound;

    void Start()
    {
        brushfound = false;
        letterfound = false;
        painting = false;
    }


    void OnTriggerStay(Collider other)
    {
        if (painting == false)
        {
            if (other.CompareTag("MainCamera"))
            {
                if (unlocked == false)
                {
                    if (locked == false)
                    {
                        inttext.SetActive(true);

                        if (Input.GetMouseButtonDown(0))
                        {
                            choiceA.SetActive(true);
                            choiceB.SetActive(true);
                            inttext.SetActive(false);
                            interact.Play();
                            painting = true;
                        }
                    }
                    if (locked == true)
                    {
                        lockedtext.SetActive(true);
                    }
                }
            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            inttext.SetActive(false);
            lockedtext.SetActive(false);
        }
    }

    void Update()
    {
        if (brushfound && letterfound)
        {
            locked = false;
        }
    }
}


