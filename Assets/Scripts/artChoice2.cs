using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class artChoice2 : MonoBehaviour
{
    public GameObject choiceA,
        choiceB,
        choice1,
        choice2,
        artA1,
        artA2,
        artB1,
        artB2,
        inttext,
        lockedtext;

    public bool unlocked,
        locked,
        choosing;

    public AudioSource interact;

    public static bool brushfound, pickedA, pickedB, picked1, picked2;

    void Start()
    {
        choosing = false;
    }

    void OnTriggerStay(Collider other)
    {
        if (choosing == false)
        {
            if (other.CompareTag("MainCamera"))
            {
                if (unlocked == false)
                {
                    if (locked == false)
                    {
                        inttext.SetActive(true);

                        if (gameObject == choiceA)
                        {
                            if (Input.GetMouseButtonDown(0))
                            {
                                choiceA.SetActive(false);
                                choiceB.SetActive(false);
                                choice1.SetActive(true);
                                choice2.SetActive(true);
                                pickedA = true;
                                inttext.SetActive(false);
                                choosing = true;
                                interact.Play();
                                sleepTrigger.paintDone = true;
                            }
                        }

                        if (gameObject == choiceB)
                        {
                            if (Input.GetMouseButtonDown(0))
                            {
                                choiceA.SetActive(false);
                                choiceB.SetActive(false);
                                choice1.SetActive(true);
                                choice2.SetActive(true);
                                pickedB = true;
                                inttext.SetActive(false);
                                interact.Play();
                            }
                        }
                        if (gameObject == choice1)
                        {
                            if (Input.GetMouseButtonDown(0))
                            {
                                choice1.SetActive(false);
                                choice2.SetActive(false);
                                picked1 = true;
                                inttext.SetActive(false);
                                choosing = true;
                                interact.Play();
                                sleepTrigger.paintDone = true;
                                if (pickedA && picked1 == true){
                                    artA1.SetActive(true);
                                } else {
                                    artB1.SetActive(true);
                                }
                            }
                        }
                        if (gameObject == choice2)
                        {
                            if (Input.GetMouseButtonDown(0))
                            {
                                choice1.SetActive(false);
                                choice2.SetActive(false);
                                picked2 = true;
                                inttext.SetActive(false);
                                choosing = true;
                                interact.Play();
                                sleepTrigger.paintDone = true;
                                if (pickedA && picked2 == true){
                                    artA2.SetActive(true);
                                } else {
                                    artB2.SetActive(true);
                                }
                                
                            }
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
        if (brushfound == true)
        {
            locked = false;
        }
    }
}
